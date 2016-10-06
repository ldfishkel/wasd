USE [master]
GO
/****** Object:  Database [GD2C2016]    Script Date: 06/10/2016 19:08:24 ******/
CREATE DATABASE [GD2C2016]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GD2C2016', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2012\MSSQL\DATA\GD2C2016.mdf' , SIZE = 147456KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GD2C2016_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2012\MSSQL\DATA\GD2C2016_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GD2C2016] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GD2C2016].[WASD].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GD2C2016] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GD2C2016] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GD2C2016] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GD2C2016] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GD2C2016] SET ARITHABORT OFF 
GO
ALTER DATABASE [GD2C2016] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GD2C2016] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GD2C2016] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GD2C2016] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GD2C2016] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GD2C2016] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GD2C2016] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GD2C2016] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GD2C2016] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GD2C2016] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GD2C2016] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GD2C2016] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GD2C2016] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GD2C2016] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GD2C2016] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GD2C2016] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GD2C2016] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GD2C2016] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GD2C2016] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GD2C2016] SET  MULTI_USER 
GO
ALTER DATABASE [GD2C2016] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GD2C2016] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GD2C2016] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GD2C2016] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [GD2C2016]
GO
/****** Object:  User [gd]    Script Date: 06/10/2016 19:08:24 ******/
CREATE USER [gd] FOR LOGIN [gd] WITH DEFAULT_SCHEMA=[WASD]
GO
/****** Object:  Schema [gd_esquema]    Script Date: 06/10/2016 19:08:24 ******/
CREATE SCHEMA [gd_esquema]
GO
/****** Object:  Table [WASD].[Agenda]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[Agenda](
	[agenda_id] [int] NOT NULL,
	[profesional_id] [int] NOT NULL,
	[agenda_dia] [char](10) NULL,
	[agenda_hora_desde] [time](7) NOT NULL,
	[agenda_hora_hasta] [time](7) NOT NULL,
	[agenda_fecha_desde] [date] NOT NULL,
	[agenda_fecha_hasta] [date] NOT NULL,
	[especialidad_id] [int] NOT NULL,
 CONSTRAINT [PK_Agenda] PRIMARY KEY CLUSTERED 
(
	[agenda_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Especialidad]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[Especialidad](
	[especialidad_id] [int] NOT NULL,
	[especialidad_nombre] [varchar](50) NOT NULL,
	[especialidad_tipo] [int] NOT NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[especialidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[EspecialidadesPorProfesional]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [WASD].[EspecialidadesPorProfesional](
	[profesional_id] [int] NOT NULL,
	[especialidad_id] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [WASD].[EstadoCivil]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[EstadoCivil](
	[estadocivil_id] [int] NOT NULL,
	[estadocivil_nombre] [char](12) NOT NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[estadocivil_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Funcionalidad]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[Funcionalidad](
	[funcionalidad_id] [int] NOT NULL,
	[funcionalidad_nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Funcionalidad] PRIMARY KEY CLUSTERED 
(
	[funcionalidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[FuncionalidadPorRol]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [WASD].[FuncionalidadPorRol](
	[rol_id] [int] NOT NULL,
	[funcionalidad_id] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [WASD].[Plan]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[Plan](
	[plan_id] [int] NOT NULL,
	[plan_nombre] [char](10) NOT NULL,
	[plan_cuota] [smallmoney] NOT NULL,
	[plan_precio_bono] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Plan] PRIMARY KEY CLUSTERED 
(
	[plan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Profesional]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[Profesional](
	[profesional_id] [int] NOT NULL,
	[profesional_nombre] [varchar](50) NOT NULL,
	[profesional_apellido] [varchar](50) NOT NULL,
	[profesional_direccion] [varchar](100) NOT NULL,
	[profesional_telefono] [int] NOT NULL,
	[profesional_mail] [varchar](50) NOT NULL,
	[profesional_fecha_nacimiento] [date] NOT NULL,
	[profesional_sexo] [int] NOT NULL,
	[profesional_matricula] [int] NOT NULL,
	[profesional_tipo_documento] [int] NOT NULL,
	[profesional_numero_documento] [int] NOT NULL,
 CONSTRAINT [PK_Profesional] PRIMARY KEY CLUSTERED 
(
	[profesional_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Rol]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[Rol](
	[rol_id] [int] NOT NULL,
	[rol_nombre] [varchar](50) NOT NULL,
	[rol_activo] [bit] NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[RolPorUsuario]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [WASD].[RolPorUsuario](
	[usuario_id] [int] NOT NULL,
	[rol_id] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [WASD].[Sexo]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[Sexo](
	[sexo_id] [int] NOT NULL,
	[sexo_nombre] [char](10) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[sexo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[TipoDocumento]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[TipoDocumento](
	[tipodocumento_id] [int] NOT NULL,
	[tipodocumento_nombre] [char](15) NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[tipodocumento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[TipoEspecialidad]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[TipoEspecialidad](
	[tipoespecialidad_id] [int] NOT NULL,
	[tipoespecialidad_nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoEspecialidad] PRIMARY KEY CLUSTERED 
(
	[tipoespecialidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Usuario]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [WASD].[Usuario](
	[usuario_id] [int] NOT NULL,
	[usuario_nombre] [varchar](50) NOT NULL,
	[usuario_apellido] [varchar](50) NOT NULL,
	[usuario_dni] [int] NOT NULL,
	[usuario_password] [varchar](50) NOT NULL,
	[usuario_intentos] [tinyint] NOT NULL,
	[usuario_activo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [gd_esquema].[Maestra]    Script Date: 06/10/2016 19:08:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [gd_esquema].[Maestra](
	[Paciente_Nombre] [varchar](255) NULL,
	[Paciente_Apellido] [varchar](255) NULL,
	[Paciente_Dni] [numeric](18, 0) NULL,
	[Paciente_Direccion] [varchar](255) NULL,
	[Paciente_Telefono] [numeric](18, 0) NULL,
	[Paciente_Mail] [varchar](255) NULL,
	[Paciente_Fecha_Nac] [datetime] NULL,
	[Plan_Med_Codigo] [numeric](18, 0) NULL,
	[Plan_Med_Descripcion] [varchar](255) NULL,
	[Plan_Med_Precio_Bono_Consulta] [numeric](18, 0) NULL,
	[Plan_Med_Precio_Bono_Farmacia] [numeric](18, 0) NULL,
	[Turno_Numero] [numeric](18, 0) NULL,
	[Turno_Fecha] [datetime] NULL,
	[Consulta_Sintomas] [varchar](255) NULL,
	[Consulta_Enfermedades] [varchar](255) NULL,
	[Medico_Nombre] [varchar](255) NULL,
	[Medico_Apellido] [varchar](255) NULL,
	[Medico_Dni] [numeric](18, 0) NULL,
	[Medico_Direccion] [varchar](255) NULL,
	[Medico_Telefono] [numeric](18, 0) NULL,
	[Medico_Mail] [varchar](255) NULL,
	[Medico_Fecha_Nac] [datetime] NULL,
	[Especialidad_Codigo] [numeric](18, 0) NULL,
	[Especialidad_Descripcion] [varchar](255) NULL,
	[Tipo_Especialidad_Codigo] [numeric](18, 0) NULL,
	[Tipo_Especialidad_Descripcion] [varchar](255) NULL,
	[Compra_Bono_Fecha] [datetime] NULL,
	[Bono_Consulta_Fecha_Impresion] [datetime] NULL,
	[Bono_Consulta_Numero] [numeric](18, 0) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [WASD].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Especialidad] FOREIGN KEY([especialidad_id])
REFERENCES [WASD].[Especialidad] ([especialidad_id])
GO
ALTER TABLE [WASD].[Agenda] CHECK CONSTRAINT [FK_Agenda_Especialidad]
GO
ALTER TABLE [WASD].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Profesional] FOREIGN KEY([profesional_id])
REFERENCES [WASD].[Profesional] ([profesional_id])
GO
ALTER TABLE [WASD].[Agenda] CHECK CONSTRAINT [FK_Agenda_Profesional]
GO
ALTER TABLE [WASD].[Especialidad]  WITH CHECK ADD  CONSTRAINT [FK_Especialidad_TipoEspecialidad] FOREIGN KEY([especialidad_tipo])
REFERENCES [WASD].[TipoEspecialidad] ([tipoespecialidad_id])
GO
ALTER TABLE [WASD].[Especialidad] CHECK CONSTRAINT [FK_Especialidad_TipoEspecialidad]
GO
ALTER TABLE [WASD].[EspecialidadesPorProfesional]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadesPorProfesional_Especialidad] FOREIGN KEY([especialidad_id])
REFERENCES [WASD].[Especialidad] ([especialidad_id])
GO
ALTER TABLE [WASD].[EspecialidadesPorProfesional] CHECK CONSTRAINT [FK_EspecialidadesPorProfesional_Especialidad]
GO
ALTER TABLE [WASD].[EspecialidadesPorProfesional]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadesPorProfesional_Profesional] FOREIGN KEY([profesional_id])
REFERENCES [WASD].[Profesional] ([profesional_id])
GO
ALTER TABLE [WASD].[EspecialidadesPorProfesional] CHECK CONSTRAINT [FK_EspecialidadesPorProfesional_Profesional]
GO
ALTER TABLE [WASD].[FuncionalidadPorRol]  WITH CHECK ADD  CONSTRAINT [FK_FuncionalidadPorRol_Funcionalidad] FOREIGN KEY([funcionalidad_id])
REFERENCES [WASD].[Funcionalidad] ([funcionalidad_id])
GO
ALTER TABLE [WASD].[FuncionalidadPorRol] CHECK CONSTRAINT [FK_FuncionalidadPorRol_Funcionalidad]
GO
ALTER TABLE [WASD].[FuncionalidadPorRol]  WITH CHECK ADD  CONSTRAINT [FK_FuncionalidadPorRol_Rol] FOREIGN KEY([rol_id])
REFERENCES [WASD].[Rol] ([rol_id])
GO
ALTER TABLE [WASD].[FuncionalidadPorRol] CHECK CONSTRAINT [FK_FuncionalidadPorRol_Rol]
GO
ALTER TABLE [WASD].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_Sexo] FOREIGN KEY([profesional_sexo])
REFERENCES [WASD].[Sexo] ([sexo_id])
GO
ALTER TABLE [WASD].[Profesional] CHECK CONSTRAINT [FK_Profesional_Sexo]
GO
ALTER TABLE [WASD].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_TipoDocumento] FOREIGN KEY([profesional_tipo_documento])
REFERENCES [WASD].[TipoDocumento] ([tipodocumento_id])
GO
ALTER TABLE [WASD].[Profesional] CHECK CONSTRAINT [FK_Profesional_TipoDocumento]
GO
ALTER TABLE [WASD].[RolPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_RolPorUsuario_Rol] FOREIGN KEY([rol_id])
REFERENCES [WASD].[Rol] ([rol_id])
GO
ALTER TABLE [WASD].[RolPorUsuario] CHECK CONSTRAINT [FK_RolPorUsuario_Rol]
GO
ALTER TABLE [WASD].[RolPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_RolPorUsuario_Usuario] FOREIGN KEY([usuario_id])
REFERENCES [WASD].[Usuario] ([usuario_id])
GO
ALTER TABLE [WASD].[RolPorUsuario] CHECK CONSTRAINT [FK_RolPorUsuario_Usuario]
GO
USE [master]
GO
ALTER DATABASE [GD2C2016] SET  READ_WRITE 
GO
