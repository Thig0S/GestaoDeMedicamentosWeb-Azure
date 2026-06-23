CREATE TABLE [dbo].[TBRequisicaoEntrada] (
    [Id]            UNIQUEIDENTIFIER NOT NULL,
    [FuncionarioId] UNIQUEIDENTIFIER NOT NULL,
    [MedicamentoId] UNIQUEIDENTIFIER NOT NULL,
    [Quantidade]    INT              NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO

