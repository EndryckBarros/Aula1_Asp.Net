
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/01/2017 21:47:34
-- Generated from EDMX file: C:\Users\1610832\Source\Repos\Aula1_Asp.Net2\ProjetoWeb0106\ProjetoWeb0106\Models\Clube2DB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Clube2DB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClubeJogador]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Jogadores] DROP CONSTRAINT [FK_ClubeJogador];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Clubes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Clubes];
GO
IF OBJECT_ID(N'[dbo].[Jogadores]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jogadores];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clubes'
CREATE TABLE [dbo].[Clubes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(30)  NOT NULL,
    [Regiao] nvarchar(30)  NOT NULL
);
GO

-- Creating table 'Jogadores'
CREATE TABLE [dbo].[Jogadores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(30)  NOT NULL,
    [Posicao] nvarchar(30)  NOT NULL,
    [Numero] int  NOT NULL,
    [ClubeId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Clubes'
ALTER TABLE [dbo].[Clubes]
ADD CONSTRAINT [PK_Clubes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jogadores'
ALTER TABLE [dbo].[Jogadores]
ADD CONSTRAINT [PK_Jogadores]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ClubeId] in table 'Jogadores'
ALTER TABLE [dbo].[Jogadores]
ADD CONSTRAINT [FK_ClubeJogador]
    FOREIGN KEY ([ClubeId])
    REFERENCES [dbo].[Clubes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClubeJogador'
CREATE INDEX [IX_FK_ClubeJogador]
ON [dbo].[Jogadores]
    ([ClubeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------