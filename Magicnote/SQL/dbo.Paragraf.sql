CREATE TABLE [dbo].[Paragraf] (
    [PK_P_ID]  INT            NOT NULL,
    [Lawtext]  NVARCHAR (MAX) NOT NULL,
    [FK_SA_ID] INT            NOT NULL,
    [ParagrafNumber] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([PK_P_ID] ASC),
    CONSTRAINT [FK_SA_ID_SubArea] FOREIGN KEY ([FK_SA_ID]) REFERENCES [dbo].[SubArea] ([PK_SA_ID])
);

