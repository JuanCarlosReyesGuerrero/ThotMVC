USE [master]
GO
/****** Object:  Database [QAcademico]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE DATABASE [QAcademico]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'InfoNotasNet', FILENAME = N'D:\BaseDatosSqlServer2014\MSSQL12.SQLEXPRESS\MSSQL\DATA\QAcademico.mdf' , SIZE = 11264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'InfoNotasNet_log', FILENAME = N'D:\BaseDatosSqlServer2014\MSSQL12.SQLEXPRESS\MSSQL\DATA\QAcademico_log.ldf' , SIZE = 52416KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QAcademico] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QAcademico].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QAcademico] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QAcademico] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QAcademico] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QAcademico] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QAcademico] SET ARITHABORT OFF 
GO
ALTER DATABASE [QAcademico] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QAcademico] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QAcademico] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QAcademico] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QAcademico] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QAcademico] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QAcademico] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QAcademico] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QAcademico] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QAcademico] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QAcademico] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QAcademico] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QAcademico] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QAcademico] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QAcademico] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QAcademico] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QAcademico] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QAcademico] SET RECOVERY FULL 
GO
ALTER DATABASE [QAcademico] SET  MULTI_USER 
GO
ALTER DATABASE [QAcademico] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QAcademico] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QAcademico] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QAcademico] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QAcademico] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QAcademico]
GO
/****** Object:  Table [dbo].[AporteParafiscal]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AporteParafiscal](
	[AporteParafiscalId] [bigint] IDENTITY(1,1) NOT NULL,
	[AporteParafiscalCodigo] [nvarchar](2) NOT NULL,
	[AporteParafiscalNombre] [nvarchar](100) NULL,
	[AporteParafiscalActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[AporteParafiscalUsuarioRegistra] [bigint] NULL,
	[AporteParafiscalFechaRegistro] [datetime] NULL,
	[AporteParafiscalUsuarioModifica] [bigint] NULL,
	[AporteParafiscalFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_APORTE_PARAFISCAL] PRIMARY KEY CLUSTERED 
(
	[AporteParafiscalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ars]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ars](
	[ArsId] [bigint] IDENTITY(1,1) NOT NULL,
	[ArsCodigo] [nvarchar](6) NOT NULL,
	[ArsNombre] [nvarchar](255) NULL,
	[ArsActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[ArsUsuarioRegistra] [bigint] NULL,
	[ArsFechaRegistro] [datetime] NULL,
	[ArsUsuarioModifica] [bigint] NULL,
	[ArsFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ARS] PRIMARY KEY CLUSTERED 
(
	[ArsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Asignatura]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignatura](
	[AsignaturaId] [bigint] IDENTITY(1,1) NOT NULL,
	[AsignaturaCodigo] [nvarchar](10) NOT NULL,
	[AsignaturaNombre] [nvarchar](255) NOT NULL,
	[SedeId] [bigint] NULL,
	[AsignaturaActivo] [bit] NULL,
	[AsignaturaUsuarioRegistra] [bigint] NULL,
	[AsignaturaFechaRegistro] [datetime] NULL,
	[AsignaturaUsuarioModifica] [bigint] NULL,
	[AsignaturaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ASIGNATURA] PRIMARY KEY CLUSTERED 
(
	[AsignaturaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[AsociacionPrivada]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsociacionPrivada](
	[AsociacionPrivadaId] [bigint] IDENTITY(1,1) NOT NULL,
	[AsociacionPrivadaCodigo] [nvarchar](2) NOT NULL,
	[AsociacionPrivadaNombre] [nvarchar](100) NULL,
	[AsociacionPrivadaActivo] [bit] NULL,
	[AsociacionPrivadaUsuarioRegistra] [bigint] NULL,
	[AsociacionPrivadaFechaRegistro] [datetime] NULL,
	[AsociacionPrivadaUsuarioModifica] [bigint] NULL,
	[AsociacionPrivadaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ASOCIACION_PRIVADA] PRIMARY KEY CLUSTERED 
(
	[AsociacionPrivadaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Calendario]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calendario](
	[CalendarioId] [bigint] IDENTITY(1,1) NOT NULL,
	[CalendarioCodigo] [nvarchar](2) NOT NULL,
	[CalendarioNombre] [nvarchar](100) NULL,
	[CalendarioActivo] [bit] NULL,
	[CalendarioUsuarioRegistra] [bigint] NULL,
	[CalendarioFechaRegistro] [datetime] NULL,
	[CalendarioUsuarioModifica] [bigint] NULL,
	[CalendarioFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_CALENDARIO_1] PRIMARY KEY CLUSTERED 
(
	[CalendarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CapacidadExcepcional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CapacidadExcepcional](
	[CapacidadExcepcionalId] [bigint] IDENTITY(1,1) NOT NULL,
	[CapacidadExcepcionalCodigo] [bigint] NOT NULL,
	[CapacidadExcepcionalNombre] [nvarchar](100) NULL,
	[CapacidadExcepcionalActivo] [bit] NULL,
	[CapacidadExcepcionalUsuarioRegistra] [bigint] NULL,
	[CapacidadExcepcionalFechaRegistro] [datetime] NULL,
	[CapacidadExcepcionalUsuarioModifica] [bigint] NULL,
	[CapacidadExcepcionalFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_CAP_EXCEPCIONALES_1] PRIMARY KEY CLUSTERED 
(
	[CapacidadExcepcionalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cargo]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargo](
	[CargoId] [bigint] IDENTITY(1,1) NOT NULL,
	[CargoCodigo] [nvarchar](2) NOT NULL,
	[CargoNombre] [nvarchar](100) NULL,
	[CargoActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[CargoUsuarioRegistra] [bigint] NULL,
	[CargoFechaRegistro] [datetime] NULL,
	[CargoUsuarioModifica] [bigint] NULL,
	[CargoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_CARGOS] PRIMARY KEY CLUSTERED 
(
	[CargoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClasesFuncionario]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClasesFuncionario](
	[ClaseFuncionarioId] [bigint] IDENTITY(1,1) NOT NULL,
	[ClaseFuncionarioCodigo] [nvarchar](2) NOT NULL,
	[ClaseFuncionarioNombre] [nvarchar](255) NULL,
	[ClaseFuncionarioActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[ClaseFuncionarioUsuarioRegistra] [bigint] NULL,
	[ClaseFuncionarioFechaRegistro] [datetime] NULL,
	[ClaseFuncionarioUsuarioModifica] [bigint] NULL,
	[ClaseFuncionarioFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_CLASE_FUNCIONARIO] PRIMARY KEY CLUSTERED 
(
	[ClaseFuncionarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Curso]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Curso](
	[CursoId] [bigint] IDENTITY(0,1) NOT NULL,
	[CursoCodigo] [nvarchar](10) NULL,
	[CursoNombre] [nvarchar](255) NULL,
	[GradoId] [bigint] NOT NULL,
	[GrupoId] [bigint] NOT NULL,
	[JornadaId] [bigint] NOT NULL,
	[ProfesorId] [bigint] NULL,
	[SedeId] [bigint] NOT NULL,
	[InstitucionId] [bigint] NULL,
	[CursoActivo] [bit] NULL,
	[CursoUsuarioRegistra] [bigint] NULL,
	[CursoFechaRegistro] [datetime] NULL,
	[CursoUsuarioModifica] [bigint] NULL,
	[CursoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_CURSO] PRIMARY KEY CLUSTERED 
(
	[CursoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Departamento]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamento](
	[DepartamentoId] [bigint] IDENTITY(1,1) NOT NULL,
	[DepartamentoCodigo] [nvarchar](4) NOT NULL,
	[DepartamentoNombre] [nvarchar](255) NULL,
	[DepartamentoActivo] [bit] NULL,
	[DepartamentoUsuarioRegistra] [bigint] NULL,
	[DepartamentoFechaRegistro] [datetime] NULL,
	[DepartamentoUsuarioModifica] [bigint] NULL,
	[DepartamentoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_DEPARTAMENTO] PRIMARY KEY CLUSTERED 
(
	[DepartamentoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Eps]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Eps](
	[EpsId] [bigint] IDENTITY(1,1) NOT NULL,
	[EpsCodigo] [nvarchar](6) NOT NULL,
	[EpsNombre] [nvarchar](255) NULL,
	[EpsActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[EpsUsuarioRegistra] [bigint] NULL,
	[EpsFechaRegistro] [datetime] NULL,
	[EpsUsuarioModifica] [bigint] NULL,
	[EpsFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_EPS] PRIMARY KEY CLUSTERED 
(
	[EpsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Equivalencia]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equivalencia](
	[EquivalenciaId] [bigint] IDENTITY(0,1) NOT NULL,
	[EquivalenciaCodigo] [nvarchar](5) NULL,
	[EquivalenciaRangoNumerico] [nvarchar](40) NULL,
	[ValorLetraId] [bigint] NULL,
	[EscalaNacionalId] [bigint] NULL,
	[SedeId] [bigint] NULL,
	[EquivalenciaActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[EquivalenciaUsuarioRegistra] [bigint] NULL,
	[EquivalenciaFechaRegistro] [datetime] NULL,
	[EquivalenciaUsuarioModifica] [bigint] NULL,
	[EquivalenciaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_EQUIVALENCIAS] PRIMARY KEY CLUSTERED 
(
	[EquivalenciaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Escalafon]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Escalafon](
	[EscalafonId] [bigint] IDENTITY(1,1) NOT NULL,
	[EscalafonCodigo] [nvarchar](2) NOT NULL,
	[EscalafonNombre] [nvarchar](100) NULL,
	[EscalafonActivo] [bit] NULL,
	[EscalafonUsuarioRegistra] [bigint] NULL,
	[EscalafonFechaRegistro] [datetime] NULL,
	[EscalafonUsuarioModifica] [bigint] NULL,
	[EscalafonFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ESCALAFON] PRIMARY KEY CLUSTERED 
(
	[EscalafonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EscalaNacional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EscalaNacional](
	[EscalaNacionalId] [bigint] IDENTITY(0,1) NOT NULL,
	[EscalaNacionalCodigo] [nvarchar](5) NULL,
	[EscalaNacionalNombre] [nvarchar](255) NULL,
	[EscalaNacionalCriterioEval] [nvarchar](255) NULL,
	[SedeId] [bigint] NULL,
	[EscalaNacionalActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[EscalaNacionalUsuarioRegistra] [bigint] NULL,
	[EscalaNacionalFechaRegistro] [datetime] NULL,
	[EscalaNacionalUsuarioModifica] [bigint] NULL,
	[EscalaNacionalFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ESCALA_NACIONAL] PRIMARY KEY CLUSTERED 
(
	[EscalaNacionalId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Especialidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Especialidad](
	[EspecialidadId] [bigint] IDENTITY(1,1) NOT NULL,
	[EspecialidadCodigo] [bigint] NOT NULL,
	[EspecialidadNombre] [nvarchar](50) NULL,
	[EspecialidadActivo] [bit] NULL,
	[EspecialidadUsuarioRegistra] [bigint] NULL,
	[EspecialidadFechaRegistro] [datetime] NULL,
	[EspecialidadUsuarioModifica] [bigint] NULL,
	[EspecialidadFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ESPECIALIDAD] PRIMARY KEY CLUSTERED 
(
	[EspecialidadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[EstadoCivil]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EstadoCivil](
	[EstadoCivilId] [bigint] IDENTITY(1,1) NOT NULL,
	[EstadoCivilCodigo] [nvarchar](2) NOT NULL,
	[EstadoCivilNombre] [nvarchar](100) NULL,
	[EstadoCivilActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[EstadoCivilUsuarioRegistra] [bigint] NULL,
	[EstadoCivilFechaRegistro] [datetime] NULL,
	[EstadoCivilUsuarioModifica] [bigint] NULL,
	[EstadoCivilFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ESTADO_CIVIL] PRIMARY KEY CLUSTERED 
(
	[EstadoCivilId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estrato]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estrato](
	[EstratoId] [bigint] IDENTITY(1,1) NOT NULL,
	[EstratoCodigo] [bigint] NOT NULL,
	[EstratoNombre] [nvarchar](10) NULL,
	[EstratoActivo] [bit] NULL,
	[EstratoUsuarioRegistra] [bigint] NULL,
	[EstratoFechaRegistro] [datetime] NULL,
	[EstratoUsuarioModifica] [bigint] NULL,
	[EstratoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ESTRATO] PRIMARY KEY CLUSTERED 
(
	[EstratoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Estudiante]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estudiante](
	[EstudianteId] [bigint] IDENTITY(1,1) NOT NULL,
	[EstudianteCodigo] [nvarchar](20) NOT NULL,
	[EstudianteCodigoMEN] [nvarchar](20) NULL,
	[TipoIdentificacionId] [bigint] NULL,
	[EstudianteNumeroDocumento] [nvarchar](20) NULL,
	[DepartamentoExpedicionId] [bigint] NULL,
	[MunicipioExpedicionId] [bigint] NULL,
	[EstudiantePrimerApellido] [nvarchar](10) NULL,
	[EstudianteSegundoApellido] [nvarchar](10) NULL,
	[EstudiantePrimerNombre] [nvarchar](20) NULL,
	[EstudianteSegundoNombre] [nvarchar](10) NULL,
	[EstudianteFechaNacimiento] [datetime] NULL,
	[DepartamentoNacimientoId] [bigint] NULL,
	[MunicipioNacimientoId] [bigint] NULL,
	[GeneroId] [bigint] NULL,
	[FactorRhId] [bigint] NULL,
	[EstudianteEmail] [nvarchar](50) NULL,
	[EstudianteFotografia] [image] NULL,
	[EstudianteDireccion] [nvarchar](100) NULL,
	[DepartamentoResidenciaId] [bigint] NULL,
	[MunicipioResidenciaId] [bigint] NULL,
	[ZonaResidenciaId] [bigint] NULL,
	[EstudianteLocalidad] [nvarchar](100) NULL,
	[EstudianteBarrio] [nvarchar](100) NULL,
	[EstratoId] [bigint] NULL,
	[EstudianteTelefono] [nvarchar](20) NULL,
	[EstudianteCelular] [nvarchar](20) NULL,
	[SisbenId] [bigint] NULL,
	[EstudianteNumeroSisben] [nvarchar](20) NULL,
	[EpsId] [bigint] NULL,
	[ArsId] [bigint] NULL,
	[PoblacionVictimaId] [bigint] NULL,
	[DepartamentoExpulsorId] [bigint] NULL,
	[MunicipioExpulsorId] [bigint] NULL,
	[EstudianteFechaExpulsion] [datetime] NULL,
	[EstudianteCertificadoExpulsion] [nvarchar](20) NULL,
	[EstudianteFechaCertificadoExpulsion] [datetime] NULL,
	[DiscapacidadId] [bigint] NULL,
	[CapacidadExcepcionalId] [bigint] NULL,
	[EtniaId] [bigint] NULL,
	[ResguardoId] [bigint] NULL,
	[EstudianteProvieneSectorPrivado] [bit] NULL,
	[EstudianteProvieneOtroMunicipio] [bit] NULL,
	[EstudianteInstitucionBienestar] [nvarchar](100) NULL,
	[TipoIdentificacionMadreId] [bigint] NULL,
	[EstudianteNumeroDocumentoMadre] [nvarchar](20) NULL,
	[DepartamentoExpedicionMadreId] [bigint] NULL,
	[MunicipioExpedicionMadreId] [bigint] NULL,
	[EstudiantePrimerApellidoMadre] [nvarchar](10) NULL,
	[EstudianteSegundoApellidoMadre] [nvarchar](10) NULL,
	[EstudiantePrimerNombreMadre] [nvarchar](20) NULL,
	[EstudianteSegundoNombreMadre] [nvarchar](10) NULL,
	[EstudianteEmailMadre] [nvarchar](50) NULL,
	[EstudianteDireccionMadre] [nvarchar](100) NULL,
	[DepartamentoResidenciaMadreId] [bigint] NULL,
	[MunicipioResidenciaMadreId] [bigint] NULL,
	[ZonaResidenciaMadreId] [bigint] NULL,
	[EstudianteBarrioMadre] [nvarchar](100) NULL,
	[EstudianteLocalidadMadre] [nvarchar](100) NULL,
	[EstudianteTelefonoMadre] [nvarchar](20) NULL,
	[EstudianteCelularMadre] [nvarchar](20) NULL,
	[EstudianteOcupacionMadre] [nvarchar](100) NULL,
	[EstudianteEmpresaMadre] [nvarchar](100) NULL,
	[EstudianteTelefonoEmpresaMadre] [nvarchar](20) NULL,
	[TipoIdentificacionPadreId] [bigint] NULL,
	[EstudianteNumeroDocumentoPadre] [nvarchar](20) NULL,
	[DepartamentoExpedicionPadreId] [bigint] NULL,
	[MunicipioExpedicionPadreId] [bigint] NULL,
	[EstudiantePrimerApellidoPadre] [nvarchar](10) NULL,
	[EstudianteSegindoApellidoPadre] [nvarchar](10) NULL,
	[EstudiantePrimerNombrePadre] [nvarchar](20) NULL,
	[EstudianteSegundoNombrePadre] [nvarchar](10) NULL,
	[EstudianteEmailPadre] [nvarchar](50) NULL,
	[EstudianteDireccionPadre] [nvarchar](100) NULL,
	[DepartamentoResidenciaPadreId] [bigint] NULL,
	[MunicipioResidenciaPadreId] [bigint] NULL,
	[ZonaResicenciaPadreId] [bigint] NULL,
	[EstudianteBarrioPadre] [nvarchar](100) NULL,
	[EstudianteLocalidadpadre] [nvarchar](100) NULL,
	[EstudianteTelefonoPadre] [nvarchar](20) NULL,
	[EstudianteCelularPadre] [nvarchar](20) NULL,
	[EstudianteOcupacionPadre] [nvarchar](100) NULL,
	[EstudianteEmpresaPadre] [nvarchar](100) NULL,
	[EstudianteTelefonoEmpresaPadre] [nvarchar](20) NULL,
	[TipoIdentificacionAcudienteId] [bigint] NULL,
	[EstudianteNumeroDocumentoAcudiente] [nvarchar](20) NULL,
	[DepartamentoExpedicionAcudienteId] [bigint] NULL,
	[MunicipioExpedicionAcudiente] [bigint] NULL,
	[EstudiantePrimerApellidoAcudiente] [nvarchar](10) NULL,
	[EstudianteSegundoApellidoAcudiente] [nvarchar](10) NULL,
	[EstudiantePrimerNombreAcudiente] [nvarchar](20) NULL,
	[EstudianteSegundoNombreAcudiente] [nvarchar](10) NULL,
	[EstudianteEmailAcudiente] [nvarchar](50) NULL,
	[EstudianteDireccionAcudiente] [nvarchar](100) NULL,
	[DepartamentoResidenciaAcudienteId] [bigint] NULL,
	[MunicipioResidenciaAcudienteId] [bigint] NULL,
	[ZonaResidenciaAcudienteId] [bigint] NULL,
	[EstudianteBarrioAcudiente] [nvarchar](100) NULL,
	[EstudianteLocalidadAcudiente] [nvarchar](100) NULL,
	[EstudianteTelefonoAcudiente] [nvarchar](20) NULL,
	[EstudianteCelularAcudiente] [nvarchar](20) NULL,
	[EstudianteOcupacionAcudiente] [nvarchar](100) NULL,
	[EstudianteEmpresaAcudiente] [nvarchar](100) NULL,
	[EstudianteTelefonoEmpresaAcudiente] [nvarchar](20) NULL,
	[GeneroAcudienteId] [bigint] NULL,
	[ParentescoAcudienteId] [bigint] NULL,
	[EstudianteColegioUltimoCurso] [nvarchar](100) NULL,
	[EstudianteDireccionColegioUltimoCurso] [nvarchar](100) NULL,
	[EstudianteTelefonoColegioUltimoCurso] [nvarchar](20) NULL,
	[EstudianteUltimoGrado] [nvarchar](10) NULL,
	[EstudianteAnio] [nvarchar](4) NULL,
	[EstudianteMotivoRetiroUltimo] [nvarchar](255) NULL,
	[EstudianteObservaciones] [text] NULL,
	[EstudianteUsuarioEstudiante] [nvarchar](20) NULL,
	[EstudianteClaveAcceso] [nvarchar](20) NULL,
	[GrupoUsuarioId] [nvarchar](2) NULL,
	[SedeId] [bigint] NULL,
	[InstitucionId] [bigint] NULL,
	[EstudianteSeleccioneMadre] [bit] NULL,
	[EstudianteSeleccionePadre] [bit] NULL,
	[EstudianteSeleccioneAcudiente] [int] NULL,
	[EstudianteActivo] [bit] NULL,
	[EstudianteUsuarioRegistra] [bigint] NULL,
	[EstudianteFechaRegistro] [datetime] NULL,
	[EstudianteUsuarioModifica] [bigint] NULL,
	[EstudianteFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ESTUDIANTES_1] PRIMARY KEY CLUSTERED 
(
	[EstudianteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Etnia]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etnia](
	[EtniaId] [bigint] IDENTITY(1,1) NOT NULL,
	[EtniaCodigo] [nvarchar](3) NOT NULL,
	[EtniaNombre] [nvarchar](100) NULL,
	[EtniaActivo] [bit] NULL,
	[EtniaUsuarioRegistra] [bigint] NULL,
	[EtniaFechaRegistro] [datetime] NULL,
	[EtniaUsuarioModifica] [bigint] NULL,
	[EtniaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ETNIAS] PRIMARY KEY CLUSTERED 
(
	[EtniaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FactorRh]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FactorRh](
	[FactorRhId] [bigint] IDENTITY(1,1) NOT NULL,
	[FactorRhCodigo] [nvarchar](1) NOT NULL,
	[FactorRhNombre] [nvarchar](3) NULL,
	[FactorRhActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[FactorRhUsuarioRegistra] [bigint] NULL,
	[FactorRhFechaRegistro] [datetime] NULL,
	[FactorRhUsuarioModifica] [bigint] NULL,
	[FactorRhFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_FACTOR_RH] PRIMARY KEY CLUSTERED 
(
	[FactorRhId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FuenteRecurso]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FuenteRecurso](
	[FuenteRecursoId] [bigint] IDENTITY(1,1) NOT NULL,
	[FuenteRecursoCodigo] [bigint] NOT NULL,
	[FuenteRecursoNombre] [nvarchar](100) NULL,
	[FuenteRecursoActivo] [bit] NULL,
	[FuenteRecursoUsuarioRegistra] [bigint] NULL,
	[FuenteRecursoFechaRegistro] [datetime] NULL,
	[FuenteRecursoUsuarioModifica] [bigint] NULL,
	[FuenteRecursoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_FUENTE_RECURSOS] PRIMARY KEY CLUSTERED 
(
	[FuenteRecursoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Genero]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genero](
	[GeneroId] [bigint] IDENTITY(1,1) NOT NULL,
	[GeneroCodigo] [nvarchar](1) NOT NULL,
	[GeneroNombre] [nvarchar](10) NULL,
	[GeneroActivo] [bit] NULL,
	[GeneroUsuarioRegistra] [bigint] NULL,
	[GeneroFechaRegistro] [datetime] NULL,
	[GeneroUsuarioModifica] [bigint] NULL,
	[GeneroFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_GENERO] PRIMARY KEY CLUSTERED 
(
	[GeneroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GeneroEstudiante]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GeneroEstudiante](
	[GeneroEstudianteId] [bigint] IDENTITY(1,1) NOT NULL,
	[GeneroEstudianteCodigo] [nvarchar](1) NOT NULL,
	[GeneroEstudianteNombre] [nvarchar](10) NULL,
	[GeneroEstudianteActivo] [bit] NULL,
	[GeneroEstudianteUsuarioRegistra] [bigint] NULL,
	[GeneroEstudianteFechaRegistro] [datetime] NULL,
	[GeneroEstudianteUsuarioModifica] [bigint] NULL,
	[GeneroEstudianteFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_GENERO_EST] PRIMARY KEY CLUSTERED 
(
	[GeneroEstudianteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Grado]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grado](
	[GradoId] [bigint] IDENTITY(1,1) NOT NULL,
	[GradoCodigo] [nvarchar](5) NOT NULL,
	[GradoNombre] [nvarchar](50) NOT NULL,
	[SedeId] [bigint] NULL,
	[InstitucionId] [bigint] NULL,
	[CursoActivo] [bit] NULL,
	[GradoUsuarioRegistra] [bigint] NULL,
	[GradoFechaRegistro] [datetime] NULL,
	[GradoUsuarioModifica] [bigint] NULL,
	[GradoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_GRADO] PRIMARY KEY CLUSTERED 
(
	[GradoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Grupo]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grupo](
	[GrupoId] [bigint] IDENTITY(1,1) NOT NULL,
	[GrupoCodigo] [nvarchar](5) NOT NULL,
	[GrupoNombre] [nvarchar](50) NOT NULL,
	[SedeId] [bigint] NULL,
	[GrupoActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[GrupoUsuarioRegistra] [bigint] NULL,
	[GrupoFechaRegistro] [datetime] NULL,
	[GrupoUsuarioModifica] [bigint] NULL,
	[GrupoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_GRUPO] PRIMARY KEY CLUSTERED 
(
	[GrupoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GrupoUsuario]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GrupoUsuario](
	[GrupoUsuarioId] [bigint] IDENTITY(1,1) NOT NULL,
	[GrupoUsuarioCodigo] [bigint] NULL,
	[GrupoUsuarioNombre] [nvarchar](50) NULL,
	[InstitucionId] [bigint] NULL,
	[GrupoUsuarioActivo] [bit] NULL,
	[GrupoUsuarioUsuarioRegistra] [bigint] NULL,
	[GrupoUsuarioFechaRegistro] [datetime] NULL,
	[GrupoUsuarioUsuarioModifica] [bigint] NULL,
	[GrupoUsuarioFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_GRUPO_USR] PRIMARY KEY CLUSTERED 
(
	[GrupoUsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Idioma]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Idioma](
	[IdiomaId] [bigint] IDENTITY(1,1) NOT NULL,
	[IdiomaCodigo] [nvarchar](2) NOT NULL,
	[IdiomaNombre] [nvarchar](100) NULL,
	[IdiomaActivo] [bit] NULL,
	[IdiomaUsuarioRegistra] [bigint] NULL,
	[IdiomaFechaRegistro] [datetime] NULL,
	[IdiomaUsuarioModifica] [bigint] NULL,
	[IdiomaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_IDIOMAS] PRIMARY KEY CLUSTERED 
(
	[IdiomaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Institucion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Institucion](
	[InstitucionId] [bigint] IDENTITY(1,1) NOT NULL,
	[InstitucionCodigoDane] [nvarchar](12) NOT NULL,
	[InstitucionNombre] [nvarchar](100) NOT NULL,
	[InstitucionNit] [nvarchar](20) NOT NULL,
	[InstitucionNombreRector] [nvarchar](50) NOT NULL,
	[CalendarioId] [nvarchar](2) NOT NULL,
	[SectorId] [nvarchar](2) NOT NULL,
	[PropiedadJuridicaId] [nvarchar](2) NULL,
	[InstitucionNumeroSedes] [int] NULL,
	[NucleoId] [nvarchar](3) NULL,
	[GeneroId] [bigint] NULL,
	[InstitucionSubsidio] [bit] NULL,
	[DiscapacidadesId] [nvarchar](2) NULL,
	[CapacidadesExcepcionalesId] [bigint] NULL,
	[EtniasId] [bigint] NULL,
	[ResguardosId] [bigint] NULL,
	[NovedadId] [nvarchar](2) NULL,
	[MetodologiaId] [nvarchar](2) NULL,
	[PrestadorServicioId] [nvarchar](2) NULL,
	[InstitucionDecretoCreacion] [nvarchar](30) NULL,
	[InstitucionDirector] [nvarchar](30) NULL,
	[InstitucionSecretaria] [nvarchar](30) NULL,
	[InstitucionAprobacion] [nvarchar](30) NULL,
	[InstitucionLema] [nvarchar](255) NULL,
	[InstitucionEscudo] [nvarchar](255) NULL,
	[DepartamentoId] [bigint] NULL,
	[MunicipioId] [bigint] NULL,
	[ZonaId] [bigint] NULL,
	[InstitucionBarrio] [nvarchar](30) NULL,
	[InstitucionDireccion] [nvarchar](100) NULL,
	[InstitucionTelefono] [nvarchar](20) NULL,
	[InstitucionFax] [nvarchar](20) NULL,
	[InstitucionSitioWeb] [nvarchar](20) NULL,
	[InstitucionEmail] [nvarchar](20) NULL,
	[InstitucionNumeroLiciencia] [nvarchar](10) NULL,
	[RegimenCostoId] [bigint] NULL,
	[IdiomaId] [bigint] NULL,
	[AsociacionId] [bigint] NULL,
	[TarifaAnualId] [bigint] NULL,
	[InstitucionActivo] [bit] NULL,
	[InstitucionUsuarioRegistra] [bigint] NULL,
	[InstitucionFechaRegistro] [datetime] NULL,
	[InstitucionUsuarioModifica] [bigint] NULL,
	[InstitucionFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_INSTITUCION] PRIMARY KEY CLUSTERED 
(
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Jornada]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jornada](
	[JornadaId] [bigint] IDENTITY(1,1) NOT NULL,
	[JornadaCodigo] [nvarchar](2) NOT NULL,
	[JornadaNombre] [nvarchar](50) NOT NULL,
	[SedeId] [bigint] NULL,
	[JornadaActivo] [bit] NULL,
	[JornadaUsuarioRegistra] [bigint] NULL,
	[JornadaFechaRegistro] [datetime] NULL,
	[JornadaUsuarioModifica] [bigint] NULL,
	[JornadaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_JORNADAS] PRIMARY KEY CLUSTERED 
(
	[JornadaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Juicio]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Juicio](
	[JuicioId] [bigint] IDENTITY(1,1) NOT NULL,
	[JuicioCodigo] [nvarchar](5) NULL,
	[JuicioNombre] [nvarchar](255) NULL,
	[GradoId] [bigint] NULL,
	[GrupoId] [bigint] NULL,
	[JornadaId] [bigint] NULL,
	[MateriaId] [bigint] NULL,
	[PeriodoId] [bigint] NULL,
	[SedeId] [bigint] NULL,
	[JuicioActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[JuicioUsuarioRegistra] [bigint] NULL,
	[JuicioFechaRegistro] [datetime] NULL,
	[JuicioUsuarioModifica] [bigint] NULL,
	[JuicioFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_JUICIOS] PRIMARY KEY CLUSTERED 
(
	[JuicioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[LibretaMilitar]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibretaMilitar](
	[LibretaMilitarId] [bigint] IDENTITY(1,1) NOT NULL,
	[LibretaMilitarCodigo] [nvarchar](2) NOT NULL,
	[LibretaMilitarNombre] [nvarchar](100) NULL,
	[LibretaMilitarActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[LibretaMilitarUsuarioRegistra] [bigint] NULL,
	[LibretaMilitarFechaRegistro] [datetime] NULL,
	[LibretaMilitarUsuarioModifica] [bigint] NULL,
	[LibretaMilitarFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_LIBRETA_MILITAR] PRIMARY KEY CLUSTERED 
(
	[LibretaMilitarId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Materia]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materia](
	[MateriaId] [bigint] IDENTITY(1,1) NOT NULL,
	[MateriaCodigo] [nvarchar](10) NULL,
	[MateriaNombre] [nvarchar](255) NULL,
	[ClasificacionId] [bigint] NULL,
	[ProfesorId] [bigint] NULL,
	[GradoId] [bigint] NULL,
	[GrupoId] [bigint] NULL,
	[JornadaId] [bigint] NULL,
	[MateriaIntensidadHoraria] [int] NULL,
	[MateriaOrden] [int] NULL,
	[SedeId] [bigint] NOT NULL,
	[MateriaActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[MateriaUsuarioRegistra] [bigint] NULL,
	[MateriaFechaRegistro] [datetime] NULL,
	[MateriaUsuarioModifica] [bigint] NULL,
	[MateriaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_MATERIA] PRIMARY KEY CLUSTERED 
(
	[MateriaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Menu]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuId] [bigint] NOT NULL,
	[MenuNombre] [varchar](50) NULL,
	[MenuPadreId] [int] NULL,
	[MenuPosicion] [int] NULL,
	[MenuIcono] [varchar](50) NULL,
	[MenuUrl] [varchar](255) NULL,
	[MenuActivo] [bit] NULL,
	[MenuUsuarioRegistra] [bigint] NULL,
	[MenuFechaRegistro] [datetime] NULL,
	[MenuUsuarioModifica] [bigint] NULL,
	[MenuFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_MENU] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Metodologia]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Metodologia](
	[MetodologiaId] [bigint] IDENTITY(1,1) NOT NULL,
	[MetodologiaCodigo] [bigint] NOT NULL,
	[MetodologiaNombre] [nvarchar](100) NULL,
	[MetodologiaActivo] [bit] NULL,
	[MetodologiaUsuarioRegistra] [bigint] NULL,
	[MetodologiaFechaRegistro] [datetime] NULL,
	[MetodologiaUsuarioModifica] [bigint] NULL,
	[MetodologiaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_METODOLOGIAS] PRIMARY KEY CLUSTERED 
(
	[MetodologiaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Municipio]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipio](
	[MunicipioId] [bigint] IDENTITY(1,1) NOT NULL,
	[MunicipioCodigo] [nvarchar](3) NULL,
	[MunicipioNombre] [nvarchar](255) NULL,
	[MunicipioCodigoUnificado] [nvarchar](6) NOT NULL,
	[DepartamentoId] [bigint] NULL,
	[DepartamentoCodigo] [nvarchar](2) NULL,
	[MunicipioActivo] [bit] NULL,
	[MunicipioUsuarioRegistra] [bigint] NULL,
	[MunicipioFechaRegistro] [datetime] NULL,
	[MunicipioUsuarioModifica] [bigint] NULL,
	[MunicipioFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_MUNICIPIO_1] PRIMARY KEY CLUSTERED 
(
	[MunicipioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NivelEducativo]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelEducativo](
	[NivelEducativoId] [bigint] IDENTITY(1,1) NOT NULL,
	[NivelEducativoCodigo] [nvarchar](2) NOT NULL,
	[NivelEducativoNombre] [nvarchar](100) NULL,
	[NivelEducativoActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[NivelEducativoUsuarioRegistra] [bigint] NULL,
	[NivelEducativoFechaRegistro] [datetime] NULL,
	[NivelEducativoUsuarioModifica] [bigint] NULL,
	[NivelEducativoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_NIVEL_EDUCATIVO] PRIMARY KEY CLUSTERED 
(
	[NivelEducativoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NivelEducativoDocente]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NivelEducativoDocente](
	[NivelEducativoDocenteId] [bigint] IDENTITY(1,1) NOT NULL,
	[NivelEducativoDocenteCodigo] [nvarchar](2) NOT NULL,
	[NivelEducativoDocenteNombre] [nvarchar](100) NULL,
	[NivelEducativoDocenteActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[NivelEducativoDocenteUsuarioRegistra] [bigint] NULL,
	[NivelEducativoDocenteFechaRegistro] [datetime] NULL,
	[NivelEducativoDocenteUsuarioModifica] [bigint] NULL,
	[NivelEducativoDocenteFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_NIVEL_EDUCATIVO_DOCENTE] PRIMARY KEY CLUSTERED 
(
	[NivelEducativoDocenteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nucleo]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nucleo](
	[NucleoId] [bigint] IDENTITY(1,1) NOT NULL,
	[NucleoCodigo] [nvarchar](3) NOT NULL,
	[NucleoNombre] [nvarchar](100) NOT NULL,
	[NucleoDireccion] [nvarchar](100) NULL,
	[NucleoTelefono] [nvarchar](20) NULL,
	[DepartamentoId] [nvarchar](2) NULL,
	[MunicipioId] [nvarchar](6) NULL,
	[NucleoNombreDirector] [nvarchar](30) NULL,
	[NucleoTelefonoDirector] [nvarchar](20) NULL,
	[NucleoActivo] [bit] NULL,
	[NucleoUsuarioRegistra] [bigint] NULL,
	[NucleoFechaRegistro] [datetime] NULL,
	[NucleoUsuarioModifica] [bigint] NULL,
	[NucleoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_NUCLEO] PRIMARY KEY CLUSTERED 
(
	[NucleoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[OpcionMenuUsuario]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OpcionMenuUsuario](
	[MenuId] [bigint] NULL,
	[GrupoUsuarioId] [bigint] NULL,
	[InstitucionId] [bigint] NULL,
	[OpcionMenuUsuarioVer] [bit] NULL,
	[OpcionMenuUsuarioAgregar] [bit] NULL,
	[OpcionMenuUsuarioModificar] [bit] NULL,
	[OpcionMenuUsuarioEliminar] [bit] NULL,
	[OpcionMenuUsuarioTodos] [bit] NULL,
	[OpcionMenuUsuarioActivo] [bit] NULL,
	[OpcionMenuUsuarioUsuarioRegistra] [bigint] NULL,
	[OpcionMenuUsuarioFechaRegistro] [datetime] NULL,
	[OpcionMenuUsuarioUsuarioModifica] [bigint] NULL,
	[OpcionMenuUsuarioFechaModifica] [datetime] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Parentesco]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parentesco](
	[ParentescoId] [bigint] NOT NULL,
	[ParentescoCodigo] [bigint] NOT NULL,
	[ParentescoNombre] [nvarchar](10) NULL,
	[ParentescoActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[ParentescoUsuarioRegistra] [bigint] NULL,
	[ParentescoFechaRegistro] [datetime] NULL,
	[ParentescoUsuarioModifica] [bigint] NULL,
	[ParentescoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_PARENTESCO] PRIMARY KEY CLUSTERED 
(
	[ParentescoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Perfil]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Perfil](
	[PerfilId] [bigint] IDENTITY(1,1) NOT NULL,
	[PerfilCodigo] [nvarchar](4) NOT NULL,
	[PerfilNombre] [nvarchar](255) NULL,
	[PerfilActivo] [bit] NOT NULL,
	[PerfilUsuarioCrea] [bigint] NULL,
	[PerfilUsuarioModifica] [bigint] NULL,
	[PerfilFechaCreacion] [datetime] NULL,
	[PerfilFechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_Perfil] PRIMARY KEY CLUSTERED 
(
	[PerfilId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Periodo]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Periodo](
	[PeriodoId] [bigint] IDENTITY(1,1) NOT NULL,
	[PeriodoCodigo] [nvarchar](3) NOT NULL,
	[PeriodoNombre] [nvarchar](50) NULL,
	[SedeId] [bigint] NULL,
	[PeriodoActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[PeriodoUsuarioRegistra] [bigint] NULL,
	[PeriodoFechaRegistro] [datetime] NULL,
	[PeriodoUsuarioModifica] [bigint] NULL,
	[PeriodoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_PERIODO] PRIMARY KEY CLUSTERED 
(
	[PeriodoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PoblacionVictimaConflicto]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PoblacionVictimaConflicto](
	[PoblVicConflictoId] [bigint] IDENTITY(1,1) NOT NULL,
	[PoblVicConflictoCodigo] [bigint] NOT NULL,
	[PoblVicConflictoNombre] [nvarchar](100) NULL,
	[PoblVicConflictoActivo] [bit] NULL,
	[PoblVicConflictoUsuarioRegistra] [bigint] NULL,
	[PoblVicConflictoFechaRegistro] [datetime] NULL,
	[PoblVicConflictoUsuarioModifica] [bigint] NULL,
	[PoblVicConflictoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_POBLA_VIC_CONFLICTO] PRIMARY KEY CLUSTERED 
(
	[PoblVicConflictoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Prestador]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prestador](
	[PrestadorId] [bigint] IDENTITY(1,1) NOT NULL,
	[PrestadorCodigo] [nvarchar](2) NOT NULL,
	[PrestadorNombre] [nvarchar](100) NULL,
	[PrestadorActivo] [bit] NULL,
	[PrestadorUsuarioRegistra] [bigint] NULL,
	[PrestadorFechaRegistro] [datetime] NULL,
	[PrestadorUsuarioModifica] [bigint] NULL,
	[PrestadorFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_PRESTADOR] PRIMARY KEY CLUSTERED 
(
	[PrestadorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profesion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesion](
	[ProfesionId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProfesionCodigo] [nvarchar](5) NOT NULL,
	[ProfesionNombre] [nvarchar](50) NOT NULL,
	[ProfesionActivo] [bit] NULL,
	[ProfesionUsuarioRegistra] [bigint] NULL,
	[ProfesionFechaRegistro] [datetime] NULL,
	[ProfesionUsuarioModifica] [bigint] NULL,
	[ProfesionFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_PROFESION] PRIMARY KEY CLUSTERED 
(
	[ProfesionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Profesor]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Profesor](
	[ProfesorId] [bigint] IDENTITY(1,1) NOT NULL,
	[ProfesorCodigo] [nvarchar](10) NULL,
	[TipoIdentificacionId] [bigint] NOT NULL,
	[ProfesorNumeroDocumento] [nvarchar](20) NOT NULL,
	[ProfesorPrimerApellido] [nvarchar](40) NOT NULL,
	[ProfesorSegundoApellido] [nvarchar](40) NULL,
	[ProfesorPrimerNombre] [nvarchar](40) NOT NULL,
	[ProfesorSegundoNombre] [nvarchar](40) NULL,
	[ProfesorDireccion] [nvarchar](255) NULL,
	[ProfesorTelefono] [nvarchar](80) NULL,
	[ProfesionId] [bigint] NOT NULL,
	[EscalafonId] [bigint] NULL,
	[SedeId] [bigint] NULL,
	[ProfesorActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[ProfesorUsuarioRegistra] [bigint] NULL,
	[ProfesorFechaRegistro] [datetime] NULL,
	[ProfesorUsuarioModifica] [bigint] NULL,
	[ProfesorFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_PROFESOR] PRIMARY KEY CLUSTERED 
(
	[ProfesorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PropiedadJuridica]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PropiedadJuridica](
	[PropiedadJuridicaId] [bigint] IDENTITY(1,1) NOT NULL,
	[PropiedadJuridicaCodigo] [nvarchar](2) NOT NULL,
	[PropiedadJuridicaNombre] [nvarchar](100) NULL,
	[PropiedadJuridicaActivo] [bit] NULL,
	[PropiedadJuridicaUsuarioRegistra] [bigint] NULL,
	[PropiedadJuridicaFechaRegistro] [datetime] NULL,
	[PropiedadJuridicaUsuarioModifica] [bigint] NULL,
	[PropiedadJuridicaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_PROPIEDAD_JURIDICA] PRIMARY KEY CLUSTERED 
(
	[PropiedadJuridicaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RegimenCosto]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RegimenCosto](
	[RegimenCostoId] [bigint] IDENTITY(1,1) NOT NULL,
	[RegimenCostoCodigo] [nvarchar](2) NOT NULL,
	[RegimenCostoNombre] [nvarchar](100) NULL,
	[RegimenCostoActivo] [bit] NULL,
	[RegimenCostoUsuarioRegistra] [bigint] NULL,
	[RegimenCostoFechaRegistro] [datetime] NULL,
	[RegimenCostoUsuarioModifica] [bigint] NULL,
	[RegimenCostoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_REGIMEN_COSTO] PRIMARY KEY CLUSTERED 
(
	[RegimenCostoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Resguardo]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resguardo](
	[ResguardoId] [bigint] IDENTITY(1,1) NOT NULL,
	[ResguardoCodigo] [nvarchar](3) NOT NULL,
	[ResguardoNombre] [nvarchar](100) NULL,
	[ResguardoActivo] [bigint] NULL,
	[ResguardoUsuarioRegistra] [bigint] NULL,
	[ResguardoFechaRegistro] [datetime] NULL,
	[ResguardoUsuarioModifica] [bigint] NULL,
	[ResguardoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_RESGUARDOS] PRIMARY KEY CLUSTERED 
(
	[ResguardoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sede]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sede](
	[SedeId] [bigint] IDENTITY(1,1) NOT NULL,
	[SedeCodigo] [bigint] NOT NULL,
	[SedeCodigoDaneNuevo] [nvarchar](12) NOT NULL,
	[SedeCodigoDaneAntiguo] [nvarchar](12) NOT NULL,
	[SedeCodigoConsecutivo] [nvarchar](20) NOT NULL,
	[SedeNombre] [nvarchar](100) NOT NULL,
	[DepartamentoId] [bigint] NOT NULL,
	[MunicipioId] [bigint] NOT NULL,
	[ZonaId] [bigint] NOT NULL,
	[SedeBarrio] [nvarchar](30) NULL,
	[SedeDireccion] [nvarchar](100) NULL,
	[SedeTelefono] [nvarchar](20) NULL,
	[SedeFax] [nvarchar](20) NULL,
	[SedeEmail] [nvarchar](20) NULL,
	[SedeNovedad] [nvarchar](2) NULL,
	[SedeJornadaCompleta] [bit] NULL,
	[SedeJornadaManana] [bit] NULL,
	[SedeJornadaTarde] [bit] NULL,
	[SedeJornadaNoche] [bit] NULL,
	[SedeJornadaFinSemana] [bit] NULL,
	[EspecialidadId] [bigint] NULL,
	[SedeFechaCreacion] [datetime] NULL,
	[SedeDirector] [nvarchar](30) NULL,
	[SedeSecretaria] [nvarchar](30) NULL,
	[SedeEscalaValoracionNacional] [bit] NULL,
	[SedeRangoNumerico] [bit] NULL,
	[SedeNumeroInicial] [int] NULL,
	[SedeNumeroFinal] [int] NULL,
	[SedeValoracionLetras] [bit] NULL,
	[SedeJuicios] [bit] NULL,
	[SedeActivo] [bit] NULL,
	[SedeUsuarioRegistra] [bigint] NULL,
	[SedeFechaRegistro] [datetime] NULL,
	[SedeUsuarioModifica] [bigint] NULL,
	[SedeFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_SEDES] PRIMARY KEY CLUSTERED 
(
	[SedeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sisben]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sisben](
	[SisbenId] [bigint] IDENTITY(1,1) NOT NULL,
	[SisbenCodigo] [bigint] NOT NULL,
	[SisbenNombre] [nvarchar](10) NULL,
	[SisbenActivo] [bit] NULL,
	[SisbenUsuarioRegistra] [bigint] NULL,
	[SisbenFechaRegistro] [datetime] NULL,
	[SisbenUsuarioModifica] [bigint] NULL,
	[SisbenFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_SISBEN] PRIMARY KEY CLUSTERED 
(
	[SisbenId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SituacionAcademica]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SituacionAcademica](
	[SituacionAcademicaId] [bigint] IDENTITY(1,1) NOT NULL,
	[SituacionAcademicaCodigo] [bigint] NOT NULL,
	[SituacionAcademicaNombre] [nvarchar](255) NULL,
	[SituacionAcademicaActivo] [bit] NULL,
	[SituacionAcademicaUsuarioRegistra] [bigint] NULL,
	[SituacionAcademicaFechaRegistro] [datetime] NULL,
	[SituacionAcademicaUsuarioModifica] [bigint] NULL,
	[SituacionAcademicaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_SITU_ACADEMICA] PRIMARY KEY CLUSTERED 
(
	[SituacionAcademicaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TarifaAnual]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TarifaAnual](
	[TarifaAnualId] [bigint] IDENTITY(1,1) NOT NULL,
	[TarifaAnualCodigo] [nvarchar](2) NOT NULL,
	[TarifaAnualNombre] [nvarchar](100) NULL,
	[TarifaAnualActivo] [bit] NULL,
	[TarifaAnualUsuarioRegistra] [bigint] NULL,
	[TarifaAnualFechaRegistro] [datetime] NULL,
	[TarifaAnualUsuarioModifica] [bigint] NULL,
	[TarifaAnualFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_TARIFA_ANUAL] PRIMARY KEY CLUSTERED 
(
	[TarifaAnualId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoAcademico]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoAcademico](
	[TipoAcademicaId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoAcademicaCodigo] [bigint] NOT NULL,
	[TipoAcademicaNombre] [nvarchar](100) NULL,
	[SedeId] [bigint] NOT NULL,
	[TipoAcademicaActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[TipoAcademicaUsuarioRegistra] [bigint] NULL,
	[TipoAcademicaFechaRegistro] [datetime] NULL,
	[TipoAcademicaUsuarioModifica] [bigint] NULL,
	[TipoAcademicaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_TP_ACADEMICA] PRIMARY KEY CLUSTERED 
(
	[TipoAcademicaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoCaracter]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCaracter](
	[TipoCaracterId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoCaracterCodigo] [bigint] NOT NULL,
	[TipoCaracterNombre] [nvarchar](50) NULL,
	[TipoCaracterActivo] [bit] NULL,
	[TipoCaracterUsuarioRegistra] [bigint] NULL,
	[TipoCaracterFechaRegistro] [datetime] NULL,
	[TipoCaracterUsuarioModifica] [bigint] NULL,
	[TipoCaracterFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_TP_CARACTER] PRIMARY KEY CLUSTERED 
(
	[TipoCaracterId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoCondicion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCondicion](
	[TipoCondicionId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoCondicionCodigo] [bigint] NOT NULL,
	[TipoCondicionNombre] [nvarchar](100) NULL,
	[TipoCondicionActivo] [bit] NULL,
	[TipoCondicionUsuarioRegistra] [bigint] NULL,
	[TipoCondicionFechaRegistro] [datetime] NULL,
	[TipoCondicionUsuarioModifica] [bigint] NULL,
	[TipoCondicionFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_TP_CONDICION] PRIMARY KEY CLUSTERED 
(
	[TipoCondicionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoDevengo]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDevengo](
	[TipoDevengoId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoDevengoCodigo] [nvarchar](2) NOT NULL,
	[TipoDevengoNombre] [nvarchar](100) NULL,
	[TipoDevengoActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[TipoDevengoUsuarioRegistra] [bigint] NULL,
	[TipoDevengoFechaRegistro] [datetime] NULL,
	[TipoDevengoUsuarioModifica] [bigint] NULL,
	[TipoDevengoFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_TP_DEVENGOS] PRIMARY KEY CLUSTERED 
(
	[TipoDevengoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoDiscapacidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoDiscapacidad](
	[TipoDiscapacidadId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoDiscapacidadCodigo] [bigint] NOT NULL,
	[TipoDiscapacidadNombre] [nvarchar](100) NULL,
	[TipoDiscapacidadActivo] [bit] NULL,
	[TipoDiscapacidadUsuarioRegistra] [bigint] NULL,
	[TipoDiscapacidadFechaRegistro] [datetime] NULL,
	[TipoDiscapacidadUsuarioModifica] [bigint] NULL,
	[TipoDiscapacidadFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_TP_DISCAPACIDAD] PRIMARY KEY CLUSTERED 
(
	[TipoDiscapacidadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoIdentificacion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoIdentificacion](
	[TipoIdentificacionId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoIdentificacionCodigo] [nvarchar](3) NOT NULL,
	[TipoIdentificacionNombre] [varchar](10) NOT NULL,
	[TipoIdentificacionActivo] [bit] NULL,
	[TipoIdentificacionUsuarioRegistra] [bigint] NULL,
	[TipoIdentificacionFechaRegistro] [datetime] NULL,
	[TipoIdentificacionUsuarioModifica] [bigint] NULL,
	[TipoIdentificacionFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_TP_IDENTIFICACION] PRIMARY KEY CLUSTERED 
(
	[TipoIdentificacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoNovedad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoNovedad](
	[TipoNovedadId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoNovedadCodigo] [nvarchar](2) NOT NULL,
	[TipoNovedadNombre] [nvarchar](255) NULL,
	[TipoNovedadActivo] [bit] NULL,
	[TipoNovedadUsuarioRegistra] [bigint] NULL,
	[TipoNovedadFechaRegistro] [datetime] NULL,
	[TipoNovedadUsuarioModifica] [bigint] NULL,
	[TipoNovedadFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_TP_NOVEDAD] PRIMARY KEY CLUSTERED 
(
	[TipoNovedadId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoRespuesta]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoRespuesta](
	[TipoRespuestaId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoRespuestaCodigo] [nvarchar](1) NOT NULL,
	[TipoRespuestaNombre] [nvarchar](10) NULL,
	[TipoRespuestaActivo] [bit] NULL,
	[TipoRespuestaUsuarioRegistra] [bigint] NULL,
	[TipoRespuestaFechaRegistro] [datetime] NULL,
	[TipoRespuestaUsuarioModifica] [bigint] NULL,
	[TipoRespuestaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_TP_RESPUESTA] PRIMARY KEY CLUSTERED 
(
	[TipoRespuestaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoSectorEducacion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoSectorEducacion](
	[TipoSectorEducacionId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoSectorEducacionCodigo] [nvarchar](2) NOT NULL,
	[TipoSectorEducacionNombre] [nvarchar](100) NULL,
	[TipoSectorEducacionActivo] [bit] NULL,
	[TipoSectorEducacionUsuarioRegistra] [bigint] NULL,
	[TipoSectorEducacionFechaRegistro] [datetime] NULL,
	[TipoSectorEducacionUsuarioModifica] [bigint] NULL,
	[TipoSectorEducacionFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_TP_SECTOR_EDU] PRIMARY KEY CLUSTERED 
(
	[TipoSectorEducacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoVinculacion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoVinculacion](
	[TipoVinculacionId] [bigint] IDENTITY(1,1) NOT NULL,
	[TipoVinculacionCodigo] [nvarchar](2) NOT NULL,
	[TipoVinculacionNombre] [nvarchar](100) NULL,
	[TipoVinculacionActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[TipoVinculacionUsuarioRegistra] [bigint] NOT NULL,
	[TipoVinculacionFechaRegistro] [datetime] NULL,
	[TipoVinculacionUsuarioModifica] [bigint] NULL,
	[TipoVinculacionFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_TP_VINCULACION] PRIMARY KEY CLUSTERED 
(
	[TipoVinculacionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[UsuarioId] [bigint] IDENTITY(1,1) NOT NULL,
	[UsuarioCodigo] [nvarchar](10) NOT NULL,
	[UsuarioNombre] [nvarchar](50) NOT NULL,
	[UsuarioLogin] [nvarchar](10) NULL,
	[UsuarioPassword] [nvarchar](40) NOT NULL,
	[UsuarioDireccion] [nvarchar](100) NULL,
	[UsuarioTelefono] [nvarchar](20) NULL,
	[UsuarioCelular] [nvarchar](20) NULL,
	[PerfilId] [bigint] NULL,
	[UsuarioCaduca] [bit] NOT NULL,
	[UsuarioFechaAsignacion] [datetime] NULL,
	[UsuarioFechaVencimiento] [datetime] NULL,
	[TipoIdentificacionId] [bigint] NOT NULL,
	[UsuarioNumeroIdentificacion] [nvarchar](10) NOT NULL,
	[UsuarioActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[UsuarioUsuarioRegistra] [bigint] NULL,
	[UsuarioFechaRegistro] [datetime] NULL,
	[UsuarioUsuarioModifica] [bigint] NULL,
	[UsuarioFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_USR_1] PRIMARY KEY CLUSTERED 
(
	[UsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UsuarioPermiso]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UsuarioPermiso](
	[UsuarioPermisoId] [bigint] IDENTITY(1,1) NOT NULL,
	[MenuId] [bigint] NOT NULL,
	[PerfilId] [bigint] NOT NULL,
	[UsuarioPermisoModulo] [bigint] NOT NULL,
	[UsuarioPermisoNombrePrograma] [nvarchar](100) NULL,
	[UsuarioPermisoNombreModulo] [nvarchar](100) NULL,
	[UsuarioPermisoAcceso] [int] NOT NULL,
	[UsuarioPermisoInsertar] [int] NOT NULL,
	[UsuarioPermisosActualizar] [int] NULL,
	[UsuarioPermisoEliminar] [int] NOT NULL,
	[UsuarioPermisoBuscar] [int] NOT NULL,
	[UsuarioPermisoImprimir] [int] NOT NULL,
	[UsuarioPermisoExportar] [int] NOT NULL,
	[UsuarioPermisoActivo] [nvarchar](1) NULL,
	[UsuarioPermisoCrea] [nvarchar](50) NULL,
	[UsuarioPermisoModifica] [nvarchar](50) NULL,
	[UsuarioPermisoFechaCreacion] [datetime] NULL,
	[UsuarioPermisoFechaModificacion] [datetime] NULL,
 CONSTRAINT [PK_T_TP_UsuarioPermiso] PRIMARY KEY CLUSTERED 
(
	[UsuarioPermisoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ValoracionLetra]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ValoracionLetra](
	[ValoracionLetrasId] [bigint] IDENTITY(1,1) NOT NULL,
	[ValoracionLetrasCodigo] [nvarchar](5) NULL,
	[ValoracionLetrasNombre] [nvarchar](255) NULL,
	[ValoracionLetrasValorNumerico] [int] NULL,
	[SedeId] [bigint] NULL,
	[ValoracionLetrasActivo] [bit] NULL,
	[InstitucionId] [bigint] NULL,
	[ValoracionLetrasUsuarioRegistra] [bigint] NULL,
	[ValoracionLetrasFechaRegistro] [datetime] NULL,
	[ValoracionLetrasUsuarioModifica] [bigint] NULL,
	[ValoracionLetrasFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_VALORACION_LETRAS] PRIMARY KEY CLUSTERED 
(
	[ValoracionLetrasId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Zona]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zona](
	[ZonaId] [bigint] IDENTITY(1,1) NOT NULL,
	[ZonaCodigo] [bigint] NOT NULL,
	[ZonaNombre] [nvarchar](10) NULL,
	[ZonaDescripcion] [nvarchar](10) NULL,
	[CursoActivo] [bit] NULL,
	[ZonaUsuarioRegistra] [bigint] NULL,
	[ZonaFechaRegistro] [datetime] NULL,
	[ZonaUsuarioModifica] [bigint] NULL,
	[ZonaFechaModifica] [datetime] NULL,
 CONSTRAINT [PK_T_ZONAS] PRIMARY KEY CLUSTERED 
(
	[ZonaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[gv_Menu]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[gv_Menu]
AS
/*
** Select all rows from the Menu table
** and the lookup expressions defined for associated tables
*/
SELECT [Menu].* FROM [Menu]

