
create proc US_ObtenerCredenciales
@Nombre_Usuario varchar(50)
as
select US_NombreUsuario,US_Salt,US_Pass from D_usuarios where D_usuarios.US_NombreUsuario = @Nombre_Usuario
go



