USE [master]
GO
/****** Object:  Database [dwFuture]    Script Date: 17/06/2019 16:31:19 ******/
CREATE DATABASE [dwFuture]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dwFuture', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\dwFuture.mdf' , SIZE = 7168KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'dwFuture_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\dwFuture_log.ldf' , SIZE = 321088KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [dwFuture] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dwFuture].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dwFuture] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dwFuture] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dwFuture] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dwFuture] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dwFuture] SET ARITHABORT OFF 
GO
ALTER DATABASE [dwFuture] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dwFuture] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [dwFuture] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dwFuture] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dwFuture] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dwFuture] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dwFuture] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dwFuture] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dwFuture] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dwFuture] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dwFuture] SET  DISABLE_BROKER 
GO
ALTER DATABASE [dwFuture] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dwFuture] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dwFuture] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dwFuture] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dwFuture] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dwFuture] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dwFuture] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dwFuture] SET RECOVERY FULL 
GO
ALTER DATABASE [dwFuture] SET  MULTI_USER 
GO
ALTER DATABASE [dwFuture] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dwFuture] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dwFuture] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dwFuture] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'dwFuture', N'ON'
GO
USE [dwFuture]
GO
/****** Object:  StoredProcedure [dbo].[registrar_exportacion_periodicamente]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[registrar_exportacion_periodicamente]
@id_usuario int,
@mes_exportado varchar(30),
@año_exportado varchar(30),
@hora varchar(20)
as
begin
insert Registro_Exportaciones(id_usuario,Mes,Año,Hora,fecha) values (@id_usuario,@mes_exportado,@año_exportado,@hora, GETDATE());
end
GO
/****** Object:  StoredProcedure [dbo].[sp_obtener_registroExp_ULTI]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_obtener_registroExp_ULTI]

as
begin
select top 1 Mes,Año  from Registro_Exportaciones order by id desc 
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Seleccionar_Hecho]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_Seleccionar_Hecho]
@MES int,
@AÑO int
as
begin
	select venta.VE_EmpresaId,venta.VE_MedicoId,detalle.DN_ArticuloId,detalle.DN_AfectadoId,nota.NT_UsuarioId,nota.NT_UnidadNegocioId,venta.VE_ClienteId,
		((YEAR(nota.NT_Fecha)*100)+(MONTH(nota.NT_Fecha))) as idfecha,
		replace(SUM(detalle.DN_Cantidad),'-','') as Cantidad,
		replace(SUM(detalle.DN_Cantidad * detalle.DN_PrecioBs),'-','') as Monto

 from Future.dbo.VENVenta venta inner join Future.dbo.INVNota nota on venta.VE_NotaId=nota.NT_NotaId
					 inner join Future.dbo.INVDetalleNota detalle on nota.NT_NotaId=detalle.DN_NotaId
					 where (YEAR(nota.NT_Fecha))=@AÑO and (MONTH(nota.NT_Fecha))=@MES
	group by
	 venta.VE_EmpresaId,
	 venta.VE_MedicoId,
	 detalle.DN_ArticuloId,
	 detalle.DN_AfectadoId,
	 nota.NT_UsuarioId,
	 nota.NT_UnidadNegocioId,
	 venta.VE_ClienteId,
	 nota.NT_Fecha
	
	 order by 
	  venta.VE_EmpresaId,
	 venta.VE_MedicoId,
	 detalle.DN_ArticuloId,
	 detalle.DN_AfectadoId,
	 nota.NT_UsuarioId,
	 nota.NT_UnidadNegocioId,
	 venta.VE_ClienteId,
	 nota.NT_Fecha,
	 Cantidad,
	 Monto
end
GO
/****** Object:  StoredProcedure [dbo].[sp_Seleccionar_unidadNegocio]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_Seleccionar_unidadNegocio]
as
begin
select UN_UnidadNegocioId, UN_Nombre
from Future.dbo.CTBUnidadNegocio
ORDER BY UN_UnidadNegocioId
end


GO
/****** Object:  StoredProcedure [dbo].[sp_SeleccionarClientes]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SeleccionarClientes]
as
begin
select  distinct cliente.EMP_EmpresaId, cliente.EMP_NombreLargo
from Future.dbo.VENVenta venta inner join Future.dbo.GENEmpresa cliente ON venta.VE_ClienteId=cliente.EMP_EmpresaId
ORDER BY cliente.EMP_EmpresaId
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SeleccionarMedicoEnvia]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SeleccionarMedicoEnvia]
as
begin
select  distinct medico.EMP_EmpresaId, medico.EMP_NombreLargo
from Future.dbo.VENVenta venta inner join Future.dbo.GENEmpresa medico ON venta.VE_MedicoId=medico.EMP_EmpresaId
ORDER BY medico.EMP_EmpresaId
end

GO
/****** Object:  StoredProcedure [dbo].[sp_SeleccionarMedicoServicio]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SeleccionarMedicoServicio]
as
begin
select  distinct medico.EMP_EmpresaId, medico.EMP_NombreLargo
from Future.dbo.INVDetalleNota detalle inner join Future.dbo.GENEmpresa medico ON detalle.DN_AfectadoId=medico.EMP_EmpresaId
ORDER BY medico.EMP_EmpresaId
end

GO
/****** Object:  StoredProcedure [dbo].[sp_SeleccionarSeguro]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SeleccionarSeguro]
as
begin
select distinct seguro.EMP_EmpresaId, seguro.EMP_NombreLargo
from Future.dbo.VENVenta venta inner join Future.dbo.GENEmpresa seguro ON venta.VE_EmpresaId=seguro.EMP_EmpresaId
order by seguro.EMP_EmpresaId
end

GO
/****** Object:  StoredProcedure [dbo].[sp_SeleccionarServicio]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[sp_SeleccionarServicio]
as
begin
select  distinct AR_ArticuloId, AR_Nombre
from Future.dbo.INVArticulo
ORDER BY AR_ArticuloId
end


GO
/****** Object:  StoredProcedure [dbo].[sp_SeleccionarUsuarios]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_SeleccionarUsuarios]
as
begin
select  distinct US_UsuarioId, US_Nombre
from Future.dbo.SEGUsuario
ORDER BY US_UsuarioId
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SubirCliente]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_SubirCliente]
AS 
BEGIN
delete from D_Cliente
BULK INSERT D_Cliente
FROM 'C:\ARCHIVOS\cliente.txt'
WITH
(
FIELDTERMINATOR = '|',
ROWTERMINATOR = '\n'
)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SubirMedicoEnvia]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_SubirMedicoEnvia]
AS 
BEGIN
delete from D_MedicoEnvia
BULK INSERT D_MedicoEnvia
FROM 'C:\ARCHIVOS\medico_envia.txt'
WITH
(
FIELDTERMINATOR = '|',
ROWTERMINATOR = '\n'
)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SubirMedicoServicio]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_SubirMedicoServicio]
AS 
BEGIN
delete from D_MedicoServicio
BULK INSERT D_MedicoServicio
FROM 'C:\ARCHIVOS\medico_servicio.txt'
WITH
(
FIELDTERMINATOR = '|',
ROWTERMINATOR = '\n'
)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SubirSeguro]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[sp_SubirSeguro]
AS 
BEGIN
delete from D_Seguro
BULK INSERT D_Seguro
FROM 'C:\ARCHIVOS\seguros.txt'
WITH
(
FIELDTERMINATOR = '|',
ROWTERMINATOR = '\n'
)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_SubirServicio]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_SubirServicio]
AS 
BEGIN
delete from D_Servicio
BULK INSERT D_Servicio
FROM 'C:\ARCHIVOS\servicio.txt'
WITH
(
FIELDTERMINATOR = '|',
ROWTERMINATOR = '\n'
)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SubirTiempo]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_SubirTiempo]
AS 
BEGIN
delete from D_Tiempo
BULK INSERT D_Tiempo
FROM 'C:\ARCHIVOS\tiempo.txt'
WITH
(
FIELDTERMINATOR = '|',
ROWTERMINATOR = '\n'
)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SubirUsuario]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_SubirUsuario]
AS 
BEGIN
delete from D_Usuario
BULK INSERT D_Usuario
FROM 'C:\ARCHIVOS\usuarios.txt'
WITH
(
FIELDTERMINATOR = '|',
ROWTERMINATOR = '\n'
)
END

GO
/****** Object:  StoredProcedure [dbo].[sp_SubirVenta]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[sp_SubirVenta]
AS 
BEGIN
delete from H_Venta
BULK INSERT H_Venta
FROM 'C:\ARCHIVOS\venta.txt'
WITH
(
FIELDTERMINATOR = '|',
ROWTERMINATOR = '\n'
)
END
GO
/****** Object:  StoredProcedure [dbo].[sp_Unidad_Negocio]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[sp_Unidad_Negocio]
AS 
BEGIN
delete from D_UnidadNegocio
BULK INSERT D_UnidadNegocio
FROM 'C:\ARCHIVOS\unidad_negocio.txt'
WITH
(
FIELDTERMINATOR = '|',
ROWTERMINATOR = '\n'
)
END

GO
/****** Object:  StoredProcedure [dbo].[spGetUserId]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spGetUserId]
as
SELECT IDENT_CURRENT('D_usuarios')+1 AS Us_Id
GO
/****** Object:  StoredProcedure [dbo].[spInsertar_Usuario]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[spInsertar_Usuario]
@nombre varchar(50),
@usuario nvarchar(50),
@salt  varbinary(max),
@pass  varbinary(max),
@estado int,
@acceso varchar(20) 
as

insert into D_usuarios (US_Nombre, US_NombreUsuario, US_Salt, US_Pass, US_Estado, US_Acceso)
values (@nombre,@usuario,@salt,@pass,@estado,@acceso)
GO
/****** Object:  StoredProcedure [dbo].[US_ObtenerCredenciales]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[US_ObtenerCredenciales]
@Nombre_Usuario varchar(50)
as
select US_NombreUsuario,US_Salt,US_Pass from D_usuarios where D_usuarios.US_NombreUsuario = @Nombre_Usuario

GO
/****** Object:  Table [dbo].[D_Cliente]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[D_Cliente](
	[id] [int] NULL,
	[nombre] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[D_MedicoEnvia]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[D_MedicoEnvia](
	[Id] [int] NULL,
	[nombre] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[D_MedicoServicio]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[D_MedicoServicio](
	[Id] [int] NULL,
	[nombre] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[D_Seguro]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[D_Seguro](
	[Id] [int] NULL,
	[Nombre] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[D_Servicio]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[D_Servicio](
	[Id] [int] NULL,
	[nombre] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[D_Tiempo]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[D_Tiempo](
	[Id] [int] NULL,
	[mes] [varchar](30) NULL,
	[año] [int] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[D_UnidadNegocio]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[D_UnidadNegocio](
	[Id] [int] NULL,
	[nombre] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[D_Usuario]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[D_Usuario](
	[id] [int] NULL,
	[nombre] [varchar](80) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[D_usuarios]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[D_usuarios](
	[Us_Id] [int] IDENTITY(1,1) NOT NULL,
	[US_Nombre] [varchar](50) NOT NULL,
	[US_NombreUsuario] [nvarchar](50) NOT NULL,
	[US_Salt] [varbinary](max) NOT NULL,
	[US_Pass] [varbinary](max) NOT NULL,
	[US_Estado] [int] NULL,
	[US_Acceso] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Us_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[US_NombreUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[H_Venta]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[H_Venta](
	[id_seguro] [int] NULL,
	[id_MedicoEnvia] [int] NULL,
	[id_Servicio] [int] NULL,
	[id_MedicoServicio] [int] NULL,
	[id_Usuario] [int] NULL,
	[id_UnidadNegocio] [int] NULL,
	[id_Cliente] [int] NULL,
	[id_Tiempo] [int] NULL,
	[Cantidad] [numeric](10, 2) NULL,
	[Monto] [numeric](10, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Registro_Exportaciones]    Script Date: 17/06/2019 16:31:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Registro_Exportaciones](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_usuario] [int] NULL,
	[Mes] [varchar](20) NULL,
	[Año] [varchar](20) NULL,
	[Hora] [varchar](20) NULL,
	[fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [dwFuture] SET  READ_WRITE 
GO
