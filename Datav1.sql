USE [master]
GO
/****** Object:  Database [AdminDb]    Script Date: 19/01/2021 15:47:01 ******/
CREATE DATABASE [AdminDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AdminDb', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AdminDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AdminDb_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AdminDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [AdminDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AdminDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AdminDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AdminDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AdminDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AdminDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AdminDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [AdminDb] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AdminDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AdminDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AdminDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AdminDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AdminDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AdminDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AdminDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AdminDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AdminDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AdminDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AdminDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AdminDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AdminDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AdminDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AdminDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [AdminDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AdminDb] SET RECOVERY FULL 
GO
ALTER DATABASE [AdminDb] SET  MULTI_USER 
GO
ALTER DATABASE [AdminDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AdminDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AdminDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AdminDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AdminDb] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'AdminDb', N'ON'
GO
ALTER DATABASE [AdminDb] SET QUERY_STORE = OFF
GO
USE [AdminDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AddressMaster]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AddressMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[Address1] [nvarchar](250) NULL,
	[Address2] [nvarchar](250) NULL,
	[City] [int] NOT NULL,
	[State] [int] NOT NULL,
	[Country] [int] NOT NULL,
	[PinCode] [nvarchar](6) NULL,
	[AddressType] [int] NULL,
	[AddressStatus] [int] NULL,
	[UserId] [int] NULL,
	[OwnerType] [int] NULL,
	[Lattitude] [nvarchar](50) NULL,
	[Longitude] [nvarchar](50) NULL,
	[CustomerId] [int] NULL,
	[GoogleMpsUrl] [nvarchar](1500) NULL,
	[Landmark] [nvarchar](50) NULL,
	[BuilderMasterId] [int] NULL,
 CONSTRAINT [PK_AddressMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[Subject] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[DurationMins] [int] NULL,
	[AppointmentDate] [datetime2](7) NOT NULL,
	[Status] [int] NOT NULL,
	[NotificationSentTime] [datetime2](7) NOT NULL,
	[NotificationSentBy] [int] NOT NULL,
	[MeetingNotes] [nvarchar](max) NULL,
	[UserId] [int] NULL,
	[CustomerId] [int] NULL,
	[AppointmentId] [int] NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuilderMaster]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuilderMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[EstablishmentYear] [datetime2](7) NOT NULL,
	[CompletedProjectsCount] [int] NOT NULL,
	[Image] [nvarchar](max) NULL,
	[Logo] [nvarchar](max) NULL,
 CONSTRAINT [PK_BuilderMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BuilderProperties]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BuilderProperties](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BuilderId] [int] NULL,
	[PropertyId] [int] NULL,
 CONSTRAINT [PK_BuilderProperties] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommonSetup]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommonSetup](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[MainType] [nvarchar](max) NULL,
	[SubType] [nvarchar](max) NULL,
	[DisplayText] [nvarchar](max) NULL,
	[DisplayValue] [int] NOT NULL,
	[ParentId] [int] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_CommonSetup] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CompanyMaster]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompanyMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[DivisionId] [int] NOT NULL,
 CONSTRAINT [PK_CompanyMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContactUs]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContactUs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[FirstName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Mobile] [nvarchar](max) NULL,
	[Message] [nvarchar](max) NULL,
	[ContactFor] [int] NOT NULL,
 CONSTRAINT [PK_ContactUs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Country]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[COUNTRYCODE] [nvarchar](3) NOT NULL,
	[COUNTRY] [nvarchar](max) NULL,
	[COUNTRY_TID] [int] NULL,
	[COUNTRYADJECTIVE] [nvarchar](max) NULL,
	[POSTCODEFIRST] [decimal](18, 2) NULL,
	[POSTCODELITERAL] [nvarchar](max) NULL,
	[POSTCODELITERAL_TID] [int] NULL,
	[POSTALNAME] [nvarchar](max) NULL,
	[STATEABBREVIATED] [decimal](18, 2) NULL,
	[ADDRESSSTYLE] [int] NULL,
	[NAMESTYLE] [int] NULL,
	[AllMembersFlag] [decimal](9, 4) NOT NULL,
	[RECORDTYPE] [nvarchar](max) NULL,
	[ALTERNATECODE] [nvarchar](max) NULL,
	[COUNTRYABBREV] [nvarchar](max) NULL,
	[INFORMALNAME] [nvarchar](max) NULL,
	[ISD] [nvarchar](max) NULL,
	[PRIORARTFLAG] [bit] NULL,
	[NOTES] [nvarchar](max) NULL,
	[DATECOMMENCED] [datetime2](7) NULL,
	[DATECEASED] [datetime2](7) NULL,
	[WORKDAYFLAG] [smallint] NULL,
	[INFORMALNAME_TID] [int] NULL,
	[COUNTRYADJECTIVE_TID] [int] NULL,
	[POSTALNAME_TID] [int] NULL,
	[NOTES_TID] [int] NULL,
	[STATELITERAL] [nvarchar](max) NULL,
	[STATELITERAL_TID] [int] NULL,
	[PostCodeAutoFlag] [decimal](9, 4) NULL,
	[POSTCODESEARCHCODE] [int] NULL,
	[DEFAULTTAXCODE] [nvarchar](450) NULL,
	[DEFAULTCURRENCY] [nvarchar](450) NULL,
	[REQUIREEXEMPTTAXNO] [decimal](9, 4) NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[COUNTRYCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CountryGroup]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CountryGroup](
	[TREATYCODE] [nvarchar](450) NOT NULL,
	[MEMBERCOUNTRY] [nvarchar](450) NOT NULL,
	[PROPERTYTYPES] [nvarchar](max) NULL,
	[DATECOMMENCED] [datetime2](7) NULL,
	[DATECEASED] [datetime2](7) NULL,
	[ASSOCIATEMEMBER] [decimal](9, 4) NULL,
	[DEFAULTFLAG] [decimal](9, 4) NULL,
	[PREVENTNATPHASE] [bit] NULL,
	[FULLMEMBERDATE] [datetime2](7) NULL,
	[ASSOCIATEMEMBERDATE] [datetime2](7) NULL,
 CONSTRAINT [PK_CountryGroup] PRIMARY KEY CLUSTERED 
(
	[TREATYCODE] ASC,
	[MEMBERCOUNTRY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Currency]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Currency](
	[CURRENCY] [nvarchar](450) NOT NULL,
	[DESCRIPTION] [nvarchar](max) NULL,
	[DESCRIPTION_TID] [int] NULL,
	[SellRate] [decimal](9, 4) NULL,
	[DECIMALPLACES] [tinyint] NULL,
 CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED 
(
	[CURRENCY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[AccountStatus] [int] NOT NULL,
	[Phone] [nvarchar](max) NULL,
	[Mobile] [nvarchar](max) NULL,
	[AltMobile] [nvarchar](max) NULL,
	[Facebook] [nvarchar](max) NULL,
	[Linkedin] [nvarchar](max) NULL,
	[Instagram] [nvarchar](max) NULL,
	[ReferredByUserId] [int] NULL,
	[ReferenceSource] [int] NOT NULL,
	[Remarks] [nvarchar](max) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DailyLoginHistory]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DailyLoginHistory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NULL,
	[SessionId] [nvarchar](max) NULL,
	[IpAddress] [nvarchar](max) NULL,
	[BrowserName] [nvarchar](max) NULL,
	[LoginType] [int] NULL,
	[LogOutTime] [datetime2](7) NULL,
	[LoginTime] [datetime2](7) NULL,
	[IsLogin] [bit] NOT NULL,
	[Application] [nvarchar](max) NULL,
	[LastExtension] [datetime2](7) NULL,
	[Provider] [nvarchar](max) NULL,
	[Source] [nvarchar](max) NULL,
 CONSTRAINT [PK_DailyLoginHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailMergeFields]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailMergeFields](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[FieldName] [nvarchar](max) NULL,
	[SrcField] [nvarchar](max) NULL,
	[SrcFieldValue] [nvarchar](max) NULL,
	[Sequence] [int] NULL,
	[TemplateCode] [int] NULL,
	[EmailTemplateId] [int] NULL,
 CONSTRAINT [PK_EmailMergeFields] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailService]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailService](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[TemplateId] [int] NOT NULL,
	[FromEmail] [nvarchar](max) NULL,
	[FromName] [nvarchar](max) NULL,
	[ToName] [nvarchar](max) NULL,
	[ToEmail] [nvarchar](max) NULL,
	[CcEmail] [nvarchar](max) NULL,
	[BccEmail] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[Body] [nvarchar](max) NULL,
	[Mobile] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Message] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
	[IsHtml] [bit] NOT NULL,
	[Priority] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[IsAttachment] [bit] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[AttachmentFileName] [nvarchar](max) NULL,
	[Remarks] [nvarchar](max) NULL,
	[TemplateCode] [int] NULL,
 CONSTRAINT [PK_EmailService] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmailTemplate]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmailTemplate](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[Name] [nvarchar](max) NULL,
	[Type] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[HtmlContent] [nvarchar](max) NULL,
	[Subject] [nvarchar](max) NULL,
	[Cost] [int] NULL,
	[AuthorName] [nvarchar](max) NULL,
	[About] [nvarchar](max) NULL,
	[TemplateCode] [int] NULL,
 CONSTRAINT [PK_EmailTemplate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ErrorLog]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ErrorLog](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EventId] [int] NULL,
	[Priority] [int] NOT NULL,
	[Severity] [int] NOT NULL,
	[Title] [nvarchar](max) NULL,
	[MachineName] [nvarchar](max) NULL,
	[AppDomainName] [nvarchar](max) NULL,
	[ProcessId] [nvarchar](max) NULL,
	[ProcessName] [nvarchar](max) NULL,
	[ThreadName] [nvarchar](max) NULL,
	[Win32ThreadId] [nvarchar](max) NULL,
	[Message] [nvarchar](max) NULL,
	[Timestamp] [datetime2](7) NOT NULL,
	[FormattedMessage] [nvarchar](max) NULL,
 CONSTRAINT [PK_ErrorLog] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginAttemptHistory]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginAttemptHistory](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[FailedAttempt] [int] NULL,
	[UserId] [int] NOT NULL,
	[LoginDate] [datetime2](7) NULL,
	[LastLoginDate] [datetime2](7) NULL,
	[IpAddress] [nvarchar](max) NULL,
	[Browser] [nvarchar](max) NULL,
 CONSTRAINT [PK_LoginAttemptHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ModuleMaster]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ModuleMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[Name] [nvarchar](max) NULL,
	[ParentModuleId] [int] NULL,
	[ModuleCode] [int] NULL,
	[Sequence] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[Icon] [nvarchar](max) NULL,
	[IsStoreWise] [bit] NULL,
	[ModuleType] [int] NOT NULL,
	[ModuleDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_ModuleMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OtpMaster]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OtpMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[Otp] [nvarchar](max) NULL,
	[Guid] [nvarchar](max) NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[Attempts] [int] NULL,
 CONSTRAINT [PK_OtpMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[DENYPERMISSION] [tinyint] NOT NULL,
	[GRANTPERMISSION] [tinyint] NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[LEVELKEY] [int] NULL,
	[LEVELTABLE] [nvarchar](max) NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[OBJECTINTEGERKEY] [int] NULL,
	[OBJECTSTRINGKEY] [nvarchar](max) NULL,
	[OBJECTTABLE] [nvarchar](max) NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyCertification]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyCertification](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[PropertyId] [int] NOT NULL,
	[ValidFrom] [datetime2](7) NOT NULL,
	[ValidUntil] [datetime2](7) NOT NULL,
	[IssuedBy] [nvarchar](150) NULL,
	[CertificationNumber] [nvarchar](50) NULL,
 CONSTRAINT [PK_PropertyCertification] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyFlat]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyFlat](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FlatNumber] [int] NOT NULL,
	[TotalRooms] [int] NOT NULL,
	[TotalWashrooms] [int] NULL,
	[TotalBalcony] [int] NULL,
	[SuperArea] [int] NOT NULL,
	[Cost] [int] NOT NULL,
	[CarpetArea] [int] NULL,
	[AreaMeasurementUnit] [int] NULL,
	[IsStudyRoomIncluded] [bit] NOT NULL,
	[IsStoreRoomIncluded] [bit] NOT NULL,
	[AppointmentId] [int] NULL,
	[FloorId] [int] NULL,
 CONSTRAINT [PK_PropertyFlat] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyImage]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyImage](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Description] [nvarchar](250) NULL,
	[Image] [nvarchar](max) NOT NULL,
	[PropertyId] [int] NULL,
 CONSTRAINT [PK_PropertyImage] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyMaster]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[PropertyName] [nvarchar](250) NOT NULL,
	[PropertyId] [int] NULL,
	[AreaSize] [int] NOT NULL,
	[ConstructionStatus] [int] NOT NULL,
 CONSTRAINT [PK_PropertyMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyRoomDetail]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyRoomDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[RoomType] [int] NOT NULL,
	[ImageId] [int] NULL,
	[RoomLengthSize] [int] NULL,
	[RoomWidthSize] [int] NULL,
	[RoomHeightSize] [int] NULL,
	[TotalSize] [int] NOT NULL,
	[IsAttachedWashRoom] [bit] NOT NULL,
	[IsFurnished] [bit] NOT NULL,
	[IsAttachedBalcony] [bit] NOT NULL,
	[FlatId] [int] NULL,
 CONSTRAINT [PK_PropertyRoomDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyTower]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyTower](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[TowerName] [nvarchar](150) NOT NULL,
	[TowerNumber] [int] NOT NULL,
	[ConstructionStatus] [int] NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Floors] [int] NOT NULL,
	[PropertyId] [int] NULL,
 CONSTRAINT [PK_PropertyTower] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyTowerFloor]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyTowerFloor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[FloorName] [nvarchar](50) NULL,
	[FloorNumber] [int] NOT NULL,
	[TotalFlats] [int] NOT NULL,
	[TowerId] [int] NOT NULL,
	[IsRoof] [bit] NOT NULL,
	[IsGroundFloor] [bit] NOT NULL,
 CONSTRAINT [PK_PropertyTowerFloor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PropertyType]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropertyType](
	[PropertyTypeId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Direction] [nvarchar](50) NULL,
 CONSTRAINT [PK_PropertyType] PRIMARY KEY CLUSTERED 
(
	[PropertyTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleMaster]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[Name] [nvarchar](max) NULL,
	[Code] [nvarchar](max) NULL,
	[Type] [int] NULL,
	[Status] [int] NOT NULL,
	[IsAdmin] [bit] NOT NULL,
	[RoleDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_RoleMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleModule]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleModule](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[RoleId] [int] NOT NULL,
	[ModuleId] [int] NOT NULL,
	[Sequence] [int] NOT NULL,
	[IsMandatory] [bit] NOT NULL,
	[ModuleMasterId] [int] NULL,
	[RoleMasterId] [int] NULL,
 CONSTRAINT [PK_RoleModule] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RowAccess]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RowAccess](
	[ACCESSNAME] [nvarchar](450) NOT NULL,
	[ACCESSDESC] [nvarchar](max) NULL,
 CONSTRAINT [PK_RowAccess] PRIMARY KEY CLUSTERED 
(
	[ACCESSNAME] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesInquiry]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesInquiry](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[InquirySource] [nvarchar](100) NULL,
	[InquirySourceId] [int] NULL,
	[Remarks] [nvarchar](max) NULL,
	[InquiryDate] [datetime2](7) NOT NULL,
	[UserId] [int] NULL,
	[CustomerId] [int] NULL,
	[SaleStatus] [int] NOT NULL,
	[PropertyId] [int] NULL,
 CONSTRAINT [PK_SalesInquiry] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SettingDefinition]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SettingDefinition](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[Name] [nvarchar](max) NULL,
	[Description] [nvarchar](max) NULL,
	[NameTid] [int] NULL,
	[DescriptionTid] [int] NULL,
 CONSTRAINT [PK_SettingDefinition] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[State]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[State](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[COUNTRYCODE] [nvarchar](max) NULL,
	[STATE] [nvarchar](max) NULL,
	[STATENAME] [nvarchar](max) NULL,
	[STATENAME_TID] [int] NULL,
	[CountryId] [nvarchar](3) NULL,
 CONSTRAINT [PK_State] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SystemSettings]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SystemSettings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[CompanyId] [int] NOT NULL,
	[LogoutTime] [int] NOT NULL,
	[LoginFailedAttempt] [int] NOT NULL,
	[MaxLeaveMarkDays] [int] NOT NULL,
	[WeeklyOffDays] [nvarchar](max) NULL,
	[IdleSystemDay] [int] NOT NULL,
 CONSTRAINT [PK_SystemSettings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableCode]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableCode](
	[TABLECODE] [int] NOT NULL,
	[TABLETYPE] [smallint] NOT NULL,
	[DESCRIPTION] [nvarchar](max) NULL,
	[DESCRIPTION_TID] [int] NULL,
	[USERCODE] [nvarchar](max) NULL,
 CONSTRAINT [PK_TableCode] PRIMARY KEY CLUSTERED 
(
	[TABLECODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TableType]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableType](
	[TABLETYPE] [smallint] NOT NULL,
	[TABLENAME] [nvarchar](max) NULL,
	[DATABASETABLE] [nvarchar](max) NULL,
	[TABLENAME_TID] [int] NULL,
 CONSTRAINT [PK_TableType] PRIMARY KEY CLUSTERED 
(
	[TABLETYPE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TASK]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TASK](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[TASKNAME] [nvarchar](max) NULL,
	[TASKNAME_TID] [int] NULL,
	[DESCRIPTION] [nvarchar](max) NULL,
	[DESCRIPTION_TID] [int] NULL,
 CONSTRAINT [PK_TASK] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaxRate]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaxRate](
	[TAXCODE] [nvarchar](450) NOT NULL,
	[DESCRIPTION] [nvarchar](max) NULL,
	[DESCRIPTION_TID] [int] NULL,
 CONSTRAINT [PK_TaxRate] PRIMARY KEY CLUSTERED 
(
	[TAXCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UploadedDocument]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UploadedDocument](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [date] NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Document] [nvarchar](max) NULL,
	[FileType] [int] NOT NULL,
	[DocumentType] [int] NOT NULL,
	[DocumentStatus] [int] NOT NULL,
	[CustomerId] [int] NULL,
	[LocationUrl] [nvarchar](1000) NULL,
 CONSTRAINT [PK_UploadedDocument] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserMaster]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NULL,
	[UserName] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[Image] [nvarchar](max) NULL,
	[EmpCode] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[AccountStatus] [int] NULL,
	[IsActive] [bit] NULL,
	[SeniorEmpId] [int] NULL,
	[IsEmployee] [bit] NULL,
	[Phone] [nvarchar](max) NULL,
	[Mobile] [nvarchar](max) NULL,
	[CompanyId] [int] NULL,
	[UserType] [int] NULL,
 CONSTRAINT [PK_UserMaster] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoleModulePermission]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoleModulePermission](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[RoleModuleId] [int] NULL,
	[UserId] [int] NULL,
	[ModuleId] [int] NULL,
	[PermissionId] [int] NOT NULL,
	[PermissionValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_UserRoleModulePermission] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserRoles]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserRoles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[RoleId] [int] NOT NULL,
	[UserId] [int] NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_UserRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserSettings]    Script Date: 19/01/2021 15:47:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserSettings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IsDeleted] [bit] NOT NULL,
	[CreatedBy] [int] NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[ModifiedBy] [int] NULL,
	[ModifiedDate] [datetime2](7) NULL,
	[UserId] [int] NULL,
	[COLCHARACTER] [nvarchar](max) NULL,
	[COLINTEGER] [int] NULL,
	[COLBOOLEAN] [bit] NULL,
	[COLDECIMAL] [decimal](18, 2) NULL,
	[SettingId] [int] NULL,
 CONSTRAINT [PK_UserSettings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201229184939_FirstMigration', N'3.1.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20201229190755_InitialMigration', N'3.1.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210103162706_EmailTemplateMigration', N'3.1.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210112111714_SecurityMigration', N'3.1.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210117055646_CRMMigration', N'3.1.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210117172728_CRM1Migration', N'3.1.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210117180911_CRM2Migration', N'3.1.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210117190615_CRM3Migration', N'3.1.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210117192832_CRM4Migration', N'3.1.6')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20210117193557_CRM5Migration', N'3.1.6')
