
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/01/2017 02:15:13
-- Generated from EDMX file: C:\Users\Endrick\Source\Repos\Aula1_Asp.Net\ProjetoAula0106\ProjetoAula0106\Models\BaseDados.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ClubeDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClubeSet'
CREATE TABLE [dbo].[ClubeSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Jogador] nvarchar(max)  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [NumeroCamisa] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClubeSet'
ALTER TABLE [dbo].[ClubeSet]
ADD CONSTRAINT [PK_ClubeSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------