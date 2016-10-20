/**SCRIPT DE CREACION INICIAL**/
/**GRUPO NUMERO 52 WASD**/
/**GESTION DE DATOS SEGUNDO CUATRIMESTRE 2016**/

USE [GD2C2016];
GO

SET LANGUAGE Spanish

/**CREAR SCHEMA**/
IF NOT EXISTS
(
  SELECT  schema_name
  FROM    information_schema.schemata
  WHERE   schema_name = 'WASD'
)

BEGIN
  EXEC sp_executesql N'CREATE SCHEMA "WASD" AUTHORIZATION gd'
END

/**BORRAR TABLAS**/
IF OBJECT_ID('WASD.Agenda', 'U') IS NOT NULL
  DROP TABLE "WASD".Agenda
GO

IF OBJECT_ID('WASD.EspecialidadPorProfesional', 'U') IS NOT NULL
  DROP TABLE "WASD".EspecialidadPorProfesional
GO

IF OBJECT_ID('WASD.FuncionalidadPorRol', 'U') IS NOT NULL
  DROP TABLE "WASD".FuncionalidadPorRol
GO

IF OBJECT_ID('WASD.Funcionalidad', 'U') IS NOT NULL
  DROP TABLE "WASD".Funcionalidad
GO

IF OBJECT_ID('WASD.HistorialPlan', 'U') IS NOT NULL
  DROP TABLE "WASD".HistorialPlan
GO

IF OBJECT_ID('WASD.Turno', 'U') IS NOT NULL
  DROP TABLE "WASD".Turno
GO

IF OBJECT_ID('WASD.Bono', 'U') IS NOT NULL
  DROP TABLE "WASD".Bono
GO

IF OBJECT_ID('WASD.Compra', 'U') IS NOT NULL
  DROP TABLE "WASD".Compra
GO

IF OBJECT_ID('WASD.Afiliado', 'U') IS NOT NULL
  DROP TABLE "WASD".Afiliado
GO

IF OBJECT_ID('WASD.PlanMedico', 'U') IS NOT NULL
  DROP TABLE "WASD".PlanMedico
GO

IF OBJECT_ID('WASD.RolPorUsuario', 'U') IS NOT NULL
  DROP TABLE "WASD".RolPorUsuario
GO

IF OBJECT_ID('WASD.Rol', 'U') IS NOT NULL
  DROP TABLE "WASD".Rol
GO

IF OBJECT_ID('WASD.Especialidad', 'U') IS NOT NULL
  DROP TABLE "WASD".Especialidad
GO

IF OBJECT_ID('WASD.TipoEspecialidad', 'U') IS NOT NULL
  DROP TABLE "WASD".TipoEspecialidad
GO

IF OBJECT_ID('WASD.EstadoCivil', 'U') IS NOT NULL
  DROP TABLE "WASD".EstadoCivil
GO

IF OBJECT_ID('WASD.Profesional', 'U') IS NOT NULL
  DROP TABLE "WASD".Profesional
GO

IF OBJECT_ID('WASD.Sexo', 'U') IS NOT NULL
  DROP TABLE "WASD".Sexo
GO

IF OBJECT_ID('WASD.TipoDocumento', 'U') IS NOT NULL
  DROP TABLE "WASD".TipoDocumento
GO

IF OBJECT_ID('WASD.Usuario', 'U') IS NOT NULL
  DROP TABLE "WASD".Usuario
GO

/**CREAR TABLAS**/

CREATE TABLE "WASD".Usuario (
	usuario_id INT PRIMARY KEY IDENTITY(1,1),
	usuario_nombre CHAR(10) NOT NULL,
	usuario_password CHAR(64) NOT NULL,
	usuario_intentos TINYINT NOT NULL,
	usuario_activo BIT NOT NULL
);

CREATE TABLE "WASD".EstadoCivil (
	estadocivil_id INT PRIMARY KEY IDENTITY(1,1),
	estadocivil_nombre CHAR(12) NOT NULL
);

CREATE TABLE "WASD".TipoDocumento (
	tipodocumento_id INT PRIMARY KEY IDENTITY(1,1),
	tipodocumento_nombre CHAR(3)
);

CREATE TABLE "WASD".PlanMedico (
	planmedico_id INT PRIMARY KEY IDENTITY(1,1),
	planmedico_nombre CHAR(15) NOT NULL,
	planmedico_cuota MONEY NOT NULL,
	planmedico_precio_bono MONEY NOT NULL
);

