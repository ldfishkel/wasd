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

IF OBJECT_ID('WASD.Sintoma', 'U') IS NOT NULL
  DROP TABLE "WASD".Sintoma
GO

IF OBJECT_ID('WASD.Diagnostico', 'U') IS NOT NULL
  DROP TABLE "WASD".Diagnostico
GO

IF OBJECT_ID('WASD.ConsultaMedica', 'U') IS NOT NULL
  DROP TABLE "WASD".ConsultaMedica
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


CREATE TABLE "WASD".PlanMedico (
	planmedico_id INT PRIMARY KEY IDENTITY(1,1),
	planmedico_nombre CHAR(15) NOT NULL,
	planmedico_cuota MONEY NOT NULL,
	planmedico_precio_bono MONEY NOT NULL
);

CREATE TABLE "WASD".Afiliado (
	afiliado_id INT PRIMARY KEY IDENTITY(1,1),
	usuario_id INT NOT NULL REFERENCES "WASD".Usuario(usuario_id),
	estadocivil_id INT NOT NULL REFERENCES "WASD".EstadoCivil(estadocivil_id),
	afiliado_tipodocumento CHAR(3) CHECK (afiliado_tipodocumento IN ('DNI', 'CI', 'LC', 'LE')),
	planmedico_id INT NOT NULL REFERENCES "WASD".PlanMedico(planmedico_id),
	afiliado_sexo CHAR(1) CHECK (afiliado_sexo IN ('M', 'F')),
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
	profesional_sexo CHAR(1) CHECK (profesional_sexo IN ('M', 'F')),
	profesional_tipodocumento CHAR(3) CHECK (profesional_tipodocumento IN ('DNI', 'CI', 'LC', 'LE')),
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
	compra_id INT PRIMARY KEY IDENTITY(1,1),
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
	especialidad_id INT NOT NULL REFERENCES "WASD".Especialidad(especialidad_id),
	turno_fecha_hora DATETIME NOT NULL,
	turno_cancelado CHAR(1)
);

CREATE TABLE "WASD".ConsultaMedica (
	consultamedica_id INT PRIMARY KEY IDENTITY(1,1),
	bono_id INT NOT NULL REFERENCES "WASD".Bono(bono_id),
	consultamedica_fecha_hora DATETIME NOT NULL
);

CREATE TABLE "WASD".Sintoma (
	sintoma_id INT PRIMARY KEY IDENTITY(1,1),
	consultamedica_id INT NOT NULL REFERENCES "WASD".ConsultaMedica(consultamedica_id),
	sintoma_descripcion VARCHAR(255) NOT NULL
);

CREATE TABLE "WASD".Diagnostico (
	diagnostico_id INT PRIMARY KEY IDENTITY(1,1),
	consultamedica_id INT NOT NULL REFERENCES "WASD".ConsultaMedica(consultamedica_id),
	diagnostico_descripcion VARCHAR(255) NOT NULL
);

/**CARGA**/
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
(1, 5),
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

INSERT INTO "WASD".RolPorUsuario VALUES
(1, 1);

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
DECLARE @sex CHAR(1)
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
	IF (SELECT FLOOR(RAND()*(2)+1)) = 1
	BEGIN
		SET @sex = 'M'
	END
	ELSE
	BEGIN
		SET @sex = 'F'
	END
	
	INSERT INTO "WASD".Profesional(usuario_id, profesional_nombre, profesional_apellido, profesional_direccion,
	profesional_telefono, profesional_mail, profesional_fecha_nacimiento, profesional_sexo, profesional_matricula,
	profesional_tipodocumento, profesional_numero_documento) VALUES
	(@usid, @nom, @ape, @dir, @tel, @mail, (SELECT CAST(@nac AS DATE)), @sex, @dni, 'DNI', @dni)
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
DECLARE @sex CHAR(1)
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
	IF (SELECT FLOOR(RAND()*(2)+1)) = 1
	BEGIN
		SET @sex = 'M'
	END
	ELSE
	BEGIN
		SET @sex = 'F'
	END

	SET @civ = (SELECT FLOOR(RAND()*(5)+1))
	INSERT INTO "WASD".Afiliado(usuario_id, afiliado_numero, afiliado_nombre, afiliado_apellido, afiliado_direccion,
	afiliado_telefono, afiliado_mail, afiliado_fecha_nacimiento, afiliado_sexo, afiliado_tipodocumento,
	afiliado_numero_documento, estadocivil_id, planmedico_id, afiliado_familiares_dependientes, afiliado_activo,
	afiliado_grupo_familiar) VALUES
	(@usid, @num, @nom, @ape, @dir, @tel, @mail, (SELECT CAST(@nac AS DATE)), @sex, 'DNI', @dni, @civ, @cod, 0, 1, NULL)
	
	SET @num += 100
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

