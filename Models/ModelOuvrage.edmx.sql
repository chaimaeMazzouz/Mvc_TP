
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/28/2021 13:52:39
-- Generated from EDMX file: C:\Users\user\Desktop\EFM_ASP_TDI203A_Mazzouz_Chaimae\Exercice1_APP_MVC\Models\ModelOuvrage.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Gestion_Ouvrage];
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

-- Creating table 'OuvrageSet'
CREATE TABLE [dbo].[OuvrageSet] (
    [Num_Ouv] int IDENTITY(1,1) NOT NULL,
    [Titre_Ouv] nvarchar(max)  NOT NULL,
    [PU] float  NOT NULL,
    [Nb_Exp] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Num_Ouv] in table 'OuvrageSet'
ALTER TABLE [dbo].[OuvrageSet]
ADD CONSTRAINT [PK_OuvrageSet]
    PRIMARY KEY CLUSTERED ([Num_Ouv] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------