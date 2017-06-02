
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/01/2017 20:02:00
-- Generated from EDMX file: C:\Users\1610832\Source\Repos\Aula1_Asp.Net2\ProjetoAula0106\ProjetoAula0106\Models\BaseDados.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [JogadorDB];
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

-- Creating table 'Jogadors'
CREATE TABLE [dbo].[Jogadors] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Regiao] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Jogadores'
CREATE TABLE [dbo].[Jogadores] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [NumeroCamisa] int  NOT NULL,
    [JogadorId] int  NOT NULL,
    [JogadorId1] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Jogadors'
ALTER TABLE [dbo].[Jogadors]
ADD CONSTRAINT [PK_Jogadors]
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

-- Creating foreign key on [JogadorId1] in table 'Jogadores'
ALTER TABLE [dbo].[Jogadores]
ADD CONSTRAINT [FK_JogadorJogador]
    FOREIGN KEY ([JogadorId1])
    REFERENCES [dbo].[Jogadors]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JogadorJogador'
CREATE INDEX [IX_FK_JogadorJogador]
ON [dbo].[Jogadores]
    ([JogadorId1]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------