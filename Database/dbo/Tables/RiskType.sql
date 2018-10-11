CREATE TABLE [dbo].[RiskType] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_RiskType_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

