CREATE TABLE [dbo].[Client] (
    [Id]      INT            NOT NULL,
    [Name]    NVARCHAR (100) NOT NULL,
    [Surname] NVARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED ([Id] ASC)
);