CREATE TABLE "WASD".Sexo (
	sexo_id INT PRIMARY KEY IDENTITY(1,1),
	sexo_nombre CHAR(10) NOT NULL
);

CREATE TABLE "WASD".Afiliado (
	afiliado_id INT PRIMARY KEY IDENTITY(1,1),
	usuario_id INT NOT NULL REFERENCES "WASD".Usuario(usuario_id),
	estadocivil_id INT NOT NULL REFERENCES "WASD".EstadoCivil(estadocivil_id),
	tipodocumento_id INT NOT NULL REFERENCES "WASD".TipoDocumento(tipodocumento_id),
	planmedico_id INT NOT NULL REFERENCES "WASD".PlanMedico(planmedico_id),
	sexo_id INT NOT NULL REFERENCES "WASD".Sexo(sexo_id),
	afiliado_numero INT NOT NULL,
	afiliado_nombre VARCHAR(50) NOT NULL,
	afiliado_apellido VARCHAR(50) NOT NULL,
	afiliado_numero_documento INT NOT NULL,
	afiliado_direccion VARCHAR(100) NOT NULL,
	afiliado_telefono INT NOT NULL,
	afiliado_mail VARCHAR(50) NOT NULL,
	afiliado_fecha_nacimiento DATE NOT NULL,
	afiliado_familiares_dependientes TINYINT NOT NULL,
	afiliado_activo BIT NOT NULL,
	afiliado_grupo_familiar INT REFERENCES "WASD".Afiliado(afiliado_id)
);

CREATE TABLE "WASD".TipoEspecialidad (
	tipoespecialidad_id INT PRIMARY KEY IDENTITY(1,1),
	tipoespecialidad_nombre VARCHAR(50) NOT NULL
);

CREATE TABLE "WASD".Especialidad (
	especialidad_id INT PRIMARY KEY IDENTITY(1,1),
	tipoespecialidad_id INT NOT NULL REFERENCES "WASD".TipoEspecialidad(tipoespecialidad_id),
	especialidad_nombre VARCHAR(50) NOT NULL
);

CREATE TABLE "WASD".Profesional (
	profesional_id INT PRIMARY KEY IDENTITY(1,1),
	usuario_id INT NOT NULL REFERENCES "WASD".Usuario(usuario_id),
	sexo_id INT NOT NULL REFERENCES "WASD".Sexo(sexo_id),
	tipodocumento_id INT NOT NULL REFERENCES "WASD".TipoDocumento(tipodocumento_id),
	profesional_numero_documento INT NOT NULL,
	profesional_nombre VARCHAR(25) NOT NULL,
	profesional_apellido VARCHAR(25) NOT NULL,
	profesional_direccion VARCHAR(100) NOT NULL,
	profesional_telefono INT NOT NULL,
	profesional_mail VARCHAR(50) NOT NULL,
	profesional_fecha_nacimiento DATE NOT NULL,
	profesional_matricula INT NOT NULL
);

CREATE TABLE "WASD".Agenda (
	agenda_id INT PRIMARY KEY IDENTITY(1,1),
	profesional_id INT NOT NULL REFERENCES "WASD".Profesional(profesional_id),
	especialidad_id INT NOT NULL REFERENCES "WASD".Especialidad(especialidad_id),
	agenda_dia CHAR(9) CHECK (agenda_dia IN ('LUNES', 'MARTES', 'MIERCOLES', 'JUEVES', 'VIERNES', 'SABADO')),
	agenda_hora_desde TIME NOT NULL,
	agenda_hora_hasta TIME NOT NULL,
	agenda_fecha_desde DATE NOT NULL,
	agenda_fecha_hasta DATE NOT NULL
);

CREATE TABLE "WASD".Compra (
	compra_id INT PRIMARY KEY  IDENTITY(1,1),
	afiliado_id INT NOT NULL REFERENCES "WASD".Afiliado(afiliado_id),
	compra_fecha_hora DATETIME NOT NULL,
	compra_cantidad SMALLINT NOT NULL,
	compra_monto MONEY NOT NULL
);

