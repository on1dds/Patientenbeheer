CREATE DATABASE [patienten]
GO
ALTER DATABASE [patienten] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [patienten].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [patienten] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [patienten] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [patienten] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [patienten] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [patienten] SET ARITHABORT OFF 
GO
ALTER DATABASE [patienten] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [patienten] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [patienten] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [patienten] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [patienten] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [patienten] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [patienten] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [patienten] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [patienten] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [patienten] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [patienten] SET  DISABLE_BROKER 
GO
ALTER DATABASE [patienten] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [patienten] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [patienten] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [patienten] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [patienten] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [patienten] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [patienten] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [patienten] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [patienten] SET  MULTI_USER 
GO
ALTER DATABASE [patienten] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [patienten] SET DB_CHAINING OFF 
GO
ALTER DATABASE [patienten] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [patienten] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [patienten]
GO

/****** Object:  Table [dbo].[Afdeling]    Script Date: 11/06/2014 16:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Afdeling](
	[AfdelingID] [int] IDENTITY(1,1) NOT NULL,
	[Afdelingnaam] [nvarchar](50) NULL,
 CONSTRAINT [PK_Afdeling] PRIMARY KEY CLUSTERED 
(
	[AfdelingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Opname]    Script Date: 11/06/2014 16:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Opname](
	[Opnamenr] [int] IDENTITY(1,1) NOT NULL,
	[Patientnr] [int] NULL,
	[Opnamedatum] [datetime] NULL,
	[Ontslagdatum] [datetime] NULL,
	[AfdelingID] [int] NULL,
	[Opmerking] [nvarchar](250) NULL,
 CONSTRAINT [PK_Opname] PRIMARY KEY CLUSTERED 
(
	[Opnamenr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 11/06/2014 16:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[Patientnr] [int] IDENTITY(1,1) NOT NULL,
	[Voornaam] [nvarchar](50) NULL,
	[Achternaam] [nvarchar](50) NULL,
	[Straat] [nvarchar](50) NULL,
	[Huisnummer] [nvarchar](10) NULL,
	[PostcodeID] [int] NULL,
	[Telefoonnummer] [nvarchar](50) NULL,
	[Geboortedatum] [date] NULL,
	[Opmerking] [nvarchar](250) NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[Patientnr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Personeel]    Script Date: 11/06/2014 16:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personeel](
	[PersoneelID] [int] IDENTITY(1,1) NOT NULL,
	[Voornaam] [nvarchar](50) NULL,
	[Achternaam] [nvarchar](50) NULL,
	[Functie] [nvarchar](50) NULL,
 CONSTRAINT [PK_Personeel] PRIMARY KEY CLUSTERED 
(
	[PersoneelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Postcode]    Script Date: 11/06/2014 16:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Postcode](
	[PostcodeID] [int] IDENTITY(1,1) NOT NULL,
	[Postcode] [nvarchar](4) NOT NULL,
	[Gemeente] [nvarchar](60) NULL,
	[Provincie] [nvarchar](60) NULL,
 CONSTRAINT [PK_Postcode_1] PRIMARY KEY CLUSTERED 
(
	[PostcodeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Prestaties]    Script Date: 11/06/2014 16:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestaties](
	[Prestatienr] [int] IDENTITY(1,1) NOT NULL,
	[PrestatieSoortID] [int] NULL,
	[Opnamenr] [int] NULL,
	[Tijdstip] [datetime] NULL,
	[UitvoerderID] [int] NULL,
	[PrestatieStatusID] [int] NULL,
	[Opmerking] [nvarchar](250) NULL,
 CONSTRAINT [PK_Prestaties] PRIMARY KEY CLUSTERED 
(
	[Prestatienr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PrestatieSoort]    Script Date: 11/06/2014 16:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrestatieSoort](
	[PrestatieSoortID] [int] IDENTITY(1,1) NOT NULL,
	[Naam] [nvarchar](50) NOT NULL,
	[Omschrijving] [nvarchar](250) NULL,
	[Kostprijs] [float] NULL,
 CONSTRAINT [PK_PrestatieSoort] PRIMARY KEY CLUSTERED 
(
	[PrestatieSoortID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Opname]  WITH CHECK ADD  CONSTRAINT [FK_Opname_Afdeling] FOREIGN KEY([AfdelingID])
REFERENCES [dbo].[Afdeling] ([AfdelingID])
GO
ALTER TABLE [dbo].[Opname] CHECK CONSTRAINT [FK_Opname_Afdeling]
GO
ALTER TABLE [dbo].[Opname]  WITH CHECK ADD  CONSTRAINT [FK_Opname_Patient] FOREIGN KEY([Patientnr])
REFERENCES [dbo].[Patient] ([Patientnr])
GO
ALTER TABLE [dbo].[Opname] CHECK CONSTRAINT [FK_Opname_Patient]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Postcode1] FOREIGN KEY([PostcodeID])
REFERENCES [dbo].[Postcode] ([PostcodeID])
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Patient_Postcode1]
GO
ALTER TABLE [dbo].[Prestaties]  WITH CHECK ADD  CONSTRAINT [FK_Prestaties_Opname] FOREIGN KEY([Opnamenr])
REFERENCES [dbo].[Opname] ([Opnamenr])
GO
ALTER TABLE [dbo].[Prestaties] CHECK CONSTRAINT [FK_Prestaties_Opname]
GO
ALTER TABLE [dbo].[Prestaties]  WITH CHECK ADD  CONSTRAINT [FK_Prestaties_Personeel] FOREIGN KEY([UitvoerderID])
REFERENCES [dbo].[Personeel] ([PersoneelID])
GO
ALTER TABLE [dbo].[Prestaties] CHECK CONSTRAINT [FK_Prestaties_Personeel]
GO
ALTER TABLE [dbo].[Prestaties]  WITH CHECK ADD  CONSTRAINT [FK_Prestaties_PrestatieSoort] FOREIGN KEY([PrestatieSoortID])
REFERENCES [dbo].[PrestatieSoort] ([PrestatieSoortID])
GO
ALTER TABLE [dbo].[Prestaties] NOCHECK CONSTRAINT [FK_Prestaties_PrestatieSoort]
GO
USE [master]
GO
ALTER DATABASE [patienten] SET  READ_WRITE 
GO

USE [patienten]

SET DATEFORMAT dmy;

DELETE FROM Postcode;
DBCC CHECKIDENT (Postcode, RESEED, 0)
BULK INSERT Postcode FROM "C:\temp\data\postcodes.csv"
WITH ( FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', CODEPAGE = 'ACP');

DELETE FROM Afdeling;
DBCC CHECKIDENT (Afdeling, RESEED, 0)
BULK INSERT Afdeling FROM "C:\temp\data\afdelingen.csv"
WITH ( FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', CODEPAGE = 'ACP');

DELETE FROM PrestatieSoort;
DBCC CHECKIDENT (PrestatieSoort, RESEED, 0)
BULK INSERT PrestatieSoort FROM "C:\temp\data\prestatiesoorten.csv"
WITH ( FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', CODEPAGE = 'ACP');

DELETE FROM Personeel;
DBCC CHECKIDENT (Personeel, RESEED, 0)
BULK INSERT Personeel FROM "C:\temp\data\personeel.csv"
WITH ( FIELDTERMINATOR = ';', ROWTERMINATOR = '\n', CODEPAGE = 'ACP');
GO

