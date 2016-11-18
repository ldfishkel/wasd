/**SCRIPT DE CREACION INICIAL**/
/**GRUPO NUMERO 52 WASD**/
/**GESTION DE DATOS SEGUNDO CUATRIMESTRE 2016**/

USE [GD2C2016];
GO

SET LANGUAGE Spanish

/****************************************************************************************************************/
/**CREAR SCHEMA**/
/****************************************************************************************************************/
IF NOT EXISTS
(
  SELECT  schema_name
  FROM    information_schema.schemata
  WHERE   schema_name = 'WASD'
)

BEGIN
  EXEC sp_executesql N'CREATE SCHEMA "WASD" AUTHORIZATION gd'
END

/****************************************************************************************************************/
/**PROPIEDADES DE TRANSACCIONES**/
/****************************************************************************************************************/
SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

/****************************************************************************************************************/
/**BORRAR TABLAS**/
/****************************************************************************************************************/
IF OBJECT_ID('WASD.Agenda', 'U') IS NOT NULL
  DROP TABLE "WASD".Agenda
GO

IF OBJECT_ID('WASD.Hora', 'U') IS NOT NULL
  DROP TABLE "WASD".Hora
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

IF OBJECT_ID('WASD.TurnoCancelado', 'U') IS NOT NULL
  DROP TABLE "WASD".TurnoCancelado
GO

IF OBJECT_ID('WASD.TipoCancelacion', 'U') IS NOT NULL
  DROP TABLE "WASD".TipoCancelacion
GO

/****************************************************************************************************************/
/**CREAR TABLAS**/
/****************************************************************************************************************/

CREATE TABLE "WASD".Usuario (
	usuario_id INT PRIMARY KEY IDENTITY(1,1),
	usuario_nombre CHAR(10) NOT NULL UNIQUE,
	usuario_password CHAR(64) NOT NULL,
	usuario_intentos TINYINT NOT NULL,
	usuario_activo BIT NOT NULL,
	usuario_nombre_a_mostrar VARCHAR(101) NOT NULL
);

CREATE TABLE "WASD".EstadoCivil (
	estadocivil_id INT PRIMARY KEY IDENTITY(1,1),
	estadocivil_nombre CHAR(12) NOT NULL UNIQUE
);


CREATE TABLE "WASD".PlanMedico (
	planmedico_id INT PRIMARY KEY IDENTITY(1,1),
	planmedico_nombre CHAR(15) NOT NULL UNIQUE,
	planmedico_cuota MONEY NOT NULL,
	planmedico_precio_bono MONEY NOT NULL
);

CREATE TABLE "WASD".Afiliado (
	afiliado_id INT PRIMARY KEY IDENTITY(1,1),
	usuario_id INT NOT NULL REFERENCES "WASD".Usuario(usuario_id),
	estadocivil_id INT NOT NULL REFERENCES "WASD".EstadoCivil(estadocivil_id),
	afiliado_tipodocumento CHAR(3) CHECK (afiliado_tipodocumento IN ('DNI', 'CI', 'LC', 'LE')),
	planmedico_id INT NOT NULL REFERENCES "WASD".PlanMedico(planmedico_id),
	afiliado_sexo CHAR(1) CHECK (afiliado_sexo IN ('M', 'F', 'X')),
	afiliado_numero INT NOT NULL UNIQUE,
	afiliado_nombre VARCHAR(50) NOT NULL,
	afiliado_apellido VARCHAR(50) NOT NULL,
	afiliado_numero_documento INT NOT NULL UNIQUE,
	afiliado_direccion VARCHAR(100) NOT NULL,
	afiliado_telefono INT NOT NULL,
	afiliado_mail VARCHAR(50) NOT NULL,
	afiliado_fecha_nacimiento DATE NOT NULL,
	afiliado_familiares_dependientes TINYINT NOT NULL,
	afiliado_activo BIT NOT NULL,
	afiliado_grupo_familiar INT REFERENCES "WASD".Afiliado(afiliado_id),
	afiliado_cantidad_bonos_usados SMALLINT NOT NULL DEFAULT 0,
	afiliado_fecha_baja DATETIME
);

