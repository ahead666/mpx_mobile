﻿<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl" %>

<%
    var agent = Request.UserAgent;
    if (agent.ToString().Contains(System.Configuration.ConfigurationSettings.AppSettings["Device"]))
    {
%>
    <div id="back">
        <fieldset>
            <legend>Home</legend>
            <div id="about" class="panel">
                <ul>
                    <li class="arrow"><a class="forward" href="/Home/Search">
                        <img class="ico" src="../Content/iPhone/lupa.png">
                        Search</a></li>
                    <li class="arrow"><a class="forward" href="/Home/BookmarkedDonors">
                        <img class="ico" src="../Content/iPhone/star.png">
                        Bookmarked</a></li>
                    <li class="arrow"><a class="forward" href="/Home/RecentlyDonors">
                        <img class="ico" src="/Content/iPhone/clock.png">
                        Recently</a></li>
                </ul>
            </div>
        </fieldset>
    </div>
<% 
    } else {
%>

    <p>Welcome to the <%=System.Configuration.ConfigurationSettings.AppSettings["ApplicationName"].ToString()%> Mobile app</p>

<% 
    }
%>