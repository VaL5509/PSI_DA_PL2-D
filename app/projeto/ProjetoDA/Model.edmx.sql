
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/12/2021 10:46:54
-- Generated from EDMX file: C:\Users\Gosto\OneDrive\Ambiente de Trabalho\Tudo\Escola\2Semeste\Da\Projeto\ProjetoDA\ProjetoDA\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [LojaBD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_EscolaFilho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Filho] DROP CONSTRAINT [FK_EscolaFilho];
GO
IF OBJECT_ID(N'[dbo].[FK_ParticipacaoEscola]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParticipacaoSet] DROP CONSTRAINT [FK_ParticipacaoEscola];
GO
IF OBJECT_ID(N'[dbo].[FK_EventoParticipacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ParticipacaoSet] DROP CONSTRAINT [FK_EventoParticipacao];
GO
IF OBJECT_ID(N'[dbo].[FK_ColaboracaoEvento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColaboracaoSet] DROP CONSTRAINT [FK_ColaboracaoEvento];
GO
IF OBJECT_ID(N'[dbo].[FK_AnimadorColaboracao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ColaboracaoSet] DROP CONSTRAINT [FK_AnimadorColaboracao];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CompraSet] DROP CONSTRAINT [FK_ClienteCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_DetalheCompraCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheCompraSet] DROP CONSTRAINT [FK_DetalheCompraCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoDetalheCompra]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[DetalheCompraSet] DROP CONSTRAINT [FK_ProdutoDetalheCompra];
GO
IF OBJECT_ID(N'[dbo].[FK_TipoProdutoProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ProdutoSet] DROP CONSTRAINT [FK_TipoProdutoProduto];
GO
IF OBJECT_ID(N'[dbo].[FK_ClienteFilho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Filho] DROP CONSTRAINT [FK_ClienteFilho];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoFilho]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoSet] DROP CONSTRAINT [FK_InscricaoFilho];
GO
IF OBJECT_ID(N'[dbo].[FK_InscricaoEvento]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InscricaoSet] DROP CONSTRAINT [FK_InscricaoEvento];
GO
IF OBJECT_ID(N'[dbo].[FK_Filho_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Filho] DROP CONSTRAINT [FK_Filho_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Animador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Animador] DROP CONSTRAINT [FK_Animador_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PessoaSet_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[CompraSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CompraSet];
GO
IF OBJECT_ID(N'[dbo].[DetalheCompraSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[DetalheCompraSet];
GO
IF OBJECT_ID(N'[dbo].[ProdutoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProdutoSet];
GO
IF OBJECT_ID(N'[dbo].[TipoProdutoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TipoProdutoSet];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet];
GO
IF OBJECT_ID(N'[dbo].[ColaboracaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ColaboracaoSet];
GO
IF OBJECT_ID(N'[dbo].[EventoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventoSet];
GO
IF OBJECT_ID(N'[dbo].[ParticipacaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ParticipacaoSet];
GO
IF OBJECT_ID(N'[dbo].[EscolaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EscolaSet];
GO
IF OBJECT_ID(N'[dbo].[InscricaoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InscricaoSet];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Filho]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Filho];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Animador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Animador];
GO
IF OBJECT_ID(N'[dbo].[PessoaSet_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PessoaSet_Cliente];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'CompraSet'
CREATE TABLE [dbo].[CompraSet] (
    [NrCompra] int IDENTITY(1,1) NOT NULL,
    [Data] nvarchar(max)  NOT NULL,
    [UtilizouCartao] nvarchar(max)  NOT NULL,
    [ProdutosCodProduto] nvarchar(max)  NOT NULL,
    [Clientes_IdPessoa] int  NOT NULL
);
GO

-- Creating table 'DetalheCompraSet'
CREATE TABLE [dbo].[DetalheCompraSet] (
    [Quantidade] nvarchar(max)  NOT NULL,
    [ComprasNrCompra] int  NOT NULL,
    [ProdutoCodProduto] int  NOT NULL
);
GO

-- Creating table 'ProdutoSet'
CREATE TABLE [dbo].[ProdutoSet] (
    [CodProduto] int IDENTITY(1,1) NOT NULL,
    [Designacao] nvarchar(max)  NOT NULL,
    [Preco] nvarchar(max)  NOT NULL,
    [StockExistente] nvarchar(max)  NOT NULL,
    [CodTipoProduto] int  NOT NULL
);
GO

-- Creating table 'TipoProdutoSet'
CREATE TABLE [dbo].[TipoProdutoSet] (
    [CodTipoProduto] int IDENTITY(1,1) NOT NULL,
    [Tipo] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PessoaSet'
CREATE TABLE [dbo].[PessoaSet] (
    [IdPessoa] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL,
    [CodigoPostal] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ColaboracaoSet'
CREATE TABLE [dbo].[ColaboracaoSet] (
    [NrEvento] int  NOT NULL,
    [IdAnimador] nvarchar(max)  NOT NULL,
    [Animadores_IdPessoa] int  NOT NULL
);
GO

-- Creating table 'EventoSet'
CREATE TABLE [dbo].[EventoSet] (
    [NrEvento] int IDENTITY(1,1) NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Local] nvarchar(max)  NOT NULL,
    [DataHora] nvarchar(max)  NOT NULL,
    [LimiteParticipacao] nvarchar(max)  NOT NULL,
    [IdadeInfeiror] nvarchar(max)  NOT NULL,
    [IdadeSuperior] nvarchar(max)  NOT NULL,
    [TipoEvento] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ParticipacaoSet'
CREATE TABLE [dbo].[ParticipacaoSet] (
    [IdEscola] int  NOT NULL,
    [NrEvento] int  NOT NULL
);
GO

-- Creating table 'EscolaSet'
CREATE TABLE [dbo].[EscolaSet] (
    [IdEscola] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada] nvarchar(max)  NOT NULL,
    [Telefone] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL,
    [Localidade] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'InscricaoSet'
CREATE TABLE [dbo].[InscricaoSet] (
    [Confirmada] nvarchar(max)  NOT NULL,
    [EventoNrEvento] int  NOT NULL,
    [FilhosIdPessoa] nvarchar(max)  NOT NULL,
    [Filhos_IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Filho'
CREATE TABLE [dbo].[PessoaSet_Filho] (
    [Sexo] nvarchar(max)  NOT NULL,
    [DataNascimento] nvarchar(max)  NOT NULL,
    [IdEscola] int  NOT NULL,
    [IdProgenitor] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL,
    [Clientes_IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Animador'
CREATE TABLE [dbo].[PessoaSet_Animador] (
    [Especialidade] nvarchar(max)  NOT NULL,
    [TipoProdutoCodTipoProduto] int  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- Creating table 'PessoaSet_Cliente'
CREATE TABLE [dbo].[PessoaSet_Cliente] (
    [ValorOferta] nvarchar(max)  NOT NULL,
    [NrCartao] nvarchar(max)  NOT NULL,
    [IdPessoa] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [NrCompra] in table 'CompraSet'
ALTER TABLE [dbo].[CompraSet]
ADD CONSTRAINT [PK_CompraSet]
    PRIMARY KEY CLUSTERED ([NrCompra] ASC);
GO

-- Creating primary key on [ComprasNrCompra], [ProdutoCodProduto] in table 'DetalheCompraSet'
ALTER TABLE [dbo].[DetalheCompraSet]
ADD CONSTRAINT [PK_DetalheCompraSet]
    PRIMARY KEY CLUSTERED ([ComprasNrCompra], [ProdutoCodProduto] ASC);
GO

-- Creating primary key on [CodProduto] in table 'ProdutoSet'
ALTER TABLE [dbo].[ProdutoSet]
ADD CONSTRAINT [PK_ProdutoSet]
    PRIMARY KEY CLUSTERED ([CodProduto] ASC);
GO

-- Creating primary key on [CodTipoProduto] in table 'TipoProdutoSet'
ALTER TABLE [dbo].[TipoProdutoSet]
ADD CONSTRAINT [PK_TipoProdutoSet]
    PRIMARY KEY CLUSTERED ([CodTipoProduto] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoaSet'
ALTER TABLE [dbo].[PessoaSet]
ADD CONSTRAINT [PK_PessoaSet]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [NrEvento], [IdAnimador] in table 'ColaboracaoSet'
ALTER TABLE [dbo].[ColaboracaoSet]
ADD CONSTRAINT [PK_ColaboracaoSet]
    PRIMARY KEY CLUSTERED ([NrEvento], [IdAnimador] ASC);
GO

-- Creating primary key on [NrEvento] in table 'EventoSet'
ALTER TABLE [dbo].[EventoSet]
ADD CONSTRAINT [PK_EventoSet]
    PRIMARY KEY CLUSTERED ([NrEvento] ASC);
GO

-- Creating primary key on [IdEscola], [NrEvento] in table 'ParticipacaoSet'
ALTER TABLE [dbo].[ParticipacaoSet]
ADD CONSTRAINT [PK_ParticipacaoSet]
    PRIMARY KEY CLUSTERED ([IdEscola], [NrEvento] ASC);
GO

-- Creating primary key on [IdEscola] in table 'EscolaSet'
ALTER TABLE [dbo].[EscolaSet]
ADD CONSTRAINT [PK_EscolaSet]
    PRIMARY KEY CLUSTERED ([IdEscola] ASC);
GO

-- Creating primary key on [EventoNrEvento], [FilhosIdPessoa] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [PK_InscricaoSet]
    PRIMARY KEY CLUSTERED ([EventoNrEvento], [FilhosIdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [PK_PessoaSet_Filho]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoaSet_Animador'
ALTER TABLE [dbo].[PessoaSet_Animador]
ADD CONSTRAINT [PK_PessoaSet_Animador]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- Creating primary key on [IdPessoa] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [PK_PessoaSet_Cliente]
    PRIMARY KEY CLUSTERED ([IdPessoa] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEscola] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [FK_EscolaFilho]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[EscolaSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EscolaFilho'
CREATE INDEX [IX_FK_EscolaFilho]
ON [dbo].[PessoaSet_Filho]
    ([IdEscola]);
GO

-- Creating foreign key on [IdEscola] in table 'ParticipacaoSet'
ALTER TABLE [dbo].[ParticipacaoSet]
ADD CONSTRAINT [FK_ParticipacaoEscola]
    FOREIGN KEY ([IdEscola])
    REFERENCES [dbo].[EscolaSet]
        ([IdEscola])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [NrEvento] in table 'ParticipacaoSet'
ALTER TABLE [dbo].[ParticipacaoSet]
ADD CONSTRAINT [FK_EventoParticipacao]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[EventoSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventoParticipacao'
CREATE INDEX [IX_FK_EventoParticipacao]
ON [dbo].[ParticipacaoSet]
    ([NrEvento]);
GO

-- Creating foreign key on [NrEvento] in table 'ColaboracaoSet'
ALTER TABLE [dbo].[ColaboracaoSet]
ADD CONSTRAINT [FK_ColaboracaoEvento]
    FOREIGN KEY ([NrEvento])
    REFERENCES [dbo].[EventoSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Animadores_IdPessoa] in table 'ColaboracaoSet'
ALTER TABLE [dbo].[ColaboracaoSet]
ADD CONSTRAINT [FK_AnimadorColaboracao]
    FOREIGN KEY ([Animadores_IdPessoa])
    REFERENCES [dbo].[PessoaSet_Animador]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AnimadorColaboracao'
CREATE INDEX [IX_FK_AnimadorColaboracao]
ON [dbo].[ColaboracaoSet]
    ([Animadores_IdPessoa]);
GO

-- Creating foreign key on [Clientes_IdPessoa] in table 'CompraSet'
ALTER TABLE [dbo].[CompraSet]
ADD CONSTRAINT [FK_ClienteCompra]
    FOREIGN KEY ([Clientes_IdPessoa])
    REFERENCES [dbo].[PessoaSet_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteCompra'
CREATE INDEX [IX_FK_ClienteCompra]
ON [dbo].[CompraSet]
    ([Clientes_IdPessoa]);
GO

-- Creating foreign key on [ComprasNrCompra] in table 'DetalheCompraSet'
ALTER TABLE [dbo].[DetalheCompraSet]
ADD CONSTRAINT [FK_DetalheCompraCompra]
    FOREIGN KEY ([ComprasNrCompra])
    REFERENCES [dbo].[CompraSet]
        ([NrCompra])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ProdutoCodProduto] in table 'DetalheCompraSet'
ALTER TABLE [dbo].[DetalheCompraSet]
ADD CONSTRAINT [FK_ProdutoDetalheCompra]
    FOREIGN KEY ([ProdutoCodProduto])
    REFERENCES [dbo].[ProdutoSet]
        ([CodProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoDetalheCompra'
CREATE INDEX [IX_FK_ProdutoDetalheCompra]
ON [dbo].[DetalheCompraSet]
    ([ProdutoCodProduto]);
GO

-- Creating foreign key on [CodTipoProduto] in table 'ProdutoSet'
ALTER TABLE [dbo].[ProdutoSet]
ADD CONSTRAINT [FK_TipoProdutoProduto]
    FOREIGN KEY ([CodTipoProduto])
    REFERENCES [dbo].[TipoProdutoSet]
        ([CodTipoProduto])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TipoProdutoProduto'
CREATE INDEX [IX_FK_TipoProdutoProduto]
ON [dbo].[ProdutoSet]
    ([CodTipoProduto]);
GO

-- Creating foreign key on [Clientes_IdPessoa] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [FK_ClienteFilho]
    FOREIGN KEY ([Clientes_IdPessoa])
    REFERENCES [dbo].[PessoaSet_Cliente]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClienteFilho'
CREATE INDEX [IX_FK_ClienteFilho]
ON [dbo].[PessoaSet_Filho]
    ([Clientes_IdPessoa]);
GO

-- Creating foreign key on [Filhos_IdPessoa] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [FK_InscricaoFilho]
    FOREIGN KEY ([Filhos_IdPessoa])
    REFERENCES [dbo].[PessoaSet_Filho]
        ([IdPessoa])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_InscricaoFilho'
CREATE INDEX [IX_FK_InscricaoFilho]
ON [dbo].[InscricaoSet]
    ([Filhos_IdPessoa]);
GO

-- Creating foreign key on [EventoNrEvento] in table 'InscricaoSet'
ALTER TABLE [dbo].[InscricaoSet]
ADD CONSTRAINT [FK_InscricaoEvento]
    FOREIGN KEY ([EventoNrEvento])
    REFERENCES [dbo].[EventoSet]
        ([NrEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoaSet_Filho'
ALTER TABLE [dbo].[PessoaSet_Filho]
ADD CONSTRAINT [FK_Filho_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoaSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoaSet_Animador'
ALTER TABLE [dbo].[PessoaSet_Animador]
ADD CONSTRAINT [FK_Animador_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoaSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [IdPessoa] in table 'PessoaSet_Cliente'
ALTER TABLE [dbo].[PessoaSet_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([IdPessoa])
    REFERENCES [dbo].[PessoaSet]
        ([IdPessoa])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------