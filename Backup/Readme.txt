MPX Readme
----------


1. System Requirements

1.1. Supported Architectures
 x86
 x64
 ia64 (Windows Server 2008)

1.2. Supported Operating Systems
 Microsoft Windows XP
 Microsoft Windows Server 2003
 Windows Vista
 Windows Server 2008

1.3. Hardware Requirements
 Minimum: 400 MHz CPU, 96 MB RAM, 800x600 256-color display
 Recommended:  1.0 GHz or higher CPU, 256 MB or more RAM, 1024x768 high-color 32-bit display
 Up to 500 MB of hard disk space may be required  



2. Known Issues

2.1. Installing


2.1.1. Uninstall earlier pre-release versions of .NET Framework 3.5 prior to installing the released version.

If you have installed earlier pre-release versions of .NET Framework 3.5, then you must uninstall them prior to running this installation by using Add or Remove Program.

To resolve this issue:

There's no workaround available.
2.1.2. Installing .NET Framework 2.0 or .NET Framework 3.0 stand-alone ENU language package MSU (shipped on media) but the .NET Framework 2.0 or .NET Framework 3.0 language package is already installed.

When one of the following files is being installed, a message, "the following updates were not installed" is displayed.

WCU\dotNetFramework\dotNetMSP\x64\NetFX2.0-KB936704-v6000-x64_RTM_en.msu
WCU\dotNetFramework\dotNetMSP\x64\NetFX3.0-KB936705-v6000-x64_RTM_en.msu
WCU\dotNetFramework\dotNetMSP\x86\NetFX2.0-KB936704-v6000-x86_RTM_en.msu
WCU\dotNetFramework\dotNetMSP\x86\NetFX3.0-KB936705-v6000-x86_RTM_en.msu

This happens because the corresponding .NET Framework 2.0 or .NET Framework 3.0 En-US language package is already installed.

To resolve this issue:

Install .NET Framework 3.5 by using the installation instructions on http://go.microsoft.com/fwlink/?LinkId=96339.


2.1.3. .NET Framework 3.5 does not install on Windows Server 2003 Itanium architectures.

Installing .NET Framework 3.5 on Windows Server 2003 for Itanium 64-bit processors produces the following message: "Microsoft .NET Framework 3.5 - You must first install Microsoft .NET Framework 2.0 SP1 before installing or repairing".

To resolve this issue:

No workaround is available. .NET Framework 3.5 is not supported on Windows 2003 for Itanium 64-bit processors. 


 2.1.4. .NET Framework 3.5 installation might not configure IIS correctly on Windows XP or Windows Server 2003

Installation of .NET Framework 3.5 will not configure IIS correctly on Windows XP or Windows Server 2003 if IIS is already installed and the IIS Admin Service is disabled.

To resolve this issue:

Do the following things after you install .NET Framework 3.5.

1. On the Start menu, click Run.

2. Type "cmd" and then press ENTER.

3. Type "sc config iisadmin start= auto" and then press ENTER.

-or-

1. On the Start menu, click Run.

2. Type "services.msc" and then press ENTER.

3. Select the IIS Admin Service from the list. If the Startup Type is Disabled, right-click IIS Admin Service and then click Properties. Change Startup Type to Automatic.

4. In %WINDIR%\Microsoft.NET\Framework\v3.5\, run WFServicesReg.exe /c.  (On 64-bit computers, the path is %WINDIR%\Microsoft.NET\Framework64\v3.5\.)


2.1.5 Register MVC Framework in IIS6 Windows Server 2003

Do the following things after you publish the application

1. On the Start menu, click Run.

2. Type "inetmgr" and then press ENTER.

3. Select the virtual directory where the application has been installed

4. Select Properties, point to HomeDirectory , click Configuration. 

5. Select Insert, click Browse, Select aspnet_isapi.dll. Press Ok 



2.1.6 Configuration Web.Config

The following steps describe changes that you must make in the Web.config file in order to change the global parameters 

1.  In the <applicationSettings> section, replace the value elements

		 <setting name="MPXMobile_WipReference_MpxWebServicesPort" serializeAs="String">
			    <value>http://localhost:1674/MpxWebServices.asmx</value>
		 </setting>
    
    with the address of your current Wip asmx

		 <setting name="MPXMobile_WipReference_MpxWebServicesPort" serializeAs="String">
			    <value>http://your URL.asmx</value>
		 </setting>


2.  In the <connectionStrings> section, replace connection string


		  <add name="MobileMPXConnectionString1" connectionString="Data Source=MPX;Initial Catalog=MobileMPX;User ID=id;Password=password"
		   providerName="System.Data.SqlClient" />


    
    with your data base credentials

		  <add name="MobileMPXConnectionString1" connectionString="Data Source=YOUR SOURCE;Initial Catalog=MobileMPX;User ID=YOUR USER;Password=YOUR PASSWORD"
		   providerName="System.Data.SqlClient" />



3.  In the <appSettings> section, replace the values of the global parameters

		<add key="ApplicationName" value="X Nonprofit MPX" />
		<add key="LogU" value="sa" />
		<add key="LogP" value="sa" />
		<add key="Device" value="iPhone" />
		<add key="NoteTypes" value="12" />
		<add key="Admin" value="mpx@mpx.com"/>

2.2. Data Base


1.	Open the Query Analyzer by visiting Start → Programs → MS SQL Server2008 → Query Analyzer

2.	Once opened, connect to the database that you are wish running the script on.

3.	Next, open the SQL file using File → Open option. DatabaseScript.sql file in the root of 	the application.

4.	Once it is open, you can execute the file by pressing F5.

