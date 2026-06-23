CREATE TABLE [dbo].[TBMedicamentoPrescrito] (
    [RequisicaoSaidaId] UNIQUEIDENTIFIER NOT NULL,
    [MedicamentoId]     UNIQUEIDENTIFIER NOT NULL,
    [Quantidade]        INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([RequisicaoSaidaId] ASC, [MedicamentoId] ASC)
);
GO

