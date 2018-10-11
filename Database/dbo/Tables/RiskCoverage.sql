CREATE TABLE [dbo].[RiskCoverage] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    CONSTRAINT [PK_RiskCoverage_1] PRIMARY KEY CLUSTERED ([Id] ASC)
);

