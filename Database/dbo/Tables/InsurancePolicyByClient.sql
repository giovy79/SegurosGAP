CREATE TABLE [dbo].[InsurancePolicyByClient] (
    [IdClient]          INT NOT NULL,
    [IdInsurancePolicy] INT NOT NULL,
    CONSTRAINT [PK_InsurancePolicyByClient] PRIMARY KEY CLUSTERED ([IdClient] ASC, [IdInsurancePolicy] ASC),
    CONSTRAINT [FK_InsurancePolicyByClient_Client] FOREIGN KEY ([IdClient]) REFERENCES [dbo].[Client] ([Id])
);