CREATE TABLE "WASD".Bono (
	bono_id INT PRIMARY KEY IDENTITY(1,1),
	planmedico_id INT NOT NULL REFERENCES "WASD".PlanMedico(planmedico_id),
	afiliado_id INT NOT NULL REFERENCES "WASD".Afiliado(afiliado_id),
	compra_id INT NOT NULL REFERENCES "WASD".Compra(compra_id),
	bono_numero_consulta SMALLINT,
	bono_afiliado_usado INT REFERENCES "WASD".Afiliado(afiliado_id),
	bono_fecha_uso DATE
);

CREATE TABLE "WASD".EspecialidadPorProfesional (
	profesional_id INT NOT NULL REFERENCES "WASD".Profesional(profesional_id),
	especialidad_id INT NOT NULL REFERENCES "WASD".Especialidad(especialidad_id),
	PRIMARY KEY (profesional_id, especialidad_id)
);

CREATE TABLE "WASD".Funcionalidad (
	funcionalidad_id INT PRIMARY KEY IDENTITY(1,1),
	funcionalidad_nombre VARCHAR(25) NOT NULL
);

CREATE TABLE "WASD".Rol (
	rol_id INT PRIMARY KEY IDENTITY(1,1),
	rol_nombre CHAR(15) NOT NULL,
	rol_activo BIT NOT NULL
);

CREATE TABLE "WASD".FuncionalidadPorRol (
	rol_id INT NOT NULL REFERENCES "WASD".Rol(rol_id),
	funcionalidad_id INT NOT NULL REFERENCES "WASD".Funcionalidad(funcionalidad_id),
	PRIMARY KEY (funcionalidad_id, rol_id)
);

CREATE TABLE "WASD".HistorialPlan (
	afiliado_id INT NOT NULL REFERENCES "WASD".Afiliado(afiliado_id),
	historial_fecha DATE NOT NULL,
	historial_motivo VARCHAR(144) NOT NULL,
	PRIMARY KEY (afiliado_id)
);

CREATE TABLE "WASD".RolPorUsuario (
	usuario_id INT NOT NULL REFERENCES "WASD".Usuario(usuario_id),
	rol_id INT NOT NULL REFERENCES "WASD".Rol(rol_id),
	PRIMARY KEY (usuario_id, rol_id)
);

CREATE TABLE "WASD".Turno (
	turno_id INT PRIMARY KEY IDENTITY(1,1),
	afiliado_id INT NOT NULL REFERENCES "WASD".Afiliado(afiliado_id),
	profesional_id INT NOT NULL REFERENCES "WASD".Profesional(profesional_id),
	bono_id INT REFERENCES "WASD".Bono(bono_id),
	especialidad_id INT NOT NULL REFERENCES "WASD".Especialidad(especialidad_id),
	turno_fecha_hora DATETIME NOT NULL,
	turno_cancelado CHAR(1),
	turno_diagnostico VARCHAR(200),
	turno_sintomas VARCHAR(200)
);

/**CARGA**/
SET IDENTITY_INSERT "WASD".Sexo ON
INSERT INTO "WASD".Sexo(sexo_id, sexo_nombre) VALUES
(1, 'Masculino'),
(2, 'Femenino')
SET IDENTITY_INSERT "WASD".Sexo OFF;

SET IDENTITY_INSERT "WASD".EstadoCivil ON
INSERT INTO "WASD".EstadoCivil(estadocivil_id, estadocivil_nombre) VALUES
(1, 'Soltero/a'),
(2, 'Casado/a'),
(3, 'Viudo/a'),
(4, 'Concubinato'),
(5, 'Divorciado/a')
SET IDENTITY_INSERT "WASD".EstadoCivil OFF;

SET IDENTITY_INSERT "WASD".Rol ON
INSERT INTO "WASD".Rol(rol_id, rol_nombre, rol_activo) VALUES
(1, 'Administrativo', 1),
(2, 'Afiliado', 1),
(3, 'Profesional', 1)
SET IDENTITY_INSERT "WASD".Rol OFF;

SET IDENTITY_INSERT "WASD".TipoDocumento ON
INSERT INTO "WASD".TipoDocumento(tipodocumento_id, tipodocumento_nombre) VALUES
(1, 'DNI'),
(2, 'CI'),
(3, 'LE'),
(4, 'LC')
SET IDENTITY_INSERT "WASD".TipoDocumento OFF;

