create table D_usuarios(
Us_Id int identity (1,1) primary key,
US_Nombre varchar(50) not null,
US_NombreUsuario nvarchar(50) unique not null,
US_Salt varbinary(max) not null,
US_Pass varbinary(max) not null,
US_Estado int
)
go

Select * from D_usuarios