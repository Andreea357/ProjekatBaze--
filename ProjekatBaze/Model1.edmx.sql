
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/02/2021 00:23:14
-- Generated from EDMX file: C:\Users\deja9\Desktop\ProjekatBaze - Copy\ProjekatBaze\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Baza2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ButikRadnik]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Radniks] DROP CONSTRAINT [FK_ButikRadnik];
GO
IF OBJECT_ID(N'[dbo].[FK_ButikProizvod]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Proizvods] DROP CONSTRAINT [FK_ButikProizvod];
GO
IF OBJECT_ID(N'[dbo].[FK_ButikKasa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kasas] DROP CONSTRAINT [FK_ButikKasa];
GO
IF OBJECT_ID(N'[dbo].[FK_MenadzerRadnik]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Radniks] DROP CONSTRAINT [FK_MenadzerRadnik];
GO
IF OBJECT_ID(N'[dbo].[FK_RacunKupuje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kupujes] DROP CONSTRAINT [FK_RacunKupuje];
GO
IF OBJECT_ID(N'[dbo].[FK_KasaRacun]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Racuns] DROP CONSTRAINT [FK_KasaRacun];
GO
IF OBJECT_ID(N'[dbo].[FK_ProizvodKupuje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kupujes] DROP CONSTRAINT [FK_ProizvodKupuje];
GO
IF OBJECT_ID(N'[dbo].[FK_KupacKupuje]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Kupujes] DROP CONSTRAINT [FK_KupacKupuje];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdavacRadnik]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Radniks] DROP CONSTRAINT [FK_ProdavacRadnik];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Butiks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Butiks];
GO
IF OBJECT_ID(N'[dbo].[Kasas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kasas];
GO
IF OBJECT_ID(N'[dbo].[Radniks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Radniks];
GO
IF OBJECT_ID(N'[dbo].[Racuns]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Racuns];
GO
IF OBJECT_ID(N'[dbo].[Proizvods]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Proizvods];
GO
IF OBJECT_ID(N'[dbo].[Kupacs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kupacs];
GO
IF OBJECT_ID(N'[dbo].[Kupujes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Kupujes];
GO
IF OBJECT_ID(N'[dbo].[Prodavacs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prodavacs];
GO
IF OBJECT_ID(N'[dbo].[Menadzers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Menadzers];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Butiks'
CREATE TABLE [dbo].[Butiks] (
    [PIB] int IDENTITY(1,1) NOT NULL,
    [Naziv] nvarchar(max)  NOT NULL,
    [Adresa] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Kasas'
CREATE TABLE [dbo].[Kasas] (
    [IdKase] int IDENTITY(1,1) NOT NULL,
    [ButikPIB] int  NULL
);
GO

-- Creating table 'Radniks'
CREATE TABLE [dbo].[Radniks] (
    [JMBG] int IDENTITY(1,1) NOT NULL,
    [ImeRadnika] nvarchar(max)  NOT NULL,
    [PrezimeRadnika] nvarchar(max)  NOT NULL,
    [TipRadnika] nvarchar(max)  NOT NULL,
    [ButikPIB] int  NOT NULL,
    [Menadzer_JMBGMenadzera] int  NOT NULL,
    [Prodavac_JMBGProdavca] int  NOT NULL
);
GO

-- Creating table 'Racuns'
CREATE TABLE [dbo].[Racuns] (
    [IdRacuna] int IDENTITY(1,1) NOT NULL,
    [Ukupno] int  NOT NULL,
    [KasaIdKase] int  NOT NULL
);
GO

-- Creating table 'Proizvods'
CREATE TABLE [dbo].[Proizvods] (
    [KodProizvoda] int IDENTITY(1,1) NOT NULL,
    [Cijena] int  NOT NULL,
    [NazivProizvoda] nvarchar(max)  NOT NULL,
    [ButikPIB] int  NULL
);
GO

-- Creating table 'Kupacs'
CREATE TABLE [dbo].[Kupacs] (
    [IdKupca] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Kupujes'
CREATE TABLE [dbo].[Kupujes] (
    [ID] int  NOT NULL,
    [KupacIdKupca] int  NOT NULL,
    [ProizvodKodProizvoda] int  NOT NULL,
    [RacunIdRacuna] int  NOT NULL
);
GO

-- Creating table 'Prodavacs'
CREATE TABLE [dbo].[Prodavacs] (
    [JMBGProdavca] int  NOT NULL
);
GO

-- Creating table 'Menadzers'
CREATE TABLE [dbo].[Menadzers] (
    [JMBGMenadzera] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [PIB] in table 'Butiks'
ALTER TABLE [dbo].[Butiks]
ADD CONSTRAINT [PK_Butiks]
    PRIMARY KEY CLUSTERED ([PIB] ASC);
GO

-- Creating primary key on [IdKase] in table 'Kasas'
ALTER TABLE [dbo].[Kasas]
ADD CONSTRAINT [PK_Kasas]
    PRIMARY KEY CLUSTERED ([IdKase] ASC);
GO

-- Creating primary key on [JMBG] in table 'Radniks'
ALTER TABLE [dbo].[Radniks]
ADD CONSTRAINT [PK_Radniks]
    PRIMARY KEY CLUSTERED ([JMBG] ASC);
GO

-- Creating primary key on [IdRacuna] in table 'Racuns'
ALTER TABLE [dbo].[Racuns]
ADD CONSTRAINT [PK_Racuns]
    PRIMARY KEY CLUSTERED ([IdRacuna] ASC);
GO

-- Creating primary key on [KodProizvoda] in table 'Proizvods'
ALTER TABLE [dbo].[Proizvods]
ADD CONSTRAINT [PK_Proizvods]
    PRIMARY KEY CLUSTERED ([KodProizvoda] ASC);
GO

-- Creating primary key on [IdKupca] in table 'Kupacs'
ALTER TABLE [dbo].[Kupacs]
ADD CONSTRAINT [PK_Kupacs]
    PRIMARY KEY CLUSTERED ([IdKupca] ASC);
GO

-- Creating primary key on [ID] in table 'Kupujes'
ALTER TABLE [dbo].[Kupujes]
ADD CONSTRAINT [PK_Kupujes]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [JMBGProdavca] in table 'Prodavacs'
ALTER TABLE [dbo].[Prodavacs]
ADD CONSTRAINT [PK_Prodavacs]
    PRIMARY KEY CLUSTERED ([JMBGProdavca] ASC);
GO

-- Creating primary key on [JMBGMenadzera] in table 'Menadzers'
ALTER TABLE [dbo].[Menadzers]
ADD CONSTRAINT [PK_Menadzers]
    PRIMARY KEY CLUSTERED ([JMBGMenadzera] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ButikPIB] in table 'Radniks'
ALTER TABLE [dbo].[Radniks]
ADD CONSTRAINT [FK_ButikRadnik]
    FOREIGN KEY ([ButikPIB])
    REFERENCES [dbo].[Butiks]
        ([PIB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ButikRadnik'
CREATE INDEX [IX_FK_ButikRadnik]
ON [dbo].[Radniks]
    ([ButikPIB]);
GO

-- Creating foreign key on [ButikPIB] in table 'Proizvods'
ALTER TABLE [dbo].[Proizvods]
ADD CONSTRAINT [FK_ButikProizvod]
    FOREIGN KEY ([ButikPIB])
    REFERENCES [dbo].[Butiks]
        ([PIB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ButikProizvod'
CREATE INDEX [IX_FK_ButikProizvod]
ON [dbo].[Proizvods]
    ([ButikPIB]);
GO

-- Creating foreign key on [ButikPIB] in table 'Kasas'
ALTER TABLE [dbo].[Kasas]
ADD CONSTRAINT [FK_ButikKasa]
    FOREIGN KEY ([ButikPIB])
    REFERENCES [dbo].[Butiks]
        ([PIB])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ButikKasa'
CREATE INDEX [IX_FK_ButikKasa]
ON [dbo].[Kasas]
    ([ButikPIB]);
GO

-- Creating foreign key on [Menadzer_JMBGMenadzera] in table 'Radniks'
ALTER TABLE [dbo].[Radniks]
ADD CONSTRAINT [FK_MenadzerRadnik]
    FOREIGN KEY ([Menadzer_JMBGMenadzera])
    REFERENCES [dbo].[Menadzers]
        ([JMBGMenadzera])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MenadzerRadnik'
CREATE INDEX [IX_FK_MenadzerRadnik]
ON [dbo].[Radniks]
    ([Menadzer_JMBGMenadzera]);
GO

-- Creating foreign key on [RacunIdRacuna] in table 'Kupujes'
ALTER TABLE [dbo].[Kupujes]
ADD CONSTRAINT [FK_RacunKupuje]
    FOREIGN KEY ([RacunIdRacuna])
    REFERENCES [dbo].[Racuns]
        ([IdRacuna])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RacunKupuje'
CREATE INDEX [IX_FK_RacunKupuje]
ON [dbo].[Kupujes]
    ([RacunIdRacuna]);
GO

-- Creating foreign key on [KasaIdKase] in table 'Racuns'
ALTER TABLE [dbo].[Racuns]
ADD CONSTRAINT [FK_KasaRacun]
    FOREIGN KEY ([KasaIdKase])
    REFERENCES [dbo].[Kasas]
        ([IdKase])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KasaRacun'
CREATE INDEX [IX_FK_KasaRacun]
ON [dbo].[Racuns]
    ([KasaIdKase]);
GO

-- Creating foreign key on [ProizvodKodProizvoda] in table 'Kupujes'
ALTER TABLE [dbo].[Kupujes]
ADD CONSTRAINT [FK_ProizvodKupuje]
    FOREIGN KEY ([ProizvodKodProizvoda])
    REFERENCES [dbo].[Proizvods]
        ([KodProizvoda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProizvodKupuje'
CREATE INDEX [IX_FK_ProizvodKupuje]
ON [dbo].[Kupujes]
    ([ProizvodKodProizvoda]);
GO

-- Creating foreign key on [KupacIdKupca] in table 'Kupujes'
ALTER TABLE [dbo].[Kupujes]
ADD CONSTRAINT [FK_KupacKupuje]
    FOREIGN KEY ([KupacIdKupca])
    REFERENCES [dbo].[Kupacs]
        ([IdKupca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_KupacKupuje'
CREATE INDEX [IX_FK_KupacKupuje]
ON [dbo].[Kupujes]
    ([KupacIdKupca]);
GO

-- Creating foreign key on [Prodavac_JMBGProdavca] in table 'Radniks'
ALTER TABLE [dbo].[Radniks]
ADD CONSTRAINT [FK_ProdavacRadnik]
    FOREIGN KEY ([Prodavac_JMBGProdavca])
    REFERENCES [dbo].[Prodavacs]
        ([JMBGProdavca])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdavacRadnik'
CREATE INDEX [IX_FK_ProdavacRadnik]
ON [dbo].[Radniks]
    ([Prodavac_JMBGProdavca]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------