CREATE TABLE "WASD".TipoCancelacion (
	tipocancelacion_id INT PRIMARY KEY IDENTITY(1,1),
	tipocancelacion_nombre VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE "WASD".TurnoCancelado (
	turnocancelado_id INT PRIMARY KEY IDENTITY(1,1),
	turnocancelado_tipocancelacion_id INT NOT NULL REFERENCES "WASD".TipoCancelacion(tipocancelacion_id),
	turnocancelado_descripcion VARCHAR(50) NOT NULL,
	turnocancelado_cancelado_por CHAR(1) CHECK (turnocancelado_cancelado_por IN ('A', 'P'))
);

CREATE TABLE "WASD".TipoEspecialidad (
	tipoespecialidad_id INT PRIMARY KEY IDENTITY(1,1),
	tipoespecialidad_nombre VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE "WASD".Especialidad (
	especialidad_id INT PRIMARY KEY IDENTITY(1,1),
	tipoespecialidad_id INT NOT NULL REFERENCES "WASD".TipoEspecialidad(tipoespecialidad_id),
	especialidad_nombre VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE "WASD".Profesional (
	profesional_id INT PRIMARY KEY IDENTITY(1,1),
	usuario_id INT NOT NULL REFERENCES "WASD".Usuario(usuario_id),
	profesional_sexo CHAR(1) CHECK (profesional_sexo IN ('M', 'F', 'X')),
	profesional_tipodocumento CHAR(3) CHECK (profesional_tipodocumento IN ('DNI', 'CI', 'LC', 'LE')),
	profesional_numero_documento INT NOT NULL UNIQUE,
	profesional_nombre VARCHAR(25) NOT NULL,
	profesional_apellido VARCHAR(25) NOT NULL,
	profesional_direccion VARCHAR(100) NOT NULL,
	profesional_telefono INT NOT NULL,
	profesional_mail VARCHAR(50) NOT NULL,
	profesional_fecha_nacimiento DATE NOT NULL,
	profesional_matricula INT NOT NULL UNIQUE
);

CREATE TABLE "WASD".Hora (
	hora_id INT PRIMARY KEY,
	hora_comienzo TIME NOT NULL UNIQUE
);

CREATE TABLE "WASD".Agenda (
	agenda_id INT PRIMARY KEY IDENTITY(1,1),
	profesional_id INT NOT NULL REFERENCES "WASD".Profesional(profesional_id),
	especialidad_id INT NOT NULL REFERENCES "WASD".Especialidad(especialidad_id),
	agenda_dia CHAR(9) CHECK (agenda_dia IN ('LUNES', 'MARTES', 'MIERCOLES', 'JUEVES', 'VIERNES', 'SABADO', 'DOMINGO')),
	agenda_hora_desde INT NOT NULL REFERENCES "WASD".Hora(hora_id),
	agenda_hora_hasta INT NOT NULL REFERENCES "WASD".Hora(hora_id),
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
	bono_afiliado_usado INT REFERENCES "WASD".Afiliado(afiliado_id)
);

CREATE TABLE "WASD".EspecialidadPorProfesional (
	profesional_id INT NOT NULL REFERENCES "WASD".Profesional(profesional_id),
	especialidad_id INT NOT NULL REFERENCES "WASD".Especialidad(especialidad_id),
	PRIMARY KEY (profesional_id, especialidad_id)
);

CREATE TABLE "WASD".Funcionalidad (
	funcionalidad_id INT PRIMARY KEY IDENTITY(1,1),
	funcionalidad_nombre VARCHAR(25) NOT NULL UNIQUE
);

CREATE TABLE "WASD".Rol (
	rol_id INT PRIMARY KEY IDENTITY(1,1),
	rol_nombre CHAR(15) NOT NULL UNIQUE,
	rol_activo BIT NOT NULL
);

CREATE TABLE "WASD".FuncionalidadPorRol (
	rol_id INT NOT NULL REFERENCES "WASD".Rol(rol_id),
	funcionalidad_id INT NOT NULL REFERENCES "WASD".Funcionalidad(funcionalidad_id),
	PRIMARY KEY (funcionalidad_id, rol_id)
);

CREATE TABLE "WASD".HistorialPlan (
	historialplan_id INT PRIMARY KEY IDENTITY(1,1),
	afiliado_id INT NOT NULL REFERENCES "WASD".Afiliado(afiliado_id),
	historial_fecha DATE NOT NULL,
	historial_motivo VARCHAR(144) NOT NULL
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
	turnocancelado_id INT REFERENCES "WASD".TurnoCancelado(turnocancelado_id),
	turno_fecha DATE NOT NULL,
	turno_hora TIME NOT NULL,
	turno_llego BIT NOT NULL
);

CREATE TABLE "WASD".ConsultaMedica (
	consultamedica_id INT NOT NULL REFERENCES "WASD".Turno(turno_id),
	bono_id INT NOT NULL REFERENCES "WASD".Bono(bono_id),
	consultamedica_fecha_hora DATETIME,
	consultamedica_ocurrio BIT,
	PRIMARY KEY (consultamedica_id)
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

/****************************************************************************************************************/
/**SEED PRE MIGRACION**/
/****************************************************************************************************************/
SET IDENTITY_INSERT "WASD".EstadoCivil ON
INSERT INTO "WASD".EstadoCivil(estadocivil_id, estadocivil_nombre) VALUES
(1, 'Soltero/a'),
(2, 'Casado/a'),
(3, 'Viudo/a'),
(4, 'Concubinato'),
(5, 'Divorciado/a'),
(6, 'Migrado/a')
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
(1, 7),
(1, 9),
(2, 4),
(2, 5),
(2, 6),
(3, 3),
(3, 6),
(3, 8);

SET IDENTITY_INSERT "WASD".Usuario ON
INSERT INTO "WASD".Usuario(usuario_id, usuario_nombre, usuario_password, usuario_intentos, usuario_activo,
usuario_nombre_a_mostrar) VALUES
(1, 'admin', 'e6b87050bfcb8143fcb8db0170a4dc9ed00d904ddd3e2a4ad1b1e8dc0fdc9be7', 0, 1, 'Administrador General')
SET IDENTITY_INSERT "WASD".Usuario OFF;

INSERT INTO "WASD".RolPorUsuario VALUES
(1, 1),
(1, 2),
(1, 3);

INSERT INTO "WASD".Hora VALUES
(1, '07:00'),
(2, '07:30'),
(3, '08:00'),
(4, '08:30'),
(5, '09:00'),
(6, '09:30'),
(7, '10:00'),
(8, '10:30'),
(9, '11:00'),
(10, '11:30'),
(11, '12:00'),
(12, '12:30'),
(13, '13:00'),
(14, '13:30'),
(15, '14:00'),
(16, '14:30'),
(17, '15:00'),
(18, '15:30'),
(19, '16:00'),
(20, '16:30'),
(21, '17:00'),
(22, '17:30'),
(23, '18:00'),
(24, '18:30'),
(25, '19:00'),
(26, '19:30'),
(27, '20:00');

INSERT INTO "WASD".TipoCancelacion(tipocancelacion_nombre)VALUES
('Emergencia'),
('Falta de tiempo'),
('Vacaciones'),
('Acto de Dios');

/****************************************************************************************************************/
/**MIGRACION**/
/****************************************************************************************************************/

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
DECLARE @usid INT;

OPEN profesionales
FETCH FROM profesionales INTO @dni, @ape, @nom, @dir, @tel, @mail, @nac
WHILE @@FETCH_STATUS = 0
BEGIN
	/**CREAMOS EL USUARIO DEL PROFESIONAL**/
	/**USUARIO: el numero de DNI**/
	/**PASSWORD: 123456**/
	INSERT INTO "WASD".Usuario(usuario_nombre, usuario_password, usuario_intentos, usuario_activo, usuario_nombre_a_mostrar)
	VALUES (@dni, '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0, 1, @ape+','+@nom)
	SET @usid = (SELECT SCOPE_IDENTITY())
	
	/**ASIGNAMOS EL ROL DE PROFESIONAL**/
	INSERT INTO "WASD".RolPorUsuario VALUES (@usid, 3)
	
	/**CREAMOS EL REGISTRO DEL PROFESIONAL**/
	INSERT INTO "WASD".Profesional(usuario_id, profesional_nombre, profesional_apellido, profesional_direccion,
	profesional_telefono, profesional_mail, profesional_fecha_nacimiento, profesional_sexo, profesional_matricula,
	profesional_tipodocumento, profesional_numero_documento) VALUES
	(@usid, @nom, @ape, @dir, @tel, @mail, (SELECT CAST(@nac AS DATE)), 'X', @dni, 'DNI', @dni)
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
SELECT COUNT(Consulta_Sintomas), Paciente_Dni, Paciente_Apellido, Paciente_Nombre, Paciente_Direccion, Paciente_Telefono,
Paciente_Mail, Paciente_Fecha_Nac, Plan_Med_Codigo
FROM gd_esquema.Maestra
WHERE Paciente_Dni IS NOT NULL
AND Consulta_Sintomas IS NOT NULL
GROUP BY Paciente_Dni, Paciente_Apellido, Paciente_Nombre, Paciente_Direccion, Paciente_Telefono, Paciente_Mail,
Paciente_Fecha_Nac, Plan_Med_Codigo
ORDER BY Paciente_Apellido ASC

DECLARE @ape VARCHAR(50)
DECLARE @nom VARCHAR(50)
DECLARE @dni INT
DECLARE @dir VARCHAR(100)
DECLARE @tel INT
DECLARE @mail VARCHAR(50)
DECLARE @nac DATE
DECLARE @cod INT
DECLARE @civ INT
DECLARE @num INT
DECLARE @usid INT
DECLARE @bonos SMALLINT

SET @num = 101

OPEN afiliados
FETCH FROM afiliados INTO @bonos, @dni, @ape, @nom, @dir, @tel, @mail, @nac, @cod
WHILE @@FETCH_STATUS = 0
BEGIN
	/**CREAMOS EL USUARIO DEL AFILIADO**/
	/**USUARIO: el numero de DNI**/
	/**PASSWORD: 123456**/
	INSERT INTO "WASD".Usuario(usuario_nombre, usuario_password, usuario_intentos, usuario_activo, usuario_nombre_a_mostrar)
	VALUES (@dni, '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0, 1, @ape+','+@nom)
	SET @usid = (SELECT SCOPE_IDENTITY())
	
	/**ASIGNAMOS EL ROL DE AFILIADO**/
	INSERT INTO "WASD".RolPorUsuario VALUES (@usid, 2)
	
	/**CREAMOS EL REGISTRO DE AFILIADO**/
	INSERT INTO "WASD".Afiliado(usuario_id, afiliado_numero, afiliado_nombre, afiliado_apellido, afiliado_direccion,
	afiliado_telefono, afiliado_mail, afiliado_fecha_nacimiento, afiliado_sexo, afiliado_tipodocumento,
	afiliado_numero_documento, estadocivil_id, planmedico_id, afiliado_familiares_dependientes, afiliado_activo,
	afiliado_grupo_familiar, afiliado_cantidad_bonos_usados, afiliado_fecha_baja) VALUES
	(@usid, @num, @nom, @ape, @dir, @tel, @mail, (SELECT CAST(@nac AS DATE)), 'X', 'DNI', @dni, 6, @cod, 0, 1, NULL, @bonos, NULL)
	
	SET @num += 100
	FETCH NEXT FROM afiliados INTO @bonos, @dni, @ape, @nom, @dir, @tel, @mail, @nac, @cod
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
INSERT INTO "WASD".Bono(bono_id, planmedico_id, afiliado_id, compra_id, bono_afiliado_usado)
SELECT m1.Bono_Consulta_Numero, m1.Plan_Med_Codigo, a.afiliado_id, c.compra_id, a.afiliado_id
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
INSERT INTO "WASD".Turno(turno_id, afiliado_id, profesional_id, especialidad_id, turnocancelado_id, turno_fecha, turno_hora, turno_llego)
SELECT m.Turno_Numero, a.afiliado_id, p.profesional_id, m.Especialidad_Codigo, NULL, (SELECT CAST(m.Turno_Fecha AS DATE)),
(SELECT CAST(m.Turno_Fecha AS TIME)), 1
FROM gd_esquema.Maestra m, "WASD".Afiliado a, "WASD".Profesional p
WHERE m.Turno_Numero IS NOT NULL
AND m.Consulta_Sintomas IS NOT NULL
AND m.Paciente_Dni = a.afiliado_numero_documento
AND m.Medico_Dni = p.profesional_numero_documento
ORDER BY m.Turno_Numero ASC
SET IDENTITY_INSERT "WASD".Turno OFF;
GO

/**CONSULTAS MEDICAS**/
INSERT INTO "WASD".ConsultaMedica(consultamedica_id, bono_id, consultamedica_fecha_hora, consultamedica_ocurrio)
SELECT Turno_Numero, Bono_Consulta_Numero, Turno_Fecha, 1
FROM gd_esquema.Maestra
WHERE Turno_Numero IS NOT NULL
AND Bono_Consulta_Numero IS NOT NULL
ORDER BY Turno_Numero ASC;
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

/**AGENDAS PROFESIONALES**/
SET DATEFIRST 7
DECLARE @mid INT, @mdni INT, @dia INT, @hini INT, @hfin INT, @esp INT
DECLARE @fdesde DATE, @fhasta DATE

/**Tomamos cada uno de los profesionales**/
DECLARE medicos CURSOR FOR
SELECT profesional_id, profesional_numero_documento
FROM "WASD".Profesional
ORDER BY profesional_id

OPEN medicos
FETCH FROM medicos INTO @mid, @mdni
WHILE @@FETCH_STATUS = 0
BEGIN
	/**Tomamos cada uno de los dias de la semana que ese profesional atendio en la tabla maestra**/
	DECLARE dias_medico CURSOR FOR
	SELECT DISTINCT(DATEPART(weekday, Turno_Fecha))
	FROM gd_esquema.Maestra
	WHERE Turno_Fecha IS NOT NULL
	AND Medico_Dni = @mdni
	
	OPEN dias_medico
	FETCH FROM dias_medico INTO @dia
	WHILE @@FETCH_STATUS = 0
	BEGIN
		/**Tomamos cada una de las especialidades que ese profesional atendio en ese dia de la semana**/
		DECLARE especialidades_medico CURSOR FOR
		SELECT DISTINCT(Especialidad_Codigo)
		FROM gd_esquema.Maestra
		WHERE Turno_Fecha IS NOT NULL
		AND Medico_Dni = @mdni
		AND DATEPART(weekday, Turno_Fecha) = @dia
		
		OPEN especialidades_medico
		FETCH FROM especialidades_medico INTO @esp
		WHILE @@FETCH_STATUS = 0
		BEGIN
			/**Tomamos fechas minima y maxima, y horas minima y maxima e insertamos todo**/
			INSERT INTO "WASD".Agenda(profesional_id, especialidad_id, agenda_dia, agenda_hora_desde, agenda_hora_hasta,
			agenda_fecha_desde, agenda_fecha_hasta)
			SELECT @mid, @esp,
			CASE @dia
				WHEN 1 THEN 'DOMINGO'
				WHEN 2 THEN 'LUNES'
				WHEN 3 THEN 'MARTES'
				WHEN 4 THEN 'MIERCOLES'
				WHEN 5 THEN 'JUEVES'
				WHEN 6 THEN	'VIERNES'
				ELSE 'SABADO'
			END,
			(MIN(DATEPART(hour, Turno_Fecha)) - 7) * 2 + 1,
			(MAX(DATEPART(hour, Turno_Fecha)) - 7) * 2 + 3,
			CAST(MIN(Turno_Fecha) AS DATE), CAST(MAX(Turno_Fecha) AS DATE)
			FROM gd_esquema.Maestra
			WHERE Turno_Fecha IS NOT NULL
			AND Medico_Dni = @mdni
			AND DATEPART(weekday, Turno_Fecha) = @dia
			AND Especialidad_Codigo = @esp
		
			FETCH NEXT FROM especialidades_medico INTO @esp
		END
		CLOSE especialidades_medico
		DEALLOCATE especialidades_medico
		
		FETCH NEXT FROM dias_medico INTO @dia
	END
	CLOSE dias_medico
	DEALLOCATE dias_medico
	
	FETCH NEXT FROM medicos INTO @mid, @mdni
END;
CLOSE medicos
DEALLOCATE medicos
GO

/****************************************************************************************************************/
/**VISTAS**/
/***********************************************************************************************************/

/**LISTADO DE ESPECIALIDADES**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaEspecialidades' AND xtype = 'V')
	DROP VIEW WASD.ListaEspecialidades;
GO

CREATE VIEW "WASD".ListaEspecialidades
AS
	SELECT 
		*
	FROM 
		"WASD".Especialidad;
GO

/**LISTADO DE TIPO DE ESPECIALIDADES**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaTipoEspecialidades' AND xtype = 'V')
	DROP VIEW WASD.ListaTipoEspecialidades;
GO

CREATE VIEW "WASD".ListaTipoEspecialidades
AS
	SELECT 
		*
	FROM 
		"WASD".TipoEspecialidad;
GO

/**LISTADO DE TIPO DE CANCELACIONES**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaTipoCancelaciones' AND xtype = 'V')
	DROP VIEW WASD.ListaTipoCancelaciones;
GO

CREATE VIEW "WASD".ListaTipoCancelaciones
AS
	SELECT 
		*
	FROM 
		"WASD".TipoCancelacion;
GO

/**LISTADO DE HORAS DE ATENCION DURANTE LA SEMANA**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaHorasSemana' AND xtype = 'V')
	DROP VIEW WASD.ListaHorasSemana;
GO

CREATE VIEW "WASD".ListaHorasSemana
AS
	SELECT 
		*
	FROM 
		"WASD".Hora;
GO

/**LISTADO DE HORAS DE ATENCION DURANTE EL SABADO**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaHorasSabado' AND xtype = 'V')
	DROP VIEW WASD.ListaHorasSabado;
GO

CREATE VIEW "WASD".ListaHorasSabado
AS
	SELECT 
		*
	FROM 
		"WASD".Hora
	WHERE 
		hora_id BETWEEN 7 AND  17;
GO

/**LISTADO DE ROLES**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaRoles' AND xtype = 'V')
	DROP VIEW WASD.ListaRoles;
GO

CREATE VIEW "WASD".ListaRoles
AS
	SELECT 
		*
	FROM 
		"WASD".Rol;
GO

/**LISTADO DE PLANES**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaPlanMedicos' AND xtype = 'V')
	DROP VIEW WASD.ListaPlanMedicos;
GO

CREATE VIEW "WASD".ListaPlanMedicos
AS
	SELECT 
		*
	FROM 
		"WASD".PlanMedico;
GO

/**LISTADO DE FUNCIONALIDADES**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaFuncionalidades' AND xtype = 'V')
	DROP VIEW WASD.ListaFuncionalidades;
GO

CREATE VIEW "WASD".ListaFuncionalidades
AS
	SELECT 
		*
	FROM 
		"WASD".Funcionalidad;
GO


/**LISTADO DE AFILIADOS**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaAfiliados' AND xtype = 'V')
	DROP VIEW WASD.ListaAfiliados;
GO

CREATE VIEW "WASD".ListaAfiliados
AS
	SELECT 
		usuario_id,
		afiliado_numero,
		afiliado_nombre,
		afiliado_apellido
	FROM 
		"WASD".Afiliado
	WHERE
		afiliado_activo = 1;
GO

/**LISTADO DE ESTADOS CIVILES**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaEstadoCivil' AND xtype = 'V')
	DROP VIEW WASD.ListaEstadoCivil;
GO

CREATE VIEW "WASD".ListaEstadoCivil
AS
	SELECT 
		*
	FROM 
		"WASD".EstadoCivil;
GO

/**LISTADO DE TIPO DE DOCUMENTO**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ListaTipoDocumento' AND xtype = 'V')
	DROP VIEW WASD.ListaTipoDocumento;
GO

CREATE VIEW "WASD".ListaTipoDocumento
AS
	SELECT 'DNI' as tipoDocumento
	UNION SELECT 'CI' as tipoDocumento
	UNION SELECT 'LC' as tipoDocumento
	UNION SELECT 'LE' as tipoDocumento;
GO


/****************************************************************************************************************/
/**FUNCIONES**/
/****************************************************************************************************************/

/**HISTORIA DE PLAN DE UN AFILIADO**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'HistorialDeAfiliado' AND xtype = 'IF')
	DROP FUNCTION WASD.HistorialDeAfiliado;
GO

CREATE FUNCTION "WASD".HistorialDeAfiliado (@afiliado INT) RETURNS TABLE
AS RETURN (
	SELECT *
	FROM WASD.HistorialPlan
	WHERE afiliado_id = @afiliado
);
GO

/**LISTADO DE PROFESIONALES POR ESPECIALIDAD**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ProfesionalesDeEspecialidad' AND xtype = 'IF')
	DROP FUNCTION WASD.ProfesionalesDeEspecialidad;
GO

CREATE FUNCTION "WASD".ProfesionalesDeEspecialidad (@especialidad INT) RETURNS TABLE
AS RETURN (
	SELECT 
		p.profesional_id, 
		p.profesional_apellido, 
		p.profesional_nombre
	FROM 
		WASD.Profesional p,
		WASD.EspecialidadPorProfesional e
	WHERE
		p.profesional_id = e.profesional_id AND
		e.especialidad_id = @especialidad
);
GO


/**PROFESIONALES POR USUARIO ID**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'ProfesionalDeUsuario' AND xtype = 'IF')
	DROP FUNCTION WASD.ProfesionalDeUsuario;
GO

CREATE FUNCTION "WASD".ProfesionalDeUsuario (@usuarioId INT) RETURNS TABLE
AS RETURN (
	SELECT 
		*
	FROM 
		WASD.Profesional
	WHERE
		usuario_id = @usuarioId
);
GO

/**LISTADO DE ESPECIALIDADES POR TIO DE ESPECIALIDAD**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'EspecialidadesDeTipo' AND xtype = 'IF')
	DROP FUNCTION WASD.EspecialidadesDeTipo;
GO

CREATE FUNCTION "WASD".EspecialidadesDeTipo(@tipoEspecialidad INT) RETURNS TABLE
AS RETURN (
	SELECT 
		*
	FROM 
		WASD.Especialidad
	WHERE 
	 	tipoespecialidad_id = @tipoEspecialidad
);
GO

/**LISTADO DE ESPECIALIDADES QUE TIENE UN PROFESIONAL**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'EspecialidadesDeProfesional' AND xtype = 'IF')
	DROP FUNCTION WASD.EspecialidadesDeProfesional;
GO

CREATE FUNCTION "WASD".EspecialidadesDeProfesional(@profesionalId INT) RETURNS TABLE
AS RETURN (
	SELECT 
		e.*
	FROM 
		WASD.Especialidad e,
		WASD.EspecialidadPorProfesional p
	WHERE 
		p.profesional_id = @profesionalId AND
		e.especialidad_id = p.especialidad_id
);
GO

/**LISTADO DE ROLES POR ID DE USUARIO**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'RolesDeUsuario' AND xtype = 'IF')
	DROP FUNCTION WASD.RolesDeUsuario;
GO

CREATE FUNCTION "WASD".RolesDeUsuario(@usuarioId INT) RETURNS TABLE
AS RETURN (
	SELECT 
		r.*,
		f.*
	FROM 
		WASD.Rol r,
		WASD.RolPorUsuario u, 
		WASD.FuncionalidadPorRol fr,
		WASD.Funcionalidad f
	WHERE 
		u.usuario_id = @usuarioId AND
		f.funcionalidad_id = fr.funcionalidad_id AND 
		r.rol_id = fr.rol_id AND
	 	r.rol_id = u.rol_id
);
GO

/**AFILIADO DADO UN TIPO DE DOCUMENTO Y SU RESPECTIVO NUMERO**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'AfiliadoBy' AND xtype = 'IF')
	DROP FUNCTION WASD.AfiliadoBy;
GO

CREATE FUNCTION "WASD".AfiliadoBy(@tipoDocumento CHAR(3), @nroDocumento INT) RETURNS TABLE
AS RETURN (
	SELECT 
		a.*
	FROM 
		WASD.Afiliado a
	WHERE 
		a.afiliado_tipodocumento = @tipoDocumento AND
	 	a.afiliado_numero_documento = @nroDocumento
);
GO

/**AFILIADO DADO UN ID DE USUARIO**/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'AfiliadoDeUsuario' AND xtype = 'IF')
	DROP FUNCTION WASD.AfiliadoDeUsuario;
GO

CREATE FUNCTION "WASD".AfiliadoDeUsuario(@usuarioId INT) RETURNS TABLE
AS RETURN (
	SELECT 
		a.*,
		e.estadocivil_nombre
	FROM 
		WASD.Afiliado a,
		WASD.EstadoCivil e
	WHERE 
		a.usuario_id = @usuarioId AND
		a.estadocivil_id = e.estadocivil_id
);
GO

/**FECHAS DISPONIBLES DE UN PROFESIONAL EN UNA ESPECIALIDAD SEGUN SU AGENDA**/
IF OBJECT_ID(N'WASD.FechasDisponibles', N'TF') IS NOT NULL
	DROP FUNCTION "WASD".FechasDisponibles;
GO

CREATE FUNCTION "WASD".FechasDisponibles (@profesionalId INT, @especialidadId INT, @anio INT) RETURNS @retFechas TABLE (Fecha DATE NOT NULL)
AS BEGIN
	DECLARE @Date1 DATE, @Date2 DATE, @Fecha DATE;

	SELECT 
		@Date1 = agenda_fecha_desde, 
		@Date2 = agenda_fecha_hasta 
	FROM
		"WASD".Agenda
	WHERE 
		profesional_id = @profesionalId AND 
		especialidad_id = @especialidadId AND
		YEAR(agenda_fecha_desde) = @anio;
		
    DECLARE fechasCursor CURSOR FOR
	
	SELECT 
		DATEADD(DAY, number + 1, @Date1) 
	FROM 
		master..spt_values
	WHERE 
		type = 'P' AND 
		DATEADD(DAY, number + 1, @Date1) <= @Date2;

	OPEN fechasCursor

	FETCH FROM fechasCursor INTO @Fecha
	
	WHILE @@FETCH_STATUS = 0
	
	BEGIN
		if (DATEPART(dw, @Fecha) IN (SELECT 
										CASE RTRIM(agenda_dia) 
										WHEN 'LUNES' THEN 2
										WHEN 'MARTES' THEN 3
										WHEN 'MIERCOLES' THEN 4
										WHEN 'JUEVES' THEN 5
										WHEN 'VIERNES' THEN 6
										WHEN 'SABADO' THEN 7
										END
									FROM 
										"WASD".Agenda
									WHERE
										YEAR(agenda_fecha_desde) = @anio AND
										profesional_id = @profesionalId AND 
										especialidad_id = @especialidadId))
			INSERT INTO @retFechas VALUES (@Fecha)
		
		FETCH NEXT FROM fechasCursor INTO @Fecha
	END

	CLOSE fechasCursor
	
	DEALLOCATE fechasCursor;
	
	RETURN; 
END;
GO

/**BONOS DISPONIBLES PARA USAR DE UN AFILIADO Y SU GRUPO FAMILIAR**/
IF EXISTS (SELECT * FROM sysobjects WHERE id = object_id(N'WASD.BonosNroAfiliado') AND xtype IN (N'FN', N'IF', N'TF')) 
	DROP FUNCTION "WASD".BonosNroAfiliado
GO

CREATE FUNCTION "WASD".BonosNroAfiliado (@nroAfiliado INT) RETURNS TABLE 
AS RETURN 
	SELECT 
		b.bono_id 
	FROM 
		"WASD".Bono b,
		"WASD".Afiliado a
	WHERE 
		b.bono_afiliado_usado IS NULL AND
		b.afiliado_id = a.afiliado_id AND
		CAST(ROUND(a.afiliado_numero / 100, 0, 1) AS INT) = CAST(ROUND(@nroAfiliado / 100, 0, 1) AS INT) AND
		a.planmedico_id = b.planmedico_id AND
		b.planmedico_id = (select planmedico_id from WASD.Afiliado WHERE afiliado_numero = @nroAfiliado);
GO

/**LISTA DE TURNOS DEL DIA DE UN PROFESIONAL FILTRADO POR ESPECIALIDAD PARA EL REGISTRO DE LLEGADA**/
IF EXISTS (SELECT type_desc, type FROM sys.all_objects WITH(NOLOCK) WHERE NAME = 'TurnosProfesionalEspecialidad' AND type = 'IF')
	DROP FUNCTION WASD.TurnosProfesionalEspecialidad;
GO

CREATE FUNCTION "WASD".TurnosProfesionalEspecialidad (@profesionalId INT, @especialidadId INT, @fecha VARCHAR(10)) RETURNS TABLE 
AS RETURN 
	SELECT
		t.turno_id,
		t.turnocancelado_id, 
		t.turno_hora, 
		t.turno_llego, 
		a.afiliado_nombre, 
		a.afiliado_apellido, 
		a.afiliado_numero, 
		e.especialidad_nombre,
		p.profesional_nombre,
		p.profesional_apellido
	FROM
		"WASD".Turno t, 
		"WASD".Afiliado a, 
		"WASD".Especialidad e,
		"WASD".Profesional p
	WHERE
		t.especialidad_id = e.especialidad_id AND
		p.profesional_id = t.profesional_id AND
		t.afiliado_id = a.afiliado_id AND
		t.profesional_id = @profesionalId AND
		t.especialidad_id = @especialidadId AND
		t.turno_fecha = CONVERT(DATE, @fecha, 103);
GO

/**LISTA DE TURNOS DEL DIA DE UN PROFESIONAL FILTRADO POR NOMBRE**/
IF EXISTS (SELECT type_desc, type FROM sys.all_objects WITH(NOLOCK) WHERE NAME = 'TurnosProfesionalNombre' AND type = 'IF')
	DROP FUNCTION WASD.TurnosProfesionalNombre;
GO

CREATE FUNCTION "WASD".TurnosProfesionalNombre (@nombreProfesional VARCHAR(51), @fecha VARCHAR(10)) RETURNS TABLE 
AS RETURN 
	SELECT
		t.turno_id,
		t.turnocancelado_id, 
		t.turno_hora, 
		t.turno_llego, 
		a.afiliado_nombre, 
		a.afiliado_apellido, 
		a.afiliado_numero, 
		e.especialidad_nombre,
		p.profesional_nombre,
		p.profesional_apellido
	FROM
		"WASD".Turno t, 
		"WASD".Afiliado a, 
		"WASD".Especialidad e,
		"WASD".Profesional p
	WHERE
		t.especialidad_id = e.especialidad_id AND
		p.profesional_id = t.profesional_id AND
		t.afiliado_id = a.afiliado_id AND
		p.profesional_nombre + ' ' + p.profesional_apellido LIKE '%' + @nombreProfesional + '%' AND
		t.turno_fecha = CONVERT(DATE, @fecha, 103);
GO

/**LISTA DE TURNOS DE UN AFILIADO PARA PODER CANCELARLAS**/
IF EXISTS (SELECT type_desc, type FROM sys.all_objects WITH(NOLOCK) WHERE NAME = 'TurnosAfiliado' AND type = 'IF')
	DROP FUNCTION WASD.TurnosAfiliado;
GO

CREATE FUNCTION "WASD".TurnosAfiliado (@afiliadoId INT, @fecha VARCHAR(10)) RETURNS TABLE 
AS RETURN 
	SELECT
		t.turno_id, 
		t.turno_hora, 
		t.turno_llego, 
		t.turno_fecha,
		a.afiliado_nombre, 
		a.afiliado_apellido, 
		a.afiliado_numero, 
		e.especialidad_nombre,
		p.profesional_nombre,
		p.profesional_apellido
	FROM
		"WASD".Turno t, 
		"WASD".Afiliado a, 
		"WASD".Especialidad e,
		"WASD".Profesional p
	WHERE
		t.especialidad_id = e.especialidad_id AND
		p.profesional_id = t.profesional_id AND
		t.afiliado_id = a.afiliado_id AND
		t.afiliado_id = @afiliadoId AND
		t.turnocancelado_id IS NULL AND
		t.turno_fecha > CONVERT(DATE, @fecha, 103);
GO

/**LISTA DE TURNOS DE UN PROFESIONAL PARA PODER CANCELARLAS**/
IF EXISTS (SELECT type_desc, type FROM sys.all_objects WITH(NOLOCK) WHERE NAME = 'TurnosProfesionalParaCancelar' AND type = 'IF')
	DROP FUNCTION WASD.TurnosProfesionalParaCancelar;
GO

CREATE FUNCTION "WASD".TurnosProfesionalParaCancelar (@profesionalId INT, @fecha VARCHAR(10)) RETURNS TABLE 
AS RETURN 
	SELECT
		t.turno_id, 
		t.turno_hora, 
		t.turno_llego,
		t.turno_fecha, 
		a.afiliado_nombre, 
		a.afiliado_apellido, 
		a.afiliado_numero, 
		e.especialidad_nombre,
		p.profesional_nombre,
		p.profesional_apellido
	FROM
		"WASD".Turno t, 
		"WASD".Afiliado a, 
		"WASD".Especialidad e,
		"WASD".Profesional p
	WHERE
		t.especialidad_id = e.especialidad_id AND
		p.profesional_id = t.profesional_id AND
		t.afiliado_id = a.afiliado_id AND
		t.profesional_id = @profesionalId AND
		t.turnocancelado_id IS NULL AND
		t.turno_fecha > CONVERT(DATE, @fecha, 103);
GO

/**AGENDA DE UN PROFESIONAL**/
IF EXISTS (SELECT type_desc, type FROM sys.all_objects WITH(NOLOCK) WHERE NAME = 'AgendaProfesional' AND type = 'IF')
	DROP FUNCTION WASD.AgendaProfesional;
GO

CREATE FUNCTION "WASD".AgendaProfesional (@profesionalId INT) RETURNS TABLE 
AS RETURN 
	SELECT
		*
	FROM
		"WASD".Agenda 
	WHERE
		profesional_id = @profesionalId;
GO

/**CONSULTAS MEDICAS DE UN PROFESIONAL PARA EL DIA DE HOY**/
IF EXISTS (SELECT type_desc, type FROM sys.all_objects WITH(NOLOCK) WHERE NAME = 'ConsultasMedicasProfesional' AND type = 'IF')
	DROP FUNCTION WASD.ConsultasMedicasProfesional;
GO

CREATE FUNCTION "WASD".ConsultasMedicasProfesional (@profesionalId INT, @fecha VARCHAR(10)) RETURNS TABLE 
AS RETURN 
	SELECT
		c.consultamedica_id,
		a.afiliado_nombre,
		a.afiliado_apellido
	FROM
		"WASD".ConsultaMedica c, 
		"WASD".Turno t, 
		"WASD".Afiliado a
	WHERE
		t.turno_id = c.consultamedica_id AND
		t.profesional_id = @profesionalId AND
		t.afiliado_id = a.afiliado_id AND
		c.consultamedica_ocurrio IS NULL AND
		t.turno_fecha = CONVERT(DATE, @fecha, 103);
GO

/**PLAN MEDICO POR ID**/
IF EXISTS (SELECT type_desc, type FROM sys.all_objects WITH(NOLOCK) WHERE NAME = 'PlanMedicoBy' AND type = 'IF')
	DROP FUNCTION WASD.PlanMedicoBy;
GO

CREATE FUNCTION "WASD".PlanMedicoBy (@planmedicoId INT) RETURNS TABLE 
AS RETURN 
	SELECT
		*
	FROM
		"WASD".PlanMedico 
	WHERE
		planmedico_id = @planmedicoId;
GO

/**LISTA DE FUNCIONALIDADES POR ROL**/
IF EXISTS (SELECT type_desc, type FROM sys.all_objects WITH(NOLOCK) WHERE NAME = 'FuncionalidadesDeRol' AND type = 'IF')
	DROP FUNCTION WASD.FuncionalidadesDeRol;
GO

CREATE FUNCTION "WASD".FuncionalidadesDeRol (@rolId INT) RETURNS TABLE 
AS RETURN 
	SELECT
		f.*
	FROM
		WASD.Funcionalidad f,
		WASD.FuncionalidadPorRol r
	WHERE
		r.funcionalidad_id = f.funcionalidad_id AND
		r.rol_id = @rolId;
GO

/****************************************************************************************************************/
/**PROCEDURES**/
/****************************************************************************************************************/

/**Login**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'Login' AND type = 'P')
DROP PROCEDURE WASD.Login;
GO

CREATE PROCEDURE "WASD".Login @username VARCHAR(10), @password VARCHAR(64)
AS
BEGIN
	DECLARE @hashedPassword VARCHAR(64), @usuarioId INT, @intentos TINYINT, @usuarioActivo BIT, @retMessage VARCHAR(30), @nombreAMostrar VARCHAR(101);
	
	SELECT @hashedPassword = SUBSTRING(master.dbo.fn_varbintohexstr(HASHBYTES('SHA2_256', @password)), 3, 64);
	
	SELECT 
		@usuarioId = usuario_id,
		@intentos = usuario_intentos, 
		@usuarioActivo = usuario_activo,
		@nombreAMostrar = usuario_nombre_a_mostrar
	FROM 
		WASD.Usuario
	WHERE 
	 	usuario_nombre = @username AND
	 	usuario_password = @hashedPassword;

	IF (@usuarioId IS NULL)

		SELECT
			@usuarioActivo = usuario_activo,
			@intentos = usuario_intentos
		FROM 
			WASD.Usuario
		WHERE
			usuario_nombre = @username;

	IF (@usuarioId IS NOT NULL) BEGIN

		IF (@usuarioActivo = 0)
			SET @retMessage = 'USUARIO INACTIVO';

		ELSE BEGIN
			SET @retMessage = 'BIENVENIDO ' + @nombreAMostrar;

			UPDATE 
				WASD.Usuario
			SET
				usuario_intentos = 0
			WHERE
				usuario_nombre = @username;

		END
	END
	ELSE BEGIN
			
		IF (@intentos < 2) BEGIN
			SET @retMessage = 'INCORRECTO';

			UPDATE 
				WASD.Usuario
			SET
				usuario_intentos = usuario_intentos + 1
			WHERE
				usuario_nombre = @username;

		END
		
		IF (@intentos = 2) BEGIN
			SET @retMessage = '3 INTENTOS, INACTIVO';
			UPDATE 
				WASD.Usuario
			SET
				usuario_activo = 0,
				usuario_intentos = usuario_intentos + 1
			WHERE
				usuario_nombre = @username;
		END
		
		IF (@usuarioActivo = 0)
			SET @retMessage = 'USUARIO INACTIVO';

	END

	SELECT 
		@usuarioId as usuario_id,
		@retMessage as message;

END;
GO
/**COMPRA DE BONOS**/
IF EXISTS (SELECT type_desc, type FROM sys.all_objects WITH(NOLOCK) WHERE NAME = 'CompraBono' AND type = 'P')
	DROP PROCEDURE WASD.CompraBono;
GO

CREATE PROCEDURE "WASD".CompraBono @afiliadoId INT, @cant INT, @planMedicoId INT, @fecha DATETIME
AS
BEGIN
	DECLARE @monto MONEY;
	DECLARE @compra_id INT
	DECLARE @intFlag INT = 1;
	DECLARE @planActual INT;
	DECLARE @msg VARCHAR(50);
	DECLARE @status INT;

	SELECT
		@planActual = planmedico_id
	FROM 
		WASD.Afiliado
	WHERE 
		afiliado_id = @afiliadoId;

	IF (@planActual = @planmedicoId) BEGIN

		SELECT 
			@monto = planmedico_precio_bono * @cant
	    FROM 
	    	"WASD".PlanMedico
	    WHERE 
	    	planmedico_id = @planMedicoId; 

		INSERT INTO 
			"WASD".Compra (afiliado_id, compra_fecha_hora, compra_cantidad, compra_monto)
	    VALUES 
	    	(@afiliadoId, @fecha, @cant, @monto);

	    SET @compra_id = (SELECT SCOPE_IDENTITY())
		
		WHILE (@intFlag <= @cant)
		BEGIN
		
			INSERT INTO 
				"WASD".Bono(planmedico_id, afiliado_id, compra_id, bono_afiliado_usado)
			VALUES
				(@planMedicoId, @afiliadoId, @compra_id, NULL);
			
			SET @intFlag = @intFlag + 1
		END

		SET @msg = 'Se ha comprado ' + CAST(@cant AS VARCHAR) + ' bonos a ' + CAST(@monto AS VARCHAR) + ' cada uno'; 
		SET @status = 0;
		
	END
	ELSE BEGIN
		SET @msg = 'El plan ha cambiado, intente nuevamente'; 
		SET @status = 1;
	END
	SELECT 
		@msg as errorMessage,
		@status as status;
END;
GO

/**REGISTRO DE LLEGADA, USO DE BONO, CREACION DE CONSULTA MEDICA**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'RegistroLlegada' AND type = 'P')
DROP PROCEDURE WASD.RegistroLlegada;
GO

CREATE PROCEDURE "WASD".RegistroLlegada @turnoId INT, @bonoId INT, @fechaActual DATETIME
AS
BEGIN
	DECLARE @afiliadoId INT;

	SELECT 
		@afiliadoId = afiliado_id
	FROM 
		WASD.Turno
	WHERE 
		turno_id = @turnoId;

	UPDATE 
		WASD.Turno
	SET
		turno_llego = 1,
		turno_fecha = @fechaActual --aca estoy pisando la fecha que tenia el turno (que era solo la parte de Date) con el mismo Date (por logica) y la hora actual para indicar la llegada)
	WHERE
		turno_id = @turnoId;

	UPDATE 
		WASD.Bono
	SET
		bono_afiliado_usado = @afiliadoId
	WHERE
		bono_id = @bonoId;

	INSERT INTO 
		WASD.ConsultaMedica (consultamedica_id,	bono_id, consultamedica_fecha_hora, consultamedica_ocurrio)
	VALUES
		(@turnoId, @bonoId, NULL, NULL);
END;
GO

/**OCURRIO CONSULTA MEDICA**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'ConsultaMedicaOcurrio' AND type = 'P')
DROP PROCEDURE WASD.ConsultaMedicaOcurrio;
GO

CREATE PROCEDURE "WASD".ConsultaMedicaOcurrio @consultaMedicaId INT, @fechaYHora DATETIME
AS
BEGIN
	UPDATE 
		WASD.ConsultaMedica
	SET
		consultamedica_ocurrio = 1,
		consultamedica_fecha_hora = @fechaYHora
	WHERE
		consultamedica_id = @consultaMedicaId;
END;
GO

/**BAJA LOGICA DE UN ROL**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'BajaRol' AND type = 'P')
DROP PROCEDURE WASD.BajaRol;
GO

CREATE PROCEDURE "WASD".BajaRol @rolId INT
AS
BEGIN
	UPDATE 
		WASD.Rol
	SET
		rol_activo = 0
	WHERE
		rol_id = @rolId;
END;
GO

/**BAJA LOGICA DE UN AFILIADO**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'BajaAfiliado' AND type = 'P')
DROP PROCEDURE WASD.BajaAfiliado;
GO

CREATE PROCEDURE "WASD".BajaAfiliado @afiliadoId INT, @fecha DATETIME
AS
BEGIN
	UPDATE 
		WASD.Afiliado
	SET
		afiliado_activo = 0,
		afiliado_fecha_baja = @fecha
	WHERE
		afiliado_id = @afiliadoId;
END;
GO

/**CANCELAR TURNO**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'CancelarTurno' AND type = 'P')
DROP PROCEDURE WASD.CancelarTurno;
GO

CREATE PROCEDURE "WASD".CancelarTurno @canceladoPor CHAR(1), @turnoId INT, @tipoCancelacionId INT, @descripcion VARCHAR(50)
AS
BEGIN
	DECLARE @lastInsertedId INT, @turnoCanceladoId INT, @msg VARCHAR(50), @status INT;

	SELECT
		@turnoCanceladoId = turnocancelado_id
	FROM
		WASD.Turno
	WHERE
		turno_id = @turnoId;

	IF (@turnoCanceladoId IS NULL) BEGIN

		INSERT INTO
			WASD.TurnoCancelado (
				turnocancelado_tipocancelacion_id,
				turnocancelado_descripcion,
				turnocancelado_cancelado_por
			)
		VALUES (
			@tipoCancelacionId,
			@descripcion,
			@canceladoPor	
		);

		SELECT @lastInsertedId = SCOPE_IDENTITY();

		UPDATE 
			WASD.Turno
		SET
			turnocancelado_id = @lastInsertedId
		WHERE
			turno_id = @turnoId;

		SET @msg = 'El turno se cancelo exitosamente';
		SET @status = 0;

	END
	ELSE BEGIN
		
		SET @status = 1;
		SET @msg = 'El turno ya se habia cancelado';
		SET @lastInsertedId = 0;

	END

	SELECT
        @status AS status,
        @lastInsertedId AS scopeIdentity,
        @msg AS errorMessage;

END;
GO

/**CANCELAR TURNO POR RANGO DE FECHAS**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'CancelarTurnoRango' AND type = 'P')
DROP PROCEDURE WASD.CancelarTurnoRango;
GO

CREATE PROCEDURE "WASD".CancelarTurnoRango @profesionalId INT, @fechaDesde DATE, @fechaHasta DATE, @tipoCancelacionId INT, @descripcion VARCHAR(50)
AS
BEGIN
	DECLARE @lastInsertedId INT;

	INSERT INTO
		WASD.TurnoCancelado (
			turnocancelado_tipocancelacion_id,
			turnocancelado_descripcion,
			turnocancelado_cancelado_por
		)
	VALUES (
		@tipoCancelacionId,
		@descripcion,
		'P'	
	);

	SELECT @lastInsertedId = SCOPE_IDENTITY();
	
	UPDATE 
		WASD.Turno
	SET
		turnocancelado_id = @lastInsertedId
	WHERE
		profesional_id = @profesionalId AND
		turno_fecha BETWEEN @fechaDesde AND @fechaHasta;
END;
GO

/**MODIFICAR AFILIADO**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'UpdateAfiliado' AND type = 'P')
DROP PROCEDURE WASD.UpdateAfiliado;
GO

CREATE PROCEDURE "WASD".UpdateAfiliado @afiliadoId INT, @direccion VARCHAR(100), @telefono INT, @mail VARCHAR(50), @estadoCivil INT, @planMedico INT, @motivo VARCHAR(144), @fecha DATETIME
AS
BEGIN
	IF (@motivo IS NOT NULL)
		INSERT INTO 
			WASD.HistorialPlan(afiliado_id, historial_fecha, historial_motivo)
	    VALUES
	       (@afiliadoId
	       ,@fecha
	       ,@motivo);

	UPDATE 
		WASD.Afiliado
	SET
		afiliado_direccion = @direccion,
		afiliado_telefono = @telefono,
		afiliado_mail = @mail,
		estadocivil_id = @estadoCivil,
		planmedico_id = @planMedico
	WHERE
		afiliado_id = @afiliadoId;
END;
GO

/**ALTA AFILIADO**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'AltaAfiliado' AND type = 'P')
DROP PROCEDURE WASD.AltaAfiliado;
GO

CREATE PROCEDURE "WASD".AltaAfiliado 
	@estadocivil_id INT, 
	@afiliado_tipodocumento CHAR(3),
	@planmedico_id INT ,
	@afiliado_sexo CHAR(1),
	@afiliado_numero INT,
	@afiliado_nombre VARCHAR(50),
	@afiliado_apellido VARCHAR(50),
	@afiliado_numero_documento INT,
	@afiliado_direccion VARCHAR(100),
	@afiliado_telefono INT,
	@afiliado_mail VARCHAR(50),
	@afiliado_fecha_nacimiento DATE,
	@afiliado_familiares_dependientes TINYINT,
	@afiliado_grupo_familiar INT
AS
BEGIN
	DECLARE @userId INT, @ultimoNumero INT;

	SELECT TOP 1
		@ultimoNumero = (FLOOR(afiliado_numero / 100)) * 100
	FROM
		WASD.Afiliado
	ORDER BY
		afiliado_numero DESC;

	IF (@afiliado_grupo_familiar IS NULL)
		SET @ultimoNumero = @ultimoNumero + 100;

	BEGIN TRY

	    BEGIN TRANSACTION ALTAAFILIADO

			INSERT INTO 
				"WASD".Usuario(usuario_nombre, usuario_password, usuario_intentos, usuario_activo, usuario_nombre_a_mostrar) 
			VALUES
				(@afiliado_numero_documento, 
				'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 
				0, 
				1,
				@afiliado_apellido + ', ' + @afiliado_nombre);

			SET @userId = (SELECT SCOPE_IDENTITY())

			INSERT INTO "WASD".RolPorUsuario VALUES
			(@userId, 2);
			
			INSERT INTO 
				"WASD".Afiliado(usuario_id, 
								estadocivil_id, 
								afiliado_tipodocumento, 
								planmedico_id, 
								afiliado_sexo, 
								afiliado_numero, 
								afiliado_nombre, 
								afiliado_apellido, 
								afiliado_numero_documento, 
								afiliado_direccion, 
								afiliado_telefono, 
								afiliado_mail, 
								afiliado_fecha_nacimiento, 
								afiliado_familiares_dependientes, 
								afiliado_activo, 
								afiliado_grupo_familiar, 
								afiliado_cantidad_bonos_usados, 
								afiliado_fecha_baja)
		    VALUES
		    	(@userId,
		    	@estadocivil_id,
				@afiliado_tipodocumento,
				@planmedico_id,
				@afiliado_sexo,
				@ultimoNumero + @afiliado_numero,
				@afiliado_nombre,
				@afiliado_apellido,
				@afiliado_numero_documento,
				@afiliado_direccion,
				@afiliado_telefono,
				@afiliado_mail,
				@afiliado_fecha_nacimiento,
				@afiliado_familiares_dependientes,
				1,
				@afiliado_grupo_familiar,
				0,
				NULL);

		    SET @userId = SCOPE_IDENTITY();
			SELECT 
				0 AS status,
				'' AS errorMessage,
				@userId AS scopeIdentity;

    	COMMIT TRANSACTION ALTAAFILIADO
	END TRY

	BEGIN CATCH 

	    IF (@afiliado_grupo_familiar IS NOT NULL)
	    BEGIN
	    	DELETE FROM
				WASD.Afiliado
			WHERE 
				afiliado_grupo_familiar = @afiliado_grupo_familiar;

			DELETE FROM
				WASD.Afiliado
			WHERE
				afiliado_id = @afiliado_grupo_familiar;

			DELETE FROM 
				WASD.RolPorUsuario 
			WHERE
				usuario_id NOT IN (SELECT usuario_id FROM WASD.Afiliado UNION SELECT usuario_id FROM WASD.Profesional UNION SELECT usuario_id FROM WASD.RolPorUsuario WHERE rol_id = 1) AND
				rol_id = 2;

			DELETE FROM 
				WASD.Usuario 
			WHERE
				usuario_id NOT IN (SELECT usuario_id FROM WASD.Afiliado UNION SELECT usuario_id FROM WASD.Profesional UNION SELECT usuario_id FROM WASD.RolPorUsuario WHERE rol_id = 1);

	    	COMMIT TRANSACTION ALTAAFILIADO

		END
		ELSE 
			ROLLBACK TRANSACTION ALTAAFILIADO	

	    SELECT
	        1 AS status,
	        0 AS scopeIdentity,
	        ERROR_MESSAGE() AS errorMessage;

	END CATCH
END;
GO

/**PEDIR TURNO**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'PedirTurno' AND type = 'P')
DROP PROCEDURE WASD.PedirTurno;
GO

CREATE PROCEDURE "WASD".PedirTurno 
	@afiliadoId INT,
	@especialidadId INT,
	@profesionalId INT,
	@fecha DATE,
	@hora TIME
AS
BEGIN
	DECLARE @turnoId INT, @status INT, @msg VARCHAR(50);
	
	SELECT
		@turnoId = turno_id
	FROM
		WASD.Turno
	WHERE
		turnocancelado_id IS NULL AND
		especialidad_id = @especialidadId AND
		profesional_id = @profesionalId AND
		CAST(turno_fecha AS DATE) = CAST(@fecha AS DATE) AND
		CAST(turno_hora AS TIME) = CAST(@hora AS TIME);

	IF (@turnoId IS NULL) BEGIN
		INSERT INTO
			WASD.Turno (afiliado_id, profesional_id, especialidad_id, turnocancelado_id, turno_fecha, turno_hora, turno_llego) 
		VALUES
			(@afiliadoId, @profesionalId, @especialidadId, NULL, @fecha, @hora, 0);

		SET @msg = 'Se reservo el turno exitosamente';
		SET @status = 0;
		SET @turnoId = SCOPE_IDENTITY();
	END
	ELSE BEGIN
		SET @msg = 'No se puede reservar turno para esa hora, seleccione otra';
		SET @status = 1;
		SET @turnoId = 0;
	END

	SELECT
        @status AS status,
        @turnoId AS scopeIdentity,
        @msg AS errorMessage;
END;
GO

/**BAJA LOGICA AFILIADO**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'DeleteAfiliado' AND type = 'P')
DROP PROCEDURE WASD.DeleteAfiliado;
GO

CREATE PROCEDURE "WASD".DeleteAfiliado @afiliadoId INT, @fecha DATETIME
AS
BEGIN
	UPDATE 
		WASD.Afiliado
	SET
		afiliado_activo = 0,
		afiliado_fecha_baja = @fecha
	WHERE
		afiliado_numero = @afiliadoId;
END;
GO

/**HORAS DISPONIBLES DADA UNA FECHA DISPONIBLE **/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'HorasDisponibles' AND type = 'P')
     DROP PROCEDURE WASD.HorasDisponibles;
GO

CREATE PROCEDURE "WASD".HorasDisponibles (@profesionalId INT, @especialidadId INT, @fechaStr VARCHAR(10))
AS BEGIN
	SET LANGUAGE Spanish

	DECLARE @desde INT, @hasta INT, @hora INT;
	DECLARE @fecha DATE = CONVERT(DATE, @fechaStr, 103);
	DECLARE @horaDesde TIME, @horaHasta TIME;
	
	SELECT 
		@desde = agenda_hora_desde, 
		@hasta = agenda_hora_hasta 
	FROM 
		"WASD".Agenda
	WHERE 
		profesional_id = @profesionalId AND 
		especialidad_id = @especialidadId AND
		@fecha BETWEEN agenda_fecha_desde AND agenda_fecha_hasta AND
		UPPER(DATEPART(dw, @fecha)) = (CASE RTRIM(agenda_dia) 
										WHEN 'LUNES' THEN 1
										WHEN 'MARTES' THEN 2
										WHEN 'MIERCOLES' THEN 3
										WHEN 'JUEVES' THEN 4
										WHEN 'VIERNES' THEN 5
										WHEN 'SABADO' THEN 6
										END);

	SELECT
		@horaDesde = hora_comienzo
	FROM 
		"WASD".Hora
	WHERE hora_id = @desde;

	SELECT
		@horaHasta = hora_comienzo
	FROM 
		"WASD".Hora
	WHERE hora_id = @hasta;
		
	WITH gen AS (
		SELECT @desde AS num
		UNION ALL
		SELECT num + 1 FROM gen WHERE num + 1 <= @hasta
	)
	SELECT 
		* 
	FROM 
		gen
	WHERE 
		num NOT IN (SELECT 
						hora_id
					FROM 
						"WASD".Hora
					WHERE hora_comienzo IN (SELECT 
												turno_hora
											FROM 
												"WASD".Turno 
											WHERE 
												turno_hora BETWEEN @horaDesde AND @horaHasta AND
												profesional_id = @profesionalId AND
												especialidad_id = @especialidadId AND
												turno_fecha = @fecha AND
												turnocancelado_id IS NULL)
					);
END;
GO

/**AGREGAR DIAGNOSTICO POST-CONSULTA**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'SP_AgregarDiagnostico' AND type = 'P')
DROP PROCEDURE WASD.SP_AgregarDiagnostico;
GO

CREATE PROCEDURE "WASD".SP_AgregarDiagnostico @consultamedica INT, @descripcion VARCHAR(255)
AS BEGIN
	INSERT INTO "WASD".Diagnostico(consultamedica_id, diagnostico_descripcion) VALUES (@consultamedica, @descripcion)
END;
GO

/**AGREGAR SINTOMAS POST-CONSULTA**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'SP_AgregarSintoma' AND type = 'P')
DROP PROCEDURE WASD.SP_AgregarSintoma;
GO

CREATE PROCEDURE "WASD".SP_AgregarSintoma @consultamedica INT, @descripcion VARCHAR(255)
AS BEGIN
	INSERT INTO "WASD".Sintoma(consultamedica_id, sintoma_descripcion) VALUES (@consultamedica, @descripcion)
END;
GO

/**ALTA DE FUNCIONALIDAD POR ROL**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'SP_AgregarFuncionalidadPorRol' AND type = 'P')
DROP PROCEDURE WASD.SP_AgregarFuncionalidadPorRol;
GO

CREATE PROCEDURE "WASD".SP_AgregarFuncionalidadPorRol @rol INT, @funcionalidad INT
AS BEGIN
	INSERT INTO "WASD".FuncionalidadPorRol(rol_id, funcionalidad_id) VALUES (@rol, @funcionalidad)
END;
GO

/**ALTA DE ROL**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'SP_AgregarRol' AND type = 'P')
DROP PROCEDURE WASD.SP_AgregarRol;
GO

CREATE PROCEDURE "WASD".SP_AgregarRol @nombre CHAR(15), @rolid INT OUTPUT
AS BEGIN
	INSERT INTO "WASD".Rol(rol_nombre, rol_activo) VALUES (@nombre, 1)
	SET @rolid = (SELECT SCOPE_IDENTITY())
	RETURN
END;
GO

/**CARGAR AGENDA DE UN PROFESIONAL**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'SP_CargarAgenda' AND type = 'P')
DROP PROCEDURE WASD.SP_CargarAgenda;
GO

CREATE PROCEDURE "WASD".SP_CargarAgenda @dia CHAR(9), @espid INT, @fdesde DATE, @fhasta DATE,
@hdesde INT, @hhasta INT, @profid INT
AS BEGIN
	INSERT INTO "WASD".Agenda(profesional_id, especialidad_id, agenda_dia, agenda_hora_desde, agenda_hora_hasta,
	agenda_fecha_desde, agenda_fecha_hasta)
	VALUES (@profid, @espid, @dia, @hdesde, @hhasta, @fdesde, @fhasta)
END;
GO

/**CARGA DE FUNCIONALIDAD POR ROL**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'SP_CargarFuncPorRol' AND type = 'P')
DROP PROCEDURE WASD.SP_CargarFuncPorRol;
GO

CREATE PROCEDURE "WASD".SP_CargarFuncPorRol @rolid INT, @funcid INT
AS BEGIN
	INSERT INTO "WASD".FuncionalidadPorRol
	VALUES (@rolid, @funcid)
END;
GO

/**MODIFICACION DE UN ROL EXISTENTE**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'SP_ModificarRol' AND type = 'P')
DROP PROCEDURE WASD.SP_ModificarRol;
GO

CREATE PROCEDURE "WASD".SP_ModificarRol @rolid INT, @nombre CHAR(15)
AS BEGIN
	
	BEGIN TRY

		BEGIN TRANSACTION MODIFICARROL
			UPDATE "WASD".Rol
			SET rol_nombre = @nombre
			WHERE rol_id = @rolid;
		COMMIT TRANSACTION MODIFICARROL

		SELECT
	        0 AS status,
	        ERROR_MESSAGE() AS errorMessage;

	END TRY
	
	BEGIN CATCH
		IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION MODIFICARROL
		
		SELECT
	        1 AS status,
	        ERROR_MESSAGE() AS errorMessage;
	END CATCH
END;
GO

/**ALTA DE UN NUEVO ROL**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'SP_AgregarRol' AND type = 'P')
DROP PROCEDURE WASD.SP_AgregarRol;
GO

CREATE PROCEDURE "WASD".SP_AgregarRol @nombre CHAR(15)
AS BEGIN
	BEGIN TRY

		BEGIN TRANSACTION ALTAROL
			INSERT INTO "WASD".Rol(rol_nombre, rol_activo)
			VALUES (@nombre, 1)
		COMMIT TRANSACTION ALTAROL

		SELECT
	        0 AS status,
	        CAST(SCOPE_IDENTITY() AS INT) AS scopeIdentity,
	        ERROR_MESSAGE() AS errorMessage;

	END TRY
	
	BEGIN CATCH
		IF (@@TRANCOUNT > 0) ROLLBACK TRANSACTION ALTAROL
		
		SELECT
	        1 AS status,
	        0 AS scopeIdentity,
	        ERROR_MESSAGE() AS errorMessage;
	END CATCH
END;
GO

/**ALTA DE UN NUEVO ROL**/
IF EXISTS (SELECT type_desc, type FROM sys.procedures WITH(NOLOCK) WHERE NAME = 'QuitarFuncionalidades' AND type = 'P')
DROP PROCEDURE WASD.QuitarFuncionalidades;
GO

CREATE PROCEDURE "WASD".QuitarFuncionalidades @rolId INT
AS BEGIN
	DELETE FROM 
		WASD.FuncionalidadPorRol 
	WHERE 
		rol_id = @rolId
END;
GO

/****************************************************************************************************************/
/**TRIGGERS**/
/****************************************************************************************************************/

/**TRIGGER DEL BORRADO LOGICO DE UN ROL**/
IF EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[WASD].[RolDeleted]'))
DROP TRIGGER [WASD].[RolDeleted];
GO

CREATE TRIGGER "WASD".RolDeleted ON "WASD".Rol FOR UPDATE
AS BEGIN
	DECLARE @rol INT
	DECLARE @activo BIT 
	
	SELECT 
		@rol = inserted.rol_id, 
		@activo = inserted.rol_activo 
	FROM 
		inserted;

	IF (@activo = 0)
	
		DELETE 
			"WASD".RolPorUsuario 
		WHERE 
			rol_id = @rol
    
END;
GO

/**TRIGGER DEL BORRADO LOGICO DE UN AFILIADO**/
IF EXISTS (SELECT * FROM sys.triggers WHERE object_id = OBJECT_ID(N'[WASD].[AfiliadoDeleted]'))
DROP TRIGGER [WASD].[AfiliadoDeleted];
GO

CREATE TRIGGER "WASD".AfiliadoDeleted ON "WASD".Afiliado FOR UPDATE
AS BEGIN
	DECLARE @afiliadoId INT
	DECLARE @activo BIT 
	DECLARE @fecha DATETIME
	DECLARE @cancelacion INT
	
	SELECT 
		@afiliadoId = inserted.afiliado_id, 
		@activo = inserted.afiliado_activo,
		@fecha = inserted.afiliado_fecha_baja 
	FROM 
		inserted;

	IF (@activo = 0)
	BEGIN
		INSERT INTO
			"WASD".TurnoCancelado(turnocancelado_tipocancelacion_id, turnocancelado_descripcion, turnocancelado_cancelado_por)
		VALUES
			(4, 'Afiliado fue dado de baja', 'A')
		
		SET @cancelacion = (SELECT SCOPE_IDENTITY())
	
		UPDATE 
			"WASD".Turno
		SET
			turnocancelado_id = @cancelacion
		WHERE
			afiliado_id = @afiliadoId AND
			turno_fecha >= @fecha AND
			turno_llego = 0
    END;
END;
GO


/****************************************************************************************************************/
/**LISTADOS ESTADISTICOS**/
/****************************************************************************************************************/
/*Top 5 de las especialidades que más se registraron cancelaciones, tanto de afiliados como de profesionales.*/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'SP_ListadoEstadistico1' AND xtype = 'P')
	DROP PROCEDURE WASD.SP_ListadoEstadistico1;
GO

CREATE PROCEDURE "WASD".SP_ListadoEstadistico1(@fecha_desde DATE, @fecha_hasta DATE, @tipo_cancelacion VARCHAR)
AS
	WITH grupo AS (
		SELECT MONTH(t.turno_fecha) mes, e.especialidad_nombre especialidad, COUNT(*) cancelaciones
		FROM WASD.Especialidad e, WASD.Turno t, WASD.TurnoCancelado c
		WHERE t.turnocancelado_id = c.turnocancelado_id
		AND e.especialidad_id = t.especialidad_id
		AND @fecha_desde <= t.turno_fecha
		AND @fecha_hasta >= t.turno_fecha
		AND c.turnocancelado_cancelado_por LIKE '%' + @tipo_cancelacion + '%'
		GROUP BY MONTH(t.turno_fecha), e.especialidad_id, e.especialidad_nombre
	)

	SELECT mes, especialidad, cancelaciones
	FROM (
		SELECT *, ROW_NUMBER() OVER (PARTITION BY mes ORDER BY cancelaciones DESC) posicion
		FROM grupo
	) tabla
	WHERE posicion <= 5
	ORDER BY mes, posicion;
GO

/*Top 5 de los profesionales más consultados por Plan, detallando también bajo que Especialidad.*/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'SP_ListadoEstadistico2' AND xtype = 'P')
	DROP PROCEDURE WASD.SP_ListadoEstadistico2;
GO

CREATE PROCEDURE "WASD".SP_ListadoEstadistico2(@fecha_desde DATE, @fecha_hasta DATE, @plan INT)
AS
	WITH grupo AS (
		SELECT MONTH(c.consultamedica_fecha_hora) mes, p.profesional_apellido, p.profesional_nombre, e.especialidad_nombre,
			pm.planmedico_nombre, COUNT(*) consultas
		FROM WASD.ConsultaMedica c, WASD.Turno t, WASD.Bono b, WASD.Profesional p, WASD.PlanMedico pm, WASD.Especialidad e
		WHERE c.consultamedica_id = t.turno_id
		AND c.bono_id = b.bono_id
		AND t.profesional_id = p.profesional_id
		AND b.planmedico_id = pm.planmedico_id
		AND t.especialidad_id = e.especialidad_id
		AND @fecha_desde <= c.consultamedica_fecha_hora
		AND @fecha_hasta >= c.consultamedica_fecha_hora
		AND pm.planmedico_id = @plan
		GROUP BY MONTH(c.consultamedica_fecha_hora), p.profesional_apellido, p.profesional_nombre, e.especialidad_nombre,
			pm.planmedico_nombre
	)
	
	SELECT mes, profesional_apellido, profesional_nombre, especialidad_nombre, planmedico_nombre, consultas
	FROM (
		SELECT *, ROW_NUMBER() OVER (PARTITION BY mes ORDER BY consultas DESC) posicion
		FROM grupo
	) tabla
	WHERE posicion <= 5
	ORDER BY mes, posicion;
GO

/*Top 5 de los profesionales con menos horas trabajadas filtrando por Plan y Especialidad.*/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'SP_ListadoEstadistico3' AND xtype = 'P')
	DROP PROCEDURE WASD.SP_ListadoEstadistico3;
GO

CREATE PROCEDURE "WASD".SP_ListadoEstadistico3(@fecha_desde DATE, @fecha_hasta DATE, @plan INT, @especialidad INT)
AS
WITH grupo AS (
		SELECT MONTH(c.consultamedica_fecha_hora) mes, p.profesional_apellido, p.profesional_nombre, e.especialidad_nombre,
			pm.planmedico_nombre, COUNT(*) / 2.0 horas
		FROM WASD.ConsultaMedica c, WASD.Turno t, WASD.Bono b, WASD.Profesional p, WASD.PlanMedico pm, WASD.Especialidad e
		WHERE c.consultamedica_id = t.turno_id
		AND c.consultamedica_ocurrio = 1
		AND c.bono_id = b.bono_id
		AND t.profesional_id = p.profesional_id
		AND b.planmedico_id = pm.planmedico_id
		AND t.especialidad_id = @especialidad
		AND t.especialidad_id = e.especialidad_id
		AND @fecha_desde <= c.consultamedica_fecha_hora
		AND @fecha_hasta >= c.consultamedica_fecha_hora
		AND pm.planmedico_id = @plan
		GROUP BY MONTH(c.consultamedica_fecha_hora), p.profesional_apellido, p.profesional_nombre, e.especialidad_nombre,
			pm.planmedico_nombre
	)
	
	SELECT mes, profesional_apellido, profesional_nombre, especialidad_nombre, planmedico_nombre, horas
	FROM (
		SELECT *, ROW_NUMBER() OVER (PARTITION BY mes ORDER BY horas ASC) posicion
		FROM grupo
	) tabla
	WHERE posicion <= 5
	ORDER BY mes, posicion;
GO

/*Top 5 de los afiliados con mayor cantidad de bonos comprados, detallando si pertenece a un grupo familiar.*/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'SP_ListadoEstadistico4' AND xtype = 'P')
	DROP PROCEDURE WASD.SP_ListadoEstadistico4;
