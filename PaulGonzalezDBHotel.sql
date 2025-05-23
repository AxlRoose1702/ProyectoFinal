USE [master]
GO
/****** Object:  Database [db_hotel]    Script Date: 6/05/2025 05:52:05 ******/
CREATE DATABASE [db_hotel]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_hotel', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_hotel.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_hotel_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_hotel_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_hotel] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_hotel].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_hotel] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_hotel] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_hotel] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_hotel] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_hotel] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_hotel] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [db_hotel] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_hotel] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_hotel] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_hotel] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_hotel] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_hotel] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_hotel] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_hotel] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_hotel] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_hotel] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_hotel] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_hotel] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_hotel] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_hotel] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_hotel] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_hotel] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_hotel] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_hotel] SET  MULTI_USER 
GO
ALTER DATABASE [db_hotel] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_hotel] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_hotel] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_hotel] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_hotel] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_hotel] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_hotel] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_hotel] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_hotel]
GO
/****** Object:  Table [dbo].[tbl_Asignaciones]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Asignaciones](
	[CodigoAsignacion] [int] IDENTITY(1,1) NOT NULL,
	[CodigoEmpleado] [int] NULL,
	[CodigoHabitacion] [int] NULL,
	[TipoAsignacion] [varchar](50) NULL,
	[FechaAsignacion] [datetime] NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoAsignacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Consumos]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Consumos](
	[CodigoConsumo] [int] IDENTITY(1,1) NOT NULL,
	[CodigoReserva] [int] NULL,
	[CodigoServicio] [int] NULL,
	[Monto] [decimal](10, 2) NULL,
	[FechaConsumo] [datetime] NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoConsumo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Empleados]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Empleados](
	[CodigoEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Cargo] [varchar](50) NULL,
	[Salario] [decimal](10, 2) NULL,
	[FechaContratacion] [datetime] NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Habitaciones]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Habitaciones](
	[CodigoHabitacion] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [varchar](10) NULL,
	[Ubicacion] [varchar](100) NULL,
	[Tipo] [varchar](50) NULL,
	[Precio] [decimal](10, 2) NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoHabitacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Huespedes]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Huespedes](
	[CodigoHuesped] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Nit] [varchar](20) NULL,
	[Telefono] [varchar](15) NULL,
	[Tipo] [varchar](50) NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoHuesped] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PagoPlanillas]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PagoPlanillas](
	[CodigoPagoPlanilla] [int] IDENTITY(1,1) NOT NULL,
	[CodigoEmpleado] [int] NULL,
	[FechaPago] [datetime] NULL,
	[Salario] [decimal](10, 2) NULL,
	[Bono] [decimal](10, 2) NULL,
	[HorasExtra] [int] NULL,
	[MontoTotal] [decimal](10, 2) NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoPagoPlanilla] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Pagos]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Pagos](
	[CodigoPago] [int] IDENTITY(1,1) NOT NULL,
	[CodigoReserva] [int] NULL,
	[Monto] [decimal](10, 2) NULL,
	[Propina] [decimal](10, 2) NULL,
	[Impuesto] [decimal](10, 2) NULL,
	[Descuento] [decimal](10, 2) NULL,
	[TotalPago] [decimal](10, 2) NULL,
	[FechaPago] [datetime] NULL,
	[MetodoPago] [varchar](50) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Reservaciones]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Reservaciones](
	[CodigoReserva] [int] IDENTITY(1,1) NOT NULL,
	[CodigoHuesped] [int] NULL,
	[CodigoHabitacion] [int] NULL,
	[FechaEntrada] [datetime] NULL,
	[FechaSalida] [datetime] NULL,
	[Total] [decimal](10, 2) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Servicios]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Servicios](
	[CodigoServicio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Tipo] [varchar](50) NULL,
	[Precio] [decimal](10, 2) NULL,
	[FechaVigencia] [datetime] NULL,
	[FechaVencimiento] [datetime] NULL,
	[Estado] [varchar](20) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Usuarios]    Script Date: 6/05/2025 05:52:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Usuarios](
	[CodigoUsuario] [int] IDENTITY(1,1) NOT NULL,
	[CodigoEmpleado] [int] NULL,
	[NombreUsuario] [varchar](50) NULL,
	[Contrasenia] [varchar](50) NULL,
	[Rol] [varchar](50) NULL,
	[Estado] [varchar](50) NULL,
	[UsuarioSistema] [varchar](50) NULL,
	[FechaSistema] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CodigoUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_Asignaciones]  WITH CHECK ADD FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[tbl_Asignaciones]  WITH CHECK ADD FOREIGN KEY([CodigoHabitacion])
REFERENCES [dbo].[tbl_Habitaciones] ([CodigoHabitacion])
GO
ALTER TABLE [dbo].[tbl_Consumos]  WITH CHECK ADD FOREIGN KEY([CodigoReserva])
REFERENCES [dbo].[tbl_Reservaciones] ([CodigoReserva])
GO
ALTER TABLE [dbo].[tbl_Consumos]  WITH CHECK ADD FOREIGN KEY([CodigoServicio])
REFERENCES [dbo].[tbl_Servicios] ([CodigoServicio])
GO
ALTER TABLE [dbo].[tbl_PagoPlanillas]  WITH CHECK ADD FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
GO
ALTER TABLE [dbo].[tbl_Pagos]  WITH CHECK ADD FOREIGN KEY([CodigoReserva])
REFERENCES [dbo].[tbl_Reservaciones] ([CodigoReserva])
GO
ALTER TABLE [dbo].[tbl_Reservaciones]  WITH CHECK ADD FOREIGN KEY([CodigoHuesped])
REFERENCES [dbo].[tbl_Huespedes] ([CodigoHuesped])
GO
ALTER TABLE [dbo].[tbl_Reservaciones]  WITH CHECK ADD FOREIGN KEY([CodigoHabitacion])
REFERENCES [dbo].[tbl_Habitaciones] ([CodigoHabitacion])
GO
ALTER TABLE [dbo].[tbl_Usuarios]  WITH CHECK ADD FOREIGN KEY([CodigoEmpleado])
REFERENCES [dbo].[tbl_Empleados] ([CodigoEmpleado])
GO
USE [master]
GO
ALTER DATABASE [db_hotel] SET  READ_WRITE 
GO
