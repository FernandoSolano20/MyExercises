SET NUMERIC_ROUNDABORT OFF
GO
SET ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS ON
GO
IF EXISTS (SELECT * FROM tempdb..sysobjects WHERE id=OBJECT_ID('tempdb..#tmpErrors')) DROP TABLE #tmpErrors
GO
CREATE TABLE #tmpErrors (Error int)
GO
SET XACT_ABORT ON
GO
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
GO
BEGIN TRANSACTION
GO
PRINT N'Creating [dbo].[Rooms]'
GO
CREATE TABLE [dbo].[Rooms]
(
[RoomId] [int] NOT NULL IDENTITY(1, 1),
[RoomNumber] [nchar] (30) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
)

GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Creating primary key [PK_Rooms] on [dbo].[Rooms]'
GO
ALTER TABLE [dbo].[Rooms] ADD CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED ([RoomId])
GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Creating [dbo].[Talks]'
GO
CREATE TABLE [dbo].[Talks]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[Name] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
[TalkTime] [datetime] NOT NULL,
[RoomId] [int] NULL
)

GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Creating primary key [PK_Talks] on [dbo].[Talks]'
GO
ALTER TABLE [dbo].[Talks] ADD CONSTRAINT [PK_Talks] PRIMARY KEY CLUSTERED ([Id])
GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Creating [dbo].[Speakers]'
GO
CREATE TABLE [dbo].[Speakers]
(
[Id] [int] NOT NULL IDENTITY(1, 1),
[Name] [nvarchar] (max) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL
)

GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Creating primary key [PK_Speakers] on [dbo].[Speakers]'
GO
ALTER TABLE [dbo].[Speakers] ADD CONSTRAINT [PK_Speakers] PRIMARY KEY CLUSTERED ([Id])
GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Creating [dbo].[TalkSpeaker]'
GO
CREATE TABLE [dbo].[TalkSpeaker]
(
[Talks_Id] [int] NOT NULL,
[Speakers_Id] [int] NOT NULL
)

GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Creating primary key [PK_TalkSpeaker] on [dbo].[TalkSpeaker]'
GO
ALTER TABLE [dbo].[TalkSpeaker] ADD CONSTRAINT [PK_TalkSpeaker] PRIMARY KEY NONCLUSTERED ([Talks_Id], [Speakers_Id])
GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Creating index [IX_FK_TalkSpeaker_Speaker] on [dbo].[TalkSpeaker]'
GO
CREATE NONCLUSTERED INDEX [IX_FK_TalkSpeaker_Speaker] ON [dbo].[TalkSpeaker] ([Speakers_Id])
GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Creating [dbo].[CompletelyUnrelatedQuery_DBSysObjects]'
GO
CREATE PROCEDURE dbo.CompletelyUnrelatedQuery_DBSysObjects
AS
	select object_id as SysObjectId, Name as SysObjectName from sys.Objects
	RETURN

GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Adding foreign keys to [dbo].[Talks]'
GO
ALTER TABLE [dbo].[Talks] ADD
CONSTRAINT [FK_Talks_Rooms] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Rooms] ([RoomId])
GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
PRINT N'Adding foreign keys to [dbo].[TalkSpeaker]'
GO
ALTER TABLE [dbo].[TalkSpeaker] ADD
CONSTRAINT [FK_TalkSpeaker_Speaker] FOREIGN KEY ([Speakers_Id]) REFERENCES [dbo].[Speakers] ([Id]),
CONSTRAINT [FK_TalkSpeaker_Talk] FOREIGN KEY ([Talks_Id]) REFERENCES [dbo].[Talks] ([Id])
GO
IF @@ERROR<>0 AND @@TRANCOUNT>0 ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT=0 BEGIN INSERT INTO #tmpErrors (Error) SELECT 1 BEGIN TRANSACTION END
GO
IF EXISTS (SELECT * FROM #tmpErrors) ROLLBACK TRANSACTION
GO
IF @@TRANCOUNT>0 BEGIN
PRINT 'The database update succeeded'
COMMIT TRANSACTION
END
ELSE PRINT 'The database update failed'
GO
DROP TABLE #tmpErrors
GO
SET NUMERIC_ROUNDABORT OFF
GO
SET XACT_ABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
GO
SET DATEFORMAT YMD
GO
-- Pointer used for text / image updates. This might not be needed, but is declared here just in case
DECLARE @pv binary(16)

BEGIN TRANSACTION

-- Drop constraints from [dbo].[TalkSpeaker]
ALTER TABLE [dbo].[TalkSpeaker] DROP CONSTRAINT [FK_TalkSpeaker_Speaker]
ALTER TABLE [dbo].[TalkSpeaker] DROP CONSTRAINT [FK_TalkSpeaker_Talk]

-- Drop constraints from [dbo].[Talks]
ALTER TABLE [dbo].[Talks] DROP CONSTRAINT [FK_Talks_Rooms]

-- Add 4 rows to [dbo].[Rooms]
SET IDENTITY_INSERT [dbo].[Rooms] ON
INSERT INTO [dbo].[Rooms] ([RoomId], [RoomNumber]) VALUES (1, N'Camel''s Hump                  ')
INSERT INTO [dbo].[Rooms] ([RoomId], [RoomNumber]) VALUES (2, N'Mansfield                     ')
INSERT INTO [dbo].[Rooms] ([RoomId], [RoomNumber]) VALUES (3, N'Lincoln Gap                   ')
INSERT INTO [dbo].[Rooms] ([RoomId], [RoomNumber]) VALUES (4, N'Molly Stark                   ')
SET IDENTITY_INSERT [dbo].[Rooms] OFF

-- Add 2 rows to [dbo].[Speakers]
SET IDENTITY_INSERT [dbo].[Speakers] ON
INSERT INTO [dbo].[Speakers] ([Id], [Name]) VALUES (3, N'Chris')
INSERT INTO [dbo].[Speakers] ([Id], [Name]) VALUES (4, N'Julie')
SET IDENTITY_INSERT [dbo].[Speakers] OFF

-- Add 3 rows to [dbo].[Talks]
SET IDENTITY_INSERT [dbo].[Talks] ON
INSERT INTO [dbo].[Talks] ([Id], [Name], [TalkTime], [RoomId]) VALUES (2, N'EF4 Shock & Awe', '2010-05-29 21:21:38.053', 1)
INSERT INTO [dbo].[Talks] ([Id], [Name], [TalkTime], [RoomId]) VALUES (3, N'EF4 POCOs', '2010-06-04 00:00:00.000', 2)
INSERT INTO [dbo].[Talks] ([Id], [Name], [TalkTime], [RoomId]) VALUES (4, N'EF4 & WCF', '2010-06-04 00:00:00.000', 3)
SET IDENTITY_INSERT [dbo].[Talks] OFF

-- Add 4 rows to [dbo].[TalkSpeaker]
INSERT INTO [dbo].[TalkSpeaker] ([Talks_Id], [Speakers_Id]) VALUES (2, 3)
INSERT INTO [dbo].[TalkSpeaker] ([Talks_Id], [Speakers_Id]) VALUES (2, 4)
INSERT INTO [dbo].[TalkSpeaker] ([Talks_Id], [Speakers_Id]) VALUES (3, 4)
INSERT INTO [dbo].[TalkSpeaker] ([Talks_Id], [Speakers_Id]) VALUES (4, 4)

-- Add constraints to [dbo].[TalkSpeaker]
ALTER TABLE [dbo].[TalkSpeaker] ADD CONSTRAINT [FK_TalkSpeaker_Speaker] FOREIGN KEY ([Speakers_Id]) REFERENCES [dbo].[Speakers] ([Id])
ALTER TABLE [dbo].[TalkSpeaker] ADD CONSTRAINT [FK_TalkSpeaker_Talk] FOREIGN KEY ([Talks_Id]) REFERENCES [dbo].[Talks] ([Id])

-- Add constraints to [dbo].[Talks]
ALTER TABLE [dbo].[Talks] ADD CONSTRAINT [FK_Talks_Rooms] FOREIGN KEY ([RoomId]) REFERENCES [dbo].[Rooms] ([RoomId])

COMMIT TRANSACTION