GO
SET IDENTITY_INSERT [dbo].[CompanyMaster] ON 

INSERT [dbo].[CompanyMaster] ([Id], [Name], [Code], [DivisionId]) VALUES (1, N'Admin Company', N'100', 1)
SET IDENTITY_INSERT [dbo].[CompanyMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[EmailMergeFields] ON 

INSERT [dbo].[EmailMergeFields] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FieldName], [SrcField], [SrcFieldValue], [Sequence], [TemplateCode], [EmailTemplateId]) VALUES (1, 1, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'First Name', N'FNAME', NULL, NULL, NULL, 1)
INSERT [dbo].[EmailMergeFields] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FieldName], [SrcField], [SrcFieldValue], [Sequence], [TemplateCode], [EmailTemplateId]) VALUES (2, 1, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Last Name', N'LNAME', NULL, NULL, NULL, 1)
INSERT [dbo].[EmailMergeFields] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FieldName], [SrcField], [SrcFieldValue], [Sequence], [TemplateCode], [EmailTemplateId]) VALUES (3, 1, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Unique String', N'UNIQUESTR', NULL, NULL, NULL, 1)
INSERT [dbo].[EmailMergeFields] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FieldName], [SrcField], [SrcFieldValue], [Sequence], [TemplateCode], [EmailTemplateId]) VALUES (4, 1, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Company Name', N'COMPANY', N'Dream Wedds', NULL, NULL, 1)
INSERT [dbo].[EmailMergeFields] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FieldName], [SrcField], [SrcFieldValue], [Sequence], [TemplateCode], [EmailTemplateId]) VALUES (5, 1, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'First Name', N'FNAME', NULL, NULL, NULL, 3)
INSERT [dbo].[EmailMergeFields] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FieldName], [SrcField], [SrcFieldValue], [Sequence], [TemplateCode], [EmailTemplateId]) VALUES (6, 1, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Last Name', N'LNAME', NULL, NULL, NULL, 3)
INSERT [dbo].[EmailMergeFields] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FieldName], [SrcField], [SrcFieldValue], [Sequence], [TemplateCode], [EmailTemplateId]) VALUES (7, 1, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Url', N'URL', NULL, NULL, NULL, 3)
INSERT [dbo].[EmailMergeFields] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FieldName], [SrcField], [SrcFieldValue], [Sequence], [TemplateCode], [EmailTemplateId]) VALUES (8, 1, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Company Name', N'COMPANY', N'Dream Wedds', NULL, NULL, 3)
SET IDENTITY_INSERT [dbo].[EmailMergeFields] OFF
GO
SET IDENTITY_INSERT [dbo].[EmailTemplate] ON 

INSERT [dbo].[EmailTemplate] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Name], [Type], [Status], [HtmlContent], [Subject], [Cost], [AuthorName], [About], [TemplateCode]) VALUES (1, 0, 20, CAST(N'2021-01-03T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Forget Password', 2, 1, N'<html><head> <title>Password Reset Email| {{COMPANY}}</title> <meta http-equiv="Content-Type" content="text/html; charset=windows-1252"> <meta name="ProgId" content="Word.Document"> <meta name="Generator" content="Microsoft Word 14"> <meta name="Originator" content="Microsoft Word 14"> <style type="text/css" rel="stylesheet" media="all"> /* Base ------------------------------ */ *:not(br):not(tr):not(html) { font-family: Arial, ''Helvetica Neue'', Helvetica, sans-serif; } body { width: 100% !important; height: 100%; margin: 0; line-height: 1.4; background-color: #F2F4F6; color: #74787E; -webkit-text-size-adjust: none; } p, ul, ol, blockquote { line-height: 1.4; text-align: left; } a { color: #3869D4; } a img { border: none; } td { word-break: break-word; } /* Layout ------------------------------ */ .email-wrapper { width: 100%; margin: 0; padding: 0; -premailer-width: 100%; -premailer-cellpadding: 0; -premailer-cellspacing: 0; background-color: #F2F4F6; } .email-content { width: 100%; margin: 0; padding: 0; -premailer-width: 100%; -premailer-cellpadding: 0; -premailer-cellspacing: 0; } /* Masthead ----------------------- */ .email-masthead { padding: 25px 0; text-align: center; } .email-masthead_logo { width: 94px; } .email-masthead_name { font-size: 16px; font-weight: bold; color: #bbbfc3; text-decoration: none; text-shadow: 0 1px 0 white; } /* Body ------------------------------ */ .email-body { width: 100%; margin: 0; padding: 0; -premailer-width: 100%; -premailer-cellpadding: 0; -premailer-cellspacing: 0; border-top: 1px solid #EDEFF2; border-bottom: 1px solid #EDEFF2; background-color: #FFFFFF; } .email-body_inner { width: 570px; margin: 0 auto; padding: 0; -premailer-width: 570px; -premailer-cellpadding: 0; -premailer-cellspacing: 0; background-color: #FFFFFF; } .email-footer { width: 570px; margin: 0 auto; padding: 0; -premailer-width: 570px; -premailer-cellpadding: 0; -premailer-cellspacing: 0; text-align: center; } .email-footer p { color: #AEAEAE; } .body-action { width: 100%; margin: 30px auto; padding: 0; -premailer-width: 100%; -premailer-cellpadding: 0; -premailer-cellspacing: 0; text-align: center; } .body-sub { margin-top: 25px; padding-top: 25px; border-top: 1px solid #EDEFF2; } .content-cell { padding: 35px; } .preheader { display: none !important; visibility: hidden; mso-hide: all; font-size: 1px; line-height: 1px; max-height: 0; max-width: 0; opacity: 0; overflow: hidden; } /* Attribute list ------------------------------ */ .attributes { margin: 0 0 21px; } .attributes_content { background-color: #EDEFF2; padding: 16px; } .attributes_item { padding: 0; } /* Related Items ------------------------------ */ .related { width: 100%; margin: 0; padding: 25px 0 0 0; -premailer-width: 100%; -premailer-cellpadding: 0; -premailer-cellspacing: 0; } .related_item { padding: 10px 0; color: #74787E; font-size: 15px; line-height: 18px; } .related_item-title { display: block; margin: .5em 0 0; } .related_item-thumb { display: block; padding-bottom: 10px; } .related_heading { border-top: 1px solid #EDEFF2; text-align: center; padding: 25px 0 10px; } /* Discount Code ------------------------------ */ .discount { width: 100%; margin: 0; padding: 24px; -premailer-width: 100%; -premailer-cellpadding: 0; -premailer-cellspacing: 0; background-color: #EDEFF2; border: 2px dashed #9BA2AB; } .discount_heading { text-align: center; } .discount_body { text-align: center; font-size: 15px; } /* Social Icons ------------------------------ */ .social { width: auto; } .social td { padding: 0; width: auto; } .social_icon { height: 20px; margin: 0 8px 10px 8px; padding: 0; } /* Data table ------------------------------ */ .purchase { width: 100%; margin: 0; padding: 35px 0; -premailer-width: 100%; -premailer-cellpadding: 0; -premailer-cellspacing: 0; } .purchase_content { width: 100%; margin: 0; padding: 25px 0 0 0; -premailer-width: 100%; -premailer-cellpadding: 0; -premailer-cellspacing: 0; } .purchase_item { padding: 10px 0; color: #74787E; font-size: 15px; line-height: 18px; } .purchase_heading { padding-bottom: 8px; border-bottom: 1px solid #EDEFF2; } .purchase_heading p { margin: 0; color: #9BA2AB; font-size: 12px; } .purchase_footer { padding-top: 15px; border-top: 1px solid #EDEFF2; } .purchase_total { margin: 0; text-align: right; font-weight: bold; color: #2F3133; } .purchase_total--label { padding: 0 15px 0 0; } /* Utilities ------------------------------ */ .align-right { text-align: right; } .align-left { text-align: left; } .align-center { text-align: center; } /*Media Queries ------------------------------ */ @media only screen and (max-width: 600px) { .email-body_inner, .email-footer { width: 100% !important; } } @media only screen and (max-width: 500px) { .button { width: 100% !important; } } /* Buttons ------------------------------ */ .button { background-color: #3869D4; border-top: 10px solid #3869D4; border-right: 18px solid #3869D4; border-bottom: 10px solid #3869D4; border-left: 18px solid #3869D4; display: inline-block; color: #FFF; text-decoration: none; border-radius: 3px; box-shadow: 0 2px 3px rgba(0, 0, 0, 0.16); -webkit-text-size-adjust: none; } .button--green { background-color: #22BC66; border-top: 10px solid #22BC66; border-right: 18px solid #22BC66; border-bottom: 10px solid #22BC66; border-left: 18px solid #22BC66; } .button--pink{ background-color: #ff7f7a; border-top: 10px solid #ff7f7a; border-right: 18px solid #ff7f7a; border-bottom: 10px solid #ff7f7a; border-left: 18px solid #ff7f7a; } /* Type ------------------------------ */ h1 { margin-top: 0; color: #2F3133; font-size: 19px; font-weight: bold; text-align: left; } h2 { margin-top: 0; color: #2F3133; font-size: 16px; font-weight: bold; text-align: left; } h3 { margin-top: 0; color: #2F3133; font-size: 14px; font-weight: bold; text-align: left; } p { margin-top: 0; color: #74787E; font-size: 16px; line-height: 1.5em; text-align: left; } p.sub { font-size: 12px; } p.center { text-align: center; } </style> </head> <body> <div class="_rp_N4 ms-font-weight-regular ms-font-color-neutralDark rpHighlightAllClass rpHighlightBodyClass" id="Item.MessageUniqueBody" tabindex="0" style="font-family: wf_segoe-ui_normal, Segoe UI, Segoe WP, Tahoma, Arial, sans-serif, serif, EmojiFont;"> <div class="rps_b4f9"> <div> <div leftmargin="0" topmargin="0" marginwidth="0" marginheight="0" style="font-size: 10pt; font-family: MS Sans Serif, serif, EmojiFont;"> <table cellspacing="0" cellpadding="0" width="600" align="center" bgcolor="#ffffff" border="0"> <tbody> <tr> <td valign="middle" align="center" style="font-size:1px; font-family:Arial,Helvetica,sans-serif; color:#ffffff"> The delight of simple. </td> </tr> <tr> <td valign="top" align="left"> <table cellspacing="0" cellpadding="0" width="600" align="center" border="0" style="font- size:0px"> <tbody> <tr> <td bgcolor="#9a9a9a" valign="top" width="1" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="1" style="display:block"></td> <td valign="top" width="598" align="left"> <table cellspacing="0" cellpadding="0" width="598" border="0"> <tbody> <tr> <td bgcolor="#9a9a9a" valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="1" style="display:block"></td> </tr> <tr> <td valign="top" align="center"> <table cellspacing="0" cellpadding="0" width="598" border="0"> <tbody> <tr> <td> <table border="0" align="left" width="598" cellpadding="0" cellspacing="0"> <tbody> <tr height="80px"> <td bgcolor="#ecf0f1"> <div class="navbar-header"> <a class="navbar-brand" href="[COMPANYWEBURL]"><img style="width:auto;height:60px;" src="[COMPANYLOGOURL]" alt="logo"></a> </div> </td> </tr> <tr> <td bgcolor="#ffffff" valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="5" style="display:block"></td> </tr> </tbody> </table> </td> </tr> <tr> <td valign="top" align="left"> <table cellspacing="0" cellpadding="0" width="598" align="center" border="0"> <tbody> <tr> </tr> </tbody> </table> </td> </tr> <tr> <td valign="top" align="center"> <div style=" text-align: left; padding-left: 10px; padding-top: 20px;"> <font color="#000000" size="2" face="Microsoft Sans Serif" style="font-family: Microsoft Sans Serif, serif, EmojiFont;"> <div> <p>Dear {{FNAME}},</p> </div> <br> <div></div> <div> <p> You have requested a password reset, please follow the link below to reset your password. </p> <p> Please ignore this email if you did not request a password change. </p> <p style=" text-align: center; "> <a href="{{UNIQUESTR}}" class="button button--pink" target="_blank">Click To Reset Password</a> </p> </div> <div><br></div> <p>Our Customer Service team is always ready to assist you in case you are having trouble with your password. </p> <p> Customer Service Team <br> {{COMPANY}} </p> </font> </div><table border="0" align="center" width="565" cellpadding="0" cellspacing="0"> <tbody> <tr> <td valign="top" colspan="2" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="8" style="display:block"></td> </tr> <tr> <td valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="6" style="display:block"></td> </tr> <tr> <td valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="12" style="display:block"></td> </tr> <tr> <td valign="top" align="left" style="font-size:11px; font-family:Arial,Helvetica,sans-serif; color:#aeaeae"> <strong>CONNECT WITH {{COMPANY}}</strong> </td> </tr> <tr> <td valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="6" style="display:block"></td> </tr> <tr> <td bgcolor="#adaeae" valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="1" style="display:block"></td> </tr> <tr> <td valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="10" style="display:block"></td> </tr> <tr> <td valign="top" align="center"> <table cellspacing="0" cellpadding="0" width="273" border="0"> <tbody> <tr> <td valign="top"><a href="https://www.facebook.com/accuit" target="_blank" rel="noopener noreferrer" style="color:#1365c2"><img src="http://oica.org/wp- content/uploads/2016/01/social-facebook-box-blue-icon-430x512.png" title="Facebook" border="0" alt="Facebook" width="65" height="70" style="display:block;/* padding-left: 60px; */"></a></td> <td valign="top"><a href="https://plus.google.com/+Accuitechservesbetter/posts" target="_blank" rel="noopener noreferrer" style="color:#1365c2"><img src="http://accuitech.com/Content/images/googleplus.png" title="Facebook" border="0" alt="Facebook" width="67" height="67" style="display:block;padding-left: 40px;"></a></td> <td valign="top" width="128" align="left"><a href="https://twitter.com/accuitech" target="_blank" rel="noopener noreferrer" style="color:#1365c2"><img src="https://1.bp.blogspot.com/-kbviOAaq2ds/T-n4PulsfwI/AAAAAAAADpo/YvXmzmRloLw/s1600/twitter-twitter-icon.png" title="Facebook" border="0" alt="Facebook" width="65" height="60" style="display:block;padding-top: 5px;padding-left: 40px;"></a></td> <td valign="top" width="145" align="left"><a href="https://www.linkedin.com/company/accuit-technologies" target="_blank" rel="noopener noreferrer" style="color:#1365c2"><img src="https://bewelldogood.files.wordpress.com/2012/04/linkedin-logo-icon.png" title="Accuitech.com" border="0" alt="accuitech.com" width="65" height="60" style="display:block;padding-top: 5px;padding-left: 40px;"></a></td> </tr> </tbody> </table> </td> </tr> <tr> <td valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="10" style="display:block"></td> </tr> <tr> <td bgcolor="#adaeae" valign="top" align="left"> <img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="1" style="display:block"> </td> </tr> <tr> <td valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="6" style="display:block"></td> </tr> <tr> <td valign="top" align="left" style="font-size:10px; font-family:Arial,Helvetica,sans-serif; color:#939598"> This communication is to inform you about receiving your message successfully. This may be our first contact but this may lead us to achieve successful business bond. </td> </tr> <tr> <td valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="6" style="display:block"></td> </tr> <tr> <td valign="top" align="left" style="font-size:10px; font-family:Arial,Helvetica,sans-serif; color:#939598"> <div align="justify" style="font- family: Arial, Helvetica, sans-serif, serif, EmojiFont;"> This emailer is intended only for Accuit customers and does not tantamount to spamming. You are advised to contact AccuIT Technologies to clarify any questions you may have with regard to any information contained in this emailer. Accuit N.A. and/or any of their affiliates/associates have no liability whatsoever to any person on account of the use of information provided herein and the said information is provided on a best-effort basis. </div> </td> </tr> <tr> <td height="6" valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="6" style="display:block"></td> </tr> <tr> <td valign="top" align="left" style="font-size:10px; font-family:Arial,Helvetica,sans-serif; color:#939598"> <div align="justify" style="font- family: Arial, Helvetica, sans-serif, serif, EmojiFont;">Please do not reply to this mail as it is a computer generated mail. For further information, please follow the instructions mentioned above.</div> </td> </tr> <tr> <td valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="8" style="display:block"></td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </td> </tr> <tr> <td bgcolor="#9a9a9a" valign="top" align="left"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="1" style="display:block"></td> </tr> </tbody> </table> </td> <td bgcolor="#9a9a9a" valign="top" width="1" align="right"><img src="http://accuitech.com/Content/images/Emailer/spacer.gif" width="1" height="1" style="display:block"></td> </tr> </tbody> </table> </td> </tr> </tbody> </table> </div> </div> </div> </div> </body></html>
', N'Reset your {{COMPANY}} account password', NULL, NULL, N'Forget Password', 102)
INSERT [dbo].[EmailTemplate] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Name], [Type], [Status], [HtmlContent], [Subject], [Cost], [AuthorName], [About], [TemplateCode]) VALUES (3, 0, 20, CAST(N'2021-01-03T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Confirm Registration', 1, 1, N'<!DOCTYPE html>
<html>


<head>
    <title></title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta http-equiv="X-UA-Compatible" content="IE=edge" />
    <style type="text/css">
        @media screen {
            @font-face {
                font-family: ''Lato'';
                font-style: normal;
                font-weight: 400;
                src: local(''Lato Regular''), local(''Lato-Regular''), url(https://fonts.gstatic.com/s/lato/v11/qIIYRU-oROkIk8vfvxw6QvesZW2xOQ-xsNqO47m55DA.woff) format(''woff'');
            }

            @font-face {
                font-family: ''Lato'';
                font-style: normal;
                font-weight: 700;
                src: local(''Lato Bold''), local(''Lato-Bold''), url(https://fonts.gstatic.com/s/lato/v11/qdgUG4U09HnJwhYI-uK18wLUuEpTyoUstqEm5AMlJo4.woff) format(''woff'');
            }

            @font-face {
                font-family: ''Lato'';
                font-style: italic;
                font-weight: 400;
                src: local(''Lato Italic''), local(''Lato-Italic''), url(https://fonts.gstatic.com/s/lato/v11/RYyZNoeFgb0l7W3Vu1aSWOvvDin1pK8aKteLpeZ5c0A.woff) format(''woff'');
            }

            @font-face {
                font-family: ''Lato'';
                font-style: italic;
                font-weight: 700;
                src: local(''Lato Bold Italic''), local(''Lato-BoldItalic''), url(https://fonts.gstatic.com/s/lato/v11/HkF_qI1x_noxlxhrhMQYELO3LdcAZYWl9Si6vvxL-qU.woff) format(''woff'');
            }
        }

        /* CLIENT-SPECIFIC STYLES */
        body,
        table,
        td,
        a {
            -webkit-text-size-adjust: 100%;
            -ms-text-size-adjust: 100%;
        }

        table,
        td {
            mso-table-lspace: 0pt;
            mso-table-rspace: 0pt;
        }

        img {
            -ms-interpolation-mode: bicubic;
        }

        /* RESET STYLES */
        img {
            border: 0;
            height: auto;
            line-height: 100%;
            outline: none;
            text-decoration: none;
        }

        table {
            border-collapse: collapse !important;
        }

        body {
            height: 100% !important;
            margin: 0 !important;
            padding: 0 !important;
            width: 100% !important;
        }

        /* iOS BLUE LINKS */
        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
            font-size: inherit !important;
            font-family: inherit !important;
            font-weight: inherit !important;
            line-height: inherit !important;
        }

        /* MOBILE STYLES */
        @media screen and (max-width:600px) {
            h1 {
                font-size: 32px !important;
                line-height: 32px !important;
            }
        }

        /* ANDROID CENTER FIX */
        div[style*="margin: 16px 0;"] {
            margin: 0 !important;
        }
    </style>
</head>

<body style="background-color: #f4f4f4; margin: 0 !important; padding: 0 !important;">
    <!-- HIDDEN PREHEADER TEXT -->
    <div style="display: none; font-size: 1px; color: #fefefe; line-height: 1px; font-family: ''Lato'', Helvetica, Arial, sans-serif; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;"> We''re thrilled to have you here! Get ready to dive into your new account. </div>
    <table border="0" cellpadding="0" cellspacing="0" width="100%">
        <!-- LOGO -->
        <tr>
            <td bgcolor="#FFA73B" align="center">
                <table border="0" cellpadding="0" cellspacing="0" width="100%" style="max-width: 600px;">
                    <tr>
                        <td align="center" valign="top" style="padding: 40px 10px 40px 10px;"> </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor="#FFA73B" align="center" style="padding: 0px 10px 0px 10px;">
                <table border="0" cellpadding="0" cellspacing="0" width="100%" style="max-width: 600px;">
                    <tr>
                        <td bgcolor="#ffffff" align="center" valign="top" style="padding: 40px 20px 20px 20px; border-radius: 4px 4px 0px 0px; color: #111111; font-family: ''Lato'', Helvetica, Arial, sans-serif; font-size: 48px; font-weight: 400; letter-spacing: 4px; line-height: 48px;">
                            <h1 style="font-size: 48px; font-weight: 400; margin: 2;">Welcome!</h1> <img src=" https://img.icons8.com/clouds/100/000000/handshake.png" width="125" height="120" style="display: block; border: 0px;" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor="#f4f4f4" align="center" style="padding: 0px 10px 0px 10px;">
                <table border="0" cellpadding="0" cellspacing="0" width="100%" style="max-width: 600px;">
                    <tr>
                        <td bgcolor="#ffffff" align="left" style="padding: 20px 30px 40px 30px; color: #666666; font-family: ''Lato'', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;">
                            <p style="margin: 0;"> Dear {{FNAME}} {{LNAME}},</p>
                            <p style="margin: 0;"> We''re excited to have you get started. First, you need to confirm your account. Just click on the button below.</p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#ffffff" align="left">
                            <table width="100%" border="0" cellspacing="0" cellpadding="0">
                                <tr>
                                    <td bgcolor="#ffffff" align="center" style="padding: 20px 30px 60px 30px;">
                                        <table border="0" cellspacing="0" cellpadding="0">
                                            <tr>
                                                <td align="center" style="border-radius: 3px;" bgcolor="#FFA73B">
                                                <a href="{{URL}}" target="_blank" style="font-size: 20px; font-family: Helvetica, Arial, sans-serif; color: #ffffff; text-decoration: none; color: #ffffff; text-decoration: none; padding: 15px 25px; border-radius: 2px; border: 1px solid #FFA73B; display: inline-block;">Confirm Account</a></td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr> <!-- COPY -->
                    <tr>
                        <td bgcolor="#ffffff" align="left" style="padding: 0px 30px 0px 30px; color: #666666; font-family: ''Lato'', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;">
                            <p style="margin: 0;">If that doesn''t work, copy and paste the following link in your browser:</p>
                        </td>
                    </tr> <!-- COPY -->
                    <tr>
                        <td bgcolor="#ffffff" align="left" style="padding: 20px 30px 20px 30px; color: #666666; font-family: ''Lato'', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;">
                            <p style="margin: 0;"><a href="#" target="_blank" style="color: #FFA73B;">{{URL}}</a></p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#ffffff" align="left" style="padding: 0px 30px 20px 30px; color: #666666; font-family: ''Lato'', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;">
                            <p style="margin: 0;">If you have any questions, just reply to this email—we''re always happy to help out.</p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor="#ffffff" align="left" style="padding: 0px 30px 40px 30px; border-radius: 0px 0px 4px 4px; color: #666666; font-family: ''Lato'', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;">
                            <p style="margin: 0;">Cheers,<br>{{COMPANY}}</p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor="#f4f4f4" align="center" style="padding: 30px 10px 0px 10px;">
                <table border="0" cellpadding="0" cellspacing="0" width="100%" style="max-width: 600px;">
                    <tr>
                        <td bgcolor="#FFECD1" align="center" style="padding: 30px 30px 30px 30px; border-radius: 4px 4px 4px 4px; color: #666666; font-family: ''Lato'', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;">
                            <h2 style="font-size: 20px; font-weight: 400; color: #111111; margin: 0;">Need more help?</h2>
                            <p style="margin: 0;"><a href="#" target="_blank" style="color: #FFA73B;">We&rsquo;re here to help you out</a></p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor="#f4f4f4" align="center" style="padding: 0px 10px 0px 10px;">
                <table border="0" cellpadding="0" cellspacing="0" width="100%" style="max-width: 600px;">
                    <tr>
                        <td bgcolor="#f4f4f4" align="left" style="padding: 0px 30px 30px 30px; color: #666666; font-family: ''Lato'', Helvetica, Arial, sans-serif; font-size: 14px; font-weight: 400; line-height: 18px;"> <br>
                            <p style="margin: 0;">If these emails get annoying, please feel free to <a href="#" target="_blank" style="color: #111111; font-weight: 700;">unsubscribe</a>.</p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
    </table>
</body>

</html>', N'Thank you for being a part of {{COMPANY}} family. Please verify your registered email.', NULL, NULL, NULL, 101)
SET IDENTITY_INSERT [dbo].[EmailTemplate] OFF
GO
SET IDENTITY_INSERT [dbo].[OtpMaster] ON 

INSERT [dbo].[OtpMaster] ([Id], [UserId], [Otp], [Guid], [CreatedDate], [Attempts]) VALUES (1, 20, N'664864', N'b6bc5fcc-e90f-4bd5-9a4f-159a8d496dab', CAST(N'2021-01-05T00:16:25.9031585' AS DateTime2), 0)
SET IDENTITY_INSERT [dbo].[OtpMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[RoleMaster] ON 

INSERT [dbo].[RoleMaster] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Name], [Code], [Type], [Status], [IsAdmin], [RoleDescription]) VALUES (3, 0, 2, CAST(N'2021-01-02T21:26:35.0321107' AS DateTime2), NULL, NULL, N'Admin', N'100', 1, 1, 1, N'Admin Role added by Admin')
INSERT [dbo].[RoleMaster] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [Name], [Code], [Type], [Status], [IsAdmin], [RoleDescription]) VALUES (4, 0, 2, CAST(N'2021-01-02T21:35:18.6377247' AS DateTime2), 20, CAST(N'2021-01-02T22:47:47.2063563' AS DateTime2), N'Employee', N'102', 2, 1, 1, N'Employee Role added by Admin')
SET IDENTITY_INSERT [dbo].[RoleMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[TASK] ON 

INSERT [dbo].[TASK] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [TASKNAME], [TASKNAME_TID], [DESCRIPTION], [DESCRIPTION_TID]) VALUES (1, 0, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Change my Password', NULL, N'Change your own password for logging into WorkBenches.', NULL)
INSERT [dbo].[TASK] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [TASKNAME], [TASKNAME_TID], [DESCRIPTION], [DESCRIPTION_TID]) VALUES (2, 0, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Maintain Access Account', NULL, N'Create, update or delete access accounts.', NULL)
INSERT [dbo].[TASK] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [TASKNAME], [TASKNAME_TID], [DESCRIPTION], [DESCRIPTION_TID]) VALUES (3, 0, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Maintain User', NULL, N'Create, update or delete WorkBench users.', NULL)
INSERT [dbo].[TASK] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [TASKNAME], [TASKNAME_TID], [DESCRIPTION], [DESCRIPTION_TID]) VALUES (4, 0, 20, CAST(N'2020-10-10T00:00:00.0000000' AS DateTime2), NULL, NULL, N'Maintain Role', NULL, N'Create, update or delete User Roles.', NULL)
SET IDENTITY_INSERT [dbo].[TASK] OFF
GO
SET IDENTITY_INSERT [dbo].[UserMaster] ON 

INSERT [dbo].[UserMaster] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FirstName], [LastName], [UserName], [Password], [Image], [EmpCode], [Email], [AccountStatus], [IsActive], [SeniorEmpId], [IsEmployee], [Phone], [Mobile], [CompanyId], [UserType]) VALUES (20, 0, 20, CAST(N'2021-01-02T21:27:40.9706117' AS DateTime2), 20, CAST(N'2021-01-02T22:59:59.3437736' AS DateTime2), N'Neeraj', N'S', N'IADxwnwnBu', N'$8(~`5(~^$baButnIAyqDxSO', NULL, NULL, N'wrGxlga}mlGxGxroNDwvGx^$IAa}DxwnwnBu', 1, 1, NULL, 1, N'678989981', N'9989786752', 1, NULL)
INSERT [dbo].[UserMaster] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FirstName], [LastName], [UserName], [Password], [Image], [EmpCode], [Email], [AccountStatus], [IsActive], [SeniorEmpId], [IsEmployee], [Phone], [Mobile], [CompanyId], [UserType]) VALUES (21, 0, 0, CAST(N'2021-01-04T23:43:02.2908357' AS DateTime2), NULL, NULL, N'Neeraj', N'Singh', N'DxwnwnBua}tnokBuyqIA', N'$8(~`5(~^$baButnIAyqDxSO', NULL, NULL, N'wrGxlga}royqbawrQH^$DxwnwnBua}tnokBuyqIA', 1, 1, NULL, 1, N'678989981', N'9989786752', 1, NULL)
INSERT [dbo].[UserMaster] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FirstName], [LastName], [UserName], [Password], [Image], [EmpCode], [Email], [AccountStatus], [IsActive], [SeniorEmpId], [IsEmployee], [Phone], [Mobile], [CompanyId], [UserType]) VALUES (22, 1, 20, CAST(N'2021-01-09T01:12:17.5826049' AS DateTime2), NULL, NULL, N'Test', N'User', N'IADxwnwnBu', N'`5(~`5(~^$', NULL, NULL, N'wrGxlga}mlGxGxroNDwvGx^$IAa}DxwnwnBu', 1, 1, NULL, 1, N'678989981', N'9989786752', 1, NULL)
INSERT [dbo].[UserMaster] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [FirstName], [LastName], [UserName], [Password], [Image], [EmpCode], [Email], [AccountStatus], [IsActive], [SeniorEmpId], [IsEmployee], [Phone], [Mobile], [CompanyId], [UserType]) VALUES (23, 1, 20, CAST(N'2021-01-09T01:13:31.9080918' AS DateTime2), NULL, NULL, N'Test', N'User', N'IADxwnwnBu', N'`5(~`5(~^$', NULL, NULL, N'wrGxlga}mlGxGxroNDwvGx^$IAa}DxwnwnBu', 1, 1, NULL, 1, N'678989981', N'9989786752', 1, NULL)
SET IDENTITY_INSERT [dbo].[UserMaster] OFF
GO
SET IDENTITY_INSERT [dbo].[UserRoles] ON 

