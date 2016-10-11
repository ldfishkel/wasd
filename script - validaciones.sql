USE [GD2C2016]
GO

/****** Object:  Schema [WASD]    Script Date: 06/10/2016 20:02:28 ******/
CREATE SCHEMA [WASD]
GO
/****** Object:  Table [WASD].[Afiliado]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Afiliado]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Afiliado](
	[afiliado_id] [int] NOT NULL,
	[afiliado_numero] [int] NOT NULL,
	[afiliado_nombre] [varchar](50) NOT NULL,
	[afiliado_apellido] [varchar](50) NOT NULL,
	[afiliado_numero_documento] [int] NOT NULL,
	[afiliado_tipo_documento] [int] NOT NULL,
	[afiliado_direccion] [varchar](100) NOT NULL,
	[afiliado_telefono] [int] NOT NULL,
	[afiliado_mail] [varchar](50) NOT NULL,
	[afiliado_fecha_nacimiento] [date] NOT NULL,
	[afiliado_sexo] [int] NOT NULL,
	[afiliado_estado_civil] [int] NOT NULL,
	[afiliado_familiares_dependientes] [tinyint] NOT NULL,
	[afiliado_plan] [int] NOT NULL,
	[afiliado_fecha_alta] [date] NOT NULL,
	[afiliado_fecha_baja] [date] NULL,
	[afiliado_activo] [bit] NOT NULL,
	[afiliado_usuario] [int] NOT NULL,
	[afiliado_grupo_familiar] [int] NULL,
 CONSTRAINT [PK_Afiliado] PRIMARY KEY CLUSTERED 
(
	[afiliado_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Agenda]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Agenda]') 
		AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Bono]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Bono]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Bono](
	[bono_id] [int] NOT NULL,
	[plan_id] [int] NOT NULL,
	[afiliado_id] [int] NOT NULL,
	[bono_numero_consulta] [int] NULL,
	[bono_afiliado_usado] [int] NULL,
	[bono_fecha_uso] [date] NULL,
	[compra_id] [int] NOT NULL,
 CONSTRAINT [PK_Bono] PRIMARY KEY CLUSTERED 
(
	[bono_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [WASD].[Compra]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Compra]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Compra](
	[compra_id] [int] NOT NULL,
	[afiliado_id] [int] NOT NULL,
	[compra_fecha_hora] [datetime] NOT NULL,
	[compra_cantidad] [smallint] NOT NULL,
	[compra_monto] [money] NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[compra_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [WASD].[Diagnóstico]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Diagnostico]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Diagnostico](
	[turno_id] [int] NOT NULL,
	[diagnostico_descripcion] [varchar](200) NOT NULL,
	[diagnostico_sintomas] [varchar](200) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Especialidad]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Especialidad]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Especialidad](
	[especialidad_id] [int] NOT NULL,
	[especialidad_nombre] [varchar](50) NOT NULL,
	[especialidad_tipo] [int] NOT NULL,
 CONSTRAINT [PK_Especialidad] PRIMARY KEY CLUSTERED 
(
	[especialidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[EspecialidadesPorProfesional]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[EspecialidadesPorProfesional]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[EspecialidadesPorProfesional](
	[profesional_id] [int] NOT NULL,
	[especialidad_id] [int] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [WASD].[EstadoCivil]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[EstadoCivil]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[EstadoCivil](
	[estadocivil_id] [int] NOT NULL,
	[estadocivil_nombre] [char](12) NOT NULL,
 CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED 
(
	[estadocivil_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Funcionalidad]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Funcionalidad]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Funcionalidad](
	[funcionalidad_id] [int] NOT NULL,
	[funcionalidad_nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Funcionalidad] PRIMARY KEY CLUSTERED 
(
	[funcionalidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[FuncionalidadPorRol]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[FuncionalidadPorRol]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[FuncionalidadPorRol](
	[rol_id] [int] NOT NULL,
	[funcionalidad_id] [int] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [WASD].[HistorialPlan]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[HistorialPlan]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[HistorialPlan](
	[afiliado_id] [int] NOT NULL,
	[historial_fecha_cambio] [date] NOT NULL,
	[historial_motivo] [varchar](144) NOT NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Plan]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Plan]') 
		AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Profesional]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Profesional]') 
		AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Rol]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Rol]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Rol](
	[rol_id] [int] NOT NULL,
	[rol_nombre] [varchar](50) NOT NULL,
	[rol_activo] [bit] NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[rol_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[RolPorUsuario]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[RolPorUsuario]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[RolPorUsuario](
	[usuario_id] [int] NOT NULL,
	[rol_id] [int] NOT NULL
) ON [PRIMARY]
END
GO
/****** Object:  Table [WASD].[Sexo]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Sexo]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Sexo](
	[sexo_id] [int] NOT NULL,
	[sexo_nombre] [char](10) NOT NULL,
 CONSTRAINT [PK_Sexo] PRIMARY KEY CLUSTERED 
(
	[sexo_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[TipoDocumento]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[TipoDocumento]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[TipoDocumento](
	[tipodocumento_id] [int] NOT NULL,
	[tipodocumento_nombre] [char](15) NOT NULL,
 CONSTRAINT [PK_TipoDocumento] PRIMARY KEY CLUSTERED 
(
	[tipodocumento_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[TipoEspecialidad]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[TipoEspecialidad]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[TipoEspecialidad](
	[tipoespecialidad_id] [int] NOT NULL,
	[tipoespecialidad_nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TipoEspecialidad] PRIMARY KEY CLUSTERED 
(
	[tipoespecialidad_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Turno]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Turno]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Turno](
	[turno_id] [int] NOT NULL,
	[afiliado_id] [int] NOT NULL,
	[profesional_id] [int] NOT NULL,
	[bono_id] [int] NULL,
	[turno_fecha_hora] [datetime] NULL,
	[turno_cancelado] [char](1) NULL,
	[especialidad_id] [int] NOT NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[turno_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [WASD].[Usuario]    Script Date: 06/10/2016 20:02:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects 
		WHERE object_id = OBJECT_ID(N'[WASD].[Usuario]') 
		AND type in (N'U'))
BEGIN
CREATE TABLE [WASD].[Usuario](
	[usuario_id] [int] NOT NULL,
	[usuario_nombre] [varchar](50) NOT NULL,
	[usuario_password] [varchar](50) NOT NULL,
	[usuario_intentos] [tinyint] NOT NULL,
	[usuario_activo] [bit] NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[usuario_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Afiliado_Afiliado]'))
ALTER TABLE [WASD].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Afiliado] FOREIGN KEY([afiliado_grupo_familiar])
REFERENCES [WASD].[Afiliado] ([afiliado_id])
GO
ALTER TABLE [WASD].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Afiliado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Afiliado_EstadoCivil]'))
ALTER TABLE [WASD].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_EstadoCivil] FOREIGN KEY([afiliado_estado_civil])
REFERENCES [WASD].[EstadoCivil] ([estadocivil_id])
GO
ALTER TABLE [WASD].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_EstadoCivil]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Afiliado_Plan]'))
ALTER TABLE [WASD].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Plan] FOREIGN KEY([afiliado_plan])
REFERENCES [WASD].[Plan] ([plan_id])
GO
ALTER TABLE [WASD].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Plan]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Afiliado_Sexo]'))
ALTER TABLE [WASD].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Sexo] FOREIGN KEY([afiliado_sexo])
REFERENCES [WASD].[Sexo] ([sexo_id])
GO
ALTER TABLE [WASD].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Sexo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Afiliado_TipoDocumento]'))
ALTER TABLE [WASD].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_TipoDocumento] FOREIGN KEY([afiliado_tipo_documento])
REFERENCES [WASD].[TipoDocumento] ([tipodocumento_id])
GO
ALTER TABLE [WASD].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_TipoDocumento]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Afiliado_Usuario]'))
ALTER TABLE [WASD].[Afiliado]  WITH CHECK ADD  CONSTRAINT [FK_Afiliado_Usuario] FOREIGN KEY([afiliado_usuario])
REFERENCES [WASD].[Usuario] ([usuario_id])
GO
ALTER TABLE [WASD].[Afiliado] CHECK CONSTRAINT [FK_Afiliado_Usuario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Agenda_Especialidad]'))
ALTER TABLE [WASD].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Especialidad] FOREIGN KEY([especialidad_id])
REFERENCES [WASD].[Especialidad] ([especialidad_id])
GO
ALTER TABLE [WASD].[Agenda] CHECK CONSTRAINT [FK_Agenda_Especialidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Agenda_Profesional]'))
ALTER TABLE [WASD].[Agenda]  WITH CHECK ADD  CONSTRAINT [FK_Agenda_Profesional] FOREIGN KEY([profesional_id])
REFERENCES [WASD].[Profesional] ([profesional_id])
GO
ALTER TABLE [WASD].[Agenda] CHECK CONSTRAINT [FK_Agenda_Profesional]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Bono_Afiliado]'))
ALTER TABLE [WASD].[Bono]  WITH CHECK ADD  CONSTRAINT [FK_Bono_Afiliado] FOREIGN KEY([afiliado_id])
REFERENCES [WASD].[Afiliado] ([afiliado_id])
GO
ALTER TABLE [WASD].[Bono] CHECK CONSTRAINT [FK_Bono_Afiliado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Bono_Compra]'))
ALTER TABLE [WASD].[Bono]  WITH CHECK ADD  CONSTRAINT [FK_Bono_Compra] FOREIGN KEY([compra_id])
REFERENCES [WASD].[Compra] ([compra_id])
GO
ALTER TABLE [WASD].[Bono] CHECK CONSTRAINT [FK_Bono_Compra]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Bono_Plan]'))
ALTER TABLE [WASD].[Bono]  WITH CHECK ADD  CONSTRAINT [FK_Bono_Plan] FOREIGN KEY([plan_id])
REFERENCES [WASD].[Plan] ([plan_id])
GO
ALTER TABLE [WASD].[Bono] CHECK CONSTRAINT [FK_Bono_Plan]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Compra_Afiliado]'))
ALTER TABLE [WASD].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Afiliado] FOREIGN KEY([afiliado_id])
REFERENCES [WASD].[Afiliado] ([afiliado_id])
GO
ALTER TABLE [WASD].[Compra] CHECK CONSTRAINT [FK_Compra_Afiliado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Diagnostico_Turno]'))
ALTER TABLE [WASD].[Diagnostico]  WITH CHECK ADD  CONSTRAINT [FK_Diagnostico_Turno] FOREIGN KEY([turno_id])
REFERENCES [WASD].[Turno] ([turno_id])
GO
ALTER TABLE [WASD].[Diagnostico] CHECK CONSTRAINT [FK_Diagnostico_Turno]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Especialidad_TipoEspecialidad]'))
ALTER TABLE [WASD].[Especialidad]  WITH CHECK ADD  CONSTRAINT [FK_Especialidad_TipoEspecialidad] FOREIGN KEY([especialidad_tipo])
REFERENCES [WASD].[TipoEspecialidad] ([tipoespecialidad_id])
GO
ALTER TABLE [WASD].[Especialidad] CHECK CONSTRAINT [FK_Especialidad_TipoEspecialidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_EspecialidadesPorProfesional_Especialidad]'))
ALTER TABLE [WASD].[EspecialidadesPorProfesional]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadesPorProfesional_Especialidad] FOREIGN KEY([especialidad_id])
REFERENCES [WASD].[Especialidad] ([especialidad_id])
GO
ALTER TABLE [WASD].[EspecialidadesPorProfesional] CHECK CONSTRAINT [FK_EspecialidadesPorProfesional_Especialidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_EspecialidadesPorProfesional_Profesional]'))
ALTER TABLE [WASD].[EspecialidadesPorProfesional]  WITH CHECK ADD  CONSTRAINT [FK_EspecialidadesPorProfesional_Profesional] FOREIGN KEY([profesional_id])
REFERENCES [WASD].[Profesional] ([profesional_id])
GO
ALTER TABLE [WASD].[EspecialidadesPorProfesional] CHECK CONSTRAINT [FK_EspecialidadesPorProfesional_Profesional]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_FuncionalidadPorRol_Funcionalidad]'))
ALTER TABLE [WASD].[FuncionalidadPorRol]  WITH CHECK ADD  CONSTRAINT [FK_FuncionalidadPorRol_Funcionalidad] FOREIGN KEY([funcionalidad_id])
REFERENCES [WASD].[Funcionalidad] ([funcionalidad_id])
GO
ALTER TABLE [WASD].[FuncionalidadPorRol] CHECK CONSTRAINT [FK_FuncionalidadPorRol_Funcionalidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_FuncionalidadPorRol_Rol]'))
ALTER TABLE [WASD].[FuncionalidadPorRol]  WITH CHECK ADD  CONSTRAINT [FK_FuncionalidadPorRol_Rol] FOREIGN KEY([rol_id])
REFERENCES [WASD].[Rol] ([rol_id])
GO
ALTER TABLE [WASD].[FuncionalidadPorRol] CHECK CONSTRAINT [FK_FuncionalidadPorRol_Rol]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_HistorialPlan_Afiliado]'))
ALTER TABLE [WASD].[HistorialPlan]  WITH CHECK ADD  CONSTRAINT [FK_HistorialPlan_Afiliado] FOREIGN KEY([afiliado_id])
REFERENCES [WASD].[Afiliado] ([afiliado_id])
GO
ALTER TABLE [WASD].[HistorialPlan] CHECK CONSTRAINT [FK_HistorialPlan_Afiliado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Profesional_Sexo]'))
ALTER TABLE [WASD].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_Sexo] FOREIGN KEY([profesional_sexo])
REFERENCES [WASD].[Sexo] ([sexo_id])
GO
ALTER TABLE [WASD].[Profesional] CHECK CONSTRAINT [FK_Profesional_Sexo]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Profesional_TipoDocumento]'))
ALTER TABLE [WASD].[Profesional]  WITH CHECK ADD  CONSTRAINT [FK_Profesional_TipoDocumento] FOREIGN KEY([profesional_tipo_documento])
REFERENCES [WASD].[TipoDocumento] ([tipodocumento_id])
GO
ALTER TABLE [WASD].[Profesional] CHECK CONSTRAINT [FK_Profesional_TipoDocumento]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_RolPorUsuario_Rol]'))
ALTER TABLE [WASD].[RolPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_RolPorUsuario_Rol] FOREIGN KEY([rol_id])
REFERENCES [WASD].[Rol] ([rol_id])
GO
ALTER TABLE [WASD].[RolPorUsuario] CHECK CONSTRAINT [FK_RolPorUsuario_Rol]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_RolPorUsuario_Usuario]'))
ALTER TABLE [WASD].[RolPorUsuario]  WITH CHECK ADD  CONSTRAINT [FK_RolPorUsuario_Usuario] FOREIGN KEY([usuario_id])
REFERENCES [WASD].[Usuario] ([usuario_id])
GO
ALTER TABLE [WASD].[RolPorUsuario] CHECK CONSTRAINT [FK_RolPorUsuario_Usuario]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Turno_Afiliado]'))
ALTER TABLE [WASD].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Afiliado] FOREIGN KEY([afiliado_id])
REFERENCES [WASD].[Afiliado] ([afiliado_id])
GO
ALTER TABLE [WASD].[Turno] CHECK CONSTRAINT [FK_Turno_Afiliado]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Turno_Bono]'))
ALTER TABLE [WASD].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Bono] FOREIGN KEY([bono_id])
REFERENCES [WASD].[Bono] ([bono_id])
GO
ALTER TABLE [WASD].[Turno] CHECK CONSTRAINT [FK_Turno_Bono]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Turno_Especialidad]'))
ALTER TABLE [WASD].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Especialidad] FOREIGN KEY([especialidad_id])
REFERENCES [WASD].[Especialidad] ([especialidad_id])
GO
ALTER TABLE [WASD].[Turno] CHECK CONSTRAINT [FK_Turno_Especialidad]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[WASD].[FK_Turno_Profesional]'))
ALTER TABLE [WASD].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Profesional] FOREIGN KEY([profesional_id])
REFERENCES [WASD].[Profesional] ([profesional_id])
GO
ALTER TABLE [WASD].[Turno] CHECK CONSTRAINT [FK_Turno_Profesional]
GO

INSERT INTO [GD2C2016].[WASD].[Usuario]([usuario_id],[usuario_nombre],[usuario_password],[usuario_intentos],[usuario_activo])VALUES(1,'asd','asd',0,1);
           
INSERT INTO [GD2C2016].[WASD].[Rol]([rol_id],[rol_nombre],[rol_activo])VALUES(1,'Administador',1);
INSERT INTO [GD2C2016].[WASD].[Rol]([rol_id],[rol_nombre],[rol_activo])VALUES(2,'Afiliado',1);
INSERT INTO [GD2C2016].[WASD].[Rol]([rol_id],[rol_nombre],[rol_activo])VALUES(3,'Profesional',1);


INSERT INTO [GD2C2016].[WASD].[Funcionalidad]([funcionalidad_id],[funcionalidad_nombre])VALUES(1,'ABM Roles');
INSERT INTO [GD2C2016].[WASD].[Funcionalidad]([funcionalidad_id],[funcionalidad_nombre])VALUES(2,'ABM Afiliados');
INSERT INTO [GD2C2016].[WASD].[Funcionalidad]([funcionalidad_id],[funcionalidad_nombre])VALUES(3,'Registrar Agenda');
INSERT INTO [GD2C2016].[WASD].[Funcionalidad]([funcionalidad_id],[funcionalidad_nombre])VALUES(4,'Comprar Bonos');
INSERT INTO [GD2C2016].[WASD].[Funcionalidad]([funcionalidad_id],[funcionalidad_nombre])VALUES(5,'Pedir Turno');
INSERT INTO [GD2C2016].[WASD].[Funcionalidad]([funcionalidad_id],[funcionalidad_nombre])VALUES(6,'Cancelar Turno');
INSERT INTO [GD2C2016].[WASD].[Funcionalidad]([funcionalidad_id],[funcionalidad_nombre])VALUES(7,'Registrar Llegada');
INSERT INTO [GD2C2016].[WASD].[Funcionalidad]([funcionalidad_id],[funcionalidad_nombre])VALUES(8,'Diagnosticar');
INSERT INTO [GD2C2016].[WASD].[Funcionalidad]([funcionalidad_id],[funcionalidad_nombre])VALUES(9,'Ver Estadisticas');

INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(1,1);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(1,2);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(3,3);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(1,4);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(2,4);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(1,5);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(2,5);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(2,6);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(3,6);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(1,7);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(3,8);
INSERT INTO [GD2C2016].[WASD].[FuncionalidadPorRol]([rol_id],[funcionalidad_id])VALUES(1,9);

INSERT INTO [GD2C2016].[WASD].[RolPorUsuario]([usuario_id],[rol_id])VALUES(1,1);
INSERT INTO [GD2C2016].[WASD].[RolPorUsuario]([usuario_id],[rol_id])VALUES(1,2);
INSERT INTO [GD2C2016].[WASD].[RolPorUsuario]([usuario_id],[rol_id])VALUES(1,3);
GO
