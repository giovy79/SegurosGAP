CREATE TABLE [dbo].[InsurancePolicy] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100)  NOT NULL,
    [Description] NVARCHAR (1000) NOT NULL,
    [BeginDate]   DATETIME        NOT NULL,
    [Range]       INT             NOT NULL,
    [Price]       MONEY           NOT NULL,
    [Risk]        INT             NOT NULL,
    [Coverage]    INT             NOT NULL,
    [Percentage]  INT             NOT NULL,
    CONSTRAINT [PK_InsurancePolicy] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_InsurancePolicy_RiskCoverage] FOREIGN KEY ([Coverage]) REFERENCES [dbo].[RiskCoverage] ([Id]),
    CONSTRAINT [FK_InsurancePolicy_RiskType] FOREIGN KEY ([Risk]) REFERENCES [dbo].[RiskType] ([Id])
);

