CREATE TABLE [dbo].[Conviction] (
    [Id] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[MainArea] (
    [PK_MA_ID] INT            NOT NULL,
    [MA_Title] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([PK_MA_ID] ASC)
);

CREATE TABLE [dbo].[Note] (
    [PK_N_ID] INT            NOT NULL,
    [Text]    NVARCHAR (MAX) NOT NULL,
    [FK_P_ID] INT            NOT NULL,
    [Date]    DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([PK_N_ID] ASC)
);

CREATE TABLE [dbo].[Paragraph] (
    [PK_P_ID]         INT            NOT NULL,
    [FK_SA_ID]        INT            NOT NULL,
    [ParagraphNumber] INT            NULL,
    [HeadLine]        NVARCHAR (MAX) NULL,
    [Lawtext]         NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([PK_P_ID] ASC),
    CONSTRAINT [FK_Paragraph_SubArea] FOREIGN KEY ([FK_SA_ID]) REFERENCES [dbo].[SubArea] ([PK_SA_ID])
);

CREATE TABLE [dbo].[SubArea] (
    [PK_SA_ID] INT            NOT NULL,
    [FK_MA_ID] INT            NOT NULL,
    [SA_Title] NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([PK_SA_ID] ASC),
    CONSTRAINT [FK_SubArea_MainArea] FOREIGN KEY ([FK_MA_ID]) REFERENCES [dbo].[MainArea] ([PK_MA_ID])
);

CREATE TABLE [dbo].[SubAreaParagraph] (
    [FK_SA_ID] INT NOT NULL,
    [FK_P_ID]  INT NOT NULL,
    PRIMARY KEY CLUSTERED ([FK_SA_ID] ASC, [FK_P_ID] ASC),
    CONSTRAINT [FK_SubAreaParagraph_SubArea] FOREIGN KEY ([FK_SA_ID]) REFERENCES [dbo].[SubArea] ([PK_SA_ID]),
    CONSTRAINT [FK_SubAreaParagraph_Paragraph] FOREIGN KEY ([FK_P_ID]) REFERENCES [dbo].[Paragraph] ([PK_P_ID])
);

CREATE PROCEDURE [dbo].[SP_GetMainLegalAreas]
AS BEGIN
	SELECT MA_Title
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
	@MA_Title char
AS BEGIN
	SELECT SA_Title
	FROM SubArea
	JOIN MainArea ON @MA_Title = MA_Title
	ORDER BY SA_Title ASC
END

EXEC SP_GetMainLegalAreas

EXEC SP_GetSubLegalAreas "EU-ret"