GO
/****** Object:  View [dbo].[gv_sysdiagrams]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[gv_sysdiagrams]
AS
/*
** Select all rows from the sysdiagrams table
** and the lookup expressions defined for associated tables
*/
SELECT [sysdiagrams].* FROM [sysdiagrams]

GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[AporteParafiscal]
(
	[AporteParafiscalCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[AporteParafiscal]
(
	[AporteParafiscalNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Cargo]
(
	[CargoCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Cargo]
(
	[CargoNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[ClasesFuncionario]
(
	[ClaseFuncionarioCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[ClasesFuncionario]
(
	[ClaseFuncionarioNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Curso]
(
	[CursoCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Curso]
(
	[CursoNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Departamento]
(
	[DepartamentoCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Departamento]
(
	[DepartamentoNombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Equivalencia]
(
	[EquivalenciaCodigo] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Equivalencia]
(
	[EquivalenciaRangoNumerico] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[EscalaNacional]
(
	[EscalaNacionalCodigo] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[EscalaNacional]
(
	[EscalaNacionalNombre] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[EstadoCivil]
(
	[EstadoCivilCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[EstadoCivil]
(
	[EstadoCivilNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[FactorRh]
(
	[FactorRhCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[FactorRh]
(
	[FactorRhNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Grado]
(
	[GradoCodigo] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Grado]
(
	[GradoNombre] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Grupo]
(
	[GrupoCodigo] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Grupo]
(
	[GrupoNombre] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[GrupoUsuario]
(
	[GrupoUsuarioCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Institucion]
(
	[InstitucionCodigoDane] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NIT]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NIT] ON [dbo].[Institucion]
(
	[InstitucionNit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Institucion]
(
	[InstitucionNombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Juicio]
(
	[JuicioCodigo] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Juicio]
(
	[JuicioNombre] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[LibretaMilitar]
(
	[LibretaMilitarCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[LibretaMilitar]
(
	[LibretaMilitarNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Materia]
(
	[MateriaCodigo] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Materia]
(
	[MateriaNombre] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Municipio]
(
	[MunicipioCodigoUnificado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Municipio]
(
	[MunicipioCodigoUnificado] ASC,
	[MunicipioNombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[NivelEducativo]
(
	[NivelEducativoCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[NivelEducativo]
(
	[NivelEducativoNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[NivelEducativoDocente]
(
	[NivelEducativoDocenteCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[NivelEducativoDocente]
(
	[NivelEducativoDocenteNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[OpcionMenuUsuario]
(
	[MenuId] ASC,
	[GrupoUsuarioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Periodo]
(
	[PeriodoCodigo] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Periodo]
(
	[PeriodoNombre] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Profesor]
(
	[TipoIdentificacionId] ASC,
	[ProfesorNumeroDocumento] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[TipoAcademico]
(
	[TipoAcademicaCodigo] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[TipoAcademico]
(
	[TipoAcademicaNombre] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[TipoDevengo]
(
	[TipoDevengoCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[TipoDevengo]
(
	[TipoDevengoNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[TipoVinculacion]
(
	[TipoVinculacionCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[TipoVinculacion]
(
	[TipoVinculacionNombre] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[Usuario]
(
	[TipoIdentificacionId] ASC,
	[UsuarioNumeroIdentificacion] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_LOGIN]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_LOGIN] ON [dbo].[Usuario]
(
	[UsuarioCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_LOGIN_PASSWORD]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_LOGIN_PASSWORD] ON [dbo].[Usuario]
(
	[UsuarioCodigo] ASC,
	[UsuarioPassword] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[Usuario]
(
	[UsuarioCodigo] ASC,
	[InstitucionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_CODIGO]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_CODIGO] ON [dbo].[ValoracionLetra]
(
	[ValoracionLetrasCodigo] ASC,
	[InstitucionId] ASC,
	[SedeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ_NOMBRE]    Script Date: 19/09/2018 10:00:25 p.m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [UQ_NOMBRE] ON [dbo].[ValoracionLetra]
(
	[ValoracionLetrasNombre] ASC,
	[SedeId] ASC,
	[InstitucionId] ASC,
	[ValoracionLetrasCodigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Sede] ADD  CONSTRAINT [DF_T_SEDES_NUM_INICIAL]  DEFAULT ((0)) FOR [SedeNumeroInicial]
GO
ALTER TABLE [dbo].[Sede] ADD  CONSTRAINT [DF_T_SEDES_NUM_FINAL]  DEFAULT ((0)) FOR [SedeNumeroFinal]
GO
ALTER TABLE [dbo].[Usuario] ADD  CONSTRAINT [DF_T_USR_CADU_USR]  DEFAULT ((0)) FOR [UsuarioCaduca]
GO
ALTER TABLE [dbo].[AporteParafiscal]  WITH CHECK ADD  CONSTRAINT [FK_T_APORTE_PARAFISCAL_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[AporteParafiscal] CHECK CONSTRAINT [FK_T_APORTE_PARAFISCAL_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Ars]  WITH CHECK ADD  CONSTRAINT [FK_Ars_Instituciones] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Ars] CHECK CONSTRAINT [FK_Ars_Instituciones]
GO
ALTER TABLE [dbo].[Cargo]  WITH CHECK ADD  CONSTRAINT [FK_T_CARGOS_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Cargo] CHECK CONSTRAINT [FK_T_CARGOS_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_Cursos_Grados] FOREIGN KEY([GradoId])
REFERENCES [dbo].[Grado] ([GradoId])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_Cursos_Grados]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_T_CURSO_T_GRUPO] FOREIGN KEY([GrupoId])
REFERENCES [dbo].[Grupo] ([GrupoId])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_T_CURSO_T_GRUPO]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_T_CURSO_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_T_CURSO_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_T_CURSO_T_JORNADAS] FOREIGN KEY([JornadaId])
REFERENCES [dbo].[Jornada] ([JornadaId])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_T_CURSO_T_JORNADAS]
GO
ALTER TABLE [dbo].[Curso]  WITH CHECK ADD  CONSTRAINT [FK_T_CURSO_T_SEDES] FOREIGN KEY([SedeId])
REFERENCES [dbo].[Sede] ([SedeId])
GO
ALTER TABLE [dbo].[Curso] CHECK CONSTRAINT [FK_T_CURSO_T_SEDES]
GO
ALTER TABLE [dbo].[Equivalencia]  WITH CHECK ADD  CONSTRAINT [FK_T_EQUIVALENCIAS_T_ESCALA_NACIONAL] FOREIGN KEY([EscalaNacionalId])
REFERENCES [dbo].[EscalaNacional] ([EscalaNacionalId])
GO
ALTER TABLE [dbo].[Equivalencia] CHECK CONSTRAINT [FK_T_EQUIVALENCIAS_T_ESCALA_NACIONAL]
GO
ALTER TABLE [dbo].[Equivalencia]  WITH CHECK ADD  CONSTRAINT [FK_T_EQUIVALENCIAS_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Equivalencia] CHECK CONSTRAINT [FK_T_EQUIVALENCIAS_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Equivalencia]  WITH CHECK ADD  CONSTRAINT [FK_T_EQUIVALENCIAS_T_INSTITUCION1] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Equivalencia] CHECK CONSTRAINT [FK_T_EQUIVALENCIAS_T_INSTITUCION1]
GO
ALTER TABLE [dbo].[Equivalencia]  WITH CHECK ADD  CONSTRAINT [FK_T_EQUIVALENCIAS_T_SEDES] FOREIGN KEY([SedeId])
REFERENCES [dbo].[Sede] ([SedeId])
GO
ALTER TABLE [dbo].[Equivalencia] CHECK CONSTRAINT [FK_T_EQUIVALENCIAS_T_SEDES]
GO
ALTER TABLE [dbo].[Equivalencia]  WITH CHECK ADD  CONSTRAINT [FK_T_EQUIVALENCIAS_T_VALORACION_LETRAS] FOREIGN KEY([ValorLetraId])
REFERENCES [dbo].[ValoracionLetra] ([ValoracionLetrasId])
GO
ALTER TABLE [dbo].[Equivalencia] CHECK CONSTRAINT [FK_T_EQUIVALENCIAS_T_VALORACION_LETRAS]
GO
ALTER TABLE [dbo].[EscalaNacional]  WITH CHECK ADD  CONSTRAINT [FK_T_ESCALA_NACIONAL_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[EscalaNacional] CHECK CONSTRAINT [FK_T_ESCALA_NACIONAL_T_INSTITUCION]
GO
ALTER TABLE [dbo].[EscalaNacional]  WITH CHECK ADD  CONSTRAINT [FK_T_ESCALA_NACIONAL_T_SEDES] FOREIGN KEY([SedeId])
REFERENCES [dbo].[Sede] ([SedeId])
GO
ALTER TABLE [dbo].[EscalaNacional] CHECK CONSTRAINT [FK_T_ESCALA_NACIONAL_T_SEDES]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_ARS] FOREIGN KEY([ArsId])
REFERENCES [dbo].[Ars] ([ArsId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_ARS]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_CAP_EXCEPCIONALES] FOREIGN KEY([CapacidadExcepcionalId])
REFERENCES [dbo].[CapacidadExcepcional] ([CapacidadExcepcionalId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_CAP_EXCEPCIONALES]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO] FOREIGN KEY([DepartamentoExpedicionId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO1] FOREIGN KEY([DepartamentoNacimientoId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO1]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO2] FOREIGN KEY([DepartamentoResidenciaId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO2]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO3] FOREIGN KEY([DepartamentoExpulsorId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO3]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO4] FOREIGN KEY([DepartamentoExpedicionMadreId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO4]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO5] FOREIGN KEY([DepartamentoResidenciaMadreId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO5]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO6] FOREIGN KEY([DepartamentoExpedicionPadreId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO6]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO7] FOREIGN KEY([DepartamentoResidenciaPadreId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO7]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO8] FOREIGN KEY([DepartamentoExpedicionAcudienteId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO8]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO9] FOREIGN KEY([DepartamentoResidenciaAcudienteId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_DEPARTAMENTO9]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_EPS] FOREIGN KEY([EpsId])
REFERENCES [dbo].[Eps] ([EpsId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_EPS]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_ESTRATO] FOREIGN KEY([EstratoId])
REFERENCES [dbo].[Estrato] ([EstratoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_ESTRATO]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_ETNIAS] FOREIGN KEY([EtniaId])
REFERENCES [dbo].[Etnia] ([EtniaId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_ETNIAS]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_FACTOR_RH] FOREIGN KEY([FactorRhId])
REFERENCES [dbo].[FactorRh] ([FactorRhId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_FACTOR_RH]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_GENERO] FOREIGN KEY([GeneroAcudienteId])
REFERENCES [dbo].[Genero] ([GeneroId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_GENERO]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_GENERO1] FOREIGN KEY([GeneroId])
REFERENCES [dbo].[Genero] ([GeneroId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_GENERO1]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO] FOREIGN KEY([MunicipioExpedicionId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO1] FOREIGN KEY([MunicipioNacimientoId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO1]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO2] FOREIGN KEY([MunicipioResidenciaId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO2]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO3] FOREIGN KEY([MunicipioExpulsorId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO3]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO4] FOREIGN KEY([MunicipioExpedicionMadreId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO4]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO5] FOREIGN KEY([MunicipioResidenciaMadreId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO5]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO6] FOREIGN KEY([MunicipioExpedicionPadreId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO6]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO7] FOREIGN KEY([MunicipioResidenciaPadreId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO7]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO8] FOREIGN KEY([MunicipioExpedicionAcudiente])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO8]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO9] FOREIGN KEY([MunicipioResidenciaAcudienteId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_MUNICIPIO9]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_PARENTESCO] FOREIGN KEY([ParentescoAcudienteId])
REFERENCES [dbo].[Parentesco] ([ParentescoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_PARENTESCO]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_POBLA_VIC_CONFLICTO] FOREIGN KEY([PoblacionVictimaId])
REFERENCES [dbo].[PoblacionVictimaConflicto] ([PoblVicConflictoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_POBLA_VIC_CONFLICTO]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_RESGUARDOS] FOREIGN KEY([ResguardoId])
REFERENCES [dbo].[Resguardo] ([ResguardoId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_RESGUARDOS]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_SEDES] FOREIGN KEY([SedeId])
REFERENCES [dbo].[Sede] ([SedeId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_SEDES]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_SISBEN] FOREIGN KEY([SisbenId])
REFERENCES [dbo].[Sisben] ([SisbenId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_SISBEN]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_TP_DISCAPACIDAD] FOREIGN KEY([DiscapacidadId])
REFERENCES [dbo].[TipoDiscapacidad] ([TipoDiscapacidadId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_TP_DISCAPACIDAD]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_TP_IDENTIFICACION] FOREIGN KEY([TipoIdentificacionId])
REFERENCES [dbo].[TipoIdentificacion] ([TipoIdentificacionId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_TP_IDENTIFICACION]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_TP_IDENTIFICACION1] FOREIGN KEY([TipoIdentificacionMadreId])
REFERENCES [dbo].[TipoIdentificacion] ([TipoIdentificacionId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_TP_IDENTIFICACION1]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_TP_IDENTIFICACION2] FOREIGN KEY([TipoIdentificacionPadreId])
REFERENCES [dbo].[TipoIdentificacion] ([TipoIdentificacionId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_TP_IDENTIFICACION2]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_TP_IDENTIFICACION3] FOREIGN KEY([TipoIdentificacionAcudienteId])
REFERENCES [dbo].[TipoIdentificacion] ([TipoIdentificacionId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_TP_IDENTIFICACION3]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_ZONAS] FOREIGN KEY([ZonaResidenciaId])
REFERENCES [dbo].[Zona] ([ZonaId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_ZONAS]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_ZONAS1] FOREIGN KEY([ZonaResidenciaMadreId])
REFERENCES [dbo].[Zona] ([ZonaId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_ZONAS1]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_ZONAS2] FOREIGN KEY([ZonaResicenciaPadreId])
REFERENCES [dbo].[Zona] ([ZonaId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_ZONAS2]
GO
ALTER TABLE [dbo].[Estudiante]  WITH CHECK ADD  CONSTRAINT [FK_T_ESTUDIANTES_T_ZONAS3] FOREIGN KEY([ZonaResidenciaAcudienteId])
REFERENCES [dbo].[Zona] ([ZonaId])
GO
ALTER TABLE [dbo].[Estudiante] CHECK CONSTRAINT [FK_T_ESTUDIANTES_T_ZONAS3]
GO
ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_T_GRUPO_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_T_GRUPO_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Grupo]  WITH CHECK ADD  CONSTRAINT [FK_T_GRUPO_T_SEDES] FOREIGN KEY([SedeId])
REFERENCES [dbo].[Sede] ([SedeId])
GO
ALTER TABLE [dbo].[Grupo] CHECK CONSTRAINT [FK_T_GRUPO_T_SEDES]
GO
ALTER TABLE [dbo].[Institucion]  WITH CHECK ADD  CONSTRAINT [FK_T_INSTITUCION_T_ASOCIACION_PRIVADA] FOREIGN KEY([AsociacionId])
REFERENCES [dbo].[AsociacionPrivada] ([AsociacionPrivadaId])
GO
ALTER TABLE [dbo].[Institucion] CHECK CONSTRAINT [FK_T_INSTITUCION_T_ASOCIACION_PRIVADA]
GO
ALTER TABLE [dbo].[Institucion]  WITH CHECK ADD  CONSTRAINT [FK_T_INSTITUCION_T_DEPARTAMENTO] FOREIGN KEY([DepartamentoId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Institucion] CHECK CONSTRAINT [FK_T_INSTITUCION_T_DEPARTAMENTO]
GO
ALTER TABLE [dbo].[Institucion]  WITH CHECK ADD  CONSTRAINT [FK_T_INSTITUCION_T_GENERO] FOREIGN KEY([GeneroId])
REFERENCES [dbo].[Genero] ([GeneroId])
GO
ALTER TABLE [dbo].[Institucion] CHECK CONSTRAINT [FK_T_INSTITUCION_T_GENERO]
GO
ALTER TABLE [dbo].[Institucion]  WITH CHECK ADD  CONSTRAINT [FK_T_INSTITUCION_T_IDIOMAS] FOREIGN KEY([IdiomaId])
REFERENCES [dbo].[Idioma] ([IdiomaId])
GO
ALTER TABLE [dbo].[Institucion] CHECK CONSTRAINT [FK_T_INSTITUCION_T_IDIOMAS]
GO
ALTER TABLE [dbo].[Institucion]  WITH CHECK ADD  CONSTRAINT [FK_T_INSTITUCION_T_MUNICIPIO] FOREIGN KEY([MunicipioId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Institucion] CHECK CONSTRAINT [FK_T_INSTITUCION_T_MUNICIPIO]
GO
ALTER TABLE [dbo].[Institucion]  WITH CHECK ADD  CONSTRAINT [FK_T_INSTITUCION_T_REGIMEN_COSTO] FOREIGN KEY([RegimenCostoId])
REFERENCES [dbo].[RegimenCosto] ([RegimenCostoId])
GO
ALTER TABLE [dbo].[Institucion] CHECK CONSTRAINT [FK_T_INSTITUCION_T_REGIMEN_COSTO]
GO
ALTER TABLE [dbo].[Institucion]  WITH CHECK ADD  CONSTRAINT [FK_T_INSTITUCION_T_TARIFA_ANUAL] FOREIGN KEY([TarifaAnualId])
REFERENCES [dbo].[TarifaAnual] ([TarifaAnualId])
GO
ALTER TABLE [dbo].[Institucion] CHECK CONSTRAINT [FK_T_INSTITUCION_T_TARIFA_ANUAL]
GO
ALTER TABLE [dbo].[Institucion]  WITH CHECK ADD  CONSTRAINT [FK_T_INSTITUCION_T_ZONAS] FOREIGN KEY([ZonaId])
REFERENCES [dbo].[Zona] ([ZonaId])
GO
ALTER TABLE [dbo].[Institucion] CHECK CONSTRAINT [FK_T_INSTITUCION_T_ZONAS]
GO
ALTER TABLE [dbo].[Juicio]  WITH CHECK ADD  CONSTRAINT [FK_Juicios_Materias] FOREIGN KEY([MateriaId])
REFERENCES [dbo].[Materia] ([MateriaId])
GO
ALTER TABLE [dbo].[Juicio] CHECK CONSTRAINT [FK_Juicios_Materias]
GO
ALTER TABLE [dbo].[Juicio]  WITH CHECK ADD  CONSTRAINT [FK_Juicios_Sedes] FOREIGN KEY([SedeId])
REFERENCES [dbo].[Sede] ([SedeId])
GO
ALTER TABLE [dbo].[Juicio] CHECK CONSTRAINT [FK_Juicios_Sedes]
GO
ALTER TABLE [dbo].[Juicio]  WITH CHECK ADD  CONSTRAINT [FK_T_JUICIOS_T_GRUPO] FOREIGN KEY([GrupoId])
REFERENCES [dbo].[Grupo] ([GrupoId])
GO
ALTER TABLE [dbo].[Juicio] CHECK CONSTRAINT [FK_T_JUICIOS_T_GRUPO]
GO
ALTER TABLE [dbo].[Juicio]  WITH CHECK ADD  CONSTRAINT [FK_T_JUICIOS_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Juicio] CHECK CONSTRAINT [FK_T_JUICIOS_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Juicio]  WITH CHECK ADD  CONSTRAINT [FK_T_JUICIOS_T_JORNADAS] FOREIGN KEY([JornadaId])
REFERENCES [dbo].[Jornada] ([JornadaId])
GO
ALTER TABLE [dbo].[Juicio] CHECK CONSTRAINT [FK_T_JUICIOS_T_JORNADAS]
GO
ALTER TABLE [dbo].[Juicio]  WITH CHECK ADD  CONSTRAINT [FK_T_JUICIOS_T_PERIODO] FOREIGN KEY([PeriodoId])
REFERENCES [dbo].[Periodo] ([PeriodoId])
GO
ALTER TABLE [dbo].[Juicio] CHECK CONSTRAINT [FK_T_JUICIOS_T_PERIODO]
GO
ALTER TABLE [dbo].[LibretaMilitar]  WITH CHECK ADD  CONSTRAINT [FK_T_LIBRETA_MILITAR_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[LibretaMilitar] CHECK CONSTRAINT [FK_T_LIBRETA_MILITAR_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_Materias_Profesores] FOREIGN KEY([ProfesorId])
REFERENCES [dbo].[Profesor] ([ProfesorId])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_Materias_Profesores]
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_T_MATERIA_T_GRADO] FOREIGN KEY([GradoId])
REFERENCES [dbo].[Grado] ([GradoId])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_T_MATERIA_T_GRADO]
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_T_MATERIA_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_T_MATERIA_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Materia]  WITH CHECK ADD  CONSTRAINT [FK_T_MATERIA_T_JORNADAS] FOREIGN KEY([JornadaId])
REFERENCES [dbo].[Jornada] ([JornadaId])
GO
ALTER TABLE [dbo].[Materia] CHECK CONSTRAINT [FK_T_MATERIA_T_JORNADAS]
GO
ALTER TABLE [dbo].[Municipio]  WITH CHECK ADD  CONSTRAINT [FK_T_MUNICIPIO_T_DEPARTAMENTO] FOREIGN KEY([DepartamentoId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Municipio] CHECK CONSTRAINT [FK_T_MUNICIPIO_T_DEPARTAMENTO]
GO
ALTER TABLE [dbo].[OpcionMenuUsuario]  WITH CHECK ADD  CONSTRAINT [FK_T_OPC_MENUXUSR_T_GRUPO_USR] FOREIGN KEY([GrupoUsuarioId])
REFERENCES [dbo].[GrupoUsuario] ([GrupoUsuarioId])
GO
ALTER TABLE [dbo].[OpcionMenuUsuario] CHECK CONSTRAINT [FK_T_OPC_MENUXUSR_T_GRUPO_USR]
GO
ALTER TABLE [dbo].[OpcionMenuUsuario]  WITH CHECK ADD  CONSTRAINT [FK_T_OPC_MENUXUSR_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[OpcionMenuUsuario] CHECK CONSTRAINT [FK_T_OPC_MENUXUSR_T_INSTITUCION]
GO
ALTER TABLE [dbo].[OpcionMenuUsuario]  WITH CHECK ADD  CONSTRAINT [FK_T_OPC_MENUXUSR_T_MENU] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menu] ([MenuId])
GO
ALTER TABLE [dbo].[OpcionMenuUsuario] CHECK CONSTRAINT [FK_T_OPC_MENUXUSR_T_MENU]
GO
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_T_PROFESOR_T_ESCALAFON] FOREIGN KEY([EscalafonId])
REFERENCES [dbo].[Escalafon] ([EscalafonId])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_T_PROFESOR_T_ESCALAFON]
GO
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_T_PROFESOR_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_T_PROFESOR_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_T_PROFESOR_T_PROFESION] FOREIGN KEY([ProfesionId])
REFERENCES [dbo].[Profesion] ([ProfesionId])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_T_PROFESOR_T_PROFESION]
GO
ALTER TABLE [dbo].[Profesor]  WITH CHECK ADD  CONSTRAINT [FK_T_PROFESOR_T_TP_IDENTIFICACION] FOREIGN KEY([TipoIdentificacionId])
REFERENCES [dbo].[TipoIdentificacion] ([TipoIdentificacionId])
GO
ALTER TABLE [dbo].[Profesor] CHECK CONSTRAINT [FK_T_PROFESOR_T_TP_IDENTIFICACION]
GO
ALTER TABLE [dbo].[Sede]  WITH CHECK ADD  CONSTRAINT [FK_Sedes_Departamentos] FOREIGN KEY([DepartamentoId])
REFERENCES [dbo].[Departamento] ([DepartamentoId])
GO
ALTER TABLE [dbo].[Sede] CHECK CONSTRAINT [FK_Sedes_Departamentos]
GO
ALTER TABLE [dbo].[Sede]  WITH CHECK ADD  CONSTRAINT [FK_T_SEDES_T_ESPECIALIDAD] FOREIGN KEY([EspecialidadId])
REFERENCES [dbo].[Especialidad] ([EspecialidadId])
GO
ALTER TABLE [dbo].[Sede] CHECK CONSTRAINT [FK_T_SEDES_T_ESPECIALIDAD]
GO
ALTER TABLE [dbo].[Sede]  WITH CHECK ADD  CONSTRAINT [FK_T_SEDES_T_MUNICIPIO] FOREIGN KEY([MunicipioId])
REFERENCES [dbo].[Municipio] ([MunicipioId])
GO
ALTER TABLE [dbo].[Sede] CHECK CONSTRAINT [FK_T_SEDES_T_MUNICIPIO]
GO
ALTER TABLE [dbo].[Sede]  WITH CHECK ADD  CONSTRAINT [FK_T_SEDES_T_ZONAS] FOREIGN KEY([ZonaId])
REFERENCES [dbo].[Zona] ([ZonaId])
GO
ALTER TABLE [dbo].[Sede] CHECK CONSTRAINT [FK_T_SEDES_T_ZONAS]
GO
ALTER TABLE [dbo].[TipoAcademico]  WITH CHECK ADD  CONSTRAINT [FK_T_TP_ACADEMICA_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[TipoAcademico] CHECK CONSTRAINT [FK_T_TP_ACADEMICA_T_INSTITUCION]
GO
ALTER TABLE [dbo].[TipoDevengo]  WITH CHECK ADD  CONSTRAINT [FK_T_TP_DEVENGOS_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[TipoDevengo] CHECK CONSTRAINT [FK_T_TP_DEVENGOS_T_INSTITUCION]
GO
ALTER TABLE [dbo].[TipoVinculacion]  WITH CHECK ADD  CONSTRAINT [FK_T_TP_VINCULACION_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[TipoVinculacion] CHECK CONSTRAINT [FK_T_TP_VINCULACION_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_T_USR_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_T_USR_T_INSTITUCION]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Perfiles] FOREIGN KEY([PerfilId])
REFERENCES [dbo].[Perfil] ([PerfilId])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuarios_Perfiles]
GO
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermisos_Menus] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menu] ([MenuId])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermisos_Menus]
GO
ALTER TABLE [dbo].[UsuarioPermiso]  WITH CHECK ADD  CONSTRAINT [FK_UsuarioPermisos_Perfiles] FOREIGN KEY([PerfilId])
REFERENCES [dbo].[Perfil] ([PerfilId])
GO
ALTER TABLE [dbo].[UsuarioPermiso] CHECK CONSTRAINT [FK_UsuarioPermisos_Perfiles]
GO
ALTER TABLE [dbo].[ValoracionLetra]  WITH CHECK ADD  CONSTRAINT [FK_T_VALORACION_LETRAS_T_INSTITUCION] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[ValoracionLetra] CHECK CONSTRAINT [FK_T_VALORACION_LETRAS_T_INSTITUCION]
GO
ALTER TABLE [dbo].[ValoracionLetra]  WITH CHECK ADD  CONSTRAINT [FK_T_VALORACION_LETRAS_T_INSTITUCION1] FOREIGN KEY([InstitucionId])
REFERENCES [dbo].[Institucion] ([InstitucionId])
GO
ALTER TABLE [dbo].[ValoracionLetra] CHECK CONSTRAINT [FK_T_VALORACION_LETRAS_T_INSTITUCION1]
GO
ALTER TABLE [dbo].[ValoracionLetra]  WITH CHECK ADD  CONSTRAINT [FK_T_VALORACION_LETRAS_T_SEDES] FOREIGN KEY([SedeId])
REFERENCES [dbo].[Sede] ([SedeId])
GO
ALTER TABLE [dbo].[ValoracionLetra] CHECK CONSTRAINT [FK_T_VALORACION_LETRAS_T_SEDES]
GO
/****** Object:  StoredProcedure [dbo].[ObtenerOpcionesMenu]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	ObtenerOpcionesMenu
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/
CREATE PROCEDURE [dbo].[ObtenerOpcionesMenu]
(
	@codUsr nvarchar(20)
)

AS

	SELECT	T_MENU.ID_MENU, 
			T_MENU.DESCRIPCION, 
			T_MENU.POSICION, 
			T_MENU.ID_PADRE, 
			T_MENU.ICONO, 
			T_MENU.HABILITADO, 
			T_MENU.URL
	FROM	T_MENU 
			INNER JOIN T_OPC_MENUXUSR ON T_MENU.ID_MENU = T_OPC_MENUXUSR.ID_MENU 
			INNER JOIN T_GRUPO_USR ON T_OPC_MENUXUSR.ID_GRUPO_USR = T_GRUPO_USR.ID_GRUPO_USR 
			INNER JOIN T_USR ON T_GRUPO_USR.ID_GRUPO_USR = T_USR.ID_GRUPO_USR
	WHERE	T_MENU.HABILITADO = 1
			 AND T_USR.ACTIVO = 1 
			 AND T_OPC_MENUXUSR.ACTIVO = 1
			 AND T_USR.COD_USR = @codUsr
	ORDER BY ID_MENU
			 

--IF (SELECT T_USR.ACTIVO FROM T_USR WHERE COD_USR = @codUsr) = 1
--BEGIN
--	SELECT	T_MENU.ID_MENU, 
--			T_MENU.DESCRIPCION, 
--			T_MENU.POSICION, 
--			T_MENU.ID_PADRE, 
--			T_MENU.ICONO, 
--			T_MENU.HABILITADO, 
--			T_MENU.URL
--	FROM	T_MENU 
--			INNER JOIN T_OPC_MENUXUSR ON T_MENU.ID_MENU = T_OPC_MENUXUSR.ID_MENU 
--			INNER JOIN T_GRUPO_USR ON T_OPC_MENUXUSR.ID_GRUPO_USR = T_GRUPO_USR.ID_GRUPO_USR 
--			INNER JOIN T_USR ON T_GRUPO_USR.ID_GRUPO_USR = T_USR.ID_GRUPO_USR
--	WHERE	T_MENU.HABILITADO = 1 
--			AND T_USR.ACTIVO = 1 
--			AND T_USR.COD_USR = @codUsr
--END
--ELSE
--BEGIN
--	SELECT	T_MENU.ID_MENU, 
--			T_MENU.DESCRIPCION, 
--			T_MENU.POSICION, 
--			T_MENU.ID_PADRE, 
--			T_MENU.ICONO, 
--			T_MENU.HABILITADO, 
--			T_MENU.URL
--	FROM	T_MENU 
--			INNER JOIN T_OPC_MENUXUSR ON T_MENU.ID_MENU = T_OPC_MENUXUSR.ID_MENU 
--			INNER JOIN T_GRUPO_USR ON T_OPC_MENUXUSR.ID_GRUPO_USR = T_GRUPO_USR.ID_GRUPO_USR 
--			INNER JOIN T_USR ON T_GRUPO_USR.ID_GRUPO_USR = T_USR.ID_GRUPO_USR
--	WHERE	T_MENU.HABILITADO = 1
--			 AND T_USR.ACTIVO = 1 
--			 AND T_USR.COD_USR = @codUsr
--			 AND T_OPC_MENUXUSR.ACTIVO = 1
--END


GO
/****** Object:  StoredProcedure [dbo].[ObtenerUsuarioLogin]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	ObtenerUsuarioLogin
Creado por:		jreyes
Fecha:			10/03/2012
Descripcion:	Obtiene el usuario y el login
******************************************************************************************************/

CREATE PROCEDURE [dbo].[ObtenerUsuarioLogin]

(
	@codUsr AS NVARCHAR(20)	
)

AS

SELECT	* 
FROM	T_USR
WHERE	COD_USR = @codUsr

GO
/****** Object:  StoredProcedure [dbo].[spActualizarAsignaturas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spActualizarAsignaturas]
(
	@idAsignatura as integer,
    @codAsignatura as nvarchar(10),
	@nomAsignatura nvarchar(255),
	@activo bit,
	@usuarioReg  nvarchar(20),
	@fechaReg datetime
)

AS

UPDATE	T_ASIGNATURA
SET		COD_ASIGNATURA = @codAsignatura,
		NOM_ASIGNATURA = @nomAsignatura,
		ACTIVO = @activo,
		USUARIO_REG = @usuarioReg,
		FECHA_REG = @fechaReg
WHERE	ID_ASIGNATURA = @idAsignatura
		
GO
/****** Object:  StoredProcedure [dbo].[spActualizarCapExcepcional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:  spActualizarCapExcepcional
Creado por:     jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarCapExcepcional]
(
	@idCapExcepcional  bigint,
	@codCapExcepcional bigint,
	@nomCapExcepcional  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_CAP_EXCEPCIONALES
SET
	COD_CAP_EXCEPCIONALES = @codCapExcepcional,
	NOM_CAP_EXCEPCIONALES = @nomCapExcepcional,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_CAP_EXCEPCIONALES = @idCapExcepcional
GO
/****** Object:  StoredProcedure [dbo].[spActualizarDepartamentos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarDepartamentos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarDepartamentos]
(
	@idDepartamento  bigint,
	@codDepartamento  nvarchar(4),
	@nomDepartamento  nvarchar(510),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_DEPARTAMENTO
SET
	COD_DEPARTAMENTO = @codDepartamento,
	NOM_DEPARTAMENTO = @nomDepartamento,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_DEPARTAMENTO = @idDepartamento
GO
/****** Object:  StoredProcedure [dbo].[spActualizarEscalafon]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spActualizarEscalafon
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Actualizar informacion de la tabla T_ESCALAFON
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spActualizarEscalafon]
(
	@ID_ESCALAFON bigint,-- Parametro de 
	@COD_ESCALAFON nvarchar(2),-- Parametro de 
	@NOM_ESCALAFON nvarchar(100) =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)
AS
UPDATE T_ESCALAFON SET 
	COD_ESCALAFON = @COD_ESCALAFON,
	NOM_ESCALAFON = @NOM_ESCALAFON,
	ACTIVO = @ACTIVO,
	ID_INSTITUCION = @ID_INSTITUCION,
	USUARIO_REG = @USUARIO_REG,
	FECHA_REG = @FECHA_REG
WHERE
	ID_ESCALAFON = @ID_ESCALAFON

GO
/****** Object:  StoredProcedure [dbo].[spActualizarEscNacional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spActualizarEscNacional
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Actualizar informacion de la tabla T_ESCALA_NACIONAL
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spActualizarEscNacional]
(
	@ID_ESCALA_NACIONAL bigint,-- Parametro de 
	@COD_ESCALA_NACIONAL nvarchar(5) =  NULL,-- Parametro de 
	@DESCRIPCION nvarchar(255) =  NULL,-- Parametro de 
	@CRITERIO_EVAL nvarchar(255) =  NULL,-- Parametro de 
	@ID_SEDE bigint =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)

AS

IF @ID_SEDE = 0
BEGIN
	SET @ID_SEDE = NULL
END

UPDATE T_ESCALA_NACIONAL SET 
	COD_ESCALA_NACIONAL = @COD_ESCALA_NACIONAL,
	DESCRIPCION = @DESCRIPCION,
	CRITERIO_EVAL = @CRITERIO_EVAL,
	ID_SEDE = @ID_SEDE,
	ACTIVO = @ACTIVO,
	ID_INSTITUCION = @ID_INSTITUCION,
	USUARIO_REG = @USUARIO_REG,
	FECHA_REG = @FECHA_REG
WHERE
	ID_ESCALA_NACIONAL = @ID_ESCALA_NACIONAL

GO
/****** Object:  StoredProcedure [dbo].[spActualizarEspecialidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarEspecialidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarEspecialidad]
(
	@idEspecialidad  bigint,
	@codEspecialidad  bigint,
	@nomEspecialidad  nvarchar(50),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

UPDATE T_ESPECIALIDAD
SET
	COD_ESPECIALIDAD = @codEspecialidad,
	NOM_ESPECIALIDAD = @nomEspecialidad,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_ESPECIALIDAD = @idEspecialidad
GO
/****** Object:  StoredProcedure [dbo].[spActualizarEstratos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:    spActualizarEstratos
Creado por:       jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarEstratos]
(
	@id_estrato  bigint,
	@cod_estrato  bigint,
	@nom_estrato  nvarchar(20),
	@activo  bit,
	@usuario_reg  nvarchar(40),
	@fecha_reg  datetime
)

AS

UPDATE T_ESTRATO
SET
	COD_ESTRATO = @cod_estrato,
	NOM_ESTRATO = @nom_estrato,
	ACTIVO = @activo,
	USUARIO_REG = @usuario_reg,
	FECHA_REG = @fecha_reg
WHERE (ID_ESTRATO = @id_estrato)



GO
/****** Object:  StoredProcedure [dbo].[spActualizarEstudiantes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spActualizarEstudiantes
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 18/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Actualizar informacion de la tabla T_ESTUDIANTES
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spActualizarEstudiantes]
(
	@ID_ESTUDIANTE bigint, 
	@COD_ESTUDIANTE nvarchar(20), 
	@COD_MEN nvarchar(20) =  NULL, 
	@ID_TP_IDENTIFICACION bigint =  NULL, 
	@NUM_DOCUMENTO nvarchar(20) =  NULL, 
	@ID_DEPARATAMENTO_EXP bigint =  NULL, 
	@ID_MUNICIPIO_EXPEDICION bigint =  NULL, 
	@PRIMER_APELLIDO nvarchar(10) =  NULL, 
	@SEGUNDO_APELLIDO nvarchar(10) =  NULL, 
	@PRIMER_NOMBRE nvarchar(20) =  NULL, 
	@SEGUNDO_NOMBRE nvarchar(10) =  NULL, 
	@FECHA_NACIMIENTO datetime =  NULL, 
	@ID_DEPARTAMENTO_NAC bigint =  NULL, 
	@ID_MUNICIPIO_NAC bigint =  NULL, 
	@ID_GENERO bigint =  NULL, 
	@ID_FACTOR_RH bigint =  NULL, 
	@EMAIL_ESTUDIANTE nvarchar(50) =  NULL, 
	@FOTOGRAFIA image =  NULL, 
	@DIRECCION nvarchar(100) =  NULL, 
	@ID_DEPARTAMENTO_RESID bigint =  NULL, 
	@ID_MUNICIPIO_RESID bigint =  NULL, 
	@ID_ZONA_RESID bigint =  NULL, 
	@LOCALIDAD nvarchar(100) =  NULL, 
	@BARRIO nvarchar(100) =  NULL, 
	@ID_ESTRATO bigint =  NULL, 
	@TELEFONO nvarchar(20) =  NULL, 
	@CELULAR nvarchar(20) =  NULL, 
	@ID_SISBEN bigint =  NULL, 
	@NUMERO_SISBEN nvarchar(20) =  NULL, 
	@ID_EPS bigint =  NULL, 
	@ID_ARS bigint =  NULL, 
	@ID_POBLACION_VICTIMA bigint =  NULL, 
	@ID_DEPARTAMENTO_EXPULSOR bigint =  NULL, 
	@ID_MUNICIPIO_EXPULSOR bigint =  NULL, 
	@FECHA_EXPULSOR datetime =  NULL, 
	@CERTIFICADO_EXPULSOR nvarchar(20) =  NULL, 
	@FECHA_CERTIFICADO_EXPULSOR datetime =  NULL, 
	@ID_TP_DISCAPACIDAD bigint =  NULL, 
	@ID_TP_CAPACIDAD_EXCEP bigint =  NULL, 
	@ID_ETNIA bigint =  NULL, 
	@ID_RESGUARDO bigint =  NULL, 
	@PROVIENE_SECT_PRIVADO bit =  NULL, 
	@PROVIENE_OTRO_MPIO bit =  NULL, 
	@INST_BIENESTAR nvarchar(100) =  NULL, 
	@ID_TP_IDENTIFICACION_MADRE bigint =  NULL, 
	@NUM_DOCUMENTO_MADRE nvarchar(20) =  NULL, 
	@ID_DEPARATAMENTO_EXP_MADRE bigint =  NULL, 
	@ID_MUNICIPIO_EXPEDICION_MADRE bigint =  NULL, 
	@PRIMER_APELLIDO_MADRE nvarchar(10) =  NULL, 
	@SEGUNDO_APELLIDO_MADRE nvarchar(10) =  NULL, 
	@PRIMER_NOMBRE_MADRE nvarchar(20) =  NULL, 
	@SEGUNDO_NOMBRE_MADRE nvarchar(10) =  NULL, 
	@EMAIL_MADRE nvarchar(50) =  NULL, 
	@DIRECCION_MADRE nvarchar(100) =  NULL, 
	@ID_DEPARTAMENTO_RESID_MADRE bigint =  NULL, 
	@ID_MUNICIPIO_RESID_MADRE bigint =  NULL, 
	@ID_ZONA_RESID_MADRE bigint =  NULL, 
	@BARRIO_MADRE nvarchar(100) =  NULL, 
	@LOCALIDAD_MADRE nvarchar(100) =  NULL, 
	@TELEFONO_MADRE nvarchar(20) =  NULL, 
	@CELULAR_MADRE nvarchar(20) =  NULL, 
	@OCUPACION_MADRE nvarchar(100) =  NULL, 
	@EMPRESA_MADRE nvarchar(100) =  NULL, 
	@TELEFONO_EMPRESA_MADRE nvarchar(20) =  NULL, 
	@ID_TP_IDENTIFICACION_PADRE bigint =  NULL, 
	@NUM_DOCUMENTO_PADRE nvarchar(20) =  NULL, 
	@ID_DEPARATAMENTO_EXP_PADRE bigint =  NULL, 
	@ID_MUNICIPIO_EXPEDICION_PADRE bigint =  NULL, 
	@PRIMER_APELLIDO_PADRE nvarchar(10) =  NULL, 
	@SEGUNDO_APELLIDO_PADRE nvarchar(10) =  NULL, 
	@PRIMER_NOMBRE_PADRE nvarchar(20) =  NULL, 
	@SEGUNDO_NOMBRE_PADRE nvarchar(10) =  NULL, 
	@EMAIL_PADRE nvarchar(50) =  NULL, 
	@DIRECCION_PADRE nvarchar(100) =  NULL, 
	@ID_DEPARTAMENTO_RESID_PADRE bigint =  NULL, 
	@ID_MUNICIPIO_RESID_PADRE bigint =  NULL, 
	@ID_ZONA_RESID_PADRE bigint =  NULL, 
	@BARRIO_PADRE nvarchar(100) =  NULL, 
	@LOCALIDAD_PADRE nvarchar(100) =  NULL, 
	@TELEFONO_PADRE nvarchar(20) =  NULL, 
	@CELULAR_PADRE nvarchar(20) =  NULL, 
	@OCUPACION_PADRE nvarchar(100) =  NULL, 
	@EMPRESA_PADRE nvarchar(100) =  NULL, 
	@TELEFONO_EMPRESA_PADRE nvarchar(20) =  NULL, 
	@ID_TP_IDENTIFICACION_ACUDIENTE bigint =  NULL, 
	@NUM_DOCUMENTO_ACUDIENTE nvarchar(20) =  NULL, 
	@ID_DEPARATAMENTO_EXP_ACUDIENTE bigint =  NULL, 
	@ID_MUNICIPIO_EXPEDICION_ACUDIENTE bigint =  NULL, 
	@PRIMER_APELLIDO_ACUDIENTE nvarchar(10) =  NULL, 
	@SEGUNDO_APELLIDO_ACUDIENTE nvarchar(10) =  NULL, 
	@PRIMER_NOMBRE_ACUDIENTE nvarchar(20) =  NULL, 
	@SEGUNDO_NOMBRE_ACUDIENTE nvarchar(10) =  NULL, 
	@EMAIL_ACUDIENTE nvarchar(50) =  NULL, 
	@DIRECCION_ACUDIENTE nvarchar(100) =  NULL, 
	@ID_DEPARTAMENTO_RESID_ACUDIENTE bigint =  NULL, 
	@ID_MUNICIPIO_RESID_ACUDIENTE bigint =  NULL, 
	@ID_ZONA_RESID_ACUDIENTE bigint =  NULL, 
	@BARRIO_ACUDIENTE nvarchar(100) =  NULL, 
	@LOCALIDAD_ACUDIENTE nvarchar(100) =  NULL, 
	@TELEFONO_ACUDIENTE nvarchar(20) =  NULL, 
	@CELULAR_ACUDIENTE nvarchar(20) =  NULL, 
	@OCUPACION_ACUDIENTE nvarchar(100) =  NULL, 
	@EMPRESA_ACUDIENTE nvarchar(100) =  NULL, 
	@TELEFONO_EMPRESA_ACUDIENTE nvarchar(20) =  NULL, 
	@ID_GENERO_ACUDIENTE bigint =  NULL, 
	@ID_PARENTESCO_ACUDIENTE bigint =  NULL, 
	@COLEGIO_ULTIMO_CURSO nvarchar(100) =  NULL, 
	@DIRECCION_COLEG_ULTIMO nvarchar(100) =  NULL, 
	@TELEFONO_COLEG_ULTIMO nvarchar(20) =  NULL, 
	@GRADO_ULTIMO nvarchar(10) =  NULL, 
	@ANIO nvarchar(4) =  NULL, 
	@MOTIVO_RETIRO_ULTIMO nvarchar(255) =  NULL, 
	@OBSERVACIONES text =  NULL, 
	@USUARIO_ESTUDIANTE nvarchar(20) =  NULL, 
	@CLAVE_ACCESO nvarchar(20) =  NULL, 
	@ID_GRUPO_USR nvarchar(2) =  NULL, 
	@ID_SEDE bigint =  NULL, 
	@ACTIVO bit =  NULL, 
	@ID_INSTITUCION bigint =  NULL, 
	@USUARIO_REG nvarchar(20) =  NULL, 
	@FECHA_REG datetime =  NULL,
	@SEL_MADRE BIT = NULL,
	@SEL_PADRE BIT = NULL,
	@SEL_ACUDIENTE INT = NULL 
)

AS

IF @ID_SEDE = 0
BEGIN
	SET @ID_SEDE = NULL
END

IF @ID_DEPARTAMENTO_EXPULSOR = 0
BEGIN
	SET @ID_DEPARTAMENTO_EXPULSOR = NULL
END

IF @ID_MUNICIPIO_EXPULSOR = 0
BEGIN
	SET @ID_MUNICIPIO_EXPULSOR = NULL
END

IF @CERTIFICADO_EXPULSOR = 0
BEGIN
	SET @CERTIFICADO_EXPULSOR = NULL
END

IF @ID_DEPARATAMENTO_EXP_MADRE = 0
BEGIN
	SET @ID_DEPARATAMENTO_EXP_MADRE = NULL
END

IF @ID_MUNICIPIO_EXPEDICION_MADRE = 0
BEGIN
	SET @ID_MUNICIPIO_EXPEDICION_MADRE = NULL
END

IF @ID_DEPARTAMENTO_RESID_MADRE = 0
BEGIN
	SET @ID_DEPARTAMENTO_RESID_MADRE = NULL
END

IF @ID_MUNICIPIO_RESID_MADRE = 0
BEGIN
	SET @ID_MUNICIPIO_RESID_MADRE = NULL
END

IF @ID_ZONA_RESID_MADRE = 0
BEGIN
	SET @ID_ZONA_RESID_MADRE = NULL
END

IF @ID_DEPARATAMENTO_EXP_PADRE = 0
BEGIN
	SET @ID_DEPARATAMENTO_EXP_PADRE = NULL
END

IF @ID_MUNICIPIO_EXPEDICION_PADRE = 0
BEGIN
	SET @ID_MUNICIPIO_EXPEDICION_PADRE = NULL
END

IF @ID_DEPARTAMENTO_RESID_PADRE = 0
BEGIN
	SET @ID_DEPARTAMENTO_RESID_PADRE = NULL
END

IF @ID_MUNICIPIO_RESID_PADRE = 0
BEGIN
	SET @ID_MUNICIPIO_RESID_PADRE = NULL
END

IF @ID_ZONA_RESID_PADRE = 0
BEGIN
	SET @ID_ZONA_RESID_PADRE = NULL
END

IF @ID_DEPARATAMENTO_EXP_ACUDIENTE = 0
BEGIN
	SET @ID_DEPARATAMENTO_EXP_ACUDIENTE = NULL
END

IF @ID_MUNICIPIO_EXPEDICION_ACUDIENTE = 0
BEGIN
	SET @ID_MUNICIPIO_EXPEDICION_ACUDIENTE = NULL
END

IF @ID_DEPARTAMENTO_RESID_ACUDIENTE = 0
BEGIN
	SET @ID_DEPARTAMENTO_RESID_ACUDIENTE = NULL
END

IF @ID_MUNICIPIO_RESID_ACUDIENTE = 0
BEGIN
	SET @ID_MUNICIPIO_RESID_ACUDIENTE = NULL
END

IF @ID_ZONA_RESID_ACUDIENTE = 0
BEGIN
	SET @ID_ZONA_RESID_ACUDIENTE = NULL
END

IF @ID_TP_IDENTIFICACION = 0
BEGIN
	SET @ID_TP_IDENTIFICACION = NULL
END

IF @ID_TP_IDENTIFICACION_MADRE = 0
BEGIN
	SET @ID_TP_IDENTIFICACION_MADRE = NULL
END

IF @ID_TP_IDENTIFICACION_PADRE = 0
BEGIN
	SET @ID_TP_IDENTIFICACION_PADRE = NULL
END

IF @ID_TP_IDENTIFICACION_ACUDIENTE = 0
BEGIN
	SET @ID_TP_IDENTIFICACION_ACUDIENTE = NULL
END


UPDATE T_ESTUDIANTES SET 
	COD_ESTUDIANTE = @COD_ESTUDIANTE,
	COD_MEN = @COD_MEN,
	ID_TP_IDENTIFICACION = @ID_TP_IDENTIFICACION,
	NUM_DOCUMENTO = @NUM_DOCUMENTO,
	ID_DEPARATAMENTO_EXP = @ID_DEPARATAMENTO_EXP,
	ID_MUNICIPIO_EXPEDICION = @ID_MUNICIPIO_EXPEDICION,
	PRIMER_APELLIDO = @PRIMER_APELLIDO,
	SEGUNDO_APELLIDO = @SEGUNDO_APELLIDO,
	PRIMER_NOMBRE = @PRIMER_NOMBRE,
	SEGUNDO_NOMBRE = @SEGUNDO_NOMBRE,
	FECHA_NACIMIENTO = @FECHA_NACIMIENTO,
	ID_DEPARTAMENTO_NAC = @ID_DEPARTAMENTO_NAC,
	ID_MUNICIPIO_NAC = @ID_MUNICIPIO_NAC,
	ID_GENERO = @ID_GENERO,
	ID_FACTOR_RH = @ID_FACTOR_RH,
	EMAIL_ESTUDIANTE = @EMAIL_ESTUDIANTE,
	FOTOGRAFIA = @FOTOGRAFIA,
	DIRECCION = @DIRECCION,
	ID_DEPARTAMENTO_RESID = @ID_DEPARTAMENTO_RESID,
	ID_MUNICIPIO_RESID = @ID_MUNICIPIO_RESID,
	ID_ZONA_RESID = @ID_ZONA_RESID,
	LOCALIDAD = @LOCALIDAD,
	BARRIO = @BARRIO,
	ID_ESTRATO = @ID_ESTRATO,
	TELEFONO = @TELEFONO,
	CELULAR = @CELULAR,
	ID_SISBEN = @ID_SISBEN,
	NUMERO_SISBEN = @NUMERO_SISBEN,
	ID_EPS = @ID_EPS,
	ID_ARS = @ID_ARS,
	ID_POBLACION_VICTIMA = @ID_POBLACION_VICTIMA,
	ID_DEPARTAMENTO_EXPULSOR = @ID_DEPARTAMENTO_EXPULSOR,
	ID_MUNICIPIO_EXPULSOR = @ID_MUNICIPIO_EXPULSOR,
	FECHA_EXPULSOR = @FECHA_EXPULSOR,
	CERTIFICADO_EXPULSOR = @CERTIFICADO_EXPULSOR,
	FECHA_CERTIFICADO_EXPULSOR = @FECHA_CERTIFICADO_EXPULSOR,
	ID_TP_DISCAPACIDAD = @ID_TP_DISCAPACIDAD,
	ID_TP_CAPACIDAD_EXCEP = @ID_TP_CAPACIDAD_EXCEP,
	ID_ETNIA = @ID_ETNIA,
	ID_RESGUARDO = @ID_RESGUARDO,
	PROVIENE_SECT_PRIVADO = @PROVIENE_SECT_PRIVADO,
	PROVIENE_OTRO_MPIO = @PROVIENE_OTRO_MPIO,
	INST_BIENESTAR = @INST_BIENESTAR,
	ID_TP_IDENTIFICACION_MADRE = @ID_TP_IDENTIFICACION_MADRE,
	NUM_DOCUMENTO_MADRE = @NUM_DOCUMENTO_MADRE,
	ID_DEPARATAMENTO_EXP_MADRE = @ID_DEPARATAMENTO_EXP_MADRE,
	ID_MUNICIPIO_EXPEDICION_MADRE = @ID_MUNICIPIO_EXPEDICION_MADRE,
	PRIMER_APELLIDO_MADRE = @PRIMER_APELLIDO_MADRE,
	SEGUNDO_APELLIDO_MADRE = @SEGUNDO_APELLIDO_MADRE,
	PRIMER_NOMBRE_MADRE = @PRIMER_NOMBRE_MADRE,
	SEGUNDO_NOMBRE_MADRE = @SEGUNDO_NOMBRE_MADRE,
	EMAIL_MADRE = @EMAIL_MADRE,
	DIRECCION_MADRE = @DIRECCION_MADRE,
	ID_DEPARTAMENTO_RESID_MADRE = @ID_DEPARTAMENTO_RESID_MADRE,
	ID_MUNICIPIO_RESID_MADRE = @ID_MUNICIPIO_RESID_MADRE,
	ID_ZONA_RESID_MADRE = @ID_ZONA_RESID_MADRE,
	BARRIO_MADRE = @BARRIO_MADRE,
	LOCALIDAD_MADRE = @LOCALIDAD_MADRE,
	TELEFONO_MADRE = @TELEFONO_MADRE,
	CELULAR_MADRE = @CELULAR_MADRE,
	OCUPACION_MADRE = @OCUPACION_MADRE,
	EMPRESA_MADRE = @EMPRESA_MADRE,
	TELEFONO_EMPRESA_MADRE = @TELEFONO_EMPRESA_MADRE,
	ID_TP_IDENTIFICACION_PADRE = @ID_TP_IDENTIFICACION_PADRE,
	NUM_DOCUMENTO_PADRE = @NUM_DOCUMENTO_PADRE,
	ID_DEPARATAMENTO_EXP_PADRE = @ID_DEPARATAMENTO_EXP_PADRE,
	ID_MUNICIPIO_EXPEDICION_PADRE = @ID_MUNICIPIO_EXPEDICION_PADRE,
	PRIMER_APELLIDO_PADRE = @PRIMER_APELLIDO_PADRE,
	SEGUNDO_APELLIDO_PADRE = @SEGUNDO_APELLIDO_PADRE,
	PRIMER_NOMBRE_PADRE = @PRIMER_NOMBRE_PADRE,
	SEGUNDO_NOMBRE_PADRE = @SEGUNDO_NOMBRE_PADRE,
	EMAIL_PADRE = @EMAIL_PADRE,
	DIRECCION_PADRE = @DIRECCION_PADRE,
	ID_DEPARTAMENTO_RESID_PADRE = @ID_DEPARTAMENTO_RESID_PADRE,
	ID_MUNICIPIO_RESID_PADRE = @ID_MUNICIPIO_RESID_PADRE,
	ID_ZONA_RESID_PADRE = @ID_ZONA_RESID_PADRE,
	BARRIO_PADRE = @BARRIO_PADRE,
	LOCALIDAD_PADRE = @LOCALIDAD_PADRE,
	TELEFONO_PADRE = @TELEFONO_PADRE,
	CELULAR_PADRE = @CELULAR_PADRE,
	OCUPACION_PADRE = @OCUPACION_PADRE,
	EMPRESA_PADRE = @EMPRESA_PADRE,
	TELEFONO_EMPRESA_PADRE = @TELEFONO_EMPRESA_PADRE,
	ID_TP_IDENTIFICACION_ACUDIENTE = @ID_TP_IDENTIFICACION_ACUDIENTE,
	NUM_DOCUMENTO_ACUDIENTE = @NUM_DOCUMENTO_ACUDIENTE,
	ID_DEPARATAMENTO_EXP_ACUDIENTE = @ID_DEPARATAMENTO_EXP_ACUDIENTE,
	ID_MUNICIPIO_EXPEDICION_ACUDIENTE = @ID_MUNICIPIO_EXPEDICION_ACUDIENTE,
	PRIMER_APELLIDO_ACUDIENTE = @PRIMER_APELLIDO_ACUDIENTE,
	SEGUNDO_APELLIDO_ACUDIENTE = @SEGUNDO_APELLIDO_ACUDIENTE,
	PRIMER_NOMBRE_ACUDIENTE = @PRIMER_NOMBRE_ACUDIENTE,
	SEGUNDO_NOMBRE_ACUDIENTE = @SEGUNDO_NOMBRE_ACUDIENTE,
	EMAIL_ACUDIENTE = @EMAIL_ACUDIENTE,
	DIRECCION_ACUDIENTE = @DIRECCION_ACUDIENTE,
	ID_DEPARTAMENTO_RESID_ACUDIENTE = @ID_DEPARTAMENTO_RESID_ACUDIENTE,
	ID_MUNICIPIO_RESID_ACUDIENTE = @ID_MUNICIPIO_RESID_ACUDIENTE,
	ID_ZONA_RESID_ACUDIENTE = @ID_ZONA_RESID_ACUDIENTE,
	BARRIO_ACUDIENTE = @BARRIO_ACUDIENTE,
	LOCALIDAD_ACUDIENTE = @LOCALIDAD_ACUDIENTE,
	TELEFONO_ACUDIENTE = @TELEFONO_ACUDIENTE,
	CELULAR_ACUDIENTE = @CELULAR_ACUDIENTE,
	OCUPACION_ACUDIENTE = @OCUPACION_ACUDIENTE,
	EMPRESA_ACUDIENTE = @EMPRESA_ACUDIENTE,
	TELEFONO_EMPRESA_ACUDIENTE = @TELEFONO_EMPRESA_ACUDIENTE,
	ID_GENERO_ACUDIENTE = @ID_GENERO_ACUDIENTE,
	ID_PARENTESCO_ACUDIENTE = @ID_PARENTESCO_ACUDIENTE,
	COLEGIO_ULTIMO_CURSO = @COLEGIO_ULTIMO_CURSO,
	DIRECCION_COLEG_ULTIMO = @DIRECCION_COLEG_ULTIMO,
	TELEFONO_COLEG_ULTIMO = @TELEFONO_COLEG_ULTIMO,
	GRADO_ULTIMO = @GRADO_ULTIMO,
	ANIO = @ANIO,
	MOTIVO_RETIRO_ULTIMO = @MOTIVO_RETIRO_ULTIMO,
	OBSERVACIONES = @OBSERVACIONES,
	USUARIO_ESTUDIANTE = @USUARIO_ESTUDIANTE,
	CLAVE_ACCESO = @CLAVE_ACCESO,
	ID_GRUPO_USR = @ID_GRUPO_USR,
	ID_SEDE = @ID_SEDE,
	ACTIVO = @ACTIVO,
	ID_INSTITUCION = @ID_INSTITUCION,
	USUARIO_REG = @USUARIO_REG,
	FECHA_REG = @FECHA_REG,
	SEL_MADRE = @SEL_MADRE,
	SEL_PADRE = @SEL_PADRE,
	SEL_ACUDIENTE = @SEL_ACUDIENTE

WHERE	ID_ESTUDIANTE = @ID_ESTUDIANTE

GO
/****** Object:  StoredProcedure [dbo].[spActualizarEtnias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarEtnias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spActualizarEtnias]
(
	@idEtnia  bigint,
	@codEtnia  nvarchar(3),
	@nomEtnia  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_ETNIAS
SET
	COD_ETNIAS = @codEtnia,
	NOM_ETNIAS = @nomEtnia,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_ETNIAS = @idEtnia
GO
/****** Object:  StoredProcedure [dbo].[spActualizarFuenteRecursos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarFuenteRecursos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spActualizarFuenteRecursos]
(
	@idFuenteRecursos  bigint,
	@codFuenteRecursos  bigint,
	@nomFuenteRecursos  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

UPDATE T_FUENTE_RECURSOS
SET
	COD_FUENTE_RECURSOS = @codFuenteRecursos,
	NOM_FUENTE_RECURSOS = @nomFuenteRecursos,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_FUENTE_RECURSOS = @idFuenteRecursos
GO
/****** Object:  StoredProcedure [dbo].[spActualizarGrupos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarGrupos
Creado por:		jreyes
Fecha:			29/01/2013
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarGrupos]
(
	@idGrupo  bigint,
	@codGrupo  nvarchar(10),
	@nomGrupo  nvarchar(100),
	@idSede  bigint,
	@activo  bit,
	@idInstitucion  bigint,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

IF @idSede = 0
BEGIN
	SET @idSede =  NULL
END

UPDATE T_GRUPO
SET
	COD_GRUPO = @codGrupo,
	NOM_GRUPO = @nomGrupo,
	ID_SEDE = @idSede,
	ACTIVO = @activo,
	ID_INSTITUCION = @idInstitucion,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg

WHERE ID_GRUPO = @idGrupo


GO
/****** Object:  StoredProcedure [dbo].[spActualizarGruposUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spActualizarGruposUsr
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Actualiza los grupos por usuarios
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarGruposUsr]
(
	@idGrupoUsr  bigint,
	@codGrupoUsr  bigint,
	@nombreGrupoUsr  nvarchar(50),
	@activo bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_GRUPO_USR
SET
	COD_GRUPO_USR = @codGrupoUsr,
	NOMBRE_GRUPO_USR = @nombreGrupoUsr,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg

WHERE ID_GRUPO_USR = @idGrupoUsr

GO
/****** Object:  StoredProcedure [dbo].[spActualizarInstituciones]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarInstituciones
Creado por:		jreyes
Fecha:			27/11/2011
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarInstituciones]
(
	@id_institucion	bigint,
	@codigo_dane	nvarchar(12),
	@nombre_est	nvarchar(100),
	@nit	nvarchar(20),
	@nombre_rector	nvarchar(50),
	@cod_calendario	nvarchar(2),
	@cod_sector	nvarchar(2),
	@cod_propiedad_juridica	nvarchar(2),
	@numero_sedes	int,
	@cod_nucleo	nvarchar(3),
	@id_genero	bigint,
	@subsidio	bit,
	@id_discapacidades	nvarchar(2),
	@id_cap_excepcionales	bigint,
	@id_etnias	bigint,
	@id_resguardos	bigint,
	@cod_novedad_est	nvarchar(2),
	@cod_metodologia	nvarchar(2),
	@cod_prestador_serv	nvarchar(2),
	@decreto_creacion	nvarchar(30),
	@director	nvarchar(30),
	@secretaria	nvarchar(30),
	@aprobacion	nvarchar(30),
	@lema	nvarchar(255),
	@escudo	image,
	@id_deparatamento	bigint,
	@id_municipio	bigint,
	@id_zona	bigint,
	@barrio	nvarchar(30),
	@direccion	nvarchar(100),
	@telefono	nvarchar(20),
	@fax	nvarchar(20),
	@sitio_web	nvarchar(20),
	@email	nvarchar(20),
	@num_licencia	nvarchar(10),
	@id_regimen_costo	bigint,
	@id_idioma	bigint,
	@id_asociacion	bigint,
	@id_tarifa_anual	bigint,
	--@activo	bit,
	@usuario_reg	nvarchar(20),
	@fecha_reg	datetime
)

AS

IF @escudo IS NULL
BEGIN
	SET @escudo = (SELECT ESCUDO FROM T_INSTITUCION WHERE ID_INSTITUCION = @id_institucion)
END

UPDATE T_INSTITUCION
SET
	CODIGO_DANE = @codigo_dane,
	NOMBRE_EST = @nombre_est,
	NIT = @nit,
	NOMBRE_RECTOR = @nombre_rector,
	COD_CALENDARIO = @cod_calendario,
	COD_SECTOR = @cod_sector,
	COD_PROPIEDAD_JURIDICA = @cod_propiedad_juridica,
	NUMERO_SEDES = @numero_sedes,
	COD_NUCLEO = @cod_nucleo,
	ID_GENERO = @id_genero,
	SUBSIDIO = @subsidio,
	ID_DISCAPACIDADES = @id_discapacidades,
	ID_CAP_EXCEPCIONALES = @id_cap_excepcionales,
	ID_ETNIAS = @id_etnias,
	ID_RESGUARDOS = @id_resguardos,
	COD_NOVEDAD_EST = @cod_novedad_est,
	COD_METODOLOGIA = @cod_metodologia,
	COD_PRESTADOR_SERV = @cod_prestador_serv,
	DECRETO_CREACION = @decreto_creacion,
	DIRECTOR = @director,
	SECRETARIA = @secretaria,
	APROBACION = @aprobacion,
	LEMA = @lema,
	ESCUDO = @escudo,	
	ID_DEPARATAMENTO = @id_deparatamento,
	ID_MUNICIPIO = @id_municipio,
	ID_ZONA = @id_zona,
	BARRIO = @barrio,
	DIRECCION = @direccion,
	TELEFONO = @telefono,
	FAX = @fax,
	SITIO_WEB = @sitio_web,
	EMAIL = @email,
	NUM_LICENCIA = @num_licencia,
	ID_REGIMEN_COSTO = @id_regimen_costo,
	ID_IDIOMA = @id_idioma,
	ID_ASOCIACION = @id_asociacion,
	ID_TARIFA_ANUAL = @id_tarifa_anual,
	--ACTIVO = @activo,
	USUARIO_REG = @usuario_reg,
	FECHA_REG = @fecha_reg

WHERE ID_INSTITUCION = @id_institucion


GO
/****** Object:  StoredProcedure [dbo].[spActualizarJornadas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarJornadas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarJornadas]
(
	@idJornada  bigint,
	@codJornada  nvarchar(2),
	@nomJornada  nvarchar(50),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

UPDATE T_JORNADAS
SET
	COD_JORNADAS = @codJornada,
	NOM_JORNADAS = @nomJornada,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_JORNADAS = @idJornada
GO
/****** Object:  StoredProcedure [dbo].[spActualizarMetodologias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarMetodologias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spActualizarMetodologias]
(
	@idMetodologia  bigint,
	@codMetodologia  bigint,
	@nomMetodologia  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

UPDATE T_METODOLOGIAS
SET
	COD_METODOLOGIAS = @codMetodologia,
	NOM_METODOLOGIAS = @nomMetodologia,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_METODOLOGIAS = @idMetodologia
GO
/****** Object:  StoredProcedure [dbo].[spActualizarMunicipio]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarMunicipio
Creado por:		jreyes
Fecha:			10/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarMunicipio]
(
	@idMunicipio  bigint,
	@idDepartamento  bigint,
	@codUnificado  nvarchar(12),
	@codMunicipio  nvarchar(6),
	@nomMunicipio  nvarchar(510),
	@codDepartamento  nvarchar(4),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_MUNICIPIO
SET
	COD_UNIFICADO = @codUnificado,
	COD_MUNICIPIO = @codMunicipio,
	NOM_MUNICIPIO = @nomMunicipio,
	COD_DEPARTAMENTO = @codDepartamento,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg

WHERE	ID_MUNICIPIO = @idMunicipio
		AND ID_DEPARTAMENTO = @idDepartamento
GO
/****** Object:  StoredProcedure [dbo].[spActualizarPermisos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spActualizarPermisos
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Actualiza los permisos de los grupos
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarPermisos]
(
	@idMenu int,
	@idGrupoUsr  bigint,
	@idInstitucion	bigint,
	@ver	bit,
	@agregar	bit,
	@modificar	bit,
	@eliminar	bit,
	@todos	bit,
	@activo bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

--IF @idInstitucion = 0
--BEGIN
--	SET @idInstitucion = NULL
--END


IF EXISTS(SELECT * FROM T_OPC_MENUXUSR WHERE ID_MENU = @idMenu AND ID_GRUPO_USR = @idGrupoUsr)
BEGIN
	UPDATE T_OPC_MENUXUSR
	SET
		ID_MENU = @idMenu,
		ID_GRUPO_USR = @idGrupoUsr,
		ID_INSTITUCION = @idInstitucion,
		VER = @ver,
		AGREGAR = @agregar,
		MODIFICAR = @modificar,
		ELIMINAR = @eliminar,
		TODOS = @todos,
		ACTIVO = @activo,
		USUARIO_REG = @usuarioReg,
		FECHA_REG = @fechaReg
	
	WHERE	ID_MENU = @idMenu
			AND ID_GRUPO_USR = @idGrupoUsr
END

ELSE

BEGIN
	INSERT INTO T_OPC_MENUXUSR
	(
		ID_MENU,
		ID_GRUPO_USR,
		ID_INSTITUCION,
		VER,
		AGREGAR,
		MODIFICAR,
		ELIMINAR,
		TODOS,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
	VALUES
	(
		@idMenu,
		@idGrupoUsr,
		@idInstitucion,
		@ver,
		@agregar,
		@modificar,
		@eliminar,
		@todos,
		@activo,
		@usuarioReg,
		@fechaReg
	)
END


UPDATE	T_OPC_MENUXUSR
SET		ACTIVO = 0
WHERE	VER = 0 
		AND AGREGAR = 0
		AND MODIFICAR = 0
		AND ELIMINAR = 0
		AND TODOS = 0



GO
/****** Object:  StoredProcedure [dbo].[spActualizarPoblaVicConflicto]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spActualizarPoblaVicConflicto
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spActualizarPoblaVicConflicto]
(
	@idPoblaVicConflicto  bigint,
	@codPoblaVicConflicto  nvarchar(4),
	@nomPoblaVicConflicto  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_POBLA_VIC_CONFLICTO
SET
	COD_POBLA_VIC_CONFLICTO = @codPoblaVicConflicto,
	NOM_POBLA_VIC_CONFLICTO = @nomPoblaVicConflicto,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_POBLA_VIC_CONFLICTO = @idPoblaVicConflicto
GO
/****** Object:  StoredProcedure [dbo].[spActualizarProfesion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spActualizarProfesion
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Actualizar informacion de la tabla T_PROFESION
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spActualizarProfesion]
(
	@ID_PROFESION bigint,-- Parametro de 
	@COD_PROFESION nvarchar(5),-- Parametro de 
	@NOM_PROFESION nvarchar(50),-- Parametro de 
	@ID_SEDE bigint =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)

AS

IF @ID_SEDE = 0
BEGIN 
	SET @ID_SEDE = NULL
END

UPDATE T_PROFESION SET 
	COD_PROFESION = @COD_PROFESION,
	NOM_PROFESION = @NOM_PROFESION,
	ID_SEDE = @ID_SEDE,
	ACTIVO = @ACTIVO,
	ID_INSTITUCION = @ID_INSTITUCION,
	USUARIO_REG = @USUARIO_REG,
	FECHA_REG = @FECHA_REG
WHERE
	ID_PROFESION = @ID_PROFESION

GO
/****** Object:  StoredProcedure [dbo].[spActualizarProfesores]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spActualizarProfesores
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Actualizar informacion de la tabla T_PROFESOR
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spActualizarProfesores]
(
	@ID_PROFESOR bigint,-- Parametro de 
	@COD_PROFESOR nvarchar(10) =  NULL,-- Parametro de 
	@ID_TP_IDENTIFICACION bigint,-- Parametro de 
	@NUM_ID_PROF nvarchar(20),-- Parametro de 
	@PRI_NOMBRE_PROF nvarchar(40),-- Parametro de 
	@SEG_NOMBRE_PROF nvarchar(40) =  NULL,-- Parametro de 
	@PRI_APELLIDO_PROF nvarchar(40),-- Parametro de 
	@SEG_APELLIDO_PROF nvarchar(40) =  NULL,-- Parametro de 
	@DIRECCION_PROF nvarchar(255) =  NULL,-- Parametro de 
	@TELEFONOS_PROF nvarchar(80) =  NULL,-- Parametro de 
	@ID_PROFESION bigint,-- Parametro de 
	@ID_ESCALAFON bigint =  NULL,-- Parametro de 
	@ID_SEDE bigint =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)

AS

IF @ID_SEDE = 0
BEGIN
	SET @ID_SEDE = NULL
END

UPDATE T_PROFESOR SET 
	COD_PROFESOR = @COD_PROFESOR,
	ID_TP_IDENTIFICACION = @ID_TP_IDENTIFICACION,
	NUM_ID_PROF = @NUM_ID_PROF,
	PRI_NOMBRE_PROF = @PRI_NOMBRE_PROF,
	SEG_NOMBRE_PROF = @SEG_NOMBRE_PROF,
	PRI_APELLIDO_PROF = @PRI_APELLIDO_PROF,
	SEG_APELLIDO_PROF = @SEG_APELLIDO_PROF,
	DIRECCION_PROF = @DIRECCION_PROF,
	TELEFONOS_PROF = @TELEFONOS_PROF,
	ID_PROFESION = @ID_PROFESION,
	ID_ESCALAFON = @ID_ESCALAFON,
	ID_SEDE = @ID_SEDE,
	ACTIVO = @ACTIVO,
	ID_INSTITUCION = @ID_INSTITUCION,
	USUARIO_REG = @USUARIO_REG,
	FECHA_REG = @FECHA_REG
WHERE
	ID_PROFESOR = @ID_PROFESOR

GO
/****** Object:  StoredProcedure [dbo].[spActualizarResguardos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarResguardos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spActualizarResguardos]
(
	@idResguardo  bigint,
	@codResguardo  nvarchar(3),
	@nomResguardo  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_RESGUARDOS
SET
	COD_RESGUARDOS = @codResguardo,
	NOM_RESGUARDOS = @nomResguardo,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_RESGUARDOS = @idResguardo
GO
/****** Object:  StoredProcedure [dbo].[spActualizarSedes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spActualizarSedes
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Actualiza las sedes
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarSedes]
(
	@idSede  bigint,
	@codSede  bigint,
	@codDaneNuevo  nvarchar(24),
	@codDaneAntiguo  nvarchar(24),
	@codSedeConsecutivo  nvarchar(40),
	@nombreSede  nvarchar(200),
	@idDepartamento  bigint,
	@idMunicipio  bigint,
	@idZona  bigint,
	@barrio  nvarchar(60),
	@direccion  nvarchar(200),
	@telefono  nvarchar(40),
	@fax  nvarchar(40),
	@email  nvarchar(40),
	@novedadSede  nvarchar(4),
	@jornadaCompleta  bit,
	@jornadaManana  bit,
	@jornadaTarde  bit,
	@jornadaNoche  bit,
	@jornadaFinSem  bit,
	@idEspecialidad  bigint,
	@fechaCreacion  datetime,
	@director  nvarchar(60),
	@secretaria  nvarchar(60),
	@escalaValNal  bit,
	@rangoNum  bit,
	@numInicial integer,
	@numFinal integer,
	@valLetras  bit,
	@juicios  bit,
	@activo  bit,
	@idInstitucion  bigint,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_SEDES
SET
	COD_SEDE = @codSede,
	COD_DANE_NUEVO = @codDaneNuevo,
	COD_DANE_ANTIGUO = @codDaneAntiguo,
	COD_SEDE_CONSECUTIVO = @codSedeConsecutivo,
	NOMBRE_SEDE = @nombreSede,
	ID_DEPARTAMENTO = @idDepartamento,
	ID_MUNICIPIO = @idMunicipio,
	ID_ZONA = @idZona,
	BARRIO = @barrio,
	DIRECCION = @direccion,
	TELEFONO = @telefono,
	FAX = @fax,
	EMAIL = @email,
	NOVEDAD_SEDE = @novedadSede,
	JORNADA_COMPLETA = @jornadaCompleta,
	JORNADA_MANANA = @jornadaManana,
	JORNADA_TARDE = @jornadaTarde,
	JORNADA_NOCHE = @jornadaNoche,
	JORNADA_FIN_SEM = @jornadaFinSem,
	ID_ESPECIALIDAD = @idEspecialidad,
	FECHA_CREACION = @fechaCreacion,
	DIRECTOR = @director,
	SECRETARIA = @secretaria,
	ESCALA_VAL_NAL = @escalaValNal,
	RANGO_NUM = @rangoNum,
	NUM_INICIAL = @numInicial,
	NUM_FINAL = @numFinal,
	VAL_LETRAS = @valLetras,
	JUICIOS = @juicios,
	ACTIVO = @activo,
	ID_INSTITUCION = @idInstitucion,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg

WHERE ID_SEDE = @idSede

GO
/****** Object:  StoredProcedure [dbo].[spActualizarSisben]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spActualizarSisben
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarSisben]
(
	@idSisben  bigint,
	@codSisben  bigint,
	@nomSisben  nvarchar(255),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_SISBEN
SET
	COD_SISBEN = @codSisben,
	NOM_SISBEN = @nomSisben,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_SISBEN = @idSisben
GO
/****** Object:  StoredProcedure [dbo].[spActualizarSituAcademica]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarSituAcademica
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spActualizarSituAcademica]
(
	@idSituAcademica  bigint,
	@codSituAcademica  bigint,
	@nomSituAcademica  nvarchar(255),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

UPDATE T_SITU_ACADEMICA
SET
	COD_SITU_ACADEMICA = @codSituAcademica,
	NOM_SITU_ACADEMICA = @nomSituAcademica,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_SITU_ACADEMICA = @idSituAcademica
GO
/****** Object:  StoredProcedure [dbo].[spActualizarTipoDiscapacidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarTipoDiscapacidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spActualizarTipoDiscapacidad]
(
	@idTpDiscapacidad bigint,
	@codTpDiscapacidad bigint,
	@nomTpDiscapacidad nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_TP_DISCAPACIDAD
SET
	COD_TP_DISCAPACIDAD = @codTpDiscapacidad,
	NOM_TP_DISCAPACIDAD = @nomTpDiscapacidad,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_TP_DISCAPACIDAD = @idTpDiscapacidad
GO
/****** Object:  StoredProcedure [dbo].[spActualizarTipoRespuestas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarTipoRespuestas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarTipoRespuestas]
(
	@idTpRespuestas bigint,
	@codTpRespuestas  nvarchar(1),
	@nomTpRespuestas nvarchar(10),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_TP_RESPUESTA
SET
	COD_TP_RESPUESTA = @codTpRespuestas,
	NOM_TP_RESPUESTA = @nomTpRespuestas,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_TP_RESPUESTA = @idTpRespuestas
GO
/****** Object:  StoredProcedure [dbo].[spActualizarTpCaracter]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarTpCaracter
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarTpCaracter]
(
	@idTpCaracter  bigint,
	@codTpCaracter  bigint,
	@nomTpCaracter  nvarchar(50),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

UPDATE T_TP_CARACTER
SET
	COD_TP_CARACTER = @codTpCaracter,
	NOM_TP_CARACTER = @nomTpCaracter,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_TP_CARACTER = @idTpCaracter
GO
/****** Object:  StoredProcedure [dbo].[spActualizarTpCondicion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarTpCondicion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spActualizarTpCondicion]
(
	@idTpCondicion  bigint,
	@codTpCondicion  bigint,
	@nomTpCondicion  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

UPDATE T_TP_CONDICION
SET
	COD_TP_CONDICION = @codTpCondicion,
	NOM_TP_CONDICION = @nomTpCondicion,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_TP_CONDICION = @idTpCondicion
GO
/****** Object:  StoredProcedure [dbo].[spActualizarTpIdentificacion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarTpIdentificacion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarTpIdentificacion]
(
	@idTpIdentificacion  bigint,
	@codTpIdentificacion  nvarchar(4),
	@nomTpIdentificacion  nvarchar(510),
	@activo  bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

UPDATE T_TP_IDENTIFICACION
SET
	COD_TP_IDENTIFICACION = @codTpIdentificacion,
	NOM_TP_IDENTIFICACION = @nomTpIdentificacion,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_TP_IDENTIFICACION = @idTpIdentificacion
GO
/****** Object:  StoredProcedure [dbo].[spActualizarUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spActualizarUsr
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Actualiza los usuarios
******************************************************************************************************/

CREATE procedure [dbo].[spActualizarUsr]
(
	@idUsr			bigint,
	@codUsr			nvarchar(10),
	@nomUsr			nvarchar(50),
	@paswUsr		nvarchar(40),
	@caduUsr		bit,
	@fechAsigUsr	datetime,
	@fechVctoUsr	datetime,
	@tpIdPers		nvarchar(2),
	@identifPers	nvarchar(10),
	@activo			bit,
	@idInstitucion	bigint,
	@idGrupoUsr		bigint,
	@usuarioReg		nvarchar(20),
	@fechaReg		datetime
)

AS

UPDATE T_USR
SET
	COD_USR = @codUsr,
	NOM_USR = @nomUsr, 
	PASW_USR = @paswUsr,
	CADU_USR = @caduUsr,
	FECH_ASIG_USR = @fechAsigUsr,
	FECH_VCTO_USR = @fechVctoUsr,
	TP_ID_PERS = @tpIdPers,
	IDENTIF_PERS = @identifPers,
	ACTIVO = @activo,
	ID_INSTITUCION = @idInstitucion,
	ID_GRUPO_USR = @idGrupoUsr,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg

WHERE ID_USR = @idUsr

GO
/****** Object:  StoredProcedure [dbo].[spActualizarValLetras]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spActualizarValLetras
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Actualizar informacion de la tabla T_VALORACION_LETRAS
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spActualizarValLetras]
(
	@ID_VAL_LETRAS bigint,-- Parametro de 
	@COD_VAL_LETRAS nvarchar(5) =  NULL,-- Parametro de 
	@DESCRIPCION nvarchar(255) =  NULL,-- Parametro de 
	@VAL_NUMERICO int =  NULL,-- Parametro de 
	@ID_SEDE bigint =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)

AS

IF @ID_SEDE = 0
BEGIN
	SET @ID_SEDE = NULL
END

UPDATE T_VALORACION_LETRAS SET 
	COD_VAL_LETRAS = @COD_VAL_LETRAS,
	DESCRIPCION = @DESCRIPCION,
	VAL_NUMERICO = @VAL_NUMERICO,
	ID_SEDE = @ID_SEDE,
	ACTIVO = @ACTIVO,
	ID_INSTITUCION = @ID_INSTITUCION,
	USUARIO_REG = @USUARIO_REG,
	FECHA_REG = @FECHA_REG
WHERE
	ID_VAL_LETRAS = @ID_VAL_LETRAS

GO
/****** Object:  StoredProcedure [dbo].[spActualizarZonas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spActualizarZonas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spActualizarZonas]
(
	@idZonas  bigint,
	@codZonas  bigint,
	@nomZonas  nvarchar(10),
	@descripcion nvarchar(10),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

UPDATE T_ZONAS
SET
	COD_ZONAS = @codZonas,
	NOM_ZONAS = @nomZonas,
	DESCRIPCION = @descripcion,
	ACTIVO = @activo,
	USUARIO_REG = @usuarioReg,
	FECHA_REG = @fechaReg
WHERE ID_Zonas = @idZonas
GO
/****** Object:  StoredProcedure [dbo].[spBuscarAsignatura]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarAsignatura
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarAsignatura]
(
	@nomAsignatura NVARCHAR(255) 
)
AS

SELECT	*	
FROM	T_ASIGNATURA
WHERE	NOM_ASIGNATURA LIKE '%' + @nomAsignatura + '%'
ORDER BY NOM_ASIGNATURA
GO
/****** Object:  StoredProcedure [dbo].[spBuscarCapExcepcional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarCapExcepcional
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarCapExcepcional]
(
	@nomCapExcepcional NVARCHAR(100) 
)
AS

SELECT	*	
FROM	T_CAP_EXCEPCIONALES
WHERE	NOM_CAP_EXCEPCIONALES LIKE '%' + @nomCapExcepcional + '%'
ORDER BY NOM_CAP_EXCEPCIONALES	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarDepartamentos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarDepartamentos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarDepartamentos]
(
	@nomDepartamento NVARCHAR(255) 
)
AS

SELECT	*	
FROM	T_DEPARTAMENTO 
WHERE	NOM_DEPARTAMENTO LIKE '%' + @nomDepartamento + '%'
ORDER BY NOM_DEPARTAMENTO	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarEscalafon]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarEscalafon
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarEscalafon]
(
	@nomEscalafon NVARCHAR(50) 
)
AS

SELECT	*	
FROM	T_ESCALAFON
WHERE	NOM_ESCALAFON LIKE '%' + @nomEscalafon + '%'
ORDER BY NOM_ESCALAFON
GO
/****** Object:  StoredProcedure [dbo].[spBuscarEscNacional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarEscNacional
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Busca los usuarios
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarEscNacional]
(
	@nomEscNacional NVARCHAR(255),
	@idInstitucion BIGINT 	
)
AS

SELECT	*	
FROM	T_ESCALA_NACIONAL
WHERE	DESCRIPCION LIKE '%' + @nomEscNacional + '%'
		AND ID_INSTITUCION = @idInstitucion
ORDER BY DESCRIPCION
GO
/****** Object:  StoredProcedure [dbo].[spBuscarEspecialidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarEspecialidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarEspecialidad]
(
	@nomEspecialidad NVARCHAR(50) 
)
AS

SELECT	*	
FROM	T_ESPECIALIDAD
WHERE	NOM_ESPECIALIDAD LIKE '%' + @nomEspecialidad + '%'
ORDER BY NOM_ESPECIALIDAD	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarEstratos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarEstratos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarEstratos]
(
	@nomEstrato NVARCHAR(10) 
)
AS

SELECT	*	
FROM	T_ESTRATO 
WHERE	NOM_ESTRATO LIKE '%' + @nomEstrato + '%'
ORDER BY NOM_ESTRATO	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarEstudiantes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarEstudiantes
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Busca los estudiantes
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarEstudiantes]
(
	@codEstudiante NVARCHAR(20),
	@idInstitucion BIGINT 	
)
AS

SELECT	*	
FROM	T_ESTUDIANTES
WHERE	COD_ESTUDIANTE = @codEstudiante 
		AND ID_INSTITUCION = @idInstitucion



--(
--	@nomEstudiante NVARCHAR(50),
--	@idInstitucion BIGINT 	
--)
--AS

--SELECT	*	
--FROM	T_ESTUDIANTES
--WHERE	PRIMER_APELLIDO LIKE '%' + @nomEstudiante + '%'
--		OR SEGUNDO_APELLIDO LIKE '%' + @nomEstudiante + '%'
--		OR PRIMER_NOMBRE LIKE '%' + @nomEstudiante + '%'
--		OR SEGUNDO_NOMBRE LIKE '%' + @nomEstudiante + '%'
--		AND ID_INSTITUCION = @idInstitucion
--ORDER BY PRIMER_APELLIDO,PRIMER_NOMBRE
GO
/****** Object:  StoredProcedure [dbo].[spBuscarEtnias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarEtnias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarEtnias]
(
	@nomEtnias NVARCHAR(100) 
)
AS

SELECT	*	
FROM	T_ETNIAS 
WHERE	NOM_ETNIAS LIKE '%' + @nomEtnias + '%'
ORDER BY NOM_ETNIAS	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarFuenteRecursos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarFuenteRecursos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarFuenteRecursos]
(
	@nomFuenteRecursos NVARCHAR(100) 
)
AS

SELECT	*	
FROM	T_FUENTE_RECURSOS
WHERE	NOM_FUENTE_RECURSOS LIKE '%' + @nomFuenteRecursos + '%'
ORDER BY NOM_FUENTE_RECURSOS	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarGrupos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarGrupos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Busca los usuarios
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarGrupos]
(
	@nomGrupo NVARCHAR(50),
	@idInstitucion BIGINT 	
)
AS

SELECT	*	
FROM	T_GRUPO
WHERE	NOM_GRUPO LIKE '%' + @nomGrupo + '%'
		AND ID_INSTITUCION = @idInstitucion
ORDER BY NOM_GRUPO
GO
/****** Object:  StoredProcedure [dbo].[spBuscarGruposUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarGruposUsr
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarGruposUsr]
(
	@nomGrupoUsr NVARCHAR(50) 	
)
AS

SELECT	*	
FROM	T_GRUPO_USR
WHERE	NOMBRE_GRUPO_USR LIKE '%' + @nomGrupoUsr + '%'
ORDER BY NOMBRE_GRUPO_USR
GO
/****** Object:  StoredProcedure [dbo].[spBuscarJornadas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarJornadas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarJornadas]
(
	@nomJornada NVARCHAR(50) 
)
AS

SELECT	*	
FROM	T_JORNADAS 
WHERE	NOM_JORNADAS LIKE '%' + @nomJornada + '%'
ORDER BY NOM_JORNADAS	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarMetodologias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarMetodologias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarMetodologias]
(
	@nomMetodologia NVARCHAR(50) 
)
AS

SELECT	*	
FROM	T_METODOLOGIAS
WHERE	NOM_METODOLOGIAS LIKE '%' + @nomMetodologia + '%'
ORDER BY NOM_METODOLOGIAS	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarMunicipios]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[spBuscarMunicipios]
(
	@nomMunicipio NVARCHAR(255) 
)
AS

SELECT	*	
FROM	T_MUNICIPIO 
		INNER JOIN T_DEPARTAMENTO ON T_MUNICIPIO.COD_DEPARTAMENTO = T_DEPARTAMENTO.COD_DEPARTAMENTO
WHERE	NOM_MUNICIPIO LIKE '%' + @nomMunicipio + '%'
ORDER BY NOM_MUNICIPIO	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarPoblaVicConflicto]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarPoblaVicConflicto
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarPoblaVicConflicto]
(
	@nomPoblaVicConflicto NVARCHAR(100) 
)
AS

SELECT	*	
FROM	T_POBLA_VIC_CONFLICTO
WHERE	NOM_POBLA_VIC_CONFLICTO LIKE '%' + @nomPoblaVicConflicto + '%'
ORDER BY NOM_POBLA_VIC_CONFLICTO	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarProfesion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarProfesion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarProfesion]
(
	@nomProfesion NVARCHAR(50) 
)
AS

SELECT	*	
FROM	T_PROFESION
WHERE	NOM_PROFESION LIKE '%' + @nomProfesion + '%'
ORDER BY NOM_PROFESION
GO
/****** Object:  StoredProcedure [dbo].[spBuscarProfesores]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarProfesores
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarProfesores]
(
	@nomProfesor NVARCHAR(50),
	@idInstitucion BIGINT 	
)
AS

SELECT	*,
		(
			PRI_APELLIDO_PROF + ' ' +
			SEG_APELLIDO_PROF + ' ' +
			PRI_NOMBRE_PROF + ' ' +
			SEG_NOMBRE_PROF
		) AS NOMBRE_PROFESOR	
FROM	T_PROFESOR
WHERE	PRI_APELLIDO_PROF LIKE '%' + @nomProfesor + '%'
			OR SEG_APELLIDO_PROF LIKE '%' + @nomProfesor + '%'
			OR PRI_NOMBRE_PROF LIKE '%' + @nomProfesor + '%'
			OR SEG_NOMBRE_PROF LIKE '%' + @nomProfesor + '%'
		AND ID_INSTITUCION = @idInstitucion
ORDER BY PRI_APELLIDO_PROF
GO
/****** Object:  StoredProcedure [dbo].[spBuscarResguardos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarResguardos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarResguardos]
(
	@nomResguardos NVARCHAR(100) 
)
AS

SELECT	*	
FROM	T_RESGUARDOS
WHERE	NOM_RESGUARDOS LIKE '%' + @nomResguardos + '%'
ORDER BY NOM_RESGUARDOS	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarSedes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarSedes
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarSedes]
(
	@nomSede NVARCHAR(100) 
)
AS

SELECT	*	
FROM	T_SEDES
WHERE	NOMBRE_SEDE LIKE '%' + @nomSede + '%'
ORDER BY NOMBRE_SEDE	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarSisben]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[spBuscarSisben]
(
	@nomSisben NVARCHAR(255) 
)
AS

SELECT	*	
FROM	T_SISBEN 
WHERE	NOM_SISBEN LIKE '%' + @nomSisben + '%'
ORDER BY NOM_SISBEN
GO
/****** Object:  StoredProcedure [dbo].[spBuscarSituAcademica]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarSituAcademica
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarSituAcademica]
(
	@nomSituAcademica NVARCHAR(255) 
)
AS

SELECT	*	
FROM	T_SITU_ACADEMICA
WHERE	NOM_SITU_ACADEMICA LIKE '%' + @nomSituAcademica + '%'
ORDER BY NOM_SITU_ACADEMICA	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarTipoDiscapacidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarTipoDiscapacidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarTipoDiscapacidad]
(
	@nomTpDiscapacidad NVARCHAR(100) 
)
AS

SELECT	*	
FROM	T_TP_DISCAPACIDAD
WHERE	NOM_TP_DISCAPACIDAD LIKE '%' + @nomTpDiscapacidad + '%'
ORDER BY NOM_TP_DISCAPACIDAD	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarTipoRespuestas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarTipoRespuestas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarTipoRespuestas]
(
	@nomTpRespuesta NVARCHAR(10) 
)
AS

SELECT	*	
FROM	T_TP_RESPUESTA 
WHERE	NOM_TP_RESPUESTA LIKE '%' + @nomTpRespuesta + '%'
ORDER BY NOM_TP_RESPUESTA	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarTpCaracter]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarTpCaracter
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarTpCaracter]
(
	@nomTpCaracter NVARCHAR(50) 
)
AS

SELECT	*	
FROM	T_TP_CARACTER
WHERE	NOM_TP_CARACTER LIKE '%' + @nomTpCaracter + '%'
ORDER BY NOM_TP_CARACTER	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarTpCondicion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarTpCondicion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarTpCondicion]
(
	@nomTpCondicion NVARCHAR(100) 
)
AS

SELECT	*	
FROM	T_TP_CONDICION
WHERE	NOM_TP_CONDICION LIKE '%' + @nomTpCondicion + '%'
ORDER BY NOM_TP_CONDICION	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarTpIdentificacion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[spBuscarTpIdentificacion]
(
	@nomTpIdentificacion NVARCHAR(255) 
)
AS

SELECT	*	
FROM	T_TP_IDENTIFICACION
WHERE	NOM_TP_IDENTIFICACION LIKE '%' + @nomTpIdentificacion + '%'
ORDER BY NOM_TP_IDENTIFICACION	
GO
/****** Object:  StoredProcedure [dbo].[spBuscarUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarUsr
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Busca los usuarios
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarUsr]
(
	@nomUsr NVARCHAR(50),
	@idInstitucion BIGINT 	
)
AS

SELECT	*	
FROM	T_USR
WHERE	NOM_USR LIKE '%' + @nomUsr + '%'
		AND ID_INSTITUCION = @idInstitucion
ORDER BY NOM_USR
GO
/****** Object:  StoredProcedure [dbo].[spBuscarValLetras]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarValLetras
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Busca los usuarios
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spBuscarValLetras]
(
	@nomValLetra NVARCHAR(255),
	@idInstitucion BIGINT 	
)
AS

SELECT	*	
FROM	T_VALORACION_LETRAS
WHERE	DESCRIPCION LIKE '%' + @nomValLetra + '%'
		AND ID_INSTITUCION = @idInstitucion
ORDER BY DESCRIPCION
GO
/****** Object:  StoredProcedure [dbo].[spBuscarZonas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spBuscarZonas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spBuscarZonas]
(
	@nomZonas NVARCHAR(10) 
)
AS

SELECT	*	
FROM	T_ZONAS
WHERE	NOM_ZONAS LIKE '%' + @nomZonas + '%'
ORDER BY NOM_ZONAS	
GO
/****** Object:  StoredProcedure [dbo].[spCapExcepcionalxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spCapExcepcionalxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spCapExcepcionalxID]
(
	@idCapExcepcional BIGINT
)
AS

SELECT	*	
FROM	T_CAP_EXCEPCIONALES
WHERE	ID_CAP_EXCEPCIONALES = @idCapExcepcional
ORDER BY NOM_CAP_EXCEPCIONALES	
GO
/****** Object:  StoredProcedure [dbo].[spDepartamentosxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spDepartamentosxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spDepartamentosxID]
(
	@idDepartamento BIGINT
)
AS

SELECT	*	
FROM	T_DEPARTAMENTO 
WHERE	ID_DEPARTAMENTO = @idDepartamento
ORDER BY NOM_DEPARTAMENTO	
GO
/****** Object:  StoredProcedure [dbo].[spEliminarAsignaturas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spEliminarAsignaturas]
(
	@codAsignatura as nvarchar(10)
)

AS

DELETE	FROM T_ASIGNATURA
WHERE	COD_ASIGNATURA = @codAsignatura

GO
/****** Object:  StoredProcedure [dbo].[spEliminarCapExcepcional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarCapExcepcional
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarCapExcepcional]
(
	@codCapExcepcional  bigint
)

AS

DELETE FROM T_CAP_EXCEPCIONALES
WHERE COD_CAP_EXCEPCIONALES = @codCapExcepcional


GO
/****** Object:  StoredProcedure [dbo].[spEliminarDepartamentos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarDepartamentos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spEliminarDepartamentos]
(
	@codDepartamento  NVARCHAR(2)
)

AS

DELETE FROM T_DEPARTAMENTO 
WHERE COD_DEPARTAMENTO = @codDepartamento


GO
/****** Object:  StoredProcedure [dbo].[spEliminarEscalafon]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEliminarEscalafon
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Eliminar informacion de la tabla T_ESCALAFON
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spEliminarEscalafon]
(
	@ID_ESCALAFON bigint-- Parametro de 
)
AS
DELETE FROM T_ESCALAFON
WHERE
	ID_ESCALAFON = @ID_ESCALAFON

GO
/****** Object:  StoredProcedure [dbo].[spEliminarEscNacional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEliminarEscNacional
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Eliminar informacion de la tabla T_ESCALA_NACIONAL
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spEliminarEscNacional]
(
	@ID_ESCALA_NACIONAL bigint-- Parametro de 
)
AS
DELETE FROM T_ESCALA_NACIONAL
WHERE
	ID_ESCALA_NACIONAL = @ID_ESCALA_NACIONAL

GO
/****** Object:  StoredProcedure [dbo].[spEliminarEspecialidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarEspecialidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spEliminarEspecialidad]
(
	@codEspecialidad  bigint
)

AS

DELETE FROM T_ESPECIALIDAD
WHERE COD_ESPECIALIDAD = @codEspecialidad


GO
/****** Object:  StoredProcedure [dbo].[spEliminarEstratos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spEliminarEstratos
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spEliminarEstratos]
(
	@codEstrato  INTEGER
)

AS

DELETE FROM T_ESTRATO 
WHERE COD_ESTRATO = @codEstrato


GO
/****** Object:  StoredProcedure [dbo].[spEliminarEstudiantes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEliminarEstudiantes
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 18/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Eliminar informacion de la tabla T_ESTUDIANTES
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spEliminarEstudiantes]
(
	@ID_ESTUDIANTE bigint-- Parametro de 
)
AS
DELETE FROM T_ESTUDIANTES
WHERE
	ID_ESTUDIANTE = @ID_ESTUDIANTE

GO
/****** Object:  StoredProcedure [dbo].[spEliminarEtnias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarEtnias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarEtnias]
(
	@codEtnia  NVARCHAR(3)
)

AS

DELETE FROM T_ETNIAS 
WHERE COD_ETNIAS = @codEtnia


GO
/****** Object:  StoredProcedure [dbo].[spEliminarFuenteRecursos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarFuenteRecursos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarFuenteRecursos]
(
	@codFuenteRecursos  bigint
)

AS

DELETE FROM T_FUENTE_RECURSOS
WHERE COD_FUENTE_RECURSOS = @codFuenteRecursos


GO
/****** Object:  StoredProcedure [dbo].[spEliminarGrupos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spEliminarGrupos
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Elimina los usuarios
******************************************************************************************************/

create procedure [dbo].[spEliminarGrupos]
(
	@idGrupo  bigint	
)

AS

DELETE FROM T_GRUPO
WHERE ID_GRUPO = @idGrupo

GO
/****** Object:  StoredProcedure [dbo].[spEliminarGruposUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spEliminarGruposUsr
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Elimina las sedes
******************************************************************************************************/

CREATE procedure [dbo].[spEliminarGruposUsr]
(
	@idGrupoUsr  bigint	
)

AS

DELETE FROM T_OPC_MENUXUSR
WHERE ID_GRUPO_USR = @idGrupoUsr

DELETE FROM T_GRUPO_USR 
WHERE ID_GRUPO_USR = @idGrupoUsr

GO
/****** Object:  StoredProcedure [dbo].[spEliminarJornadas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarJornadas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarJornadas]
(
	@codJornada  NVARCHAR(2)
)

AS

DELETE FROM T_JORNADAS 
WHERE COD_JORNADAS = @codJornada


GO
/****** Object:  StoredProcedure [dbo].[spEliminarMetodologias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarMetodologias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarMetodologias]
(
	@codMetodologia  bigint
)

AS

DELETE FROM T_METODOLOGIAS
WHERE COD_METODOLOGIAS = @codMetodologia


GO
/****** Object:  StoredProcedure [dbo].[spEliminarMunicipios]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spEliminarMunicipios]
(
	@idMunicipio bigint,
	@idDepartamento bigint
)

AS

DELETE	FROM	T_MUNICIPIO
WHERE	T_MUNICIPIO.COD_MUNICIPIO = @idMunicipio
		AND T_MUNICIPIO.COD_DEPARTAMENTO = @idDepartamento

GO
/****** Object:  StoredProcedure [dbo].[spEliminarPoblaVicConflicto]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spEliminarPoblaVicConflicto
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarPoblaVicConflicto]
(
	@codPoblaVicConflicto  NVARCHAR(4)
)

AS

DELETE FROM T_POBLA_VIC_CONFLICTO
WHERE COD_POBLA_VIC_CONFLICTO = @codPoblaVicConflicto


GO
/****** Object:  StoredProcedure [dbo].[spEliminarProfesion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEliminarProfesion
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Eliminar informacion de la tabla T_PROFESION
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spEliminarProfesion]
(
	@ID_PROFESION bigint-- Parametro de 
)
AS
DELETE FROM T_PROFESION
WHERE
	ID_PROFESION = @ID_PROFESION

GO
/****** Object:  StoredProcedure [dbo].[spEliminarProfesores]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEliminarProfesores
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Eliminar informacion de la tabla T_PROFESOR
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spEliminarProfesores]
(
	@ID_PROFESOR bigint-- Parametro de 
)
AS
DELETE FROM T_PROFESOR
WHERE
	ID_PROFESOR = @ID_PROFESOR

GO
/****** Object:  StoredProcedure [dbo].[spEliminarResguardos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarResguardos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarResguardos]
(
	@codResguardo  NVARCHAR(3)
)

AS

DELETE FROM T_RESGUARDOS
WHERE COD_RESGUARDOS = @codResguardo


GO
/****** Object:  StoredProcedure [dbo].[spEliminarSedes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spEliminarSedes
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Elimina las sedes
******************************************************************************************************/

create procedure [dbo].[spEliminarSedes]
(
	@idSede  bigint	
)

AS

DELETE FROM T_SEDES 
WHERE ID_SEDE = @idSede

GO
/****** Object:  StoredProcedure [dbo].[spEliminarSisben]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spEliminarSisben
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spEliminarSisben]
(
	@codSisben  bigint
)

AS

DELETE FROM T_SISBEN
WHERE COD_SISBEN = @codSisben


GO
/****** Object:  StoredProcedure [dbo].[spEliminarSituAcademica]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarSituAcademica
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarSituAcademica]
(
	@codSituAcademica  bigint
)

AS

DELETE FROM T_SITU_ACADEMICA
WHERE COD_SITU_ACADEMICA = @codSituAcademica


GO
/****** Object:  StoredProcedure [dbo].[spEliminarTipoDiscapacidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarTipoDiscapacidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarTipoDiscapacidad]
(
	@codTpDiscapacidad  bigint
)

AS

DELETE FROM T_TP_DISCAPACIDAD
WHERE COD_TP_DISCAPACIDAD = @codTpDiscapacidad


GO
/****** Object:  StoredProcedure [dbo].[spEliminarTipoRespuestas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarTipoRespuestas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarTipoRespuestas]
(
	@codTpRespuestas  NVARCHAR(2)
)

AS

DELETE FROM T_TP_RESPUESTA
WHERE COD_TP_RESPUESTA = @codTpRespuestas


GO
/****** Object:  StoredProcedure [dbo].[spEliminarTpCaracter]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarTpCaracter
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarTpCaracter]
(
	@codTpCaracter  bigint
)

AS

DELETE FROM T_TP_CARACTER
WHERE COD_TP_CARACTER = @codTpCaracter


GO
/****** Object:  StoredProcedure [dbo].[spEliminarTpCondicion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarTpCondicion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarTpCondicion]
(
	@codTpCondicion  bigint
)

AS

DELETE FROM T_TP_CONDICION
WHERE COD_TP_CONDICION = @codTpCondicion


GO
/****** Object:  StoredProcedure [dbo].[spEliminarTpIdentificacion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spEliminarTpIdentificacion
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarTpIdentificacion]
(
	@codTpIdentificacion  NVARCHAR(2)
)

AS

DELETE FROM T_TP_IDENTIFICACION 
WHERE COD_TP_IDENTIFICACION = @codTpIdentificacion


GO
/****** Object:  StoredProcedure [dbo].[spEliminarUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spEliminarUsr
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Elimina los usuarios
******************************************************************************************************/

CREATE procedure [dbo].[spEliminarUsr]
(
	@idUsr  bigint	
)

AS

DELETE FROM T_USR
WHERE ID_USR = @idUsr

GO
/****** Object:  StoredProcedure [dbo].[spEliminarValLetras]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEliminarValLetras
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Eliminar informacion de la tabla T_VALORACION_LETRAS
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spEliminarValLetras]
(
@ID_VAL_LETRAS bigint-- Parametro de 
)
AS
DELETE FROM T_VALORACION_LETRAS
WHERE
ID_VAL_LETRAS = @ID_VAL_LETRAS

GO
/****** Object:  StoredProcedure [dbo].[spEliminarZonas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEliminarZonas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spEliminarZonas]
(
	@codZonas  bigint
)

AS

DELETE FROM T_Zonas
WHERE COD_Zonas = @codZonas


GO
/****** Object:  StoredProcedure [dbo].[spEscalafonTraerxPK]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEscalafonTraerxPK
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para TraerxPK informacion de la tabla T_ESCALAFON
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spEscalafonTraerxPK]
(
	@ID_ESCALAFON bigint-- Parametro de 
)
AS
SELECT * FROM T_ESCALAFON
WHERE
	ID_ESCALAFON = @ID_ESCALAFON

GO
/****** Object:  StoredProcedure [dbo].[spEscNacionalTraerxPK]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEscNacionalTraerxPK
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para TraerxPK informacion de la tabla T_ESCALA_NACIONAL
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spEscNacionalTraerxPK]
(
	@ID_ESCALA_NACIONAL bigint-- Parametro de 
)
AS
SELECT * FROM T_ESCALA_NACIONAL
WHERE
	ID_ESCALA_NACIONAL = @ID_ESCALA_NACIONAL

GO
/****** Object:  StoredProcedure [dbo].[spEspecialidadxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEspecialidadxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spEspecialidadxID]
(
	@idEspecialidad BIGINT
)
AS

SELECT	*	
FROM	T_ESPECIALIDAD
WHERE	ID_ESPECIALIDAD = @idEspecialidad
ORDER BY NOM_ESPECIALIDAD	
GO
/****** Object:  StoredProcedure [dbo].[spEstratosxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[spEstratosxID]
(
	@idEstrato BIGINT
)
AS

SELECT	*	
FROM	T_ESTRATO 
WHERE	ID_ESTRATO = @idEstrato
ORDER BY NOM_ESTRATO	
GO
/****** Object:  StoredProcedure [dbo].[spEstudiantesTraerxPK]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEstudiantesTraerxPK
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 18/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para TraerxPK informacion de la tabla T_ESTUDIANTES
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spEstudiantesTraerxPK]
(
	@ID_ESTUDIANTE bigint-- Parametro de 
)
AS
SELECT * FROM T_ESTUDIANTES
WHERE
	ID_ESTUDIANTE = @ID_ESTUDIANTE

GO
/****** Object:  StoredProcedure [dbo].[spEtniasxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spEtniasxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spEtniasxID]
(
	@idetnia BIGINT
)
AS

SELECT	*	
FROM	T_ETNIAS
WHERE	ID_ETNIAS = @idetnia
ORDER BY NOM_ETNIAS
GO
/****** Object:  StoredProcedure [dbo].[spFuenteRecursosxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spFuenteRecursosxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spFuenteRecursosxID]
(
	@idFuenteRecursos BIGINT
)
AS

SELECT	*	
FROM	T_FUENTE_RECURSOS
WHERE	ID_FUENTE_RECURSOS = @idFuenteRecursos
ORDER BY NOM_FUENTE_RECURSOS	
GO
/****** Object:  StoredProcedure [dbo].[spInfoTablaClassCreator]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spInfoTablaClassCreator]
(
	@nomtabla		nvarchar(100)
)

AS

SELECT
	OBJ.NAME AS NOM_TABLA,
	ISNULL((SELECT	EP.VALUE
			  FROM	SYS.EXTENDED_PROPERTIES EP
					INNER JOIN SYS.TABLES TB ON EP.MAJOR_ID = TB.OBJECT_ID
			WHERE	TB.NAME = @nomtabla  AND MINOR_ID = 0 AND EP.NAME = 'MS_Description'),'') AS DESC_TABLA,					
	COL.COLUMN_ID AS ORDEN_COLUMNA,
	COL.NAME AS NOM_COLUMNA,
	ISNULL((SELECT	COUNT(KCOL.COLUMN_NAME)
			FROM	INFORMATION_SCHEMA.KEY_COLUMN_USAGE KCOL
					INNER JOIN INFORMATION_SCHEMA.TABLE_CONSTRAINTS TBL	ON KCOL.CONSTRAINT_NAME = TBL.CONSTRAINT_NAME
			WHERE	KCOL.TABLE_NAME = @nomtabla
					AND TBL.CONSTRAINT_TYPE = 'Primary key'
					AND KCOL.COLUMN_NAME = COL.NAME), 0) AS PRIMARY_KEY,
	COL.IS_NULLABLE AS NULO, 
	COL.MAX_LENGTH AS LONGITUD,
	COL.IS_COMPUTED AS COMPUTED, 
	TYP.SYSTEM_TYPE_ID AS ID_TIPO,
	TYP.NAME AS NOM_TIPO,
	ISNULL((SELECT	EP.VALUE 
			FROM	SYS.EXTENDED_PROPERTIES EP
					INNER JOIN SYS.TABLES TB ON EP.MAJOR_ID = TB.OBJECT_ID
					INNER JOIN SYS.COLUMNS CL ON EP.MAJOR_ID = CL.OBJECT_ID  AND EP.MINOR_ID = CL.COLUMN_ID 	
			 WHERE 	TB.NAME = @nomtabla AND CL.NAME = COL.NAME  AND  EP.NAME = 'MS_Description'),'') AS DESC_COLUMNA ,
                 COL.IS_IDENTITY 
FROM	SYS.OBJECTS OBJ
	INNER JOIN SYS.COLUMNS COL ON OBJ.OBJECT_ID = COL.OBJECT_ID
	INNER JOIN SYS.TYPES TYP ON COL.SYSTEM_TYPE_ID = TYP.SYSTEM_TYPE_ID 
                     AND COL.USER_TYPE_ID = TYP.USER_TYPE_ID
WHERE	OBJ.NAME=@nomtabla
	AND OBJ.TYPE = 'U' 
ORDER BY ORDEN_COLUMNA ASC


GO
/****** Object:  StoredProcedure [dbo].[spInsertaAsignaturas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spInsertaAsignaturas]
(
	@idAsignatura as integer,
    @codAsignatura as nvarchar(10),
	@nomAsignatura nvarchar(255),
	@activo bit,
	@usuarioReg  nvarchar(20),
	@fechaReg datetime
)

AS

INSERT INTO T_ASIGNATURA
	(
		COD_ASIGNATURA,
		NOM_ASIGNATURA,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codAsignatura,
		@nomAsignatura,
		@activo,
		@usuarioReg,
		@fechaReg
	) 

GO
/****** Object:  StoredProcedure [dbo].[spInsertaMunicipios]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[spInsertaMunicipios]
(
	@codUnificado	nvarchar(6),
	@codMunicipio	nvarchar(6),
	@nomMunicipio	nvarchar(255),
	@codDepartamento	nvarchar(2),
	@activo	bit,
	@usuarioReg	nvarchar(20),
	@fechaReg	datetime
)

AS

INSERT INTO T_MUNICIPIO
	(
		COD_UNIFICADO,
		COD_MUNICIPIO,
		NOM_MUNICIPIO,
		COD_DEPARTAMENTO,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codUnificado,
		@codMunicipio,
		@nomMunicipio,
		@codDepartamento,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
	
	--ACTUALIZA EL ID DEL DEPARTAMENTO EN LA TABLA DE MUNICIPIOS	
	UPDATE T_MUNICIPIO SET ID_DEPARTAMENTO = (SELECT ID_DEPARTAMENTO FROM T_DEPARTAMENTO WHERE COD_DEPARTAMENTO = @codDepartamento)
	WHERE T_MUNICIPIO.COD_UNIFICADO = @codUnificado
	
	

GO
/****** Object:  StoredProcedure [dbo].[spInsertarCapExcepcional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spInsertarCapExcepcional
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


create PROCEDURE [dbo].[spInsertarCapExcepcional]
(
	@codCapExcepcional	bigint,
	@nomCapExcepcional	nvarchar(100),
	@activo				bit,
	@usuarioReg			nvarchar(20),
	@fechaReg			datetime
)

AS

INSERT INTO T_CAP_EXCEPCIONALES
	(
		COD_CAP_EXCEPCIONALES,
		NOM_CAP_EXCEPCIONALES,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codCapExcepcional,
		@nomCapExcepcional,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarDepartamentos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spInsertarDepartamentos
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


CREATE PROCEDURE [dbo].[spInsertarDepartamentos]
(
	@codDepartamento	nvarchar(2),
	@nomDepartamento	nvarchar(255),
	@activo				bit,
	@usuarioReg			nvarchar(20),
	@fechaReg			datetime
)

AS

INSERT INTO T_DEPARTAMENTO
	(
		COD_DEPARTAMENTO,
		NOM_DEPARTAMENTO,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codDepartamento,
		@nomDepartamento,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarEscalafon]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spInsertarEscalafon
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Guardar informacion de la tabla T_ESCALAFON
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spInsertarEscalafon]
(
	@ID_ESCALAFON bigint = 0 OUTPUT,-- Parametro de 
	@COD_ESCALAFON nvarchar(2),-- Parametro de 
	@NOM_ESCALAFON nvarchar(100) =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)
AS
INSERT INTO T_ESCALAFON
(
	COD_ESCALAFON,
	NOM_ESCALAFON,
	ACTIVO,
	ID_INSTITUCION,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@COD_ESCALAFON,
	@NOM_ESCALAFON,
	@ACTIVO,
	@ID_INSTITUCION,
	@USUARIO_REG,
	@FECHA_REG
)
SET @ID_ESCALAFON = SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[spInsertarEscNacional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spInsertarEscNacional
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Guardar informacion de la tabla T_ESCALA_NACIONAL
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spInsertarEscNacional]
(
	@ID_ESCALA_NACIONAL bigint = 0 OUTPUT,-- Parametro de 
	@COD_ESCALA_NACIONAL nvarchar(5) =  NULL,-- Parametro de 
	@DESCRIPCION nvarchar(255) =  NULL,-- Parametro de 
	@CRITERIO_EVAL nvarchar(255) =  NULL,-- Parametro de 
	@ID_SEDE bigint =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)

AS

IF @ID_SEDE = 0
BEGIN
	SET @ID_SEDE = NULL
END

INSERT INTO T_ESCALA_NACIONAL
(
	COD_ESCALA_NACIONAL,
	DESCRIPCION,
	CRITERIO_EVAL,
	ID_SEDE,
	ACTIVO,
	ID_INSTITUCION,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@COD_ESCALA_NACIONAL,
	@DESCRIPCION,
	@CRITERIO_EVAL,
	@ID_SEDE,
	@ACTIVO,
	@ID_INSTITUCION,
	@USUARIO_REG,
	@FECHA_REG
)
SET @ID_ESCALA_NACIONAL = SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[spInsertarEspecialidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spInsertarEspecialidad
Creado por:		jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spInsertarEspecialidad]
(
	@codEspecialidad  bigint,
	@nomEspecialidad  nvarchar(50),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

INSERT INTO T_ESPECIALIDAD
(
	COD_ESPECIALIDAD,
	NOM_ESPECIALIDAD,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codEspecialidad,
	@nomEspecialidad,
	@activo,
	@usuarioReg,
	@fechaReg
)


GO
/****** Object:  StoredProcedure [dbo].[spInsertarEstratos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spInsertarEstratos
Creado por:		jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spInsertarEstratos]
(
	@cod_estrato  bigint,
	@nom_estrato  nvarchar(20),
	@activo  bit,
	@usuario_reg  nvarchar(40),
	@fecha_reg  datetime
)

AS

INSERT INTO T_ESTRATO
(
	COD_ESTRATO,
	NOM_ESTRATO,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@cod_estrato,
	@nom_estrato,
	@activo,
	@usuario_reg,
	@fecha_reg
)


GO
/****** Object:  StoredProcedure [dbo].[spInsertarEstudiantes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spInsertarEstudiantes
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 18/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Guardar informacion de la tabla T_ESTUDIANTES
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spInsertarEstudiantes]
(
	@ID_ESTUDIANTE bigint = 0 OUTPUT,-- Parametro de 
	@COD_ESTUDIANTE nvarchar(20),-- Parametro de 
	@COD_MEN nvarchar(20) =  NULL,-- Parametro de 
	@ID_TP_IDENTIFICACION bigint =  NULL,-- Parametro de 
	@NUM_DOCUMENTO nvarchar(20) =  NULL,-- Parametro de 
	@ID_DEPARATAMENTO_EXP bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_EXPEDICION bigint =  NULL,-- Parametro de 
	@PRIMER_APELLIDO nvarchar(10) =  NULL,-- Parametro de 
	@SEGUNDO_APELLIDO nvarchar(10) =  NULL,-- Parametro de 
	@PRIMER_NOMBRE nvarchar(20) =  NULL,-- Parametro de 
	@SEGUNDO_NOMBRE nvarchar(10) =  NULL,-- Parametro de 
	@FECHA_NACIMIENTO datetime =  NULL,-- Parametro de 
	@ID_DEPARTAMENTO_NAC bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_NAC bigint =  NULL,-- Parametro de 
	@ID_GENERO bigint =  NULL,-- Parametro de 
	@ID_FACTOR_RH bigint =  NULL,-- Parametro de 
	@EMAIL_ESTUDIANTE nvarchar(50) =  NULL,-- Parametro de 
	@FOTOGRAFIA image =  NULL,-- Parametro de 
	@DIRECCION nvarchar(100) =  NULL,-- Parametro de 
	@ID_DEPARTAMENTO_RESID bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_RESID bigint =  NULL,-- Parametro de 
	@ID_ZONA_RESID bigint =  NULL,-- Parametro de 
	@LOCALIDAD nvarchar(100) =  NULL,-- Parametro de 
	@BARRIO nvarchar(100) =  NULL,-- Parametro de 
	@ID_ESTRATO bigint =  NULL,-- Parametro de 
	@TELEFONO nvarchar(20) =  NULL,-- Parametro de 
	@CELULAR nvarchar(20) =  NULL,-- Parametro de 
	@ID_SISBEN bigint =  NULL,-- Parametro de 
	@NUMERO_SISBEN nvarchar(20) =  NULL,-- Parametro de 
	@ID_EPS bigint =  NULL,-- Parametro de 
	@ID_ARS bigint =  NULL,-- Parametro de 
	@ID_POBLACION_VICTIMA bigint =  NULL,-- Parametro de 
	@ID_DEPARTAMENTO_EXPULSOR bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_EXPULSOR bigint =  NULL,-- Parametro de 
	@FECHA_EXPULSOR datetime =  NULL,-- Parametro de 
	@CERTIFICADO_EXPULSOR nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_CERTIFICADO_EXPULSOR datetime =  NULL,-- Parametro de 
	@ID_TP_DISCAPACIDAD bigint =  NULL,-- Parametro de 
	@ID_TP_CAPACIDAD_EXCEP bigint =  NULL,-- Parametro de 
	@ID_ETNIA bigint =  NULL,-- Parametro de 
	@ID_RESGUARDO bigint =  NULL,-- Parametro de 
	@PROVIENE_SECT_PRIVADO bit =  NULL,-- Parametro de 
	@PROVIENE_OTRO_MPIO bit =  NULL,-- Parametro de 
	@INST_BIENESTAR nvarchar(100) =  NULL,-- Parametro de 
	@ID_TP_IDENTIFICACION_MADRE bigint =  NULL,-- Parametro de 
	@NUM_DOCUMENTO_MADRE nvarchar(20) =  NULL,-- Parametro de 
	@ID_DEPARATAMENTO_EXP_MADRE bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_EXPEDICION_MADRE bigint =  NULL,-- Parametro de 
	@PRIMER_APELLIDO_MADRE nvarchar(10) =  NULL,-- Parametro de 
	@SEGUNDO_APELLIDO_MADRE nvarchar(10) =  NULL,-- Parametro de 
	@PRIMER_NOMBRE_MADRE nvarchar(20) =  NULL,-- Parametro de 
	@SEGUNDO_NOMBRE_MADRE nvarchar(10) =  NULL,-- Parametro de 
	@EMAIL_MADRE nvarchar(50) =  NULL,-- Parametro de 
	@DIRECCION_MADRE nvarchar(100) =  NULL,-- Parametro de 
	@ID_DEPARTAMENTO_RESID_MADRE bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_RESID_MADRE bigint =  NULL,-- Parametro de 
	@ID_ZONA_RESID_MADRE bigint =  NULL,-- Parametro de 
	@BARRIO_MADRE nvarchar(100) =  NULL,-- Parametro de 
	@LOCALIDAD_MADRE nvarchar(100) =  NULL,-- Parametro de 
	@TELEFONO_MADRE nvarchar(20) =  NULL,-- Parametro de 
	@CELULAR_MADRE nvarchar(20) =  NULL,-- Parametro de 
	@OCUPACION_MADRE nvarchar(100) =  NULL,-- Parametro de 
	@EMPRESA_MADRE nvarchar(100) =  NULL,-- Parametro de 
	@TELEFONO_EMPRESA_MADRE nvarchar(20) =  NULL,-- Parametro de 
	@ID_TP_IDENTIFICACION_PADRE bigint =  NULL,-- Parametro de 
	@NUM_DOCUMENTO_PADRE nvarchar(20) =  NULL,-- Parametro de 
	@ID_DEPARATAMENTO_EXP_PADRE bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_EXPEDICION_PADRE bigint =  NULL,-- Parametro de 
	@PRIMER_APELLIDO_PADRE nvarchar(10) =  NULL,-- Parametro de 
	@SEGUNDO_APELLIDO_PADRE nvarchar(10) =  NULL,-- Parametro de 
	@PRIMER_NOMBRE_PADRE nvarchar(20) =  NULL,-- Parametro de 
	@SEGUNDO_NOMBRE_PADRE nvarchar(10) =  NULL,-- Parametro de 
	@EMAIL_PADRE nvarchar(50) =  NULL,-- Parametro de 
	@DIRECCION_PADRE nvarchar(100) =  NULL,-- Parametro de 
	@ID_DEPARTAMENTO_RESID_PADRE bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_RESID_PADRE bigint =  NULL,-- Parametro de 
	@ID_ZONA_RESID_PADRE bigint =  NULL,-- Parametro de 
	@BARRIO_PADRE nvarchar(100) =  NULL,-- Parametro de 
	@LOCALIDAD_PADRE nvarchar(100) =  NULL,-- Parametro de 
	@TELEFONO_PADRE nvarchar(20) =  NULL,-- Parametro de 
	@CELULAR_PADRE nvarchar(20) =  NULL,-- Parametro de 
	@OCUPACION_PADRE nvarchar(100) =  NULL,-- Parametro de 
	@EMPRESA_PADRE nvarchar(100) =  NULL,-- Parametro de 
	@TELEFONO_EMPRESA_PADRE nvarchar(20) =  NULL,-- Parametro de 
	@ID_TP_IDENTIFICACION_ACUDIENTE bigint =  NULL,-- Parametro de 
	@NUM_DOCUMENTO_ACUDIENTE nvarchar(20) =  NULL,-- Parametro de 
	@ID_DEPARATAMENTO_EXP_ACUDIENTE bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_EXPEDICION_ACUDIENTE bigint =  NULL,-- Parametro de 
	@PRIMER_APELLIDO_ACUDIENTE nvarchar(10) =  NULL,-- Parametro de 
	@SEGUNDO_APELLIDO_ACUDIENTE nvarchar(10) =  NULL,-- Parametro de 
	@PRIMER_NOMBRE_ACUDIENTE nvarchar(20) =  NULL,-- Parametro de 
	@SEGUNDO_NOMBRE_ACUDIENTE nvarchar(10) =  NULL,-- Parametro de 
	@EMAIL_ACUDIENTE nvarchar(50) =  NULL,-- Parametro de 
	@DIRECCION_ACUDIENTE nvarchar(100) =  NULL,-- Parametro de 
	@ID_DEPARTAMENTO_RESID_ACUDIENTE bigint =  NULL,-- Parametro de 
	@ID_MUNICIPIO_RESID_ACUDIENTE bigint =  NULL,-- Parametro de 
	@ID_ZONA_RESID_ACUDIENTE bigint =  NULL,-- Parametro de 
	@BARRIO_ACUDIENTE nvarchar(100) =  NULL,-- Parametro de 
	@LOCALIDAD_ACUDIENTE nvarchar(100) =  NULL,-- Parametro de 
	@TELEFONO_ACUDIENTE nvarchar(20) =  NULL,-- Parametro de 
	@CELULAR_ACUDIENTE nvarchar(20) =  NULL,-- Parametro de 
	@OCUPACION_ACUDIENTE nvarchar(100) =  NULL,-- Parametro de 
	@EMPRESA_ACUDIENTE nvarchar(100) =  NULL,-- Parametro de 
	@TELEFONO_EMPRESA_ACUDIENTE nvarchar(20) =  NULL,-- Parametro de 
	@ID_GENERO_ACUDIENTE bigint =  NULL,-- Parametro de 
	@ID_PARENTESCO_ACUDIENTE bigint =  NULL,-- Parametro de 
	@COLEGIO_ULTIMO_CURSO nvarchar(100) =  NULL,-- Parametro de 
	@DIRECCION_COLEG_ULTIMO nvarchar(100) =  NULL,-- Parametro de 
	@TELEFONO_COLEG_ULTIMO nvarchar(20) =  NULL,-- Parametro de 
	@GRADO_ULTIMO nvarchar(10) =  NULL,-- Parametro de 
	@ANIO nvarchar(4) =  NULL,-- Parametro de 
	@MOTIVO_RETIRO_ULTIMO nvarchar(255) =  NULL,-- Parametro de 
	@OBSERVACIONES text =  NULL,-- Parametro de 
	@USUARIO_ESTUDIANTE nvarchar(20) =  NULL,-- Parametro de 
	@CLAVE_ACCESO nvarchar(20) =  NULL,-- Parametro de 
	@ID_GRUPO_USR nvarchar(2) =  NULL,-- Parametro de 
	@ID_SEDE bigint =  NULL,
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL,
	@SEL_MADRE BIT = NULL,
	@SEL_PADRE BIT = NULL,
	@SEL_ACUDIENTE INT = NULL 
)

AS

IF @ID_SEDE = 0
BEGIN
	SET @ID_SEDE = NULL
END

IF @ID_DEPARTAMENTO_EXPULSOR = 0
BEGIN
	SET @ID_DEPARTAMENTO_EXPULSOR = NULL
END

IF @ID_MUNICIPIO_EXPULSOR = 0
BEGIN
	SET @ID_MUNICIPIO_EXPULSOR = NULL
END

IF @CERTIFICADO_EXPULSOR = 0
BEGIN
	SET @CERTIFICADO_EXPULSOR = NULL
END

IF @ID_DEPARATAMENTO_EXP_MADRE = 0
BEGIN
	SET @ID_DEPARATAMENTO_EXP_MADRE = NULL
END

IF @ID_MUNICIPIO_EXPEDICION_MADRE = 0
BEGIN
	SET @ID_MUNICIPIO_EXPEDICION_MADRE = NULL
END

IF @ID_DEPARTAMENTO_RESID_MADRE = 0
BEGIN
	SET @ID_DEPARTAMENTO_RESID_MADRE = NULL
END

IF @ID_MUNICIPIO_RESID_MADRE = 0
BEGIN
	SET @ID_MUNICIPIO_RESID_MADRE = NULL
END

IF @ID_ZONA_RESID_MADRE = 0
BEGIN
	SET @ID_ZONA_RESID_MADRE = NULL
END

IF @ID_DEPARATAMENTO_EXP_PADRE = 0
BEGIN
	SET @ID_DEPARATAMENTO_EXP_PADRE = NULL
END

IF @ID_MUNICIPIO_EXPEDICION_PADRE = 0
BEGIN
	SET @ID_MUNICIPIO_EXPEDICION_PADRE = NULL
END

IF @ID_DEPARTAMENTO_RESID_PADRE = 0
BEGIN
	SET @ID_DEPARTAMENTO_RESID_PADRE = NULL
END

IF @ID_MUNICIPIO_RESID_PADRE = 0
BEGIN
	SET @ID_MUNICIPIO_RESID_PADRE = NULL
END

IF @ID_ZONA_RESID_PADRE = 0
BEGIN
	SET @ID_ZONA_RESID_PADRE = NULL
END

IF @ID_DEPARATAMENTO_EXP_ACUDIENTE = 0
BEGIN
	SET @ID_DEPARATAMENTO_EXP_ACUDIENTE = NULL
END

IF @ID_MUNICIPIO_EXPEDICION_ACUDIENTE = 0
BEGIN
	SET @ID_MUNICIPIO_EXPEDICION_ACUDIENTE = NULL
END

IF @ID_DEPARTAMENTO_RESID_ACUDIENTE = 0
BEGIN
	SET @ID_DEPARTAMENTO_RESID_ACUDIENTE = NULL
END

IF @ID_MUNICIPIO_RESID_ACUDIENTE = 0
BEGIN
	SET @ID_MUNICIPIO_RESID_ACUDIENTE = NULL
END

IF @ID_ZONA_RESID_ACUDIENTE = 0
BEGIN
	SET @ID_ZONA_RESID_ACUDIENTE = NULL
END

IF @ID_TP_IDENTIFICACION = 0
BEGIN
	SET @ID_TP_IDENTIFICACION = NULL
END

IF @ID_TP_IDENTIFICACION_MADRE = 0
BEGIN
	SET @ID_TP_IDENTIFICACION_MADRE = NULL
END

IF @ID_TP_IDENTIFICACION_PADRE = 0
BEGIN
	SET @ID_TP_IDENTIFICACION_PADRE = NULL
END

IF @ID_TP_IDENTIFICACION_ACUDIENTE = 0
BEGIN
	SET @ID_TP_IDENTIFICACION_ACUDIENTE = NULL
END

INSERT INTO T_ESTUDIANTES
(
	COD_ESTUDIANTE,
	COD_MEN,
	ID_TP_IDENTIFICACION,
	NUM_DOCUMENTO,
	ID_DEPARATAMENTO_EXP,
	ID_MUNICIPIO_EXPEDICION,
	PRIMER_APELLIDO,
	SEGUNDO_APELLIDO,
	PRIMER_NOMBRE,
	SEGUNDO_NOMBRE,
	FECHA_NACIMIENTO,
	ID_DEPARTAMENTO_NAC,
	ID_MUNICIPIO_NAC,
	ID_GENERO,
	ID_FACTOR_RH,
	EMAIL_ESTUDIANTE,
	FOTOGRAFIA,
	DIRECCION,
	ID_DEPARTAMENTO_RESID,
	ID_MUNICIPIO_RESID,
	ID_ZONA_RESID,
	LOCALIDAD,
	BARRIO,
	ID_ESTRATO,
	TELEFONO,
	CELULAR,
	ID_SISBEN,
	NUMERO_SISBEN,
	ID_EPS,
	ID_ARS,
	ID_POBLACION_VICTIMA,
	ID_DEPARTAMENTO_EXPULSOR,
	ID_MUNICIPIO_EXPULSOR,
	FECHA_EXPULSOR,
	CERTIFICADO_EXPULSOR,
	FECHA_CERTIFICADO_EXPULSOR,
	ID_TP_DISCAPACIDAD,
	ID_TP_CAPACIDAD_EXCEP,
	ID_ETNIA,
	ID_RESGUARDO,
	PROVIENE_SECT_PRIVADO,
	PROVIENE_OTRO_MPIO,
	INST_BIENESTAR,
	ID_TP_IDENTIFICACION_MADRE,
	NUM_DOCUMENTO_MADRE,
	ID_DEPARATAMENTO_EXP_MADRE,
	ID_MUNICIPIO_EXPEDICION_MADRE,
	PRIMER_APELLIDO_MADRE,
	SEGUNDO_APELLIDO_MADRE,
	PRIMER_NOMBRE_MADRE,
	SEGUNDO_NOMBRE_MADRE,
	EMAIL_MADRE,
	DIRECCION_MADRE,
	ID_DEPARTAMENTO_RESID_MADRE,
	ID_MUNICIPIO_RESID_MADRE,
	ID_ZONA_RESID_MADRE,
	BARRIO_MADRE,
	LOCALIDAD_MADRE,
	TELEFONO_MADRE,
	CELULAR_MADRE,
	OCUPACION_MADRE,
	EMPRESA_MADRE,
	TELEFONO_EMPRESA_MADRE,
	ID_TP_IDENTIFICACION_PADRE,
	NUM_DOCUMENTO_PADRE,
	ID_DEPARATAMENTO_EXP_PADRE,
	ID_MUNICIPIO_EXPEDICION_PADRE,
	PRIMER_APELLIDO_PADRE,
	SEGUNDO_APELLIDO_PADRE,
	PRIMER_NOMBRE_PADRE,
	SEGUNDO_NOMBRE_PADRE,
	EMAIL_PADRE,
	DIRECCION_PADRE,
	ID_DEPARTAMENTO_RESID_PADRE,
	ID_MUNICIPIO_RESID_PADRE,
	ID_ZONA_RESID_PADRE,
	BARRIO_PADRE,
	LOCALIDAD_PADRE,
	TELEFONO_PADRE,
	CELULAR_PADRE,
	OCUPACION_PADRE,
	EMPRESA_PADRE,
	TELEFONO_EMPRESA_PADRE,
	ID_TP_IDENTIFICACION_ACUDIENTE,
	NUM_DOCUMENTO_ACUDIENTE,
	ID_DEPARATAMENTO_EXP_ACUDIENTE,
	ID_MUNICIPIO_EXPEDICION_ACUDIENTE,
	PRIMER_APELLIDO_ACUDIENTE,
	SEGUNDO_APELLIDO_ACUDIENTE,
	PRIMER_NOMBRE_ACUDIENTE,
	SEGUNDO_NOMBRE_ACUDIENTE,
	EMAIL_ACUDIENTE,
	DIRECCION_ACUDIENTE,
	ID_DEPARTAMENTO_RESID_ACUDIENTE,
	ID_MUNICIPIO_RESID_ACUDIENTE,
	ID_ZONA_RESID_ACUDIENTE,
	BARRIO_ACUDIENTE,
	LOCALIDAD_ACUDIENTE,
	TELEFONO_ACUDIENTE,
	CELULAR_ACUDIENTE,
	OCUPACION_ACUDIENTE,
	EMPRESA_ACUDIENTE,
	TELEFONO_EMPRESA_ACUDIENTE,
	ID_GENERO_ACUDIENTE,
	ID_PARENTESCO_ACUDIENTE,
	COLEGIO_ULTIMO_CURSO,
	DIRECCION_COLEG_ULTIMO,
	TELEFONO_COLEG_ULTIMO,
	GRADO_ULTIMO,
	ANIO,
	MOTIVO_RETIRO_ULTIMO,
	OBSERVACIONES,
	USUARIO_ESTUDIANTE,
	CLAVE_ACCESO,
	ID_GRUPO_USR,
	ID_SEDE,
	ACTIVO,
	ID_INSTITUCION,
	USUARIO_REG,
	FECHA_REG,
	SEL_MADRE,
	SEL_PADRE,
	SEL_ACUDIENTE
)
VALUES
(
	@COD_ESTUDIANTE,
	@COD_MEN,
	@ID_TP_IDENTIFICACION,
	@NUM_DOCUMENTO,
	@ID_DEPARATAMENTO_EXP,
	@ID_MUNICIPIO_EXPEDICION,
	@PRIMER_APELLIDO,
	@SEGUNDO_APELLIDO,
	@PRIMER_NOMBRE,
	@SEGUNDO_NOMBRE,
	@FECHA_NACIMIENTO,
	@ID_DEPARTAMENTO_NAC,
	@ID_MUNICIPIO_NAC,
	@ID_GENERO,
	@ID_FACTOR_RH,
	@EMAIL_ESTUDIANTE,
	@FOTOGRAFIA,
	@DIRECCION,
	@ID_DEPARTAMENTO_RESID,
	@ID_MUNICIPIO_RESID,
	@ID_ZONA_RESID,
	@LOCALIDAD,
	@BARRIO,
	@ID_ESTRATO,
	@TELEFONO,
	@CELULAR,
	@ID_SISBEN,
	@NUMERO_SISBEN,
	@ID_EPS,
	@ID_ARS,
	@ID_POBLACION_VICTIMA,
	@ID_DEPARTAMENTO_EXPULSOR,
	@ID_MUNICIPIO_EXPULSOR,
	@FECHA_EXPULSOR,
	@CERTIFICADO_EXPULSOR,
	@FECHA_CERTIFICADO_EXPULSOR,
	@ID_TP_DISCAPACIDAD,
	@ID_TP_CAPACIDAD_EXCEP,
	@ID_ETNIA,
	@ID_RESGUARDO,
	@PROVIENE_SECT_PRIVADO,
	@PROVIENE_OTRO_MPIO,
	@INST_BIENESTAR,
	@ID_TP_IDENTIFICACION_MADRE,
	@NUM_DOCUMENTO_MADRE,
	@ID_DEPARATAMENTO_EXP_MADRE,
	@ID_MUNICIPIO_EXPEDICION_MADRE,
	@PRIMER_APELLIDO_MADRE,
	@SEGUNDO_APELLIDO_MADRE,
	@PRIMER_NOMBRE_MADRE,
	@SEGUNDO_NOMBRE_MADRE,
	@EMAIL_MADRE,
	@DIRECCION_MADRE,
	@ID_DEPARTAMENTO_RESID_MADRE,
	@ID_MUNICIPIO_RESID_MADRE,
	@ID_ZONA_RESID_MADRE,
	@BARRIO_MADRE,
	@LOCALIDAD_MADRE,
	@TELEFONO_MADRE,
	@CELULAR_MADRE,
	@OCUPACION_MADRE,
	@EMPRESA_MADRE,
	@TELEFONO_EMPRESA_MADRE,
	@ID_TP_IDENTIFICACION_PADRE,
	@NUM_DOCUMENTO_PADRE,
	@ID_DEPARATAMENTO_EXP_PADRE,
	@ID_MUNICIPIO_EXPEDICION_PADRE,
	@PRIMER_APELLIDO_PADRE,
	@SEGUNDO_APELLIDO_PADRE,
	@PRIMER_NOMBRE_PADRE,
	@SEGUNDO_NOMBRE_PADRE,
	@EMAIL_PADRE,
	@DIRECCION_PADRE,
	@ID_DEPARTAMENTO_RESID_PADRE,
	@ID_MUNICIPIO_RESID_PADRE,
	@ID_ZONA_RESID_PADRE,
	@BARRIO_PADRE,
	@LOCALIDAD_PADRE,
	@TELEFONO_PADRE,
	@CELULAR_PADRE,
	@OCUPACION_PADRE,
	@EMPRESA_PADRE,
	@TELEFONO_EMPRESA_PADRE,
	@ID_TP_IDENTIFICACION_ACUDIENTE,
	@NUM_DOCUMENTO_ACUDIENTE,
	@ID_DEPARATAMENTO_EXP_ACUDIENTE,
	@ID_MUNICIPIO_EXPEDICION_ACUDIENTE,
	@PRIMER_APELLIDO_ACUDIENTE,
	@SEGUNDO_APELLIDO_ACUDIENTE,
	@PRIMER_NOMBRE_ACUDIENTE,
	@SEGUNDO_NOMBRE_ACUDIENTE,
	@EMAIL_ACUDIENTE,
	@DIRECCION_ACUDIENTE,
	@ID_DEPARTAMENTO_RESID_ACUDIENTE,
	@ID_MUNICIPIO_RESID_ACUDIENTE,
	@ID_ZONA_RESID_ACUDIENTE,
	@BARRIO_ACUDIENTE,
	@LOCALIDAD_ACUDIENTE,
	@TELEFONO_ACUDIENTE,
	@CELULAR_ACUDIENTE,
	@OCUPACION_ACUDIENTE,
	@EMPRESA_ACUDIENTE,
	@TELEFONO_EMPRESA_ACUDIENTE,
	@ID_GENERO_ACUDIENTE,
	@ID_PARENTESCO_ACUDIENTE,
	@COLEGIO_ULTIMO_CURSO,
	@DIRECCION_COLEG_ULTIMO,
	@TELEFONO_COLEG_ULTIMO,
	@GRADO_ULTIMO,
	@ANIO,
	@MOTIVO_RETIRO_ULTIMO,
	@OBSERVACIONES,
	@USUARIO_ESTUDIANTE,
	@CLAVE_ACCESO,
	@ID_GRUPO_USR,
	@ID_SEDE,
	@ACTIVO,
	@ID_INSTITUCION,
	@USUARIO_REG,
	@FECHA_REG,
	@SEL_MADRE,
	@SEL_PADRE,
	@SEL_ACUDIENTE
)
SET @ID_ESTUDIANTE = SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[spInsertarEtnias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spInsertarEtnias
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


create PROCEDURE [dbo].[spInsertarEtnias]
(
	@codEtnia	nvarchar(3),
	@nomEtnia	nvarchar(100),
	@activo		bit,
	@usuarioReg	nvarchar(20),
	@fechaReg	datetime
)

AS

INSERT INTO T_ETNIAS
	(
		COD_ETNIAS,
		NOM_ETNIAS,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codEtnia,
		@nomEtnia,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarFuenteRecursos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spInsertarFuenteRecursos
Creado por:		jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spInsertarFuenteRecursos]
(
	@codFuenteRecursos  bigint,
	@nomFuenteRecursos  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

INSERT INTO T_FUENTE_RECURSOS
(
	COD_FUENTE_RECURSOS,
	NOM_FUENTE_RECURSOS,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codFuenteRecursos,
	@nomFuenteRecursos,
	@activo,
	@usuarioReg,
	@fechaReg
)


GO
/****** Object:  StoredProcedure [dbo].[spInsertarGrupos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spInsertarGrupos
Creado por:		jreyes
Fecha:			29/01/2013
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spInsertarGrupos]
(
	@idGrupo  bigint = 0 output,
	@codGrupo  nvarchar(10),
	@nomGrupo  nvarchar(100),
	@idSede  bigint,
	@activo  bit,
	@idInstitucion  bigint,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

IF @idSede = 0
BEGIN
	SET @idSede =  NULL
END

INSERT INTO T_GRUPO
(
	COD_GRUPO,
	NOM_GRUPO,
	ID_SEDE,
	ACTIVO,
	ID_INSTITUCION,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codGrupo,
	@nomGrupo,
	@idSede,
	@activo,
	@idInstitucion,
	@usuarioReg,
	@fechaReg
)

SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]


GO
/****** Object:  StoredProcedure [dbo].[spInsertarGruposUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spInsertarGruposUsr
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Inserta las sedes
******************************************************************************************************/

CREATE procedure [dbo].[spInsertarGruposUsr]
(
	@idGrupoUsr	bigint = 0 output,
	@codGrupoUsr  bigint,
	@nombreGrupoUsr nvarchar(50),
	@activo bit,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

INSERT INTO T_GRUPO_USR
(
	COD_GRUPO_USR,
	NOMBRE_GRUPO_USR,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codGrupoUsr,
	@nombreGrupoUsr,
	@activo,
	@usuarioReg,
	@fechaReg
)

SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]
GO
/****** Object:  StoredProcedure [dbo].[spInsertarInstituciones]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spInsertarInstituciones
Creado por:		jreyes
Fecha:			27/11/2011
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spInsertarInstituciones]
(
	@codigo_dane	nvarchar (12),
	@nombre_est	nvarchar (100),
	@nit	nvarchar (20),
	@nombre_rector	nvarchar (50),
	@cod_calendario	nvarchar (2),
	@cod_sector	nvarchar (2),
	@cod_propiedad_juridica	nvarchar (2),
	@numero_sedes	int,
	@cod_nucleo	nvarchar (3),
	@id_genero	bigint,
	@subsidio	bit,
	@idDiscapacidades	bigint,
	@idCapExepcionales	bigint,
	@idEtnias	bigint,
	@idResguardo	bigint,
	@cod_novedad_est	nvarchar (2),
	@cod_metodologia	nvarchar (2),
	@cod_prestador_serv	nvarchar (2),
	@decreto_creacion	nvarchar (30),
	@director	nvarchar (30),
	@secretaria	nvarchar (30),
	@aprobacion	nvarchar (30),
	@lema	nvarchar (255),
	@escudo	image,
	@id_deparatamento	bigint,
	@id_municipio	bigint,
	@id_zona	bigint,
	@barrio	nvarchar (30),
	@direccion	nvarchar (100),
	@telefono	nvarchar (20),
	@fax	nvarchar (20),
	@sitio_web	nvarchar (20),
	@email	nvarchar (20),
	@num_licencia	nvarchar (10),
	@id_regimen_costo	bigint,
	@id_idioma	bigint,
	@id_asociacion	bigint,
	@id_tarifa_anual	bigint,
	@activo	bit,
	@usuario_reg	nvarchar (20),
	@fecha_reg	datetime
)

AS

INSERT INTO T_INSTITUCION
(
	CODIGO_DANE,
	NOMBRE_EST,
	NIT,
	NOMBRE_RECTOR,
	COD_CALENDARIO,
	COD_SECTOR,
	COD_PROPIEDAD_JURIDICA,
	NUMERO_SEDES,
	COD_NUCLEO,
	ID_GENERO,
	SUBSIDIO,
	ID_DISCAPACIDADES,
	ID_CAP_EXCEPCIONALES,
	ID_ETNIAS,
	ID_RESGUARDOS,
	COD_NOVEDAD_EST,
	COD_METODOLOGIA,
	COD_PRESTADOR_SERV,
	DECRETO_CREACION,
	DIRECTOR,
	SECRETARIA,
	APROBACION,
	LEMA,
	ESCUDO,
	ID_DEPARATAMENTO,
	ID_MUNICIPIO,
	ID_ZONA,
	BARRIO,
	DIRECCION,
	TELEFONO,
	FAX,
	SITIO_WEB,
	EMAIL,
	NUM_LICENCIA,
	ID_REGIMEN_COSTO,
	ID_IDIOMA,
	ID_ASOCIACION,
	ID_TARIFA_ANUAL,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codigo_dane,
	@nombre_est,
	@nit,
	@nombre_rector,
	@cod_calendario,
	@cod_sector,
	@cod_propiedad_juridica,
	@numero_sedes,
	@cod_nucleo,
	@id_genero,
	@subsidio,
	@idDiscapacidades,
	@idCapExepcionales,
	@idEtnias,
	@idResguardo,
	@cod_novedad_est,
	@cod_metodologia,
	@cod_prestador_serv,
	@decreto_creacion,
	@director,
	@secretaria,
	@aprobacion,
	@lema,
	@escudo,
	@id_deparatamento,
	@id_municipio,
	@id_zona,
	@barrio,
	@direccion,
	@telefono,
	@fax,
	@sitio_web,
	@email,
	@num_licencia,
	@id_regimen_costo,
	@id_idioma,
	@id_asociacion,
	@id_tarifa_anual,
	@activo,
	@usuario_reg,
	@fecha_reg
)
GO
/****** Object:  StoredProcedure [dbo].[spInsertarJornadas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spInsertarJornadas
Creado por:		jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spInsertarJornadas]
(
	@codJornada  nvarchar(2),
	@nomJornada  nvarchar(50),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

INSERT INTO T_JORNADAS
(
	COD_JORNADAS,
	NOM_JORNADAS,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codJornada,
	@nomJornada,
	@activo,
	@usuarioReg,
	@fechaReg
)


GO
/****** Object:  StoredProcedure [dbo].[spInsertarMetodologias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spInsertarMetodologias
Creado por:		jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spInsertarMetodologias]
(
	@codMetodologia  bigint,
	@nomMetodologia  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

INSERT INTO T_METODOLOGIAS
(
	COD_METODOLOGIAS,
	NOM_METODOLOGIAS,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codMetodologia,
	@nomMetodologia,
	@activo,
	@usuarioReg,
	@fechaReg
)


GO
/****** Object:  StoredProcedure [dbo].[spInsertarPermisos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:    spInsertarPermisos
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


CREATE PROCEDURE [dbo].[spInsertarPermisos]
(
	@idMenu	INT,
	@idGrupoUsr	BIGINT,
	@idInstitucion	BIGINT,
	@ver	BIT,
	@agregar	BIT,
	@modificar	BIT,
	@eliminar	BIT,
	@todos	BIT,
	@activo	BIT,
	@usuarioReg	NVARCHAR(20),
	@fechaReg	datetime
)

AS

IF @idInstitucion = 0
BEGIN
	SET @idInstitucion = NULL
END

INSERT INTO T_OPC_MENUXUSR
	(
		ID_MENU,
		ID_GRUPO_USR,
		ID_INSTITUCION,
		VER,
		AGREGAR,
		MODIFICAR,
		ELIMINAR,
		TODOS,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@idMenu,
		@idGrupoUsr,
		@idInstitucion,
		@ver,
		@agregar,
		@modificar,
		@eliminar,
		@todos,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarPoblaVicConflicto]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spInsertarPoblaVicConflicto
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


create PROCEDURE [dbo].[spInsertarPoblaVicConflicto]
(
	@codPoblaVicConflicto	nvarchar(4),
	@nomPoblaVicConflicto	nvarchar(100),
	@activo				bit,
	@usuarioReg			nvarchar(20),
	@fechaReg			datetime
)

AS

INSERT INTO T_POBLA_VIC_CONFLICTO
	(
		COD_POBLA_VIC_CONFLICTO,
		NOM_POBLA_VIC_CONFLICTO,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codPoblaVicConflicto,
		@nomPoblaVicConflicto,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarProfesion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spInsertarProfesion
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Guardar informacion de la tabla T_PROFESION
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spInsertarProfesion]
(
	@ID_PROFESION bigint = 0 OUTPUT,-- Parametro de 
	@COD_PROFESION nvarchar(5),-- Parametro de 
	@NOM_PROFESION nvarchar(50),-- Parametro de 
	@ID_SEDE bigint =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)

AS

IF @ID_SEDE = 0
BEGIN
	SET @ID_SEDE = NULL
END

INSERT INTO T_PROFESION
(
	COD_PROFESION,
	NOM_PROFESION,
	ID_SEDE,
	ACTIVO,
	ID_INSTITUCION,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@COD_PROFESION,
	@NOM_PROFESION,
	@ID_SEDE,
	@ACTIVO,
	@ID_INSTITUCION,
	@USUARIO_REG,
	@FECHA_REG
)
SET @ID_PROFESION = SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[spInsertarProfesores]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spInsertarProfesores
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Guardar informacion de la tabla T_PROFESOR
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spInsertarProfesores]
(
	@ID_PROFESOR bigint = 0 OUTPUT,-- Parametro de 
	@COD_PROFESOR nvarchar(10) =  NULL,-- Parametro de 
	@ID_TP_IDENTIFICACION bigint,-- Parametro de 
	@NUM_ID_PROF nvarchar(20),-- Parametro de 
	@PRI_NOMBRE_PROF nvarchar(40),-- Parametro de 
	@SEG_NOMBRE_PROF nvarchar(40) =  NULL,-- Parametro de 
	@PRI_APELLIDO_PROF nvarchar(40),-- Parametro de 
	@SEG_APELLIDO_PROF nvarchar(40) =  NULL,-- Parametro de 
	@DIRECCION_PROF nvarchar(255) =  NULL,-- Parametro de 
	@TELEFONOS_PROF nvarchar(80) =  NULL,-- Parametro de 
	@ID_PROFESION bigint,-- Parametro de 
	@ID_ESCALAFON bigint =  NULL,-- Parametro de 
	@ID_SEDE bigint =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)

AS

IF @ID_SEDE = 0
BEGIN
	SET @ID_SEDE = NULL
END

INSERT INTO T_PROFESOR
(
	COD_PROFESOR,
	ID_TP_IDENTIFICACION,
	NUM_ID_PROF,
	PRI_NOMBRE_PROF,
	SEG_NOMBRE_PROF,
	PRI_APELLIDO_PROF,
	SEG_APELLIDO_PROF,
	DIRECCION_PROF,
	TELEFONOS_PROF,
	ID_PROFESION,
	ID_ESCALAFON,
	ID_SEDE,
	ACTIVO,
	ID_INSTITUCION,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@COD_PROFESOR,
	@ID_TP_IDENTIFICACION,
	@NUM_ID_PROF,
	@PRI_NOMBRE_PROF,
	@SEG_NOMBRE_PROF,
	@PRI_APELLIDO_PROF,
	@SEG_APELLIDO_PROF,
	@DIRECCION_PROF,
	@TELEFONOS_PROF,
	@ID_PROFESION,
	@ID_ESCALAFON,
	@ID_SEDE,
	@ACTIVO,
	@ID_INSTITUCION,
	@USUARIO_REG,
	@FECHA_REG
)
SET @ID_PROFESOR = SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[spInsertarResguardos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spInsertarResguardos
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


create PROCEDURE [dbo].[spInsertarResguardos]
(
	@codResguardo	nvarchar(3),
	@nomResguardo	nvarchar(100),
	@activo		bit,
	@usuarioReg	nvarchar(20),
	@fechaReg	datetime
)

AS

INSERT INTO T_RESGUARDOS
	(
		COD_RESGUARDOS,
		NOM_RESGUARDOS,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codResguardo,
		@nomResguardo,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarSedes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spInsertarSedes
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Inserta las sedes
******************************************************************************************************/

CREATE procedure [dbo].[spInsertarSedes]
(
	@idSede  bigint,
	@codSede  bigint,
	@codDaneNuevo  nvarchar(24),
	@codDaneAntiguo  nvarchar(24),
	@codSedeConsecutivo  nvarchar(40),
	@nombreSede  nvarchar(200),
	@idDepartamento  bigint,
	@idMunicipio  bigint,
	@idZona  bigint,
	@barrio  nvarchar(60),
	@direccion  nvarchar(200),
	@telefono  nvarchar(40),
	@fax  nvarchar(40),
	@email  nvarchar(40),
	@novedadSede  nvarchar(4),
	@jornadaCompleta  bit,
	@jornadaManana  bit,
	@jornadaTarde  bit,
	@jornadaNoche  bit,
	@jornadaFinSem  bit,
	@idEspecialidad  bigint,
	@fechaCreacion  datetime,
	@director  nvarchar(60),
	@secretaria  nvarchar(60),
	@escalaValNal  bit,
	@rangoNum  bit,
	@numInicial integer,
	@numFinal integer,
	@valLetras  bit,
	@juicios  bit,
	@activo  bit,
	@idInstitucion  bigint,
	@usuarioReg  nvarchar(40),
	@fechaReg  datetime
)

AS

INSERT INTO T_SEDES
(
	COD_SEDE,
	COD_DANE_NUEVO,
	COD_DANE_ANTIGUO,
	COD_SEDE_CONSECUTIVO,
	NOMBRE_SEDE,
	ID_DEPARTAMENTO,
	ID_MUNICIPIO,
	ID_ZONA,
	BARRIO,
	DIRECCION,
	TELEFONO,
	FAX,
	EMAIL,
	NOVEDAD_SEDE,
	JORNADA_COMPLETA,
	JORNADA_MANANA,
	JORNADA_TARDE,
	JORNADA_NOCHE,
	JORNADA_FIN_SEM,
	ID_ESPECIALIDAD,
	FECHA_CREACION,
	DIRECTOR,
	SECRETARIA,
	ESCALA_VAL_NAL,
	RANGO_NUM,
	NUM_INICIAL,
	NUM_FINAL,
	VAL_LETRAS,
	JUICIOS,
	ACTIVO,
	ID_INSTITUCION,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codSede,
	@codDaneNuevo,
	@codDaneAntiguo,
	@codSedeConsecutivo,
	@nombreSede,
	@idDepartamento,
	@idMunicipio,
	@idZona,
	@barrio,
	@direccion,
	@telefono,
	@fax,
	@email,
	@novedadSede,
	@jornadaCompleta,
	@jornadaManana,
	@jornadaTarde,
	@jornadaNoche,
	@jornadaFinSem,
	@idEspecialidad,
	@fechaCreacion,
	@director,
	@secretaria,
	@escalaValNal,
	@rangoNum,
	@numInicial,
	@numFinal,
	@valLetras,
	@juicios,
	@activo,
	@idInstitucion,
	@usuarioReg,
	@fechaReg
)
GO
/****** Object:  StoredProcedure [dbo].[spInsertarSisben]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spInsertarSisben
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


CREATE PROCEDURE [dbo].[spInsertarSisben]
(
	@codSisben	bigint,
	@nomSisben	nvarchar(255),
	@activo		bit,
	@usuarioReg	nvarchar(20),
	@fechaReg	datetime
)

AS

INSERT INTO T_SISBEN
	(
		COD_SISBEN,
		NOM_SISBEN,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codSisben,
		@nomSisben,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarSituAcademica]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spInsertarSituAcademica
Creado por:		jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spInsertarSituAcademica]
(
	@codSituAcademica  bigint,
	@nomSituAcademica  nvarchar(255),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

INSERT INTO T_SITU_ACADEMICA
(
	COD_SITU_ACADEMICA,
	NOM_SITU_ACADEMICA,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codSituAcademica,
	@nomSituAcademica,
	@activo,
	@usuarioReg,
	@fechaReg
)


GO
/****** Object:  StoredProcedure [dbo].[spInsertarTipoDiscapacidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spInsertarTipoDiscapacidad
Creado por:       jreyes
Fecha:			  12/03/2012
Descripcion:
******************************************************************************************************/


create PROCEDURE [dbo].[spInsertarTipoDiscapacidad]
(
	@codTpDiscapacidad	bigint,
	@nomTpDiscapacidad	nvarchar(100),
	@activo				bit,
	@usuarioReg			nvarchar(20),
	@fechaReg			datetime
)

AS

INSERT INTO T_TP_DISCAPACIDAD
	(
		COD_TP_DISCAPACIDAD,
		NOM_TP_DISCAPACIDAD,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codTpDiscapacidad,
		@nomTpDiscapacidad,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarTipoRespuestas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spInsertarTipoRespuestas
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


create PROCEDURE [dbo].[spInsertarTipoRespuestas]
(
	@codTpRespuesta	nvarchar(1),
	@nomTpRespuesta	nvarchar(10),
	@activo				bit,
	@usuarioReg			nvarchar(20),
	@fechaReg			datetime
)

AS

INSERT INTO T_TP_RESPUESTA
	(
		COD_TP_RESPUESTA,
		NOM_TP_RESPUESTA,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codTpRespuesta,
		@nomTpRespuesta,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarTpCaracter]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spInsertarTpCaracter
Creado por:		jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spInsertarTpCaracter]
(
	@codTpCaracter  bigint,
	@nomTpCaracter  nvarchar(50),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

INSERT INTO T_TP_CARACTER
(
	COD_TP_CARACTER,
	NOM_TP_CARACTER,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codTpCaracter,
	@nomTpCaracter,
	@activo,
	@usuarioReg,
	@fechaReg
)


GO
/****** Object:  StoredProcedure [dbo].[spInsertarTpCondicion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spInsertarTpCondicion
Creado por:		jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

CREATE procedure [dbo].[spInsertarTpCondicion]
(
	@codTpCondicion  bigint,
	@nomTpCondicion  nvarchar(100),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

INSERT INTO T_TP_CONDICION
(
	COD_TP_CONDICION,
	NOM_TP_CONDICION,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codTpCondicion,
	@nomTpCondicion,
	@activo,
	@usuarioReg,
	@fechaReg
)


GO
/****** Object:  StoredProcedure [dbo].[spInsertarTpIdentificacion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spInsertarTpIdentificacion
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


create PROCEDURE [dbo].[spInsertarTpIdentificacion]
(
	@codTpIdentificacion	nvarchar(2),
	@nomTpIdentificacion	nvarchar(255),
	@activo				bit,
	@usuarioReg			nvarchar(20),
	@fechaReg			datetime
)

AS

INSERT INTO T_TP_IDENTIFICACION
	(
		COD_TP_IDENTIFICACION,
		NOM_TP_IDENTIFICACION,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codTpIdentificacion,
		@nomTpIdentificacion,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[spInsertarUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spInsertarUsr
Creado por:		jreyes
Fecha:			28/11/2012
Descripcion:	Inserta los usuarios
******************************************************************************************************/

CREATE procedure [dbo].[spInsertarUsr]
(
	@idUsr			bigint = 0 output,
	@codUsr			nvarchar(10),
	@nomUsr			nvarchar(50),
	@paswUsr		nvarchar(40),
	@caduUsr		bit,
	@fechAsigUsr	datetime,
	@fechVctoUsr	datetime,
	@tpIdPers		nvarchar(2),
	@identifPers	nvarchar(10),
	@activo			bit,
	@idInstitucion	bigint,
	@idGrupoUsr		bigint,
	@usuarioReg		nvarchar(20),
	@fechaReg		datetime
)

AS

INSERT INTO T_USR
(
	COD_USR,
	NOM_USR,
	PASW_USR,
	CADU_USR,
	FECH_ASIG_USR,
	FECH_VCTO_USR,
	TP_ID_PERS,
	IDENTIF_PERS,
	ACTIVO,
	ID_INSTITUCION,
	ID_GRUPO_USR,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codUsr,
	@nomUsr,
	@paswUsr,
	@caduUsr,
	@fechAsigUsr,
	@fechVctoUsr,
	@tpIdPers,
	@identifPers,
	@activo,
	@idInstitucion,
	@idGrupoUsr,
	@usuarioReg,
	@fechaReg
)

SELECT SCOPE_IDENTITY() AS [SCOPE_IDENTITY]
GO
/****** Object:  StoredProcedure [dbo].[spInsertarValLetras]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spInsertarValLetras
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Guardar informacion de la tabla T_VALORACION_LETRAS
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spInsertarValLetras]
(
	@ID_VAL_LETRAS bigint = 0 OUTPUT,-- Parametro de 
	@COD_VAL_LETRAS nvarchar(5) =  NULL,-- Parametro de 
	@DESCRIPCION nvarchar(255) =  NULL,-- Parametro de 
	@VAL_NUMERICO int =  NULL,-- Parametro de 
	@ID_SEDE bigint =  NULL,-- Parametro de 
	@ACTIVO bit =  NULL,-- Parametro de 
	@ID_INSTITUCION bigint =  NULL,-- Parametro de 
	@USUARIO_REG nvarchar(20) =  NULL,-- Parametro de 
	@FECHA_REG datetime =  NULL-- Parametro de 
)

AS

IF @ID_SEDE = 0
BEGIN
	SET @ID_SEDE = NULL
END

INSERT INTO T_VALORACION_LETRAS
(
	COD_VAL_LETRAS,
	DESCRIPCION,
	VAL_NUMERICO,
	ID_SEDE,
	ACTIVO,
	ID_INSTITUCION,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@COD_VAL_LETRAS,
	@DESCRIPCION,
	@VAL_NUMERICO,
	@ID_SEDE,
	@ACTIVO,
	@ID_INSTITUCION,
	@USUARIO_REG,
	@FECHA_REG
)
SET @ID_VAL_LETRAS = SCOPE_IDENTITY()

GO
/****** Object:  StoredProcedure [dbo].[spInsertarZonas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spInsertarZonas
Creado por:		jreyes
Fecha:			16/03/2012
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spInsertarZonas]
(
	@codZonas  bigint,
	@nomZonas  nvarchar(10),
	@descripcion nvarchar(10),
	@activo  bit,
	@usuarioReg  nvarchar(20),
	@fechaReg  datetime
)

AS

INSERT INTO T_Zonas
(
	COD_ZONAS,
	NOM_ZONAS,
	DESCRIPCION,
	ACTIVO,
	USUARIO_REG,
	FECHA_REG
)
VALUES
(
	@codZonas,
	@nomZonas,
	@descripcion,
	@activo,
	@usuarioReg,
	@fechaReg
)


GO
/****** Object:  StoredProcedure [dbo].[spJornadasxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spJornadasxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spJornadasxID]
(
	@idJornada BIGINT
)
AS

SELECT	*	
FROM	T_JORNADAS 
WHERE	ID_JORNADAS = @idJornada
ORDER BY NOM_JORNADAS	
GO
/****** Object:  StoredProcedure [dbo].[spMetodologiasxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spMetodologiasxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spMetodologiasxID]
(
	@idMetodologia BIGINT
)
AS

SELECT	*	
FROM	T_METODOLOGIAS
WHERE	ID_METODOLOGIAS = @idMetodologia
ORDER BY NOM_METODOLOGIAS	
GO
/****** Object:  StoredProcedure [dbo].[spMunicipiosxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[spMunicipiosxID]
(
	@idMunicipio BIGINT
)
AS

SELECT	*	
FROM	T_MUNICIPIO 
WHERE	ID_MUNICIPIO = @idMunicipio
ORDER BY NOM_MUNICIPIO	
GO
/****** Object:  StoredProcedure [dbo].[spPoblaVicConflictoxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spPoblaVicConflictoxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


create PROCEDURE [dbo].[spPoblaVicConflictoxID]
(
	@idPoblaVicConflicto BIGINT
)
AS

SELECT	*	
FROM	T_POBLA_VIC_CONFLICTO
WHERE	ID_POBLA_VIC_CONFLICTO = @idPoblaVicConflicto
ORDER BY NOM_POBLA_VIC_CONFLICTO	
GO
/****** Object:  StoredProcedure [dbo].[spProfesionTraerxPK]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spProfesionTraerxPK
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para TraerxPK informacion de la tabla T_PROFESION
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spProfesionTraerxPK]
(
	@ID_PROFESION bigint-- Parametro de 
)
AS
SELECT * FROM T_PROFESION
WHERE
	ID_PROFESION = @ID_PROFESION

GO
/****** Object:  StoredProcedure [dbo].[spProfesoresTraerxPK]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spProfesoresTraerxPK
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para TraerxPK informacion de la tabla T_PROFESOR
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spProfesoresTraerxPK]
(
	@ID_PROFESOR bigint-- Parametro de 
)
AS
SELECT * FROM T_PROFESOR
WHERE
	ID_PROFESOR = @ID_PROFESOR

GO
/****** Object:  StoredProcedure [dbo].[spResguardosxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spResguardosxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spResguardosxID]
(
	@idResguardo BIGINT
)
AS

SELECT	*	
FROM	T_RESGUARDOS
WHERE	ID_RESGUARDOS = @idResguardo
ORDER BY NOM_RESGUARDOS
GO
/****** Object:  StoredProcedure [dbo].[spSeleccionarInstituciones]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spSeleccionarInstituciones
Creado por:       jreyes
Fecha:			27/11/2011
Descripcion:
******************************************************************************************************/

create procedure [dbo].[spSeleccionarInstituciones]
(
	@id_institucion  bigint,
	@codigo_dane  nvarchar(24),
	@nombre_est  nvarchar(200),
	@nit  nvarchar(40),
	@nombre_rector  int,
	@cod_calendario  nvarchar(4),
	@cod_sector  nvarchar(4),
	@cod_propiedad_juridica  nvarchar(4),
	@numero_sedes  int,
	@cod_nucleo  nvarchar(6),
	@genero  nvarchar(2),
	@subsidio  bit,
	@cod_discapacidades  nvarchar(4),
	@cap_exepcionales  bit,
	@etnias  bit,
	@resguardo  bit,
	@cod_novedad_est  nvarchar(4),
	@cod_metodologia  nvarchar(4),
	@cod_prestador_serv  nvarchar(4),
	@decreto_creacion  nvarchar(60),
	@director  nvarchar(60),
	@secretaria  nvarchar(60),
	@aprobacion  nvarchar(60),
	@lema  nvarchar(510),
	@escudo  image,
	@cod_deparatamento  nvarchar(4),
	@cod_municipio  nvarchar(12),
	@cod_zona  nvarchar(4),
	@barrio  nvarchar(60),
	@direccion  nvarchar(200),
	@telefono  nvarchar(40),
	@fax  nvarchar(40),
	@sitio_web  nvarchar(40),
	@email  nvarchar(40),
	@num_licencia  nvarchar(20),
	@cod_regimen_costo  nvarchar(4),
	@cod_idioma  nvarchar(4),
	@cod_asociacion  nvarchar(4),
	@cod_rango  nvarchar(4),
	@activo  bit,
	@usuario_reg  nvarchar(40),
	@fecha_reg  datetime
)

AS

SELECT	*
FROM	T_INSTITUCION
WHERE	ID_INSTITUCION = @id_institucion




GO
/****** Object:  StoredProcedure [dbo].[spSisbenxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[spSisbenxID]
(
	@idSisben BIGINT
)
AS

SELECT	*	
FROM	T_SISBEN 
WHERE	ID_SISBEN = @idSisben
ORDER BY NOM_SISBEN
GO
/****** Object:  StoredProcedure [dbo].[spSituAcademicaxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spSituAcademicaxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spSituAcademicaxID]
(
	@idSituAcademica BIGINT
)
AS

SELECT	*	
FROM	T_SITU_ACADEMICA
WHERE	ID_SITU_ACADEMICA = @idSituAcademica
ORDER BY NOM_SITU_ACADEMICA	
GO
/****** Object:  StoredProcedure [dbo].[spT_ZONAS_Delete]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spT_ZONAS_Delete]
(
	@COD_ZONAS bigint
)
AS
/*
** Delete a row from the T_ZONAS table
*/
DELETE FROM [T_ZONAS] WHERE [COD_ZONAS] = @COD_ZONAS

IF @@ROWCOUNT = 0
BEGIN
	RAISERROR ('Delete failed: Zero rows were deleted from the T_ZONAS table', 16, 1)
END


GO
/****** Object:  StoredProcedure [dbo].[spT_ZONAS_Insert]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spT_ZONAS_Insert]
(
	@COD_ZONAS bigint,
	@NOM_ZONAS nvarchar(10)
)
AS
/*
** Add a row to the T_ZONAS table
*/

INSERT INTO [T_ZONAS]
( [COD_ZONAS], [NOM_ZONAS]
)
VALUES
( @COD_ZONAS, @NOM_ZONAS
)

/*
** Select the new row
*/
SELECT
	gv_T_ZONAS.*
FROM
	gv_T_ZONAS
WHERE
	[COD_ZONAS] = @COD_ZONAS


GO
/****** Object:  StoredProcedure [dbo].[spT_ZONAS_SelectAll]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spT_ZONAS_SelectAll]
AS
/*
** Select all rows from the T_ZONAS table
*/

SELECT 
	gv_T_ZONAS.*
FROM
	gv_T_ZONAS
ORDER BY
	[COD_ZONAS]	


GO
/****** Object:  StoredProcedure [dbo].[spT_ZONAS_SelectByCOD_ZONAS]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spT_ZONAS_SelectByCOD_ZONAS]
(
	@COD_ZONAS bigint
)
AS
/*
** Select a row from the T_ZONAS table by primary key
*/

SELECT 
	gv_T_ZONAS.*
FROM
	gv_T_ZONAS WHERE [COD_ZONAS] = @COD_ZONAS


GO
/****** Object:  StoredProcedure [dbo].[spT_ZONAS_Update]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[spT_ZONAS_Update]
(
	@COD_ZONASOriginal bigint, 
	@COD_ZONAS bigint,
	@NOM_ZONAS nvarchar(10)
)
AS
/*
** Update a row in the T_ZONAS table using the primary key
*/
UPDATE [T_ZONAS] SET [COD_ZONAS] = @COD_ZONAS, [NOM_ZONAS] = @NOM_ZONAS WHERE [COD_ZONAS] = @COD_ZONASOriginal


/*
** Select the updated row
*/
SELECT
	gv_T_ZONAS.*
FROM
	gv_T_ZONAS
WHERE
	[COD_ZONAS] = @COD_ZONASOriginal



GO
/****** Object:  StoredProcedure [dbo].[spTipoDiscapacidadxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTipoDiscapacidadxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTipoDiscapacidadxID]
(
	@idTpDiscapacidad BIGINT
)
AS

SELECT	*	
FROM	T_TP_DISCAPACIDAD 
WHERE	ID_TP_DISCAPACIDAD = @idTpDiscapacidad
ORDER BY NOM_TP_DISCAPACIDAD	
GO
/****** Object:  StoredProcedure [dbo].[spTipoRespuestasxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTipoRespuestasxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTipoRespuestasxID]
(
	@idTpRespuesta BIGINT
)
AS

SELECT	*	
FROM	T_TP_RESPUESTA 
WHERE	ID_TP_RESPUESTA = @idTpRespuesta
ORDER BY NOM_TP_RESPUESTA	
GO
/****** Object:  StoredProcedure [dbo].[spTpCaracterxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTpCaracterxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTpCaracterxID]
(
	@idTpCaracter BIGINT
)
AS

SELECT	*	
FROM	T_TP_CARACTER
WHERE	ID_TP_CARACTER = @idTpCaracter
ORDER BY NOM_TP_CARACTER	
GO
/****** Object:  StoredProcedure [dbo].[spTpCondicionxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTpCondicionxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTpCondicionxID]
(
	@idTpCondicion BIGINT
)
AS

SELECT	*	
FROM	T_TP_CONDICION
WHERE	ID_TP_CONDICION = @idTpCondicion
ORDER BY NOM_TP_CONDICION	
GO
/****** Object:  StoredProcedure [dbo].[spTpIdentificacionxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[spTpIdentificacionxID]
(
	@idTpIdentificacion BIGINT
)
AS

SELECT	*	
FROM	T_TP_IDENTIFICACION 
WHERE	ID_TP_IDENTIFICACION = @idTpIdentificacion
ORDER BY NOM_TP_IDENTIFICACION	
GO
/****** Object:  StoredProcedure [dbo].[spTraerArs]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerArs
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerArs]

AS

SELECT	*		
FROM	T_ARS
ORDER BY NOM_ARS
GO
/****** Object:  StoredProcedure [dbo].[spTraerAsignaturas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerAsignaturas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerAsignaturas]

AS

SELECT	* 
FROM	T_ASIGNATURA
ORDER BY NOM_ASIGNATURA
GO
/****** Object:  StoredProcedure [dbo].[spTraerAsignaturasxId]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



create PROCEDURE [dbo].[spTraerAsignaturasxId]
(
	@idAsignatura as integer
)

AS

SELECT	* 
FROM	T_ASIGNATURA
WHERE	ID_ASIGNATURA = @idAsignatura
ORDER BY NOM_ASIGNATURA
GO
/****** Object:  StoredProcedure [dbo].[spTraerAsociacionPrivada]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerAsociacionPrivada
Creado por:		jreyes
Fecha:			25/06/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerAsociacionPrivada]

AS

SELECT	*		
FROM	T_ASOCIACION_PRIVADA
WHERE	ACTIVO = 1
ORDER BY NOM_ASOCIACION
GO
/****** Object:  StoredProcedure [dbo].[spTraerCalendarioActivos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerCalendarioActivos
Creado por:		jreyes
Fecha:			25/06/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerCalendarioActivos]

AS

SELECT	*		
FROM	T_CALENDARIO
WHERE	ACTIVO = 1
ORDER BY NOM_CALENDARIO
GO
/****** Object:  StoredProcedure [dbo].[spTraerCapExcepcional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerCapExcepcional
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerCapExcepcional]

AS

SELECT	*		
FROM	T_CAP_EXCEPCIONALES
ORDER BY NOM_CAP_EXCEPCIONALES	
GO
/****** Object:  StoredProcedure [dbo].[spTraerCapExcepcionalesActivas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerCapExcepcionalesActivas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerCapExcepcionalesActivas]

AS

SELECT	*		
FROM	T_CAP_EXCEPCIONALES
WHERE	ACTIVO = 1
ORDER BY NOM_CAP_EXCEPCIONALES	
GO
/****** Object:  StoredProcedure [dbo].[spTraerDepartamentos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerDepartamentos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerDepartamentos]

AS

SELECT	*		
FROM	T_DEPARTAMENTO
ORDER BY NOM_DEPARTAMENTO	
GO
/****** Object:  StoredProcedure [dbo].[spTraerDepartamentosActivos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerDepartamentosActivos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/
CREATE PROCEDURE [dbo].[spTraerDepartamentosActivos]

AS

SELECT	*		
FROM	T_DEPARTAMENTO
WHERE	ACTIVO = 1
ORDER BY NOM_DEPARTAMENTO	
GO
/****** Object:  StoredProcedure [dbo].[spTraerEps]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerEps
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerEps]

AS

SELECT	*		
FROM	T_EPS
ORDER BY NOM_EPS
GO
/****** Object:  StoredProcedure [dbo].[spTraerEscalafon]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spTraerEscalafon
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Traer informacion de la tabla T_ESCALAFON
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spTraerEscalafon]
AS
SELECT * FROM T_ESCALAFON ORDER BY NOM_ESCALAFON

GO
/****** Object:  StoredProcedure [dbo].[spTraerEscNacional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spTraerEscNacional
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Traer informacion de la tabla T_GRADO
--- ***************************************************************************************************************
create PROCEDURE [dbo].[spTraerEscNacional]
(
	@idInstitucion BIGINT 	
)
AS
SELECT	* 
FROM	T_ESCALA_NACIONAL
WHERE	ID_INSTITUCION = @idInstitucion


GO
/****** Object:  StoredProcedure [dbo].[spTraerEspecialidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerEspecialidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerEspecialidad]

AS

SELECT	*		
FROM	T_ESPECIALIDAD
ORDER BY NOM_ESPECIALIDAD	
GO
/****** Object:  StoredProcedure [dbo].[spTraerEstratos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerEstratos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerEstratos]

AS

SELECT	*		
FROM	T_ESTRATO
ORDER BY NOM_ESTRATO	
GO
/****** Object:  StoredProcedure [dbo].[spTraerEstudiantes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spTraerEstudiantes
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 18/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Traer informacion de la tabla T_ESTUDIANTES
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spTraerEstudiantes]
AS
	SELECT * FROM T_ESTUDIANTES

GO
/****** Object:  StoredProcedure [dbo].[spTraerEtnias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerEtnias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerEtnias]

AS

SELECT	*		
FROM	T_ETNIAS
ORDER BY NOM_ETNIAS
GO
/****** Object:  StoredProcedure [dbo].[spTraerEtniasActivas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerEtniasActivas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerEtniasActivas]

AS

SELECT	*		
FROM	T_ETNIAS
WHERE	ACTIVO = 1
ORDER BY NOM_ETNIAS
GO
/****** Object:  StoredProcedure [dbo].[spTraerFactorRH]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerFactorRH
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerFactorRH]

AS

SELECT	*		
FROM	T_FACTOR_RH
ORDER BY NOM_FACTOR_RH
GO
/****** Object:  StoredProcedure [dbo].[spTraerFuenteRecursos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerFuenteRecursos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerFuenteRecursos]

AS

SELECT	*		
FROM	T_FUENTE_RECURSOS
ORDER BY NOM_FUENTE_RECURSOS	
GO
/****** Object:  StoredProcedure [dbo].[spTraerGrupos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerGrupos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Trae todos los grupos por institucion
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerGrupos]
(
	@idInstitucion BIGINT
)
AS

SELECT	*		
FROM	T_GRUPO
WHERE	ID_INSTITUCION = @idInstitucion
ORDER BY NOM_GRUPO
GO
/****** Object:  StoredProcedure [dbo].[spTraerGruposUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerGruposUsr
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerGruposUsr]

AS

SELECT	*		
FROM	T_GRUPO_USR
ORDER BY NOMBRE_GRUPO_USR
GO
/****** Object:  StoredProcedure [dbo].[spTraerGruposUsrxId]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/*****************************************************************************************************
Procedimiento:	spTraerGruposUsrxId
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Trae la sede relacionada por la institución
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerGruposUsrxId]
(
	@idGrupoUsr bigint
)

AS

SELECT	*		
FROM	T_GRUPO_USR
WHERE	ID_GRUPO_USR = @idGrupoUsr
GO
/****** Object:  StoredProcedure [dbo].[spTraerGruposxPk]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/*****************************************************************************************************
Procedimiento:	spTraerGruposxPk
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Trae el grupo por el identificador único
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerGruposxPk]
(
	@idGrupo bigint
)

AS

SELECT	*		
FROM	T_GRUPO
WHERE	ID_GRUPO = @idGrupo
GO
/****** Object:  StoredProcedure [dbo].[spTraerIdiomas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerIdiomas
Creado por:		jreyes
Fecha:			25/06/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerIdiomas]

AS

SELECT	*		
FROM	T_IDIOMAS
WHERE	ACTIVO = 1
ORDER BY NOM_IDIOMA
GO
/****** Object:  StoredProcedure [dbo].[spTraerImagenxIdInst]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/*****************************************************************************************************
Procedimiento:	spTraerImagenxIdInst
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Trae el escudo de la institución
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerImagenxIdInst]
(
	@idInstitucion bigint
)

AS


SELECT	ESCUDO
FROM	T_INSTITUCION
WHERE	ID_INSTITUCION = @idInstitucion
GO
/****** Object:  StoredProcedure [dbo].[spTraerInstituciones]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerInstituciones
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerInstituciones]

AS

SELECT	*		
FROM	T_INSTITUCION
WHERE	ACTIVO = 1
ORDER BY NOMBRE_EST
GO
/****** Object:  StoredProcedure [dbo].[spTraerInstitucionxIdUsuario]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/*****************************************************************************************************
Procedimiento:	spTraerInstitucionxIdUsuario
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Trae la institución por el código del usuario
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerInstitucionxIdUsuario]
(
	@codUsuario nvarchar(10)
)

AS

DECLARE @idInstitucion bigint
SET @idInstitucion = (SELECT ID_INSTITUCION FROM T_USR WHERE COD_USR = @codUsuario)

SELECT	*		
FROM	T_INSTITUCION
WHERE	ID_INSTITUCION = @idInstitucion
GO
/****** Object:  StoredProcedure [dbo].[spTraerJornadas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerJornadas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerJornadas]

AS

SELECT	*		
FROM	T_JORNADAS
ORDER BY NOM_JORNADAS	
GO
/****** Object:  StoredProcedure [dbo].[spTraerMetodologias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerMetodologias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerMetodologias]

AS

SELECT	*		
FROM	T_METODOLOGIAS
ORDER BY NOM_METODOLOGIAS	
GO
/****** Object:  StoredProcedure [dbo].[spTraerMetodologiasActivas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerMetodologiasActivas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerMetodologiasActivas]

AS

SELECT	*		
FROM	T_METODOLOGIAS
WHERE	ACTIVO = 1
ORDER BY NOM_METODOLOGIAS	
GO
/****** Object:  StoredProcedure [dbo].[spTraerMunicipios]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spTraerMunicipios
Creado por:       jreyes
Fecha:			10/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerMunicipios]

AS

SELECT	*	
FROM	T_MUNICIPIO 
		INNER JOIN T_DEPARTAMENTO ON T_MUNICIPIO.COD_DEPARTAMENTO = T_DEPARTAMENTO.COD_DEPARTAMENTO
ORDER BY NOM_MUNICIPIO	
GO
/****** Object:  StoredProcedure [dbo].[spTraerMunicipiosActivos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spTraerMunicipiosActivos
Creado por:       jreyes
Fecha:			10/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerMunicipiosActivos]
(
	@idDepartamento BIGINT
)

AS

DECLARE @codDepartamento NVARCHAR(2)
SET @codDepartamento = (SELECT DISTINCT COD_DEPARTAMENTO FROM T_DEPARTAMENTO WHERE ID_DEPARTAMENTO = @idDepartamento)

SELECT	*	
FROM	T_MUNICIPIO 
		INNER JOIN T_DEPARTAMENTO ON T_MUNICIPIO.COD_DEPARTAMENTO = T_DEPARTAMENTO.COD_DEPARTAMENTO
WHERE	T_MUNICIPIO.ACTIVO = 1
		AND T_MUNICIPIO.COD_DEPARTAMENTO = @codDepartamento		
ORDER BY NOM_MUNICIPIO	
GO
/****** Object:  StoredProcedure [dbo].[spTraerParentesco]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerParentesco
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerParentesco]

AS

SELECT	*		
FROM	T_PARENTESCO
ORDER BY NOM_PARENTESCO	
GO
/****** Object:  StoredProcedure [dbo].[spTraerPermisosGruposUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerPermisosGruposUsr
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerPermisosGruposUsr]
(
	@idGrupoUsr bigint
)

AS

DECLARE @FALSO BIT
SET @FALSO = 0

--********************************
--TRAE A TODOS LOS ELEMENTOS
--********************************
SELECT	DISTINCT
		T_MENU.ID_MENU,
		T_MENU.DESCRIPCION,
		@FALSO AS VER,
		@FALSO AS AGREGAR,
		@FALSO AS MODIFICAR,
		@FALSO AS ELIMINAR,
		@FALSO AS TODOS			
FROM	T_OPC_MENUXUSR
		INNER JOIN T_MENU ON T_MENU.ID_MENU = T_OPC_MENUXUSR.ID_MENU
WHERE	T_MENU.HABILITADO = 1
ORDER BY DESCRIPCION

--********************************
--TRAE A LOS ELEMENTOS FILTRADOS
--********************************
	SELECT	T_MENU.ID_MENU AS ID_MENU,
			T_MENU.DESCRIPCION AS DESCRIPCION,
			VER,
			AGREGAR,
			MODIFICAR,
			ELIMINAR,
			TODOS
	FROM	T_GRUPO_USR
			INNER JOIN T_OPC_MENUXUSR ON T_GRUPO_USR.ID_GRUPO_USR = T_OPC_MENUXUSR.ID_GRUPO_USR
			INNER JOIN T_MENU ON T_MENU.ID_MENU = T_OPC_MENUXUSR.ID_MENU
	WHERE	T_MENU.HABILITADO = 1
			AND T_OPC_MENUXUSR.ID_GRUPO_USR = @idGrupoUsr
	ORDER BY DESCRIPCION







/*
DECLARE @FALSO BIT
SET @FALSO = 0

IF @idGrupoUsr <> 0
BEGIN
	SELECT	T_MENU.ID_MENU AS ID_MENU,
			T_MENU.DESCRIPCION AS DESCRIPCION,
			VER,
			AGREGAR,
			MODIFICAR,
			ELIMINAR,
			TODOS
	FROM	T_GRUPO_USR
			INNER JOIN T_OPC_MENUXUSR ON T_GRUPO_USR.ID_GRUPO_USR = T_OPC_MENUXUSR.ID_GRUPO_USR
			INNER JOIN T_MENU ON T_MENU.ID_MENU = T_OPC_MENUXUSR.ID_MENU
	WHERE	T_MENU.HABILITADO = 1
			AND T_OPC_MENUXUSR.ID_GRUPO_USR = @idGrupoUsr
	ORDER BY DESCRIPCION
END
ELSE
BEGIN
	SELECT	T_MENU.ID_MENU,
			T_MENU.DESCRIPCION,
			@FALSO AS VER,
			@FALSO AS AGREGAR,
			@FALSO AS MODIFICAR,
			@FALSO AS ELIMINAR,
			@FALSO AS TODOS			
	FROM	T_OPC_MENUXUSR
			INNER JOIN T_MENU ON T_MENU.ID_MENU = T_OPC_MENUXUSR.ID_MENU
	WHERE	T_MENU.HABILITADO = 1
	ORDER BY DESCRIPCION
END
*/
GO
/****** Object:  StoredProcedure [dbo].[spTraerPoblaVicConflicto]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerPoblaVicConflicto
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerPoblaVicConflicto]

AS

SELECT	*		
FROM	T_POBLA_VIC_CONFLICTO
ORDER BY NOM_POBLA_VIC_CONFLICTO	
GO
/****** Object:  StoredProcedure [dbo].[spTraerPrestadoresActivos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerPrestadoresActivos
Creado por:		jreyes
Fecha:			25/06/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerPrestadoresActivos]

AS

SELECT	*		
FROM	T_PRESTADOR
WHERE	ACTIVO = 1
ORDER BY NOM_PRESTADOR
GO
/****** Object:  StoredProcedure [dbo].[spTraerProfesion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spTraerProfesion
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Traer informacion de la tabla T_PROFESION
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spTraerProfesion]

AS

SELECT	* 
FROM	T_PROFESION 
ORDER BY NOM_PROFESION


GO
/****** Object:  StoredProcedure [dbo].[spTraerProfesores]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spTraerProfesores
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 03/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Traer informacion de la tabla T_PROFESOR
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spTraerProfesores]
(
	@idInstitucion BIGINT 	
)

AS

SELECT	ID_PROFESOR,
		COD_PROFESOR,
		(
			PRI_APELLIDO_PROF + ' ' +
			SEG_APELLIDO_PROF + ' ' +
			PRI_NOMBRE_PROF + ' ' +
			SEG_NOMBRE_PROF
		) AS NOMBRE_PROFESOR,
		ID_TP_IDENTIFICACION,
		NUM_ID_PROF,
		PRI_NOMBRE_PROF,
		SEG_NOMBRE_PROF,
		PRI_APELLIDO_PROF,
		SEG_APELLIDO_PROF,
		DIRECCION_PROF,
		TELEFONOS_PROF,
		ID_PROFESION,
		ID_ESCALAFON,
		ID_SEDE,
		ACTIVO,
		ID_INSTITUCION,
		USUARIO_REG,
		FECHA_REG
FROM	T_PROFESOR 
WHERE	ID_INSTITUCION = @idInstitucion
ORDER BY PRI_APELLIDO_PROF

GO
/****** Object:  StoredProcedure [dbo].[spTraerPropiedadJuridicaActivos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerPropiedadJuridicaActivos
Creado por:		jreyes
Fecha:			25/06/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerPropiedadJuridicaActivos]

AS

SELECT	*		
FROM	T_PROPIEDAD_JURIDICA
WHERE	ACTIVO = 1
ORDER BY NOM_PROP_JURIDICA
GO
/****** Object:  StoredProcedure [dbo].[spTraerRegimenCostos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerRegimenCostos
Creado por:		jreyes
Fecha:			25/06/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerRegimenCostos]

AS

SELECT	*		
FROM	T_REGIMEN_COSTO
WHERE	ACTIVO = 1
ORDER BY NOM_REGIMEN_COSTO
GO
/****** Object:  StoredProcedure [dbo].[spTraerResguardos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerResguardos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerResguardos]

AS

SELECT	*		
FROM	T_RESGUARDOS
ORDER BY NOM_RESGUARDOS
GO
/****** Object:  StoredProcedure [dbo].[spTraerResguardosActivos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerResguardosActivos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerResguardosActivos]

AS

SELECT	*		
FROM	T_RESGUARDOS
WHERE	ACTIVO = 1
ORDER BY NOM_RESGUARDOS
GO
/****** Object:  StoredProcedure [dbo].[spTraerSedesxIdInstitucion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/*****************************************************************************************************
Procedimiento:	spTraerSedesxIdInstitucion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Trae las sedes relacionadas por las institucion
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerSedesxIdInstitucion]
(
	@idInstitucion bigint
)

AS

SELECT	*		
FROM	T_SEDES
WHERE	ID_INSTITUCION = @idInstitucion
GO
/****** Object:  StoredProcedure [dbo].[spTraerSedexId]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/*****************************************************************************************************
Procedimiento:	spTraerSedexId
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Trae la sede relacionada por la institución
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerSedexId]
(
	@idSede bigint
)

AS

SELECT	*		
FROM	T_SEDES
WHERE	ID_SEDE = @idSede
GO
/****** Object:  StoredProcedure [dbo].[spTraerSisben]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[spTraerSisben]

AS

SELECT	*		
FROM	T_SISBEN
ORDER BY NOM_SISBEN	
GO
/****** Object:  StoredProcedure [dbo].[spTraerSituAcademica]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerSituAcademica
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerSituAcademica]

AS

SELECT	*		
FROM	T_SITU_ACADEMICA
ORDER BY NOM_SITU_ACADEMICA	
GO
/****** Object:  StoredProcedure [dbo].[spTraerTarifaAnual]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerTarifaAnual
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spTraerTarifaAnual]

AS

SELECT	*		
FROM	T_TARIFA_ANUAL
WHERE	ACTIVO = 1
ORDER BY NOM_TARIFA_ANUAL
GO
/****** Object:  StoredProcedure [dbo].[spTraerTipoDiscapacidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerTipoDiscapacidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerTipoDiscapacidad]

AS

SELECT	*		
FROM	T_TP_DISCAPACIDAD
ORDER BY NOM_TP_DISCAPACIDAD	
GO
/****** Object:  StoredProcedure [dbo].[spTraerTipoDiscapacidadesActivas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerTipoDiscapacidadesActivas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerTipoDiscapacidadesActivas]

AS

SELECT	*		
FROM	T_TP_DISCAPACIDAD
WHERE	ACTIVO = 1
ORDER BY NOM_TP_DISCAPACIDAD	
GO
/****** Object:  StoredProcedure [dbo].[spTraerTipoRespuestas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spTraerTipoRespuestas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerTipoRespuestas]

AS

SELECT	*		
FROM	T_TP_RESPUESTA
ORDER BY NOM_TP_RESPUESTA	
GO
/****** Object:  StoredProcedure [dbo].[spTraerTodasTablaClassCreator]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spTraerTodasTablaClassCreator]

AS

SELECT
	SYS.OBJECTS.OBJECT_ID AS ID_TABLA,
	SYS.OBJECTS.NAME AS NOM_TABLA
FROM	SYS.OBJECTS 
WHERE	SYS.OBJECTS.TYPE = 'U' 

ORDER BY NOM_TABLA


GO
/****** Object:  StoredProcedure [dbo].[spTraerTpCaracter]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerTpCaracter
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerTpCaracter]

AS

SELECT	*		
FROM	T_TP_CARACTER
ORDER BY NOM_TP_CARACTER	
GO
/****** Object:  StoredProcedure [dbo].[spTraerTpCondicion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerTpCondicion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerTpCondicion]

AS

SELECT	*		
FROM	T_TP_CONDICION
ORDER BY NOM_TP_CONDICION	
GO
/****** Object:  StoredProcedure [dbo].[spTraerTpIdentificacion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	spTraerTpIdentificacion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/
CREATE PROCEDURE [dbo].[spTraerTpIdentificacion]

AS

SELECT	*		
FROM	T_TP_IDENTIFICACION
ORDER BY NOM_TP_IDENTIFICACION	
GO
/****** Object:  StoredProcedure [dbo].[spTraerTpNovedadesActivas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerTpNovedadesActivas
Creado por:		jreyes
Fecha:			25/06/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerTpNovedadesActivas]

AS

SELECT	*		
FROM	T_TP_NOVEDAD
WHERE	ACTIVO = 1
ORDER BY NOM_TP_NOVEDAD
GO
/****** Object:  StoredProcedure [dbo].[spTraerTpSectorEduActivos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerTpSectorEduActivos
Creado por:		jreyes
Fecha:			25/06/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerTpSectorEduActivos]

AS

SELECT	*		
FROM	T_TP_SECTOR_EDU
WHERE	ACTIVO = 1
ORDER BY NOM_SECTOR
GO
/****** Object:  StoredProcedure [dbo].[spTraerUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerUsr
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Trae todos los usuarios por institucion
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerUsr]
(
	@idInstitucion BIGINT
)
AS

SELECT	*		
FROM	T_USR
WHERE	ID_INSTITUCION = @idInstitucion
ORDER BY NOM_USR
GO
/****** Object:  StoredProcedure [dbo].[spTraerUsrxPk]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



/*****************************************************************************************************
Procedimiento:	spTraerUsrxPk
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Trae el usuario por el identificador único
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerUsrxPk]
(
	@idUsr bigint
)

AS

SELECT	*		
FROM	T_USR
WHERE	ID_USR = @idUsr
GO
/****** Object:  StoredProcedure [dbo].[spTraerValLetras]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spTraerValLetras
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Traer informacion de la tabla T_GRADO
--- ***************************************************************************************************************
create PROCEDURE [dbo].[spTraerValLetras]
(
	@idInstitucion BIGINT 	
)
AS
SELECT	* 
FROM	T_VALORACION_LETRAS
WHERE	ID_INSTITUCION = @idInstitucion


GO
/****** Object:  StoredProcedure [dbo].[spTraerZonas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerZonas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerZonas]

AS

SELECT	*		
FROM	T_ZONAS
ORDER BY NOM_ZONAS	
GO
/****** Object:  StoredProcedure [dbo].[spTraerZonasActivas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerZonasActivas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spTraerZonasActivas]

AS

SELECT	*		
FROM	T_ZONAS
WHERE	ACTIVO = 1
ORDER BY NOM_ZONAS	
GO
/****** Object:  StoredProcedure [dbo].[spValidarAsignatura]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarAsignatura
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarAsignatura]
(
	@codAsignatura bigint
)

AS

SELECT	*		
FROM	T_ASIGNATURA
		INNER JOIN T_INSTITUCION ON T_ASIGNATURA.ID_INSTITUCION = T_INSTITUCION.ID_INSTITUCION
WHERE	T_ASIGNATURA.COD_ASIGNATURA = @codAsignatura

GO
/****** Object:  StoredProcedure [dbo].[spValidarCapExcepcional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarCapExcepcional
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarCapExcepcional]
(
	@codCapExcepcional bigint
)

AS

SELECT	*		
FROM	T_CAP_EXCEPCIONALES
		INNER JOIN T_INSTITUCION ON T_CAP_EXCEPCIONALES.COD_CAP_EXCEPCIONALES = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_CAP_EXCEPCIONALES.COD_CAP_EXCEPCIONALES = @codCapExcepcional

GO
/****** Object:  StoredProcedure [dbo].[spValidarDepartamentos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarDepartamentos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spValidarDepartamentos]
(
	@codDepartamento nvarchar(2)
)

AS

SELECT	*		
FROM	T_DEPARTAMENTO
		INNER JOIN T_INSTITUCION ON T_DEPARTAMENTO.COD_DEPARTAMENTO = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_DEPARTAMENTO.COD_DEPARTAMENTO = @codDepartamento

GO
/****** Object:  StoredProcedure [dbo].[spValidarEscalafon]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarEscalafon
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarEscalafon]
(
	@idEscalafon bigint
)

AS

SELECT	*		
FROM	T_ESCALAFON
		INNER JOIN T_INSTITUCION ON T_ESCALAFON.ID_ESCALAFON = T_INSTITUCION.ID_INSTITUCION
WHERE	T_ESCALAFON.ID_ESCALAFON = @idEscalafon

GO
/****** Object:  StoredProcedure [dbo].[spValidarEscNacional]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarEscNacional
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarEscNacional]
(
	@idEscNacional bigint
)

AS

SELECT	*		
FROM	T_ESCALA_NACIONAL
		INNER JOIN T_INSTITUCION ON T_ESCALA_NACIONAL.ID_ESCALA_NACIONAL = T_INSTITUCION.ID_INSTITUCION
WHERE	T_ESCALA_NACIONAL.ID_ESCALA_NACIONAL = @idEscNacional

GO
/****** Object:  StoredProcedure [dbo].[spValidarEspecialidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarEspecialidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spValidarEspecialidad]
(
	@codEspecialidad bigint
)

AS

SELECT	*		
FROM	T_ESPECIALIDAD
		INNER JOIN T_INSTITUCION ON T_ESPECIALIDAD.COD_ESPECIALIDAD = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_ESPECIALIDAD.COD_ESPECIALIDAD = @codEspecialidad

GO
/****** Object:  StoredProcedure [dbo].[spValidarEstratos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarEstratos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spValidarEstratos]
(
	@codEstrato bigint
)

AS

SELECT	*		
FROM	T_ESTRATO
		INNER JOIN T_INSTITUCION ON T_ESTRATO.COD_ESTRATO = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_ESTRATO.COD_ESTRATO = @codEstrato

GO
/****** Object:  StoredProcedure [dbo].[spValidarEstudiantes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarEstudiantes
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spValidarEstudiantes]
(
	@idEstudiante bigint
)

AS

SELECT	*		
FROM	T_ESTUDIANTES
		INNER JOIN T_INSTITUCION ON T_ESTUDIANTES.ID_ESTUDIANTE = T_INSTITUCION.ID_INSTITUCION
WHERE	T_ESTUDIANTES.ID_ESTUDIANTE = @idEstudiante

GO
/****** Object:  StoredProcedure [dbo].[spValidarEtnias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarEtnias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarEtnias]
(
	@codEtnia nvarchar(3)
)

AS

SELECT	*		
FROM	T_ETNIAS
		INNER JOIN T_INSTITUCION ON T_ETNIAS.COD_ETNIAS = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_ETNIAS.COD_ETNIAS = @codEtnia

GO
/****** Object:  StoredProcedure [dbo].[spValidarFuenteRecursos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarFuenteRecursos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarFuenteRecursos]
(
	@codFuenteRecursos bigint
)

AS

SELECT	*		
FROM	T_FUENTE_RECURSOS
		INNER JOIN T_INSTITUCION ON T_FUENTE_RECURSOS.COD_FUENTE_RECURSOS = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_FUENTE_RECURSOS.COD_FUENTE_RECURSOS = @codFuenteRecursos

GO
/****** Object:  StoredProcedure [dbo].[spValidarGrados]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarGrados
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarGrados]
(
	@idGrado bigint
)

AS

SELECT	*		
FROM	T_GRADO
		INNER JOIN T_INSTITUCION ON T_GRADO.ID_GRADO = T_INSTITUCION.ID_INSTITUCION
WHERE	T_GRADO.ID_GRADO = @idGrado

GO
/****** Object:  StoredProcedure [dbo].[spValidarGrupos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarGrupos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarGrupos]
(
	@idGrupo bigint
)

AS

SELECT	*		
FROM	T_GRUPO
		INNER JOIN T_INSTITUCION ON T_GRUPO.ID_GRUPO = T_INSTITUCION.ID_INSTITUCION
WHERE	T_GRUPO.ID_GRUPO = @idGrupo

GO
/****** Object:  StoredProcedure [dbo].[spValidarGruposUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarGruposUsr
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarGruposUsr]
(
	@idGrupoUsr bigint
)

AS

SELECT	*		
FROM	T_GRUPO_USR
		INNER JOIN T_INSTITUCION ON T_GRUPO_USR.ID_GRUPO_USR = T_INSTITUCION.ID_INSTITUCION
WHERE	T_GRUPO_USR.ID_GRUPO_USR = @idGrupoUsr

GO
/****** Object:  StoredProcedure [dbo].[spValidarJornadas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarJornadas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarJornadas]
(
	@codJornada nvarchar(2)
)

AS

SELECT	*		
FROM	T_JORNADAS
		INNER JOIN T_INSTITUCION ON T_JORNADAS.COD_JORNADAS = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_JORNADAS.COD_JORNADAS = @codJornada

GO
/****** Object:  StoredProcedure [dbo].[spValidarMetodologias]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarMetodologias
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarMetodologias]
(
	@codMetodologia bigint
)

AS

SELECT	*		
FROM	T_METODOLOGIAS
		INNER JOIN T_INSTITUCION ON T_METODOLOGIAS.COD_METODOLOGIAS = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_METODOLOGIAS.COD_METODOLOGIAS = @codMetodologia

GO
/****** Object:  StoredProcedure [dbo].[spValidarMunicipios]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spValidarMunicipios]
(
	@codMunicipio nvarchar(3),
	@codDepartamento nvarchar(2)
)

AS

SELECT	*		
FROM	T_MUNICIPIO
		INNER JOIN T_INSTITUCION ON T_MUNICIPIO.COD_UNIFICADO = T_INSTITUCION.COD_MUNICIPIO
WHERE	T_MUNICIPIO.COD_MUNICIPIO = @codMunicipio
		AND T_MUNICIPIO.COD_DEPARTAMENTO = @codDepartamento

GO
/****** Object:  StoredProcedure [dbo].[spValidarPoblaVicConflicto]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarPoblaVicConflicto
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


CREATE PROCEDURE [dbo].[spValidarPoblaVicConflicto]
(
	@codPoblaVicConflicto bigint
)

AS

SELECT	*		
FROM	T_POBLA_VIC_CONFLICTO
		INNER JOIN T_INSTITUCION ON T_POBLA_VIC_CONFLICTO.COD_POBLA_VIC_CONFLICTO = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_POBLA_VIC_CONFLICTO.COD_POBLA_VIC_CONFLICTO = @codPoblaVicConflicto

GO
/****** Object:  StoredProcedure [dbo].[spValidarProfesion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarProfesion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spValidarProfesion]
(
	@idProfesion bigint
)

AS

SELECT	*		
FROM	T_PROFESION
		INNER JOIN T_INSTITUCION ON T_PROFESION.ID_PROFESION = T_INSTITUCION.ID_INSTITUCION
WHERE	T_PROFESION.ID_PROFESION = @idProfesion

GO
/****** Object:  StoredProcedure [dbo].[spValidarProfesores]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarProfesores
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarProfesores]
(
	@idProfesor bigint
)

AS

SELECT	*		
FROM	T_PROFESOR
		INNER JOIN T_INSTITUCION ON T_PROFESOR.ID_PROFESOR = T_INSTITUCION.ID_INSTITUCION
WHERE	T_PROFESOR.ID_PROFESOR = @idProfesor

GO
/****** Object:  StoredProcedure [dbo].[spValidarResguardos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarResguardos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarResguardos]
(
	@codResguardo nvarchar(3)
)

AS

SELECT	*		
FROM	T_RESGUARDOS
		INNER JOIN T_INSTITUCION ON T_RESGUARDOS.COD_RESGUARDOS = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_RESGUARDOS.COD_RESGUARDOS = @codResguardo

GO
/****** Object:  StoredProcedure [dbo].[spValidarSedes]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarSedes
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spValidarSedes]
(
	@codSede bigint
)

AS

SELECT	*		
FROM	T_SEDES
		INNER JOIN T_INSTITUCION ON T_SEDES.ID_INSTITUCION = T_INSTITUCION.ID_INSTITUCION
WHERE	T_SEDES.COD_SEDE = @codSede

GO
/****** Object:  StoredProcedure [dbo].[spValidarSisben]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spValidarSisben]
(
	@codSisben bigint
)

AS

SELECT	*		
FROM	T_SISBEN
		INNER JOIN T_INSTITUCION ON T_SISBEN.COD_SISBEN = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_SISBEN.COD_SISBEN = @codSisben

GO
/****** Object:  StoredProcedure [dbo].[spValidarSituAcademica]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarSituAcademica
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarSituAcademica]
(
	@codSituAcademica bigint
)

AS

SELECT	*		
FROM	T_SITU_ACADEMICA
		INNER JOIN T_INSTITUCION ON T_SITU_ACADEMICA.COD_SITU_ACADEMICA = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_SITU_ACADEMICA.COD_SITU_ACADEMICA = @codSituAcademica

GO
/****** Object:  StoredProcedure [dbo].[spValidarTipoDiscapacidad]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarTipoDiscapacidad
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarTipoDiscapacidad]
(
	@codTpDiscapacidad nvarchar(1)
)

AS

SELECT	*		
FROM	T_TP_DISCAPACIDAD
		INNER JOIN T_INSTITUCION ON T_TP_DISCAPACIDAD.COD_TP_DISCAPACIDAD = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_TP_DISCAPACIDAD.COD_TP_DISCAPACIDAD = @codTpDiscapacidad

GO
/****** Object:  StoredProcedure [dbo].[spValidarTipoRespuestas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarTipoRespuestas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[spValidarTipoRespuestas]
(
	@codTpRespuesta nvarchar(1)
)

AS

SELECT	*		
FROM	T_TP_RESPUESTA
		INNER JOIN T_INSTITUCION ON T_TP_RESPUESTA.COD_TP_RESPUESTA = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_TP_RESPUESTA.COD_TP_RESPUESTA = @codTpRespuesta

GO
/****** Object:  StoredProcedure [dbo].[spValidarTpCaracter]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarTpCaracter
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarTpCaracter]
(
	@codTpCaracter bigint
)

AS

SELECT	*		
FROM	T_TP_CARACTER
		INNER JOIN T_INSTITUCION ON T_TP_CARACTER.COD_TP_CARACTER = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_TP_CARACTER.COD_TP_CARACTER = @codTpCaracter

GO
/****** Object:  StoredProcedure [dbo].[spValidarTpCondicion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarTpCondicion
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarTpCondicion]
(
	@codTpCondicion bigint
)

AS

SELECT	*		
FROM	T_TP_CONDICION
		INNER JOIN T_INSTITUCION ON T_TP_CONDICION.COD_TP_CONDICION = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_TP_CONDICION.COD_TP_CONDICION = @codTpCondicion

GO
/****** Object:  StoredProcedure [dbo].[spValidarTpIdentificacion]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spValidarTpIdentificacion]
(
	@codTpIdentificacion nvarchar(3)
)

AS

SELECT	*		
FROM	T_TP_IDENTIFICACION
		INNER JOIN T_INSTITUCION ON T_TP_IDENTIFICACION.COD_TP_IDENTIFICACION = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_TP_IDENTIFICACION.COD_TP_IDENTIFICACION = @codTpIdentificacion

GO
/****** Object:  StoredProcedure [dbo].[spValidarUsr]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarUsr
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Valida los usuarios
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarUsr]
(
	@idUsr bigint
)

AS

SELECT	*		
FROM	T_USR
		INNER JOIN T_INSTITUCION ON T_USR.ID_USR = T_INSTITUCION.ID_INSTITUCION
WHERE	T_USR.ID_USR = @idUsr

GO
/****** Object:  StoredProcedure [dbo].[spValidarValLetras]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarValLetras
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarValLetras]
(
	@idValLetras bigint
)

AS

SELECT	*		
FROM	T_VALORACION_LETRAS
		INNER JOIN T_INSTITUCION ON T_VALORACION_LETRAS.ID_INSTITUCION = T_INSTITUCION.ID_INSTITUCION
WHERE	T_VALORACION_LETRAS.ID_VAL_LETRAS = @idValLetras

GO
/****** Object:  StoredProcedure [dbo].[spValidarZonas]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spValidarZonas
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spValidarZonas]
(
	@codZonas bigint
)

AS

SELECT	*		
FROM	T_ZONAS
		INNER JOIN T_INSTITUCION ON T_ZONAS.COD_ZONAS = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_ZONAS.COD_ZONAS = @codZonas

GO
/****** Object:  StoredProcedure [dbo].[spValLetrasTraerxPK]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--- ***************************************************************************************************************
--- Procedimiento Almacenado: spValLetrasTraerxPK
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para TraerxPK informacion de la tabla T_VALORACION_LETRAS
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[spValLetrasTraerxPK]
(
	@ID_VAL_LETRAS bigint-- Parametro de 
)
AS
SELECT * FROM T_VALORACION_LETRAS
WHERE
	ID_VAL_LETRAS = @ID_VAL_LETRAS

GO
/****** Object:  StoredProcedure [dbo].[spZonasxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:	spZonasxID
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[spZonasxID]
(
	@idZonas BIGINT
)
AS

SELECT	*	
FROM	T_ZONAS
WHERE	ID_ZONAS = @idZonas
ORDER BY NOM_ZONAS
GO
/****** Object:  StoredProcedure [dbo].[uspActualizarGenero]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    uspActualizarGenero
Creado por:       jreyes
Fecha:            27/07/2016
Descripcion:      Actualiza los Genero
******************************************************************************************************/

create procedure [dbo].[uspActualizarGenero]
(
	@GeneroId  bigint,
	@GeneroCodigo  nvarchar(2),
	@GeneroNombre  nvarchar(20),
	@GeneroActivo  bit,
	@GeneroUsuarioRegistra  bigint,
	@GeneroFechaRegistro  datetime,
	@GeneroUsuarioModifica  bigint,
	@GeneroFechaModifica  datetime
)

AS

UPDATE Genero SET
	GeneroCodigo = @GeneroCodigo,
	GeneroNombre = @GeneroNombre,
	GeneroActivo = @GeneroActivo,
	GeneroUsuarioRegistra = @GeneroUsuarioRegistra,
	GeneroFechaRegistro = @GeneroFechaRegistro,
	GeneroUsuarioModifica = @GeneroUsuarioModifica,
	GeneroFechaModifica = @GeneroFechaModifica
WHERE	GeneroId = @GeneroId
GO
/****** Object:  StoredProcedure [dbo].[uspActualizarGrados]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--- ***************************************************************************************************************
--- Procedimiento Almacenado: spActualizarGrados
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Actualizar informacion de la tabla T_GRADO
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[uspActualizarGrados]
(
	@GradoId bigint,
	@GradoCodigo nvarchar(5),
	@GradoNombre nvarchar(50),
	@SedeId bigint,
	@InstitucionId bigint,
	@CursoActivo int,
	@GradoUsuarioRegistra nvarchar(20),
	@GradoFechaRegistro datetime,
	@GradoUsuarioModifica nvarchar(20),
	@GradoFechaModifica datetime
)

AS

IF @SedeId = 0
BEGIN
	SET @SedeId =  NULL
END

UPDATE	Grados SET	
		GradoCodigo = @GradoCodigo,
		GradoNombre = @GradoNombre,
		SedeId = @SedeId,
		InstitucionId = @InstitucionId,
		CursoActivo = @CursoActivo,
		GradoUsuarioRegistra = @GradoUsuarioRegistra,
		GradoFechaRegistro = @GradoFechaRegistro,
		GradoUsuarioModifica = @GradoUsuarioModifica,
		GradoFechaModifica = @GradoFechaModifica
WHERE	GradoId = @GradoId


GO
/****** Object:  StoredProcedure [dbo].[uspBuscarGenero]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    uspBuscarGenero
Creado por:       jreyes
Fecha:            27/07/2016
Descripcion:      Busca todos los registros de Genero
******************************************************************************************************/

create procedure [dbo].[uspBuscarGenero]
(
	@GeneroNombre  nvarchar(20)
)

AS

SELECT 
	GeneroId,
	GeneroCodigo,
	GeneroNombre,
	GeneroActivo,
	GeneroUsuarioRegistra,
	GeneroFechaRegistro,
	GeneroUsuarioModifica,
	GeneroFechaModifica
FROM	Genero
WHERE	GeneroNombre LIKE '%' + @GeneroNombre + '%'
ORDER BY	GeneroNombre
GO
/****** Object:  StoredProcedure [dbo].[uspBuscarGrados]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spBuscarGrados
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:	Busca los grados
******************************************************************************************************/

CREATE PROCEDURE [dbo].[uspBuscarGrados]
(
	@GradoNombre NVARCHAR(50),
	@InstitucionId BIGINT 	
)
AS

SELECT	GradoId,
		GradoCodigo,
		GradoNombre,
		SedeId,
		InstitucionId,
		CursoActivo,
		GradoUsuarioRegistra,
		GradoFechaRegistro,
		GradoUsuarioModifica,
		GradoFechaModifica	
FROM	Grados
WHERE	GradoNombre LIKE '%' + @GradoNombre + '%'
		AND InstitucionId = @InstitucionId
ORDER BY GradoNombre

GO
/****** Object:  StoredProcedure [dbo].[uspEliminarGrados]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--- ***************************************************************************************************************
--- Procedimiento Almacenado: spEliminarGrados
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Eliminar informacion de la tabla T_GRADO
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[uspEliminarGrados]
(
	@GradoId bigint,
	@InstitucionId bigint
)

AS

UPDATE Grados SET CursoActivo = 3
WHERE	GradoId = @GradoId 
		AND InstitucionId = @InstitucionId

/*
DELETE FROM Grados
WHERE
	ID_GRADO = @ID_GRADO
*/

GO
/****** Object:  StoredProcedure [dbo].[uspGenerosxID]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[uspGenerosxID]
(
	@idGenero BIGINT
)
AS

SELECT	*	
FROM	T_GENERO
WHERE	ID_GENERO = @idGenero
ORDER BY NOM_GENERO
GO
/****** Object:  StoredProcedure [dbo].[uspInsertarGenero]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    uspInsertarGenero
Creado por:       jreyes
Fecha:            27/07/2016
Descripcion:      Inserta los Genero
******************************************************************************************************/

create procedure [dbo].[uspInsertarGenero]
(
	@GeneroId  bigint,
	@GeneroCodigo  nvarchar(2),
	@GeneroNombre  nvarchar(20),
	@GeneroActivo  bit,
	@GeneroUsuarioRegistra  bigint,
	@GeneroFechaRegistro  datetime,
	@GeneroUsuarioModifica  bigint,
	@GeneroFechaModifica  datetime
)

AS

INSERT INTO Genero
(
	GeneroCodigo,
	GeneroNombre,
	GeneroActivo,
	GeneroUsuarioRegistra,
	GeneroFechaRegistro,
	GeneroUsuarioModifica,
	GeneroFechaModifica
)
VALUES
(
	@GeneroCodigo,
	@GeneroNombre,
	@GeneroActivo,
	@GeneroUsuarioRegistra,
	@GeneroFechaRegistro,
	@GeneroUsuarioModifica,
	@GeneroFechaModifica
)
GO
/****** Object:  StoredProcedure [dbo].[uspInsertarGeneros]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    spInsertarGeneros
Creado por:       jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/


create PROCEDURE [dbo].[uspInsertarGeneros]
(
	@codGenero	nvarchar(1),
	@nomGenero	nvarchar(10),
	@activo				bit,
	@usuarioReg			nvarchar(20),
	@fechaReg			datetime
)

AS

INSERT INTO T_GENERO
	(
		COD_GENERO,
		NOM_GENERO,
		ACTIVO,
		USUARIO_REG,
		FECHA_REG
	)
VALUES
	(
		@codGenero,
		@nomGenero,
		@activo,
		@usuarioReg,
		@fechaReg
	) 
	
GO
/****** Object:  StoredProcedure [dbo].[uspInsertarGrados]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--- ***************************************************************************************************************
--- Procedimiento Almacenado: spInsertarGrados
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Guardar informacion de la tabla T_GRADO
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[uspInsertarGrados]
(
	@GradoId bigint,
	@GradoCodigo nvarchar(5),
	@GradoNombre nvarchar(50),
	@SedeId bigint,
	@InstitucionId bigint,
	@CursoActivo int,
	@GradoUsuarioRegistra nvarchar(20),
	@GradoFechaRegistro datetime,
	@GradoUsuarioModifica nvarchar(20),
	@GradoFechaModifica datetime
)
AS

IF @SedeId = 0
BEGIN
	SET @SedeId =  NULL
END

INSERT INTO Grados
(
	GradoCodigo,
	GradoNombre,
	SedeId,
	InstitucionId,
	CursoActivo,
	GradoUsuarioRegistra,
	GradoFechaRegistro,
	GradoUsuarioModifica,
	GradoFechaModifica
)
VALUES
(
	@GradoCodigo,
	@GradoNombre,
	@SedeId,
	@InstitucionId,
	@CursoActivo,
	@GradoUsuarioRegistra,
	@GradoFechaRegistro,
	@GradoUsuarioModifica,
	@GradoFechaModifica
)
SET @GradoId = SCOPE_IDENTITY()


GO
/****** Object:  StoredProcedure [dbo].[uspObtenerHash]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	uspObtenerHash
Creado por:		jreyes
Fecha:			21/10/2015
Descripcion:	Obtiene password del usuario
******************************************************************************************************/

CREATE PROCEDURE [dbo].[uspObtenerHash]

(
	@UsuarioLogin AS NVARCHAR(10)	
)

AS

SELECT	UsuarioPassword 
FROM	Usuario
WHERE	UsuarioLogin = @UsuarioLogin 
GO
/****** Object:  StoredProcedure [dbo].[uspObtenerUsuarioLogin]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*****************************************************************************************************
Procedimiento:	uspObtenerUsuarioLogin
Creado por:		jreyes
Fecha:			21/10/2015
Descripcion:	Obtiene el usuario y el login
******************************************************************************************************/

CREATE PROCEDURE [dbo].[uspObtenerUsuarioLogin]

(
	@UsuarioLogin AS NVARCHAR(10)	
)

AS

--**************************************
--TABLA 1
--**************************************
SELECT	* 
FROM	Usuario
WHERE	UsuarioLogin = @UsuarioLogin 

--**************************************
--TABLA 2 Permisos opciones de menu
--**************************************
SELECT	P.PerfilCodigo, 
		UP.MenuId,
		P.PerfilNombre, 
		UP.UsuarioPermisoNombrePrograma, 
		UP.UsuarioPermisoAcceso, 
		UsuarioPermisoInsertar,
		UsuarioPermisosActualizar,
		UP.UsuarioPermisoEliminar, 
		UP.UsuarioPermisoImprimir, 
		UP.UsuarioPermisoBuscar, 
		UP.UsuarioPermisoExportar		
FROM	UsuarioPermiso UP
		INNER JOIN Perfil P ON UP.PerfilId = P.PerfilId 
		INNER JOIN Menu M ON UP.MenuId = M.MenuId 
		INNER JOIN Usuario U ON P.PerfilId = U.PerfilId	
WHERE	UsuarioLogin = @UsuarioLogin 
GO
/****** Object:  StoredProcedure [dbo].[uspSeleccionarGenero]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    uspSeleccionarGenero
Creado por:       jreyes
Fecha:			27/07/2016
Descripcion:
******************************************************************************************************/

create procedure [dbo].[uspSeleccionarGenero]
(
	@generoid  bigint,
	@generocodigo  nvarchar(2),
	@generonombre  nvarchar(20),
	@generoactivo  bit,
	@generousuarioregistra  bigint,
	@generofecharegistro  datetime,
	@generousuariomodifica  bigint,
	@generofechamodifica  datetime
)

AS

SELECT *
FROM Genero
GO
/****** Object:  StoredProcedure [dbo].[uspTraerGenero]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    uspTraerGenero
Creado por:       jreyes
Fecha:            27/07/2016
Descripcion:      Trae todos los registros de Genero
******************************************************************************************************/

create procedure [dbo].[uspTraerGenero]

AS

SELECT 
	GeneroId,
	GeneroCodigo,
	GeneroNombre,
	GeneroActivo,
	GeneroUsuarioRegistra,
	GeneroFechaRegistro,
	GeneroUsuarioModifica,
	GeneroFechaModifica
FROM	Genero
ORDER BY	GeneroNombre
GO
/****** Object:  StoredProcedure [dbo].[uspTraerGeneros]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerGeneros
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

create PROCEDURE [dbo].[uspTraerGeneros]

AS

SELECT	*		
FROM	T_GENERO
WHERE ACTIVO = 1
ORDER BY NOM_GENERO
GO
/****** Object:  StoredProcedure [dbo].[uspTraerGenerosEstActivos]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


/*****************************************************************************************************
Procedimiento:	spTraerGenerosEstActivos
Creado por:		jreyes
Fecha:			12/03/2012
Descripcion:
******************************************************************************************************/

CREATE PROCEDURE [dbo].[uspTraerGenerosEstActivos]

AS

SELECT	*		
FROM	GeneroEstudiante
WHERE	GeneroEstudianteActivo = 1
ORDER BY GeneroEstudianteNombre
GO
/****** Object:  StoredProcedure [dbo].[usptraerGeneroxId]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

/*****************************************************************************************************
Procedimiento:    uspTraerGeneroxId
Creado por:       jreyes
Fecha:            27/07/2016
Descripcion:      Busca todos los registros de Generopor Id
******************************************************************************************************/

create procedure [dbo].[usptraerGeneroxId]
(
	@GeneroId  bigint
)

AS

SELECT 
	GeneroId,
	GeneroCodigo,
	GeneroNombre,
	GeneroActivo,
	GeneroUsuarioRegistra,
	GeneroFechaRegistro,
	GeneroUsuarioModifica,
	GeneroFechaModifica
FROM	Genero
WHERE	GeneroId = @GeneroId
ORDER BY	GeneroId
GO
/****** Object:  StoredProcedure [dbo].[uspTraerGrados]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


--- ***************************************************************************************************************
--- Procedimiento Almacenado: spTraerGrados
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para Traer informacion de la tabla T_GRADO
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[uspTraerGrados]
(
	@InstitucionId BIGINT 	
)
AS
SELECT	GradoId,
		GradoCodigo,
		GradoNombre,
		SedeId,
		InstitucionId,
		CursoActivo,
		GradoUsuarioRegistra,
		GradoFechaRegistro,
		GradoUsuarioModifica,
		GradoFechaModifica 
FROM	Grados
WHERE	InstitucionId = @InstitucionId



GO
/****** Object:  StoredProcedure [dbo].[uspTraerGradosxId]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




--- ***************************************************************************************************************
--- Procedimiento Almacenado: spTraerGradosxId
--- Autor: Juan Carlos Reyes G.(ingreyesguerrero@gmail.com)
--- Fecha: 02/02/2013
--- Empresa: ClickyEnter - 2013
--- Descripcion: Procedimiento Almacenado para TraerxPK informacion de la tabla T_GRADO
--- ***************************************************************************************************************
CREATE PROCEDURE [dbo].[uspTraerGradosxId]
(
	@GradoId bigint,
	@InstitucionId bigint
)
AS
SELECT	GradoId,
		GradoCodigo,
		GradoNombre,
		SedeId,
		InstitucionId,
		CursoActivo,
		GradoUsuarioRegistra,
		GradoFechaRegistro,
		GradoUsuarioModifica,
		GradoFechaModifica 
FROM	Grados
WHERE	GradoId = @GradoId




GO
/****** Object:  StoredProcedure [dbo].[uspValidarGeneros]    Script Date: 19/09/2018 10:00:25 p.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[uspValidarGeneros]
(
	@codGenero nvarchar(1)
)

AS

SELECT	*		
FROM	T_GENERO
		INNER JOIN T_INSTITUCION ON T_GENERO.COD_GENERO = T_INSTITUCION.COD_DEPARATAMENTO
WHERE	T_GENERO.COD_GENERO = @codGenero

GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Llave principal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Perfil', @level2type=N'COLUMN',@level2name=N'PerfilId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Código' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Perfil', @level2type=N'COLUMN',@level2name=N'PerfilCodigo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Perfil', @level2type=N'COLUMN',@level2name=N'PerfilNombre'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado activo o inactivo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Perfil', @level2type=N'COLUMN',@level2name=N'PerfilActivo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario que crea el registro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Perfil', @level2type=N'COLUMN',@level2name=N'PerfilUsuarioCrea'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario que modifica el registro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Perfil', @level2type=N'COLUMN',@level2name=N'PerfilUsuarioModifica'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de creación del registro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Perfil', @level2type=N'COLUMN',@level2name=N'PerfilFechaCreacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de Modificación del registro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Perfil', @level2type=N'COLUMN',@level2name=N'PerfilFechaModificacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Llave principal' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'llave foranea a la tabla menu' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'MenuId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Perfil' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'PerfilId'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Módulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoModulo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre programa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoNombrePrograma'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Nombre módulo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoNombreModulo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Acceso (si - no)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoAcceso'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Grabar (si - no)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoInsertar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Eliminar (si - no)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoEliminar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Buscar (si - no)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoBuscar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Imprimir (si - no)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoImprimir'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Exportar (si - no)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoExportar'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Estado activo o inactivo' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoActivo'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario que crea el registro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoCrea'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Usuario que modifica el registro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoModifica'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de creación del registro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoFechaCreacion'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Fecha de Modificación del registro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UsuarioPermiso', @level2type=N'COLUMN',@level2name=N'UsuarioPermisoFechaModificacion'
GO
USE [master]
GO
ALTER DATABASE [QAcademico] SET  READ_WRITE 
GO