SET IDENTITY_INSERT "WASD".Funcionalidad ON
INSERT INTO "WASD".Funcionalidad(funcionalidad_id, funcionalidad_nombre) VALUES
(1, 'ABM Roles'),
(2, 'ABM Afiliados'),
(3, 'Registrar Agenda'),
(4, 'Comprar Bonos'),
(5, 'Pedir Turno'),
(6, 'Cancelar Turno'),
(7, 'Registrar Llegada'),
(8, 'Diagnosticar'),
(9, 'Ver Estadisticas')
SET IDENTITY_INSERT "WASD".Funcionalidad OFF;

INSERT INTO "WASD".FuncionalidadPorRol VALUES
(1, 1),
(1, 2),
(1, 4),
(1, 7),
(1, 9),
(2, 4),
(2, 5),
(2, 6),
(3, 3),
(3, 6),
(3, 8);

SET IDENTITY_INSERT "WASD".Usuario ON
INSERT INTO "WASD".Usuario(usuario_id, usuario_nombre, usuario_password, usuario_intentos, usuario_activo) VALUES
(1, 'admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0, 1)
SET IDENTITY_INSERT "WASD".Usuario OFF;

SET IDENTITY_INSERT "WASD".PlanMedico ON;
INSERT INTO "WASD".PlanMedico (planmedico_id, planmedico_nombre, planmedico_cuota, planmedico_precio_bono) VALUES
(1, 'OSDE 310', 50, 43);
SET IDENTITY_INSERT "WASD".PlanMedico OFF;

SET IDENTITY_INSERT "WASD".Afiliado ON;
INSERT INTO "WASD".Afiliado (usuario_id, afiliado_numero, afiliado_nombre, afiliado_apellido, afiliado_direccion,
	afiliado_telefono, afiliado_mail, afiliado_fecha_nacimiento, sexo_id, tipodocumento_id, afiliado_numero_documento,
	estadocivil_id, planmedico_id, afiliado_familiares_dependientes, afiliado_activo, afiliado_grupo_familiar) VALUES
	(1, 99999900, 'Leonel', 'Dan', 'Humboldt', 123456789, 'asd@asd.asd', '9-1-1992',1, 1, 36157488, 1, 1, 0, 1, null);
SET IDENTITY_INSERT "WASD".Afiliado OFF;

INSERT INTO "WASD".Profesional(usuario_id, profesional_nombre, profesional_apellido, profesional_direccion,
	profesional_telefono, profesional_mail, profesional_fecha_nacimiento, sexo_id, profesional_matricula,
	tipodocumento_id,	profesional_numero_documento) VALUES
	(1, 'Dr Leonel', 'Dan', 'Uriburu', 12345, 'asd@asd.asd', '1-9-1992', 1, 231561, 1, 36157489);

INSERT INTO "WASD".RolPorUsuario VALUES
(1, 1);
INSERT INTO "WASD".RolPorUsuario VALUES
(1, 2);
INSERT INTO "WASD".RolPorUsuario VALUES
(1, 3);


/**MIGRACION**/
/**PLANES**/
SET IDENTITY_INSERT "WASD".PlanMedico ON
INSERT INTO "WASD".PlanMedico(planmedico_id, planmedico_nombre, planmedico_cuota, planmedico_precio_bono)
SELECT DISTINCT Plan_Med_Codigo, Plan_Med_Descripcion, Plan_Med_Precio_Bono_Consulta, Plan_Med_Precio_Bono_Farmacia
FROM gd_esquema.Maestra
WHERE Plan_Med_Codigo IS NOT NULL
ORDER BY Plan_Med_Codigo ASC
SET IDENTITY_INSERT "WASD".PlanMedico OFF;

/**TIPOS DE ESPECIALIDADES**/
SET IDENTITY_INSERT "WASD".TipoEspecialidad ON
INSERT INTO "WASD".TipoEspecialidad(tipoespecialidad_id, tipoespecialidad_nombre)
SELECT DISTINCT Tipo_Especialidad_Codigo, Tipo_Especialidad_Descripcion
FROM gd_esquema.Maestra
WHERE Tipo_Especialidad_Codigo IS NOT NULL
ORDER BY Tipo_Especialidad_Codigo ASC
SET IDENTITY_INSERT "WASD".TipoEspecialidad OFF;

/**ESPECIALIDADES**/
SET IDENTITY_INSERT "WASD".Especialidad ON
INSERT INTO "WASD".Especialidad(especialidad_id, tipoespecialidad_id, especialidad_nombre)
SELECT DISTINCT Especialidad_Codigo, Tipo_Especialidad_Codigo, Especialidad_Descripcion
FROM gd_esquema.Maestra
WHERE Especialidad_Codigo IS NOT NULL
ORDER BY Especialidad_Codigo ASC
SET IDENTITY_INSERT "WASD".Especialidad OFF;

/**PROFESIONALES**/
DECLARE profesionales CURSOR FOR
SELECT DISTINCT Medico_Dni, Medico_Apellido, Medico_Nombre, Medico_Direccion, Medico_Telefono, Medico_Mail, Medico_Fecha_Nac
FROM gd_esquema.Maestra
WHERE Medico_Dni IS NOT NULL
ORDER BY Medico_Apellido ASC;

DECLARE @ape VARCHAR(50)
DECLARE @nom VARCHAR(50)
DECLARE @dni INT
DECLARE @dir VARCHAR(100)
DECLARE @tel INT
DECLARE @mail VARCHAR(50)
DECLARE @nac DATE
DECLARE @sex INT
DECLARE @usid INT;

OPEN profesionales
FETCH FROM profesionales INTO @dni, @ape, @nom, @dir, @tel, @mail, @nac
WHILE @@FETCH_STATUS = 0
BEGIN
	/**CREAMOS EL USUARIO DEL PROFESIONAL**/
	INSERT INTO "WASD".Usuario(usuario_nombre, usuario_password, usuario_intentos, usuario_activo) VALUES
	(@dni, '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0, 1)
	SET @usid = (SELECT SCOPE_IDENTITY())
	
	/**ASIGNAMOS EL ROL DE PROFESIONAL**/
	INSERT INTO "WASD".RolPorUsuario VALUES (@usid, 3)
	
	/**CREAMOS EL REGISTRO DEL PROFESIONAL**/
	SET @sex = (SELECT FLOOR(RAND()*(2)+1))
	INSERT INTO "WASD".Profesional(usuario_id, profesional_nombre, profesional_apellido, profesional_direccion,
	profesional_telefono, profesional_mail, profesional_fecha_nacimiento, sexo_id, profesional_matricula,
	tipodocumento_id,	profesional_numero_documento) VALUES
	(@usid, @nom, @ape, @dir, @tel, @mail, (SELECT CAST(@nac AS DATE)), @sex, @dni, 1, @dni)
	FETCH NEXT FROM profesionales INTO @dni, @ape, @nom, @dir, @tel, @mail, @nac
END
CLOSE profesionales
DEALLOCATE profesionales;
GO

/**ESPECIALIDADES POR PROFESIONAL**/
DECLARE profesionales CURSOR FOR
SELECT DISTINCT Medico_Dni, Especialidad_Codigo
FROM gd_esquema.Maestra
WHERE Medico_Dni IS NOT NULL
ORDER BY Medico_Dni ASC

DECLARE @dni INT
DECLARE @dniant INT
DECLARE @esp INT
DECLARE @profid INT

SET @dniant = 0
OPEN profesionales
FETCH FROM profesionales INTO @dni, @esp
WHILE @@FETCH_STATUS = 0
BEGIN
	IF (@dniant != @dni)
	BEGIN
		SET @dniant = @dni
		SET @profid = (SELECT profesional_id FROM WASD.Profesional WHERE profesional_numero_documento = @dni)
	END
	INSERT INTO "WASD".EspecialidadPorProfesional VALUES (@profid, @esp)
	FETCH NEXT FROM profesionales INTO @dni, @esp
END
CLOSE profesionales
DEALLOCATE profesionales;
GO

/**AFILIADOS**/
DECLARE afiliados CURSOR FOR
SELECT DISTINCT Paciente_Dni, Paciente_Apellido, Paciente_Nombre, Paciente_Direccion, Paciente_Telefono, Paciente_Mail,
Paciente_Fecha_Nac, Plan_Med_Codigo
FROM gd_esquema.Maestra
WHERE Paciente_Dni IS NOT NULL
ORDER BY Paciente_Apellido ASC

DECLARE @ape VARCHAR(50)
DECLARE @nom VARCHAR(50)
DECLARE @dni INT
DECLARE @dir VARCHAR(100)
DECLARE @tel INT
DECLARE @mail VARCHAR(50)
DECLARE @nac DATE
DECLARE @sex INT
DECLARE @cod INT
DECLARE @civ INT
DECLARE @num INT
DECLARE @usid INT

SET @num = 100

OPEN afiliados
FETCH FROM afiliados INTO @dni, @ape, @nom, @dir, @tel, @mail, @nac, @cod
WHILE @@FETCH_STATUS = 0
BEGIN
	/**CREAMOS EL USUARIO DEL AFILIADO**/
	INSERT INTO "WASD".Usuario(usuario_nombre, usuario_password, usuario_intentos, usuario_activo) VALUES
	(@dni, '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0, 1)
	SET @usid = (SELECT SCOPE_IDENTITY())
	
	/**ASIGNAMOS EL ROL DE AFILIADO**/
	INSERT INTO "WASD".RolPorUsuario VALUES (@usid, 2)

	/**CREAMOS EL REGISTRO DE AFILIADO**/
	SET @sex = (SELECT FLOOR(RAND()*(2)+1))
	SET @civ = (SELECT FLOOR(RAND()*(5)+1))
	INSERT INTO "WASD".Afiliado(usuario_id, afiliado_numero, afiliado_nombre, afiliado_apellido, afiliado_direccion,
	afiliado_telefono, afiliado_mail, afiliado_fecha_nacimiento, sexo_id, tipodocumento_id, afiliado_numero_documento,
	estadocivil_id, planmedico_id, afiliado_familiares_dependientes, afiliado_activo, afiliado_grupo_familiar) VALUES
	(@usid, @num, @nom, @ape, @dir, @tel, @mail, (SELECT CAST(@nac AS DATE)), @sex, 1, @dni, @civ, @cod, 0, 1, NULL)
	
	SET @num = @num + 100
	FETCH NEXT FROM afiliados INTO @dni, @ape, @nom, @dir, @tel, @mail, @nac, @cod
END
CLOSE afiliados
DEALLOCATE afiliados;
GO

/**COMPRAS**/
INSERT INTO "WASD".Compra
SELECT a.afiliado_id, m.Compra_Bono_Fecha, COUNT(*), COUNT(*) * p.planmedico_precio_bono
FROM gd_esquema.Maestra m, WASD.Afiliado a, WASD.PlanMedico p
WHERE m.Compra_Bono_Fecha IS NOT NULL
AND m.Paciente_Dni = a.afiliado_numero_documento
AND a.planmedico_id = p.planmedico_id
GROUP BY m.Compra_Bono_Fecha, a.afiliado_id, p.planmedico_precio_bono
ORDER BY afiliado_id;
GO

/* Triggers */
CREATE TRIGGER "WASD".RolDeleted
ON "WASD".Rol
FOR UPDATE
AS BEGIN
  declare @rol INT
  declare @activo BIT 
  select @rol = inserted.rol_id, @activo = inserted.rol_activo from inserted;
  
  IF (@activo = 0)
    DELETE "WASD".RolPorUsuario where rol_id = @rol
    
END

CREATE PROCEDURE "WASD".CompraBono @afiliadoId INT, @cant INT, @planMedicoId INT
AS
BEGIN

	DECLARE @fecha DATETIME = GETDATE();
	DECLARE @monto MONEY;
	DECLARE @compra_id INT
	DECLARE @intFlag INT = 1;

	select @monto = planmedico_precio_bono * @cant
    from "WASD".PlanMedico
    WHERE planmedico_id = @planMedicoId; 

	INSERT INTO "WASD".Compra (afiliado_id, compra_fecha_hora, compra_cantidad, compra_monto)
     VALUES (@afiliadoId, @fecha, @cant, @monto);

    select TOP 1 @compra_id = compra_id 
    from "WASD".Compra
    ORDER BY compra_id desc;
	
	WHILE (@intFlag <= @cant)
	BEGIN
	
		INSERT INTO "WASD".Bono([planmedico_id],[afiliado_id],[compra_id],[bono_numero_consulta],[bono_afiliado_usado],[bono_fecha_uso])
		VALUES(@planMedicoId, @afiliadoId, @compra_id, NULL, NULL, NULL);
		
		SET @intFlag = @intFlag + 1
	END

END;