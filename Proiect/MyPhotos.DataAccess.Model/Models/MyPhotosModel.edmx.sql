
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/16/2020 21:42:49
-- Generated from EDMX file: C:\Users\sturcu\Desktop\facultate\tsp.net\TSP.NET\MyPhotos.DataAccess.Model\Models\MyPhotosModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PhotosType_Photos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosType] DROP CONSTRAINT [FK_PhotosType_Photos];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosType_Type]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosType] DROP CONSTRAINT [FK_PhotosType_Type];
GO
IF OBJECT_ID(N'[dbo].[FK_EventPhotos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Photos] DROP CONSTRAINT [FK_EventPhotos];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosPlaces_Photos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosPlaces] DROP CONSTRAINT [FK_PhotosPlaces_Photos];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosPlaces_Places]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosPlaces] DROP CONSTRAINT [FK_PhotosPlaces_Places];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosPerson_Photos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosPerson] DROP CONSTRAINT [FK_PhotosPerson_Photos];
GO
IF OBJECT_ID(N'[dbo].[FK_PhotosPerson_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PhotosPerson] DROP CONSTRAINT [FK_PhotosPerson_Person];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Photos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Photos];
GO
IF OBJECT_ID(N'[dbo].[Places]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Places];
GO
IF OBJECT_ID(N'[dbo].[People]', 'U') IS NOT NULL
    DROP TABLE [dbo].[People];
GO
IF OBJECT_ID(N'[dbo].[Events]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Events];
GO
IF OBJECT_ID(N'[dbo].[Types]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Types];
GO
IF OBJECT_ID(N'[dbo].[PhotosType]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotosType];
GO
IF OBJECT_ID(N'[dbo].[PhotosPlaces]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotosPlaces];
GO
IF OBJECT_ID(N'[dbo].[PhotosPerson]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PhotosPerson];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Photos'
CREATE TABLE [dbo].[Photos] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(128)  NOT NULL,
    [Path] nvarchar(252)  NOT NULL,
    [IsDeleted] bit  NOT NULL,
    [CreationDate] datetime  NOT NULL,
    [Event_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'Places'
CREATE TABLE [dbo].[Places] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] uniqueidentifier  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Events'
CREATE TABLE [dbo].[Events] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Types'
CREATE TABLE [dbo].[Types] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PhotosType'
CREATE TABLE [dbo].[PhotosType] (
    [Photos_Id] uniqueidentifier  NOT NULL,
    [Types_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PhotosPlaces'
CREATE TABLE [dbo].[PhotosPlaces] (
    [Photos_Id] uniqueidentifier  NOT NULL,
    [Places_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'PhotosPerson'
CREATE TABLE [dbo].[PhotosPerson] (
    [Photos_Id] uniqueidentifier  NOT NULL,
    [People_Id] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [PK_Photos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Places'
ALTER TABLE [dbo].[Places]
ADD CONSTRAINT [PK_Places]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Events'
ALTER TABLE [dbo].[Events]
ADD CONSTRAINT [PK_Events]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Types'
ALTER TABLE [dbo].[Types]
ADD CONSTRAINT [PK_Types]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Photos_Id], [Types_Id] in table 'PhotosType'
ALTER TABLE [dbo].[PhotosType]
ADD CONSTRAINT [PK_PhotosType]
    PRIMARY KEY CLUSTERED ([Photos_Id], [Types_Id] ASC);
GO

-- Creating primary key on [Photos_Id], [Places_Id] in table 'PhotosPlaces'
ALTER TABLE [dbo].[PhotosPlaces]
ADD CONSTRAINT [PK_PhotosPlaces]
    PRIMARY KEY CLUSTERED ([Photos_Id], [Places_Id] ASC);
GO

-- Creating primary key on [Photos_Id], [People_Id] in table 'PhotosPerson'
ALTER TABLE [dbo].[PhotosPerson]
ADD CONSTRAINT [PK_PhotosPerson]
    PRIMARY KEY CLUSTERED ([Photos_Id], [People_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Photos_Id] in table 'PhotosType'
ALTER TABLE [dbo].[PhotosType]
ADD CONSTRAINT [FK_PhotosType_Photos]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Types_Id] in table 'PhotosType'
ALTER TABLE [dbo].[PhotosType]
ADD CONSTRAINT [FK_PhotosType_Type]
    FOREIGN KEY ([Types_Id])
    REFERENCES [dbo].[Types]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosType_Type'
CREATE INDEX [IX_FK_PhotosType_Type]
ON [dbo].[PhotosType]
    ([Types_Id]);
GO

-- Creating foreign key on [Event_Id] in table 'Photos'
ALTER TABLE [dbo].[Photos]
ADD CONSTRAINT [FK_EventPhotos]
    FOREIGN KEY ([Event_Id])
    REFERENCES [dbo].[Events]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EventPhotos'
CREATE INDEX [IX_FK_EventPhotos]
ON [dbo].[Photos]
    ([Event_Id]);
GO

-- Creating foreign key on [Photos_Id] in table 'PhotosPlaces'
ALTER TABLE [dbo].[PhotosPlaces]
ADD CONSTRAINT [FK_PhotosPlaces_Photos]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Places_Id] in table 'PhotosPlaces'
ALTER TABLE [dbo].[PhotosPlaces]
ADD CONSTRAINT [FK_PhotosPlaces_Places]
    FOREIGN KEY ([Places_Id])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosPlaces_Places'
CREATE INDEX [IX_FK_PhotosPlaces_Places]
ON [dbo].[PhotosPlaces]
    ([Places_Id]);
GO

-- Creating foreign key on [Photos_Id] in table 'PhotosPerson'
ALTER TABLE [dbo].[PhotosPerson]
ADD CONSTRAINT [FK_PhotosPerson_Photos]
    FOREIGN KEY ([Photos_Id])
    REFERENCES [dbo].[Photos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [People_Id] in table 'PhotosPerson'
ALTER TABLE [dbo].[PhotosPerson]
ADD CONSTRAINT [FK_PhotosPerson_Person]
    FOREIGN KEY ([People_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PhotosPerson_Person'
CREATE INDEX [IX_FK_PhotosPerson_Person]
ON [dbo].[PhotosPerson]
    ([People_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------