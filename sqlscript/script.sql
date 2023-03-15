USE [master]
GO
/****** Object:  Database [Quanlicudan]    Script Date: 3/15/2023 5:43:16 PM ******/
CREATE DATABASE [Quanlicudan]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quanlicudan', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Quanlicudan.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quanlicudan_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Quanlicudan_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Quanlicudan] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quanlicudan].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quanlicudan] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quanlicudan] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quanlicudan] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quanlicudan] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quanlicudan] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quanlicudan] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quanlicudan] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quanlicudan] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quanlicudan] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quanlicudan] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quanlicudan] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quanlicudan] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quanlicudan] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quanlicudan] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quanlicudan] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quanlicudan] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quanlicudan] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quanlicudan] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quanlicudan] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quanlicudan] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quanlicudan] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quanlicudan] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quanlicudan] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quanlicudan] SET  MULTI_USER 
GO
ALTER DATABASE [Quanlicudan] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quanlicudan] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quanlicudan] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quanlicudan] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quanlicudan] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quanlicudan] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Quanlicudan] SET QUERY_STORE = OFF
GO
USE [Quanlicudan]
GO
/****** Object:  Table [dbo].[Chuho]    Script Date: 3/15/2023 5:43:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Chuho](
	[MaHK] [char](4) NOT NULL,
	[TenCH] [nchar](100) NULL,
	[sothanhvien] [int] NULL,
	[SDT] [nchar](10) NULL,
	[diachi] [nchar](100) NULL,
	[namsinhCH] [char](4) NULL,
	[Gioitinh] [nchar](10) NULL,
	[CCCD] [nchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Diaban]    Script Date: 3/15/2023 5:43:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Diaban](
	[Madiaban] [char](10) NULL,
	[idQuanli] [char](10) NULL,
	[Tendiaban] [nchar](50) NULL,
	[TongDanSo] [int] NULL,
	[SoHogiadinh] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TTTV]    Script Date: 3/15/2023 5:43:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TTTV](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ten] [nchar](10) NULL,
	[namsinh] [char](10) NULL,
	[CCCD] [nchar](10) NULL,
	[DCthuongtru] [nchar](100) NULL,
	[DCtamtru] [nchar](100) NULL,
	[Ngayden] [date] NULL,
	[Ngaydi] [date] NULL,
	[Lido] [ntext] NULL,
	[State] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/15/2023 5:43:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [char](10) NULL,
	[Username] [nchar](50) NULL,
	[Password] [nchar](20) NULL,
	[Ten] [nchar](100) NULL,
	[Namsinh] [char](10) NULL,
	[Gioitinh] [nchar](10) NULL,
	[Madiaban] [char](10) NULL,
	[Roles] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1100', N'Lê Thị Thuỷ                                                                                         ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nữ        ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1110', N'Le Van A                                                                                            ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nam       ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1111', N'eeeeee                                                                                              ', 3, N'0444444444', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nữ        ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1113', N'Lê Thuy                                                                                             ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nữ        ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1114', N'Lê Văn Nam                                                                                          ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1977', N'Nam       ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1115', N'eida                                                                                                ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nữ        ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1116', N'Lê Thị Hoa                                                                                          ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nữ        ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1117', N'Lê Thị Thuỷ                                                                                         ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nữ        ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1118', N'Lê Thuỷ                                                                                             ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nữ        ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1119', N'Lê Thị Thuỷ                                                                                         ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nữ        ', N'261111423 ')
INSERT [dbo].[Chuho] ([MaHK], [TenCH], [sothanhvien], [SDT], [diachi], [namsinhCH], [Gioitinh], [CCCD]) VALUES (N'1132', N'Lê Thị Thuỷ                                                                                         ', 3, N'0356874458', N'1A Tân Phong Biên Hoà Đồng Nai                                                                      ', N'1970', N'Nữ        ', N'261111423 ')
GO
SET IDENTITY_INSERT [dbo].[TTTV] ON 

INSERT [dbo].[TTTV] ([Id], [Ten], [namsinh], [CCCD], [DCthuongtru], [DCtamtru], [Ngayden], [Ngaydi], [Lido], [State]) VALUES (1, N'Le Tuan   ', N'2000      ', N'261837645 ', N'Ham My                                                                                              ', N'HCM                                                                                                 ', CAST(N'2022-03-04' AS Date), CAST(N'2022-02-20' AS Date), N'asfsfdsfdsg', 0)
SET IDENTITY_INSERT [dbo].[TTTV] OFF
GO
INSERT [dbo].[Users] ([Id], [Username], [Password], [Ten], [Namsinh], [Gioitinh], [Madiaban], [Roles]) VALUES (N'0001      ', N'user01                                            ', N'123456              ', N'Tr?n Qu?c Hùng                                                                                      ', N'1977      ', N'Nam       ', N'DB01      ', 1)
INSERT [dbo].[Users] ([Id], [Username], [Password], [Ten], [Namsinh], [Gioitinh], [Madiaban], [Roles]) VALUES (N'0002      ', N'user02                                            ', N'123456              ', N'Đinh Thị Hà                                                                                         ', N'1974      ', N'Nữ        ', N'DB02      ', 1)
INSERT [dbo].[Users] ([Id], [Username], [Password], [Ten], [Namsinh], [Gioitinh], [Madiaban], [Roles]) VALUES (N'0003      ', N'tuanle                                            ', N'123456              ', N'Lê Hoàng Tu?n                                                                                       ', N'2000      ', N'Nam       ', N'DB02      ', 2)
INSERT [dbo].[Users] ([Id], [Username], [Password], [Ten], [Namsinh], [Gioitinh], [Madiaban], [Roles]) VALUES (N'0004      ', N'huuthanh                                          ', N'123456              ', N'Nguyen Huu Thanh                                                                                    ', N'2000      ', N'Nam       ', N'DB01      ', 2)
GO
ALTER TABLE [dbo].[TTTV] ADD  DEFAULT ((0)) FOR [State]
GO
/****** Object:  StoredProcedure [dbo].[USP_UpdateUser]    Script Date: 3/15/2023 5:43:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_UpdateUser]
@username nchar(100), @fullname nchar(100), @password nchar(50), @newpassword nchar(50)
AS
BEGIN
	DECLARE @isRightpass int =0
	select @isRightpass = Count(*) from dbo.Users where Username=@username and Password = @password
	IF(@isRightpass = 1)
	BEGIN
		IF(@newpassword = NULL OR @newpassword = '')
		BEGIN
			UPDATE dbo.Users set Ten = @fullname where Username = @username
		END
		ELSE
			UPDATE dbo.Users set Ten= @fullname , Password=@newpassword where Username=@username
	END
END
GO
USE [master]
GO
ALTER DATABASE [Quanlicudan] SET  READ_WRITE 
GO