INSERT [dbo].[UserRoles] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [RoleId], [UserId], [IsActive]) VALUES (2, 0, 0, CAST(N'2021-01-02T21:27:41.0179626' AS DateTime2), NULL, NULL, 3, 20, 1)
INSERT [dbo].[UserRoles] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [RoleId], [UserId], [IsActive]) VALUES (3, 0, 0, CAST(N'2021-01-04T23:43:11.8548744' AS DateTime2), NULL, NULL, 3, 21, 1)
INSERT [dbo].[UserRoles] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [RoleId], [UserId], [IsActive]) VALUES (4, 0, 20, CAST(N'2021-01-09T01:12:17.7004687' AS DateTime2), NULL, NULL, 3, 22, 1)
INSERT [dbo].[UserRoles] ([Id], [IsDeleted], [CreatedBy], [CreatedDate], [ModifiedBy], [ModifiedDate], [RoleId], [UserId], [IsActive]) VALUES (5, 0, 20, CAST(N'2021-01-09T01:13:31.9166653' AS DateTime2), NULL, NULL, 3, 23, 1)
SET IDENTITY_INSERT [dbo].[UserRoles] OFF
GO
/****** Object:  Index [IX_AddressMaster_BuilderMasterId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_AddressMaster_BuilderMasterId] ON [dbo].[AddressMaster]
(
	[BuilderMasterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AddressMaster_CustomerId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_AddressMaster_CustomerId] ON [dbo].[AddressMaster]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_AddressMaster_UserId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_AddressMaster_UserId] ON [dbo].[AddressMaster]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Appointment_AppointmentId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_Appointment_AppointmentId] ON [dbo].[Appointment]
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Appointment_CustomerId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_Appointment_CustomerId] ON [dbo].[Appointment]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Appointment_UserId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_Appointment_UserId] ON [dbo].[Appointment]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_BuilderProperties_BuilderId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_BuilderProperties_BuilderId] ON [dbo].[BuilderProperties]
(
	[BuilderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_BuilderProperties_PropertyId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_BuilderProperties_PropertyId] ON [dbo].[BuilderProperties]
(
	[PropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Country_ADDRESSSTYLE]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_Country_ADDRESSSTYLE] ON [dbo].[Country]
(
	[ADDRESSSTYLE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Country_DEFAULTCURRENCY]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_Country_DEFAULTCURRENCY] ON [dbo].[Country]
(
	[DEFAULTCURRENCY] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Country_DEFAULTTAXCODE]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_Country_DEFAULTTAXCODE] ON [dbo].[Country]
(
	[DEFAULTTAXCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Country_NAMESTYLE]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_Country_NAMESTYLE] ON [dbo].[Country]
(
	[NAMESTYLE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Country_POSTCODESEARCHCODE]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_Country_POSTCODESEARCHCODE] ON [dbo].[Country]
(
	[POSTCODESEARCHCODE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_DailyLoginHistory_UserId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_DailyLoginHistory_UserId] ON [dbo].[DailyLoginHistory]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EmailMergeFields_EmailTemplateId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_EmailMergeFields_EmailTemplateId] ON [dbo].[EmailMergeFields]
(
	[EmailTemplateId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_LoginAttemptHistory_UserId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_LoginAttemptHistory_UserId] ON [dbo].[LoginAttemptHistory]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PropertyCertification_PropertyId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_PropertyCertification_PropertyId] ON [dbo].[PropertyCertification]
(
	[PropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PropertyFlat_AppointmentId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_PropertyFlat_AppointmentId] ON [dbo].[PropertyFlat]
(
	[AppointmentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PropertyFlat_FloorId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_PropertyFlat_FloorId] ON [dbo].[PropertyFlat]
(
	[FloorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PropertyImage_PropertyId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_PropertyImage_PropertyId] ON [dbo].[PropertyImage]
(
	[PropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PropertyMaster_PropertyId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_PropertyMaster_PropertyId] ON [dbo].[PropertyMaster]
(
	[PropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PropertyRoomDetail_FlatId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_PropertyRoomDetail_FlatId] ON [dbo].[PropertyRoomDetail]
(
	[FlatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PropertyTower_PropertyId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_PropertyTower_PropertyId] ON [dbo].[PropertyTower]
(
	[PropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_PropertyTowerFloor_TowerId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_PropertyTowerFloor_TowerId] ON [dbo].[PropertyTowerFloor]
(
	[TowerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RoleModule_ModuleMasterId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_RoleModule_ModuleMasterId] ON [dbo].[RoleModule]
(
	[ModuleMasterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RoleModule_RoleMasterId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_RoleModule_RoleMasterId] ON [dbo].[RoleModule]
(
	[RoleMasterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SalesInquiry_CustomerId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_SalesInquiry_CustomerId] ON [dbo].[SalesInquiry]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SalesInquiry_PropertyId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_SalesInquiry_PropertyId] ON [dbo].[SalesInquiry]
(
	[PropertyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SalesInquiry_UserId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_SalesInquiry_UserId] ON [dbo].[SalesInquiry]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_State_CountryId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_State_CountryId] ON [dbo].[State]
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_SystemSettings_CompanyId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_SystemSettings_CompanyId] ON [dbo].[SystemSettings]
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_TableCode_TABLETYPE]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_TableCode_TABLETYPE] ON [dbo].[TableCode]
(
	[TABLETYPE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UploadedDocument_CustomerId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_UploadedDocument_CustomerId] ON [dbo].[UploadedDocument]
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserMaster_CompanyId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_UserMaster_CompanyId] ON [dbo].[UserMaster]
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserRoleModulePermission_RoleModuleId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_UserRoleModulePermission_RoleModuleId] ON [dbo].[UserRoleModulePermission]
(
	[RoleModuleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserRoles_RoleId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_RoleId] ON [dbo].[UserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserRoles_UserId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_UserRoles_UserId] ON [dbo].[UserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserSettings_SettingId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_UserSettings_SettingId] ON [dbo].[UserSettings]
(
	[SettingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_UserSettings_UserId]    Script Date: 19/01/2021 15:47:02 ******/