/**BONOS**/
SET IDENTITY_INSERT "WASD".Bono ON
INSERT INTO "WASD".Bono(bono_id, planmedico_id, afiliado_id, compra_id, bono_numero_consulta, bono_afiliado_usado,
bono_fecha_uso)
SELECT m1.Bono_Consulta_Numero, m1.Plan_Med_Codigo, a.afiliado_id, c.compra_id, NULL, a.afiliado_id,
(SELECT CAST(m1.Turno_Fecha AS DATE))
FROM WASD.Afiliado a, WASD.Compra c,
(SELECT
	MAX(Plan_Med_Codigo) as Plan_Med_Codigo,
	MAX(Paciente_Dni) as Paciente_Dni,
	Bono_Consulta_Numero,
	MAX(Turno_Fecha) as Turno_Fecha,
	MAX(Compra_Bono_Fecha) as Compra_Bono_Fecha
	FROM gd_esquema.Maestra
	WHERE Bono_Consulta_Numero IS NOT NULL
	GROUP BY Bono_Consulta_Numero) m1
WHERE a.afiliado_numero_documento = m1.Paciente_Dni
AND a.afiliado_id = c.afiliado_id
AND c.compra_fecha_hora = m1.Compra_Bono_Fecha
ORDER BY m1.Bono_Consulta_Numero
SET IDENTITY_INSERT "WASD".Bono OFF;
GO

/**TURNOS**/
SET IDENTITY_INSERT "WASD".Turno ON
INSERT INTO "WASD".Turno(turno_id, afiliado_id, profesional_id, especialidad_id, turno_fecha_hora, turno_cancelado)
SELECT m.Turno_Numero, a.afiliado_id, p.profesional_id, m.Especialidad_Codigo, m.Turno_Fecha, NULL
FROM gd_esquema.Maestra m, "WASD".Afiliado a, "WASD".Profesional p
WHERE m.Turno_Numero IS NOT NULL
AND m.Consulta_Sintomas IS NOT NULL
AND m.Paciente_Dni = a.afiliado_numero_documento
AND m.Medico_Dni = p.profesional_numero_documento
ORDER BY m.Turno_Numero ASC
SET IDENTITY_INSERT "WASD".Turno OFF;
GO

/**CONSULTAS MEDICAS**/
SET IDENTITY_INSERT "WASD".ConsultaMedica ON
INSERT INTO "WASD".ConsultaMedica(consultamedica_id, bono_id, consultamedica_fecha_hora)
SELECT Turno_Numero, Bono_Consulta_Numero, Turno_Fecha
FROM gd_esquema.Maestra
WHERE Turno_Numero IS NOT NULL
AND Bono_Consulta_Numero IS NOT NULL
ORDER BY Turno_Numero ASC
SET IDENTITY_INSERT "WASD".ConsultaMedica OFF;
GO

/**SINTOMAS**/
INSERT INTO "WASD".Sintoma(consultamedica_id, sintoma_descripcion)
SELECT Turno_Numero, Consulta_Sintomas
FROM gd_esquema.Maestra
WHERE Consulta_Sintomas IS NOT NULL
ORDER BY Turno_Numero ASC;
GO

/**DIAGNOSTICOS**/
INSERT INTO "WASD".Diagnostico(consultamedica_id, diagnostico_descripcion)
SELECT Turno_Numero, Consulta_Enfermedades
FROM gd_esquema.Maestra
WHERE Consulta_Enfermedades IS NOT NULL
ORDER BY Turno_Numero ASC;
GO