GO

CREATE PROCEDURE "WASD".SP_ListadoEstadistico4(@fecha_desde DATE, @fecha_hasta DATE)
AS
	WITH grupo AS (
		SELECT MONTH(c.compra_fecha_hora) mes, a.afiliado_numero, a.afiliado_apellido, a.afiliado_nombre,
		(SELECT CASE
			WHEN a.afiliado_grupo_familiar IS NULL THEN 'NO'
			ELSE 'SI'
			END
		) AS pertenece_a_grupo,
		SUM(c.compra_cantidad) cantidad
		FROM WASD.Compra c, WASD.Afiliado a
		WHERE a.afiliado_id = c.afiliado_id
		AND @fecha_desde <= c.compra_fecha_hora
		AND @fecha_hasta >= c.compra_fecha_hora
		GROUP BY MONTH(c.compra_fecha_hora), a.afiliado_numero, a.afiliado_apellido, a.afiliado_nombre,
		a.afiliado_grupo_familiar
	)

	SELECT mes, afiliado_numero, afiliado_apellido, afiliado_nombre, pertenece_a_grupo, cantidad
	FROM (
		SELECT *, ROW_NUMBER() OVER (partition BY mes ORDER BY cantidad DESC) posicion
		FROM grupo
	) tabla
	WHERE posicion <= 5
	ORDER BY mes, posicion;