CREATE NONCLUSTERED INDEX [IX_UserSettings_UserId] ON [dbo].[UserSettings]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Appointment] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Appointment] ADD  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((0)) FOR [AccountStatus]
GO
ALTER TABLE [dbo].[Customer] ADD  DEFAULT ((0)) FOR [ReferenceSource]
GO
ALTER TABLE [dbo].[Permissions] ADD  DEFAULT ((0)) FOR [CreatedBy]
GO
ALTER TABLE [dbo].[Permissions] ADD  DEFAULT ('0001-01-01T00:00:00.0000000') FOR [CreatedDate]
GO
ALTER TABLE [dbo].[Permissions] ADD  DEFAULT (CONVERT([tinyint],(0))) FOR [DENYPERMISSION]
GO
ALTER TABLE [dbo].[Permissions] ADD  DEFAULT (CONVERT([tinyint],(0))) FOR [GRANTPERMISSION]
GO
ALTER TABLE [dbo].[Permissions] ADD  DEFAULT (CONVERT([bit],(0))) FOR [IsDeleted]
GO
ALTER TABLE [dbo].[PropertyMaster] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[PropertyTower] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[SalesInquiry] ADD  DEFAULT ((2)) FOR [SaleStatus]
GO
ALTER TABLE [dbo].[UploadedDocument] ADD  DEFAULT (getdate()) FOR [CreatedDate]
GO
ALTER TABLE [dbo].[UploadedDocument] ADD  DEFAULT ((2)) FOR [DocumentType]
GO
ALTER TABLE [dbo].[UploadedDocument] ADD  DEFAULT ((1)) FOR [DocumentStatus]
GO
ALTER TABLE [dbo].[AddressMaster]  WITH CHECK ADD  CONSTRAINT [FK_AddressMaster_BuilderMaster_BuilderMasterId] FOREIGN KEY([BuilderMasterId])
REFERENCES [dbo].[BuilderMaster] ([Id])
GO
ALTER TABLE [dbo].[AddressMaster] CHECK CONSTRAINT [FK_AddressMaster_BuilderMaster_BuilderMasterId]
GO
ALTER TABLE [dbo].[AddressMaster]  WITH CHECK ADD  CONSTRAINT [FK_AddressMaster_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[AddressMaster] CHECK CONSTRAINT [FK_AddressMaster_Customer_CustomerId]
GO
ALTER TABLE [dbo].[AddressMaster]  WITH CHECK ADD  CONSTRAINT [FK_AddressMaster_UserMaster_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserMaster] ([Id])
GO
ALTER TABLE [dbo].[AddressMaster] CHECK CONSTRAINT [FK_AddressMaster_UserMaster_UserId]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_Customer_CustomerId]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_SalesInquiry_AppointmentId] FOREIGN KEY([AppointmentId])
REFERENCES [dbo].[SalesInquiry] ([Id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_SalesInquiry_AppointmentId]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Appointment_UserMaster_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserMaster] ([Id])
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Appointment_UserMaster_UserId]
GO
ALTER TABLE [dbo].[BuilderProperties]  WITH CHECK ADD  CONSTRAINT [FK_BuilderProperties_BuilderMaster_BuilderId] FOREIGN KEY([BuilderId])
REFERENCES [dbo].[BuilderMaster] ([Id])
GO
ALTER TABLE [dbo].[BuilderProperties] CHECK CONSTRAINT [FK_BuilderProperties_BuilderMaster_BuilderId]
GO
ALTER TABLE [dbo].[BuilderProperties]  WITH CHECK ADD  CONSTRAINT [FK_BuilderProperties_PropertyMaster_PropertyId] FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PropertyMaster] ([Id])
GO
ALTER TABLE [dbo].[BuilderProperties] CHECK CONSTRAINT [FK_BuilderProperties_PropertyMaster_PropertyId]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_Currency_DEFAULTCURRENCY] FOREIGN KEY([DEFAULTCURRENCY])
REFERENCES [dbo].[Currency] ([CURRENCY])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_Currency_DEFAULTCURRENCY]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_TableCode_ADDRESSSTYLE] FOREIGN KEY([ADDRESSSTYLE])
REFERENCES [dbo].[TableCode] ([TABLECODE])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_TableCode_ADDRESSSTYLE]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_TableCode_NAMESTYLE] FOREIGN KEY([NAMESTYLE])
REFERENCES [dbo].[TableCode] ([TABLECODE])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_TableCode_NAMESTYLE]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_TableCode_POSTCODESEARCHCODE] FOREIGN KEY([POSTCODESEARCHCODE])
REFERENCES [dbo].[TableCode] ([TABLECODE])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_TableCode_POSTCODESEARCHCODE]
GO
ALTER TABLE [dbo].[Country]  WITH CHECK ADD  CONSTRAINT [FK_Country_TaxRate_DEFAULTTAXCODE] FOREIGN KEY([DEFAULTTAXCODE])
REFERENCES [dbo].[TaxRate] ([TAXCODE])
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_TaxRate_DEFAULTTAXCODE]
GO
ALTER TABLE [dbo].[DailyLoginHistory]  WITH CHECK ADD  CONSTRAINT [FK_DailyLoginHistory_UserMaster_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserMaster] ([Id])
GO
ALTER TABLE [dbo].[DailyLoginHistory] CHECK CONSTRAINT [FK_DailyLoginHistory_UserMaster_UserId]
GO
ALTER TABLE [dbo].[EmailMergeFields]  WITH CHECK ADD  CONSTRAINT [FK_EmailMergeFields_EmailTemplate_EmailTemplateId] FOREIGN KEY([EmailTemplateId])
REFERENCES [dbo].[EmailTemplate] ([Id])
GO
ALTER TABLE [dbo].[EmailMergeFields] CHECK CONSTRAINT [FK_EmailMergeFields_EmailTemplate_EmailTemplateId]
GO
ALTER TABLE [dbo].[LoginAttemptHistory]  WITH CHECK ADD  CONSTRAINT [FK_LoginAttemptHistory_UserMaster_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserMaster] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[LoginAttemptHistory] CHECK CONSTRAINT [FK_LoginAttemptHistory_UserMaster_UserId]
GO
ALTER TABLE [dbo].[PropertyCertification]  WITH CHECK ADD  CONSTRAINT [FK_PropertyCertification_PropertyMaster_PropertyId] FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PropertyMaster] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PropertyCertification] CHECK CONSTRAINT [FK_PropertyCertification_PropertyMaster_PropertyId]
GO
ALTER TABLE [dbo].[PropertyFlat]  WITH CHECK ADD  CONSTRAINT [FK_PropertyFlat_PropertyTowerFloor_FloorId] FOREIGN KEY([FloorId])
REFERENCES [dbo].[PropertyTowerFloor] ([Id])
GO
ALTER TABLE [dbo].[PropertyFlat] CHECK CONSTRAINT [FK_PropertyFlat_PropertyTowerFloor_FloorId]
GO
ALTER TABLE [dbo].[PropertyFlat]  WITH CHECK ADD  CONSTRAINT [FK_PropertyFlat_SalesInquiry_AppointmentId] FOREIGN KEY([AppointmentId])
REFERENCES [dbo].[SalesInquiry] ([Id])
GO
ALTER TABLE [dbo].[PropertyFlat] CHECK CONSTRAINT [FK_PropertyFlat_SalesInquiry_AppointmentId]
GO
ALTER TABLE [dbo].[PropertyImage]  WITH CHECK ADD  CONSTRAINT [FK_PropertyImage_PropertyMaster_PropertyId] FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PropertyMaster] ([Id])
GO
ALTER TABLE [dbo].[PropertyImage] CHECK CONSTRAINT [FK_PropertyImage_PropertyMaster_PropertyId]
GO
ALTER TABLE [dbo].[PropertyMaster]  WITH CHECK ADD  CONSTRAINT [FK_PropertyMaster_PropertyType_PropertyId] FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PropertyType] ([PropertyTypeId])
GO
ALTER TABLE [dbo].[PropertyMaster] CHECK CONSTRAINT [FK_PropertyMaster_PropertyType_PropertyId]
GO
ALTER TABLE [dbo].[PropertyRoomDetail]  WITH CHECK ADD  CONSTRAINT [FK_PropertyRoomDetail_PropertyFlat_FlatId] FOREIGN KEY([FlatId])
REFERENCES [dbo].[PropertyFlat] ([Id])
GO
ALTER TABLE [dbo].[PropertyRoomDetail] CHECK CONSTRAINT [FK_PropertyRoomDetail_PropertyFlat_FlatId]
GO
ALTER TABLE [dbo].[PropertyTower]  WITH CHECK ADD  CONSTRAINT [FK_PropertyTower_PropertyMaster_PropertyId] FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PropertyMaster] ([Id])
GO
ALTER TABLE [dbo].[PropertyTower] CHECK CONSTRAINT [FK_PropertyTower_PropertyMaster_PropertyId]
GO
ALTER TABLE [dbo].[PropertyTowerFloor]  WITH CHECK ADD  CONSTRAINT [FK_PropertyTowerFloor_PropertyTower_TowerId] FOREIGN KEY([TowerId])
REFERENCES [dbo].[PropertyTower] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PropertyTowerFloor] CHECK CONSTRAINT [FK_PropertyTowerFloor_PropertyTower_TowerId]
GO
ALTER TABLE [dbo].[RoleModule]  WITH CHECK ADD  CONSTRAINT [FK_RoleModule_ModuleMaster_ModuleMasterId] FOREIGN KEY([ModuleMasterId])
REFERENCES [dbo].[ModuleMaster] ([Id])
GO
ALTER TABLE [dbo].[RoleModule] CHECK CONSTRAINT [FK_RoleModule_ModuleMaster_ModuleMasterId]
GO
ALTER TABLE [dbo].[RoleModule]  WITH CHECK ADD  CONSTRAINT [FK_RoleModule_RoleMaster_RoleMasterId] FOREIGN KEY([RoleMasterId])
REFERENCES [dbo].[RoleMaster] ([Id])
GO
ALTER TABLE [dbo].[RoleModule] CHECK CONSTRAINT [FK_RoleModule_RoleMaster_RoleMasterId]
GO
ALTER TABLE [dbo].[SalesInquiry]  WITH CHECK ADD  CONSTRAINT [FK_SalesInquiry_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[SalesInquiry] CHECK CONSTRAINT [FK_SalesInquiry_Customer_CustomerId]
GO
ALTER TABLE [dbo].[SalesInquiry]  WITH CHECK ADD  CONSTRAINT [FK_SalesInquiry_PropertyMaster_PropertyId] FOREIGN KEY([PropertyId])
REFERENCES [dbo].[PropertyMaster] ([Id])
GO
ALTER TABLE [dbo].[SalesInquiry] CHECK CONSTRAINT [FK_SalesInquiry_PropertyMaster_PropertyId]
GO
ALTER TABLE [dbo].[SalesInquiry]  WITH CHECK ADD  CONSTRAINT [FK_SalesInquiry_UserMaster_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserMaster] ([Id])
GO
ALTER TABLE [dbo].[SalesInquiry] CHECK CONSTRAINT [FK_SalesInquiry_UserMaster_UserId]
GO
ALTER TABLE [dbo].[State]  WITH CHECK ADD  CONSTRAINT [FK_State_Country_CountryId] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([COUNTRYCODE])
GO
ALTER TABLE [dbo].[State] CHECK CONSTRAINT [FK_State_Country_CountryId]
GO
ALTER TABLE [dbo].[SystemSettings]  WITH CHECK ADD  CONSTRAINT [FK_SystemSettings_CompanyMaster_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[CompanyMaster] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SystemSettings] CHECK CONSTRAINT [FK_SystemSettings_CompanyMaster_CompanyId]
GO
ALTER TABLE [dbo].[TableCode]  WITH CHECK ADD  CONSTRAINT [FK_TableCode_TableType_TABLETYPE] FOREIGN KEY([TABLETYPE])
REFERENCES [dbo].[TableType] ([TABLETYPE])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[TableCode] CHECK CONSTRAINT [FK_TableCode_TableType_TABLETYPE]
GO
ALTER TABLE [dbo].[UploadedDocument]  WITH CHECK ADD  CONSTRAINT [FK_UploadedDocument_Customer_CustomerId] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[UploadedDocument] CHECK CONSTRAINT [FK_UploadedDocument_Customer_CustomerId]
GO
ALTER TABLE [dbo].[UserMaster]  WITH CHECK ADD  CONSTRAINT [FK_UserMaster_CompanyMaster_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[CompanyMaster] ([Id])
GO
ALTER TABLE [dbo].[UserMaster] CHECK CONSTRAINT [FK_UserMaster_CompanyMaster_CompanyId]
GO
ALTER TABLE [dbo].[UserRoleModulePermission]  WITH CHECK ADD  CONSTRAINT [FK_UserRoleModulePermission_RoleModule_RoleModuleId] FOREIGN KEY([RoleModuleId])
REFERENCES [dbo].[RoleModule] ([Id])
GO
ALTER TABLE [dbo].[UserRoleModulePermission] CHECK CONSTRAINT [FK_UserRoleModulePermission_RoleModule_RoleModuleId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_RoleMaster_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[RoleMaster] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_RoleMaster_RoleId]
GO
ALTER TABLE [dbo].[UserRoles]  WITH CHECK ADD  CONSTRAINT [FK_UserRoles_UserMaster_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserMaster] ([Id])
GO
ALTER TABLE [dbo].[UserRoles] CHECK CONSTRAINT [FK_UserRoles_UserMaster_UserId]
GO
ALTER TABLE [dbo].[UserSettings]  WITH CHECK ADD  CONSTRAINT [FK_UserSettings_SettingDefinition_SettingId] FOREIGN KEY([SettingId])
REFERENCES [dbo].[SettingDefinition] ([Id])
GO
ALTER TABLE [dbo].[UserSettings] CHECK CONSTRAINT [FK_UserSettings_SettingDefinition_SettingId]
GO
ALTER TABLE [dbo].[UserSettings]  WITH CHECK ADD  CONSTRAINT [FK_UserSettings_UserMaster_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserMaster] ([Id])
GO
ALTER TABLE [dbo].[UserSettings] CHECK CONSTRAINT [FK_UserSettings_UserMaster_UserId]
GO
USE [master]
GO
ALTER DATABASE [AdminDb] SET  READ_WRITE 
GO
