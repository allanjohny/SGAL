
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 08/28/2015 13:18:12
-- Generated from EDMX file: C:\Users\aderencia01\Documents\GitHub\SGAL\SGAL\SGAL.Model\Logic\SGAL\SGAL.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SGAL];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_adeptolivropresenca_adepto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptolivropresenca] DROP CONSTRAINT [FK_adeptolivropresenca_adepto];
GO
IF OBJECT_ID(N'[dbo].[FK_adeptolivropresenca_livropresenca]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptolivropresenca] DROP CONSTRAINT [FK_adeptolivropresenca_livropresenca];
GO
IF OBJECT_ID(N'[dbo].[FK_adeptomissaosagrada_adepto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptomissaosagrada] DROP CONSTRAINT [FK_adeptomissaosagrada_adepto];
GO
IF OBJECT_ID(N'[dbo].[FK_adeptomissaosagrada_adeptomissaosagrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptomissaosagrada] DROP CONSTRAINT [FK_adeptomissaosagrada_adeptomissaosagrada];
GO
IF OBJECT_ID(N'[dbo].[FK_adeptomissaosagrada_missaosagrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptomissaosagrada] DROP CONSTRAINT [FK_adeptomissaosagrada_missaosagrada];
GO
IF OBJECT_ID(N'[dbo].[FK_adeptomodulo_adepto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptomodulo] DROP CONSTRAINT [FK_adeptomodulo_adepto];
GO
IF OBJECT_ID(N'[dbo].[FK_adeptomodulo_modulo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptomodulo] DROP CONSTRAINT [FK_adeptomodulo_modulo];
GO
IF OBJECT_ID(N'[dbo].[FK_adeptorevistasagrada_adepto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptorevistasagrada] DROP CONSTRAINT [FK_adeptorevistasagrada_adepto];
GO
IF OBJECT_ID(N'[dbo].[FK_adeptorevistasagrada_associacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptorevistasagrada] DROP CONSTRAINT [FK_adeptorevistasagrada_associacao];
GO
IF OBJECT_ID(N'[dbo].[FK_adeptorevistasagrada_revistasagrada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[adeptorevistasagrada] DROP CONSTRAINT [FK_adeptorevistasagrada_revistasagrada];
GO
IF OBJECT_ID(N'[dbo].[FK_associacao_federacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[associacao] DROP CONSTRAINT [FK_associacao_federacao];
GO
IF OBJECT_ID(N'[dbo].[FK_associacao_regional]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[associacao] DROP CONSTRAINT [FK_associacao_regional];
GO
IF OBJECT_ID(N'[dbo].[FK_associado_adepto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[associado] DROP CONSTRAINT [FK_associado_adepto];
GO
IF OBJECT_ID(N'[dbo].[FK_associado_associacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[associado] DROP CONSTRAINT [FK_associado_associacao];
GO
IF OBJECT_ID(N'[dbo].[FK_associado_associadotipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[associado] DROP CONSTRAINT [FK_associado_associadotipo];
GO
IF OBJECT_ID(N'[dbo].[FK_livropresenca_adepto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[livropresenca] DROP CONSTRAINT [FK_livropresenca_adepto];
GO
IF OBJECT_ID(N'[dbo].[FK_livropresenca_associacao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[livropresenca] DROP CONSTRAINT [FK_livropresenca_associacao];
GO
IF OBJECT_ID(N'[dbo].[FK_livropresenca_atividade]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[livropresenca] DROP CONSTRAINT [FK_livropresenca_atividade];
GO
IF OBJECT_ID(N'[dbo].[FK_missaosagrada_missaosagradatipo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[missaosagrada] DROP CONSTRAINT [FK_missaosagrada_missaosagradatipo];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[adepto]', 'U') IS NOT NULL
    DROP TABLE [dbo].[adepto];
GO
IF OBJECT_ID(N'[dbo].[adeptolivropresenca]', 'U') IS NOT NULL
    DROP TABLE [dbo].[adeptolivropresenca];
GO
IF OBJECT_ID(N'[dbo].[adeptomissaosagrada]', 'U') IS NOT NULL
    DROP TABLE [dbo].[adeptomissaosagrada];
GO
IF OBJECT_ID(N'[dbo].[adeptomodulo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[adeptomodulo];
GO
IF OBJECT_ID(N'[dbo].[adeptorevistasagrada]', 'U') IS NOT NULL
    DROP TABLE [dbo].[adeptorevistasagrada];
GO
IF OBJECT_ID(N'[dbo].[associacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[associacao];
GO
IF OBJECT_ID(N'[dbo].[associado]', 'U') IS NOT NULL
    DROP TABLE [dbo].[associado];
GO
IF OBJECT_ID(N'[dbo].[associadotipo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[associadotipo];
GO
IF OBJECT_ID(N'[dbo].[atividade]', 'U') IS NOT NULL
    DROP TABLE [dbo].[atividade];
GO
IF OBJECT_ID(N'[dbo].[federacao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[federacao];
GO
IF OBJECT_ID(N'[dbo].[livropresenca]', 'U') IS NOT NULL
    DROP TABLE [dbo].[livropresenca];
GO
IF OBJECT_ID(N'[dbo].[missaosagrada]', 'U') IS NOT NULL
    DROP TABLE [dbo].[missaosagrada];
GO
IF OBJECT_ID(N'[dbo].[missaosagradatipo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[missaosagradatipo];
GO
IF OBJECT_ID(N'[dbo].[modulo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[modulo];
GO
IF OBJECT_ID(N'[dbo].[regional]', 'U') IS NOT NULL
    DROP TABLE [dbo].[regional];
GO
IF OBJECT_ID(N'[dbo].[revistasagrada]', 'U') IS NOT NULL
    DROP TABLE [dbo].[revistasagrada];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'adepto'
CREATE TABLE [dbo].[adepto] (
    [adeptoid] int IDENTITY(1,1) NOT NULL,
    [nome] varchar(200)  NULL,
    [datanascimento] datetime  NULL,
    [email] varchar(150)  NULL,
    [telefoneresidencial] varchar(11)  NULL,
    [telefonecomercial] varchar(11)  NULL,
    [telefonecelular] varchar(11)  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL,
    [dataprimeiravez] datetime  NULL
);
GO

-- Creating table 'adeptolivropresenca'
CREATE TABLE [dbo].[adeptolivropresenca] (
    [adeptolivropresencaid] int IDENTITY(1,1) NOT NULL,
    [livropresencaid] int  NULL,
    [adeptoid] int  NULL,
    [primeiravez] bit  NULL,
    [observacao] varchar(max)  NULL
);
GO

-- Creating table 'adeptomissaosagrada'
CREATE TABLE [dbo].[adeptomissaosagrada] (
    [adeptomissaosagradaid] int IDENTITY(1,1) NOT NULL,
    [adeptoid] int  NULL,
    [missaosagradaid] int  NULL,
    [situacao] char(1)  NULL,
    [valor] decimal(13,2)  NULL,
    [valortotal] decimal(13,2)  NULL,
    [datainicio] datetime  NULL,
    [dataalteracao] datetime  NULL,
    [datatermino] datetime  NULL,
    [adeptomissaosagradavinculoid] int  NULL
);
GO

-- Creating table 'adeptomodulo'
CREATE TABLE [dbo].[adeptomodulo] (
    [adeptomoduloid] int IDENTITY(1,1) NOT NULL,
    [adeptoid] int  NULL,
    [moduloid] int  NULL,
    [datainicio] datetime  NULL,
    [datatermino] datetime  NULL,
    [aprovado] bit  NULL
);
GO

-- Creating table 'adeptorevistasagrada'
CREATE TABLE [dbo].[adeptorevistasagrada] (
    [adeptorevistasagradaid] int IDENTITY(1,1) NOT NULL,
    [adeptoid] int  NULL,
    [associacaoid] int  NULL,
    [revistasagradaid] int  NULL,
    [quantidade] int  NULL,
    [valorcota] decimal(13,2)  NULL
);
GO

-- Creating table 'associacao'
CREATE TABLE [dbo].[associacao] (
    [associacaoid] int IDENTITY(1,1) NOT NULL,
    [regionalid] int  NULL,
    [federacaoid] int  NULL,
    [descricao] varchar(200)  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL,
    [dataabertura] datetime  NULL,
    [datafechamento] datetime  NULL
);
GO

-- Creating table 'associado'
CREATE TABLE [dbo].[associado] (
    [associadoid] int IDENTITY(1,1) NOT NULL,
    [associadotipoid] int  NULL,
    [adeptoid] int  NULL,
    [associacaoid] int  NULL,
    [dataassociacao] datetime  NULL,
    [dataalteracao] datetime  NULL,
    [observacao] varchar(max)  NULL,
    [situacao] char(1)  NULL
);
GO

-- Creating table 'associadotipo'
CREATE TABLE [dbo].[associadotipo] (
    [associadotipoid] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(100)  NULL,
    [situacao] char(1)  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL
);
GO

-- Creating table 'atividade'
CREATE TABLE [dbo].[atividade] (
    [atividadeid] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(150)  NULL,
    [situacao] char(1)  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL
);
GO

-- Creating table 'federacao'
CREATE TABLE [dbo].[federacao] (
    [federacaoid] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(200)  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL
);
GO

-- Creating table 'livropresenca'
CREATE TABLE [dbo].[livropresenca] (
    [livropresencaid] int IDENTITY(1,1) NOT NULL,
    [associacaoid] int  NULL,
    [atividadeid] int  NULL,
    [orientadorid] int  NULL,
    [datahorareuniao] datetime  NULL,
    [temareuniao] varchar(150)  NULL,
    [observacoes] varchar(max)  NULL
);
GO

-- Creating table 'missaosagrada'
CREATE TABLE [dbo].[missaosagrada] (
    [missaosagradaid] int IDENTITY(1,1) NOT NULL,
    [missaosagradatipoid] int  NULL,
    [descricao] varchar(100)  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL,
    [situacao] char(1)  NULL,
    [valor] decimal(13,2)  NULL
);
GO

-- Creating table 'missaosagradatipo'
CREATE TABLE [dbo].[missaosagradatipo] (
    [missaosagradatipoid] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(50)  NULL,
    [situacao] char(1)  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL
);
GO

-- Creating table 'modulo'
CREATE TABLE [dbo].[modulo] (
    [moduloid] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(100)  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL
);
GO

-- Creating table 'regional'
CREATE TABLE [dbo].[regional] (
    [regionalid] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(150)  NULL,
    [dataabertura] datetime  NULL,
    [datafechamento] datetime  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL
);
GO

-- Creating table 'revistasagrada'
CREATE TABLE [dbo].[revistasagrada] (
    [revistasagradaid] int IDENTITY(1,1) NOT NULL,
    [descricao] varchar(100)  NULL,
    [datainclusao] datetime  NULL,
    [dataalteracao] datetime  NULL,
    [valor] decimal(13,2)  NULL,
    [valorcotistas] decimal(13,2)  NULL,
    [situacao] char(1)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [adeptoid] in table 'adepto'
ALTER TABLE [dbo].[adepto]
ADD CONSTRAINT [PK_adepto]
    PRIMARY KEY CLUSTERED ([adeptoid] ASC);
GO

-- Creating primary key on [adeptolivropresencaid] in table 'adeptolivropresenca'
ALTER TABLE [dbo].[adeptolivropresenca]
ADD CONSTRAINT [PK_adeptolivropresenca]
    PRIMARY KEY CLUSTERED ([adeptolivropresencaid] ASC);
GO

-- Creating primary key on [adeptomissaosagradaid] in table 'adeptomissaosagrada'
ALTER TABLE [dbo].[adeptomissaosagrada]
ADD CONSTRAINT [PK_adeptomissaosagrada]
    PRIMARY KEY CLUSTERED ([adeptomissaosagradaid] ASC);
GO

-- Creating primary key on [adeptomoduloid] in table 'adeptomodulo'
ALTER TABLE [dbo].[adeptomodulo]
ADD CONSTRAINT [PK_adeptomodulo]
    PRIMARY KEY CLUSTERED ([adeptomoduloid] ASC);
GO

-- Creating primary key on [adeptorevistasagradaid] in table 'adeptorevistasagrada'
ALTER TABLE [dbo].[adeptorevistasagrada]
ADD CONSTRAINT [PK_adeptorevistasagrada]
    PRIMARY KEY CLUSTERED ([adeptorevistasagradaid] ASC);
GO

-- Creating primary key on [associacaoid] in table 'associacao'
ALTER TABLE [dbo].[associacao]
ADD CONSTRAINT [PK_associacao]
    PRIMARY KEY CLUSTERED ([associacaoid] ASC);
GO

-- Creating primary key on [associadoid] in table 'associado'
ALTER TABLE [dbo].[associado]
ADD CONSTRAINT [PK_associado]
    PRIMARY KEY CLUSTERED ([associadoid] ASC);
GO

-- Creating primary key on [associadotipoid] in table 'associadotipo'
ALTER TABLE [dbo].[associadotipo]
ADD CONSTRAINT [PK_associadotipo]
    PRIMARY KEY CLUSTERED ([associadotipoid] ASC);
GO

-- Creating primary key on [atividadeid] in table 'atividade'
ALTER TABLE [dbo].[atividade]
ADD CONSTRAINT [PK_atividade]
    PRIMARY KEY CLUSTERED ([atividadeid] ASC);
GO

-- Creating primary key on [federacaoid] in table 'federacao'
ALTER TABLE [dbo].[federacao]
ADD CONSTRAINT [PK_federacao]
    PRIMARY KEY CLUSTERED ([federacaoid] ASC);
GO

-- Creating primary key on [livropresencaid] in table 'livropresenca'
ALTER TABLE [dbo].[livropresenca]
ADD CONSTRAINT [PK_livropresenca]
    PRIMARY KEY CLUSTERED ([livropresencaid] ASC);
GO

-- Creating primary key on [missaosagradaid] in table 'missaosagrada'
ALTER TABLE [dbo].[missaosagrada]
ADD CONSTRAINT [PK_missaosagrada]
    PRIMARY KEY CLUSTERED ([missaosagradaid] ASC);
GO

-- Creating primary key on [missaosagradatipoid] in table 'missaosagradatipo'
ALTER TABLE [dbo].[missaosagradatipo]
ADD CONSTRAINT [PK_missaosagradatipo]
    PRIMARY KEY CLUSTERED ([missaosagradatipoid] ASC);
GO

-- Creating primary key on [moduloid] in table 'modulo'
ALTER TABLE [dbo].[modulo]
ADD CONSTRAINT [PK_modulo]
    PRIMARY KEY CLUSTERED ([moduloid] ASC);
GO

-- Creating primary key on [regionalid] in table 'regional'
ALTER TABLE [dbo].[regional]
ADD CONSTRAINT [PK_regional]
    PRIMARY KEY CLUSTERED ([regionalid] ASC);
GO

-- Creating primary key on [revistasagradaid] in table 'revistasagrada'
ALTER TABLE [dbo].[revistasagrada]
ADD CONSTRAINT [PK_revistasagrada]
    PRIMARY KEY CLUSTERED ([revistasagradaid] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [adeptoid] in table 'adeptolivropresenca'
ALTER TABLE [dbo].[adeptolivropresenca]
ADD CONSTRAINT [FK_adeptolivropresenca_adepto]
    FOREIGN KEY ([adeptoid])
    REFERENCES [dbo].[adepto]
        ([adeptoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptolivropresenca_adepto'
CREATE INDEX [IX_FK_adeptolivropresenca_adepto]
ON [dbo].[adeptolivropresenca]
    ([adeptoid]);
GO

-- Creating foreign key on [adeptoid] in table 'adeptomissaosagrada'
ALTER TABLE [dbo].[adeptomissaosagrada]
ADD CONSTRAINT [FK_adeptomissaosagrada_adepto]
    FOREIGN KEY ([adeptoid])
    REFERENCES [dbo].[adepto]
        ([adeptoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptomissaosagrada_adepto'
CREATE INDEX [IX_FK_adeptomissaosagrada_adepto]
ON [dbo].[adeptomissaosagrada]
    ([adeptoid]);
GO

-- Creating foreign key on [adeptoid] in table 'adeptomodulo'
ALTER TABLE [dbo].[adeptomodulo]
ADD CONSTRAINT [FK_adeptomodulo_adepto]
    FOREIGN KEY ([adeptoid])
    REFERENCES [dbo].[adepto]
        ([adeptoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptomodulo_adepto'
CREATE INDEX [IX_FK_adeptomodulo_adepto]
ON [dbo].[adeptomodulo]
    ([adeptoid]);
GO

-- Creating foreign key on [adeptoid] in table 'adeptorevistasagrada'
ALTER TABLE [dbo].[adeptorevistasagrada]
ADD CONSTRAINT [FK_adeptorevistasagrada_adepto]
    FOREIGN KEY ([adeptoid])
    REFERENCES [dbo].[adepto]
        ([adeptoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptorevistasagrada_adepto'
CREATE INDEX [IX_FK_adeptorevistasagrada_adepto]
ON [dbo].[adeptorevistasagrada]
    ([adeptoid]);
GO

-- Creating foreign key on [adeptoid] in table 'associado'
ALTER TABLE [dbo].[associado]
ADD CONSTRAINT [FK_associado_adepto]
    FOREIGN KEY ([adeptoid])
    REFERENCES [dbo].[adepto]
        ([adeptoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_associado_adepto'
CREATE INDEX [IX_FK_associado_adepto]
ON [dbo].[associado]
    ([adeptoid]);
GO

-- Creating foreign key on [orientadorid] in table 'livropresenca'
ALTER TABLE [dbo].[livropresenca]
ADD CONSTRAINT [FK_livropresenca_adepto]
    FOREIGN KEY ([orientadorid])
    REFERENCES [dbo].[adepto]
        ([adeptoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_livropresenca_adepto'
CREATE INDEX [IX_FK_livropresenca_adepto]
ON [dbo].[livropresenca]
    ([orientadorid]);
GO

-- Creating foreign key on [livropresencaid] in table 'adeptolivropresenca'
ALTER TABLE [dbo].[adeptolivropresenca]
ADD CONSTRAINT [FK_adeptolivropresenca_livropresenca]
    FOREIGN KEY ([livropresencaid])
    REFERENCES [dbo].[livropresenca]
        ([livropresencaid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptolivropresenca_livropresenca'
CREATE INDEX [IX_FK_adeptolivropresenca_livropresenca]
ON [dbo].[adeptolivropresenca]
    ([livropresencaid]);
GO

-- Creating foreign key on [adeptomissaosagradavinculoid] in table 'adeptomissaosagrada'
ALTER TABLE [dbo].[adeptomissaosagrada]
ADD CONSTRAINT [FK_adeptomissaosagrada_adeptomissaosagrada]
    FOREIGN KEY ([adeptomissaosagradavinculoid])
    REFERENCES [dbo].[adeptomissaosagrada]
        ([adeptomissaosagradaid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptomissaosagrada_adeptomissaosagrada'
CREATE INDEX [IX_FK_adeptomissaosagrada_adeptomissaosagrada]
ON [dbo].[adeptomissaosagrada]
    ([adeptomissaosagradavinculoid]);
GO

-- Creating foreign key on [missaosagradaid] in table 'adeptomissaosagrada'
ALTER TABLE [dbo].[adeptomissaosagrada]
ADD CONSTRAINT [FK_adeptomissaosagrada_missaosagrada]
    FOREIGN KEY ([missaosagradaid])
    REFERENCES [dbo].[missaosagrada]
        ([missaosagradaid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptomissaosagrada_missaosagrada'
CREATE INDEX [IX_FK_adeptomissaosagrada_missaosagrada]
ON [dbo].[adeptomissaosagrada]
    ([missaosagradaid]);
GO

-- Creating foreign key on [moduloid] in table 'adeptomodulo'
ALTER TABLE [dbo].[adeptomodulo]
ADD CONSTRAINT [FK_adeptomodulo_modulo]
    FOREIGN KEY ([moduloid])
    REFERENCES [dbo].[modulo]
        ([moduloid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptomodulo_modulo'
CREATE INDEX [IX_FK_adeptomodulo_modulo]
ON [dbo].[adeptomodulo]
    ([moduloid]);
GO

-- Creating foreign key on [associacaoid] in table 'adeptorevistasagrada'
ALTER TABLE [dbo].[adeptorevistasagrada]
ADD CONSTRAINT [FK_adeptorevistasagrada_associacao]
    FOREIGN KEY ([associacaoid])
    REFERENCES [dbo].[associacao]
        ([associacaoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptorevistasagrada_associacao'
CREATE INDEX [IX_FK_adeptorevistasagrada_associacao]
ON [dbo].[adeptorevistasagrada]
    ([associacaoid]);
GO

-- Creating foreign key on [revistasagradaid] in table 'adeptorevistasagrada'
ALTER TABLE [dbo].[adeptorevistasagrada]
ADD CONSTRAINT [FK_adeptorevistasagrada_revistasagrada]
    FOREIGN KEY ([revistasagradaid])
    REFERENCES [dbo].[revistasagrada]
        ([revistasagradaid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_adeptorevistasagrada_revistasagrada'
CREATE INDEX [IX_FK_adeptorevistasagrada_revistasagrada]
ON [dbo].[adeptorevistasagrada]
    ([revistasagradaid]);
GO

-- Creating foreign key on [federacaoid] in table 'associacao'
ALTER TABLE [dbo].[associacao]
ADD CONSTRAINT [FK_associacao_federacao]
    FOREIGN KEY ([federacaoid])
    REFERENCES [dbo].[federacao]
        ([federacaoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_associacao_federacao'
CREATE INDEX [IX_FK_associacao_federacao]
ON [dbo].[associacao]
    ([federacaoid]);
GO

-- Creating foreign key on [regionalid] in table 'associacao'
ALTER TABLE [dbo].[associacao]
ADD CONSTRAINT [FK_associacao_regional]
    FOREIGN KEY ([regionalid])
    REFERENCES [dbo].[regional]
        ([regionalid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_associacao_regional'
CREATE INDEX [IX_FK_associacao_regional]
ON [dbo].[associacao]
    ([regionalid]);
GO

-- Creating foreign key on [associacaoid] in table 'associado'
ALTER TABLE [dbo].[associado]
ADD CONSTRAINT [FK_associado_associacao]
    FOREIGN KEY ([associacaoid])
    REFERENCES [dbo].[associacao]
        ([associacaoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_associado_associacao'
CREATE INDEX [IX_FK_associado_associacao]
ON [dbo].[associado]
    ([associacaoid]);
GO

-- Creating foreign key on [associacaoid] in table 'livropresenca'
ALTER TABLE [dbo].[livropresenca]
ADD CONSTRAINT [FK_livropresenca_associacao]
    FOREIGN KEY ([associacaoid])
    REFERENCES [dbo].[associacao]
        ([associacaoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_livropresenca_associacao'
CREATE INDEX [IX_FK_livropresenca_associacao]
ON [dbo].[livropresenca]
    ([associacaoid]);
GO

-- Creating foreign key on [associadotipoid] in table 'associado'
ALTER TABLE [dbo].[associado]
ADD CONSTRAINT [FK_associado_associadotipo]
    FOREIGN KEY ([associadotipoid])
    REFERENCES [dbo].[associadotipo]
        ([associadotipoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_associado_associadotipo'
CREATE INDEX [IX_FK_associado_associadotipo]
ON [dbo].[associado]
    ([associadotipoid]);
GO

-- Creating foreign key on [atividadeid] in table 'livropresenca'
ALTER TABLE [dbo].[livropresenca]
ADD CONSTRAINT [FK_livropresenca_atividade]
    FOREIGN KEY ([atividadeid])
    REFERENCES [dbo].[atividade]
        ([atividadeid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_livropresenca_atividade'
CREATE INDEX [IX_FK_livropresenca_atividade]
ON [dbo].[livropresenca]
    ([atividadeid]);
GO

-- Creating foreign key on [missaosagradatipoid] in table 'missaosagrada'
ALTER TABLE [dbo].[missaosagrada]
ADD CONSTRAINT [FK_missaosagrada_missaosagradatipo]
    FOREIGN KEY ([missaosagradatipoid])
    REFERENCES [dbo].[missaosagradatipo]
        ([missaosagradatipoid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_missaosagrada_missaosagradatipo'
CREATE INDEX [IX_FK_missaosagrada_missaosagradatipo]
ON [dbo].[missaosagrada]
    ([missaosagradatipoid]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------