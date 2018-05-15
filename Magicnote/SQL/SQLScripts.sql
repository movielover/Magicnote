CREATE TABLE [dbo].[Conviction] (
    [Id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[MainLegalArea] (
    [PK_MA_ID] INT            NOT NULL,
    [MA_Title] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([PK_MA_ID] ASC)
);

CREATE TABLE [dbo].[Note] (
    [PK_N_ID] INT            NOT NULL,
    [NoteText]    NVARCHAR (MAX) NOT NULL,
    [FK_P_ID] INT            NOT NULL,
    [NoteDate]    DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([PK_N_ID] ASC)
);

CREATE TABLE [dbo].[Paragraph] (
    [PK_P_ID]         INT            NOT NULL,
    [ParagraphNumber] INT            NULL,
    [HeadLine]        NVARCHAR (MAX) NULL,
    [Lawtext]         NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([PK_P_ID] ASC),
    CONSTRAINT [FK_Paragraph_SubArea] FOREIGN KEY ([FK_SA_ID]) REFERENCES [dbo].[SubArea] ([PK_SA_ID])
);

CREATE TABLE [dbo].[SubLegalArea] (
    [PK_SA_ID] INT            NOT NULL,
    [FK_MA_ID] INT            NOT NULL,
    [SA_Title] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([PK_SA_ID] ASC),
    CONSTRAINT [FK_SubArea_MainArea] FOREIGN KEY ([FK_MA_ID]) REFERENCES [dbo].[MainArea] ([PK_MA_ID])
);

CREATE TABLE [dbo].[SubLegalAreaParagraph] (
    [FK_SA_ID] INT NOT NULL,
    [FK_P_ID]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([FK_SA_ID] ASC, [FK_P_ID] ASC),
    CONSTRAINT [FK_SubLegalAreaParagraph_SubLegalArea] FOREIGN KEY ([FK_SA_ID]) REFERENCES [dbo].[SubLegalArea] ([PK_SA_ID]),
    CONSTRAINT [FK_SubLegalAreaParagraph_Paragraph] FOREIGN KEY ([FK_P_ID]) REFERENCES [dbo].[Paragraph] ([PK_P_ID])
);

CREATE PROCEDURE [dbo].[SP_GetMainLegalAreas]
AS BEGIN
	SELECT PK_MA_ID, MA_Title
	FROM MainArea
	ORDER BY MA_Title ASC
END

CREATE PROCEDURE [dbo].[SP_GetParagraphs]
	@FK_SA_ID int
AS BEGIN
	SELECT ParagraphNumber, Headline, LawText
	FROM Paragraph
	WHERE FK_SA_ID = @FK_SA_ID
	ORDER BY ParagraphNumber ASC
END

CREATE PROCEDURE [dbo].[SP_GetSubLegalAreas]
	@FK_MA_ID int
AS BEGIN
	SELECT PK_SA_ID, SA_Title
	FROM SubArea
	WHERE FK_MA_ID = @FK_MA_ID
	ORDER BY SA_Title ASC
END

CREATE PROCEDURE [dbo].[SP_GetNote]
	@PK_N_ID int
AS BEGIN
	SELECT NoteText, NoteDate, PK_N_ID
	FROM	Note
	WHERE FK_P_ID = @PK_N_ID
END


CREATE PROCEDURE [dbo].[SP_AddNote]
 @NoteText NVarchar,  
 @NoteDate Datetime,
 @FK_P_ID int 
AS BEGIN
UPDATE Note
SET NoteText = @NoteText, NoteDate = @NoteDate
WHERE FK_P_ID = @FK_P_ID
END

CREATE PROCEDURE [dbo].[SP_SaveNote]
	@NoteText NVarchar,
	@FK_P_ID int
AS BEGIN
	UPDATE [dbo].[Note]
	SET NoteText = @NoteText
	WHERE FK_P_ID = @FK_P_ID
END