CREATE DATABASE MobileMPX
USE [MobileMPX]
GO
/****** Object:  Table [dbo].[LogSessions]    Script Date: 06/18/2010 08:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LogSessions](
	[Log_sessionId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](250) NULL,
	[SessionDate] [datetime] NULL,
 CONSTRAINT [PK_LogSessions] PRIMARY KEY CLUSTERED 
(
	[Log_sessionId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LogActions]    Script Date: 06/18/2010 08:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LogActions](
	[Log_ActionsId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](250) NULL,
	[Action] [varchar](250) NULL,
	[ActionDate] [datetime] NULL,
 CONSTRAINT [PK_LogActions] PRIMARY KEY CLUSTERED 
(
	[Log_ActionsId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LocalUser]    Script Date: 06/18/2010 08:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LocalUser](
	[First_Name] [varchar](50) NULL,
	[Last_name] [varchar](50) NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](150) NOT NULL,
	[Created_at] [datetime] NULL,
	[Updated_at] [datetime] NULL,
 CONSTRAINT [PK_LocalUser] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[BookmarkedDonors]    Script Date: 06/18/2010 08:07:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BookmarkedDonors](
	[Bookmarked_ID] [int] IDENTITY(1,1) NOT NULL,
	[User_ID] [varchar](250) NULL,
	[Donor_ID] [int] NULL,
 CONSTRAINT [PK_BookmarkedDonors] PRIMARY KEY CLUSTERED 
(
	[Bookmarked_ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