GO

/*Top 5 de las especialidades de médicos con más bonos de consultas utilizados.*/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'SP_ListadoEstadistico5' AND xtype = 'P')
	DROP PROCEDURE WASD.SP_ListadoEstadistico5;
GO

CREATE PROCEDURE "WASD".SP_ListadoEstadistico5(@fecha_desde DATE, @fecha_hasta DATE)
AS
	WITH grupo AS (
		SELECT MONTH(t.turno_fecha) mes, e.especialidad_nombre,
		COUNT(*) cantidad
		FROM WASD.Turno t, WASD.Especialidad e
		WHERE t.especialidad_id = e.especialidad_id
		AND EXISTS(
			SELECT 1 FROM WASD.ConsultaMedica c
			WHERE c.consultamedica_id = t.turno_id
		)
		AND @fecha_desde <= t.turno_fecha
		AND @fecha_hasta >= t.turno_fecha
		GROUP BY MONTH(t.turno_fecha), e.especialidad_nombre
	)

	SELECT mes, especialidad_nombre, cantidad
	FROM (
		SELECT *, ROW_NUMBER() OVER (partition BY mes ORDER BY cantidad DESC) posicion
		FROM grupo
	) tabla
	WHERE posicion <= 5
	ORDER BY mes, posicion;
GO
