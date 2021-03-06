USE [master]
GO

/****** Object:  Database [BugManager]    Script Date: 10/28/2021 4:35:54 PM ******/
DROP DATABASE IF EXISTS [BugManager]
GO

/****** Object:  Database [BugManager]    Script Date: 10/28/2021 4:35:54 PM ******/
CREATE DATABASE [BugManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BugManager', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BugManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BugManager_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BugManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BugManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [BugManager] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [BugManager] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [BugManager] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [BugManager] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [BugManager] SET ARITHABORT OFF 
GO

ALTER DATABASE [BugManager] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [BugManager] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [BugManager] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [BugManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [BugManager] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [BugManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [BugManager] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [BugManager] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [BugManager] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [BugManager] SET  DISABLE_BROKER 
GO

ALTER DATABASE [BugManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [BugManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [BugManager] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [BugManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [BugManager] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [BugManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [BugManager] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [BugManager] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [BugManager] SET  MULTI_USER 
GO

ALTER DATABASE [BugManager] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [BugManager] SET DB_CHAINING OFF 
GO

ALTER DATABASE [BugManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [BugManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [BugManager] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [BugManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [BugManager] SET QUERY_STORE = OFF
GO

ALTER DATABASE [BugManager] SET  READ_WRITE 
GO

/****** Object:  Table [dbo].[Bugs]    Script Date: 10/28/2021 4:36:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

USE BugManager
GO

CREATE TABLE [dbo].[Bugs](
	[Id] [int] IDENTITY PRIMARY KEY,
	[Summary] [nvarchar](max) NOT NULL,
	[Created] [datetime2](7) NOT NULL,
	[IsOpen] [bit] NOT NULL,
	[ResponsibleDev] [nvarchar](255) NULL,
	[Location] [nvarchar](255) NULL)
GO

INSERT INTO Bugs 
	(Summary, Created, IsOpen, ResponsibleDev, Location)
VALUES
	('The application crashes when I click exit', '10/28/21', 1, 'Matt Eland', 'Main Menu'),
	('Bitcoin miner is not included in installer', '9/15/21', 1, 'Jevin Teos', 'Installer'),
	('It unleashes bees all over my household!', '10/15/21', 0, 'Jevin Teos', 'Misc.'),
	('Withdrawing money does not decrease my balance', '10/22/21', 1, 'Vinny Sanfillipo', 'Balance')
GO