/**STORED PROCEDURES**/

/**ACTUALIZACION NUMERO DE USO DE BONOS DE MIGRACION**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'SP_ActualizacionBonos' AND xtype = 'P')
DROP PROCEDURE  WASD.SP_ActualizacionBonos;
GO

CREATE PROCEDURE "WASD".SP_ActualizacionBonos @afid INT
AS
BEGIN
	DECLARE bonos CURSOR FOR
	SELECT bono_id FROM "WASD".Bono
	WHERE bono_numero_consulta IS NULL AND bono_fecha_uso IS NOT NULL AND afiliado_id = @afid
	ORDER BY bono_fecha_uso ASC
	
	DECLARE @bid INT
	DECLARE @cont SMALLINT
	
	SET @cont = 1
	OPEN bonos
	FETCH FROM bonos INTO @bid
	WHILE @@FETCH_STATUS = 0
	BEGIN
		UPDATE "WASD".Bono SET bono_numero_consulta = @cont WHERE bono_id = @bid
		SET @cont += 1
		FETCH NEXT FROM bonos INTO @bid
	END
	CLOSE bonos
	DEALLOCATE bonos
END;
GO

/**VISTAS**/

/**LISTADO DE PROFESIONALES**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'V_ListarProf' AND xtype = 'V')
DROP FUNCTION  WASD.V_ListarProf;
GO

CREATE VIEW "WASD".V_ListarProf
AS
	SELECT profesional_id, profesional_apellido, profesional_nombre
	FROM "WASD".Profesional;
GO

/**LISTADO DE ESPECIALIDADES**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'V_ListarEsp' AND xtype = 'V')
DROP FUNCTION  WASD.V_ListarEsp;
GO

CREATE VIEW "WASD".V_ListarEsp
AS
	SELECT e.especialidad_id, e.especialidad_nombre, t.tipoespecialidad_id, t.tipoespecialidad_nombre
	FROM "WASD".Especialidad e
	JOIN "WASD".TipoEspecialidad t
	ON e.tipoespecialidad_id = t.tipoespecialidad_id;
GO

/**FUNCIONES**/
/**LISTADO DE PROFESIONALES POR ESPECIALIDAD**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'F_ProfPorEsp' AND xtype = 'TF')
DROP FUNCTION WASD.F_ProfPorEsp;
GO

CREATE FUNCTION "WASD".F_ProfPorEsp(@especialidad INT)
RETURNS TABLE
AS RETURN (
	SELECT p.profesional_id, p.profesional_apellido, p.profesional_nombre
	FROM WASD.EspecialidadPorProfesional e
	JOIN WASD.Profesional p
	ON e.profesional_id = p.profesional_id
	WHERE e.especialidad_id = @especialidad
);
GO

/**LISTADO DE TURNOS DEL DIA PARA UN PROFESIONAL**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'F_TurnosProf' AND xtype = 'IF')
DROP FUNCTION WASD.F_TurnosProf;
GO

CREATE FUNCTION "WASD".F_TurnosProf(@prof INT, @fecha DATE)
RETURNS TABLE
AS RETURN (
	SELECT a.afiliado_id, a.afiliado_apellido, a.afiliado_nombre, CAST(t.turno_fecha_hora AS TIME) AS turno_hora
	FROM WASD.Afiliado a
	JOIN WASD.Turno t
	ON a.afiliado_id = t.afiliado_id
	WHERE t.profesional_id = @prof
	AND CAST(t.turno_fecha_hora AS DATE) = @fecha
);
GO

/**TRIGGERS**/
CREATE TRIGGER "WASD".RolDeleted
ON "WASD".Rol
FOR UPDATE
AS BEGIN
  declare @rol INT
  declare @activo BIT 
  select @rol = inserted.rol_id, @activo = inserted.rol_activo from inserted;
  
  IF (@activo = 0)
    DELETE "WASD".RolPorUsuario where rol_id = @rol
    
END;
GO
