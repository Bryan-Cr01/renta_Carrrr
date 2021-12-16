go
create view clientes_view
as
select Id_clientes,Cedula,Nombre,Telefono,Correo,Direccion from Clientes


select * from clientes_view


-----procedure para un update si es necesario en este caso hacemos el por medio del Id es que hacemos el update si se quiere hacer por medio 
---de cedula se iguala el input en el where 
---input me refiero a la variable toma el valor para buscarlo el la tabla en este caso el numero 2
go 
create proc update_client (@Id int,@ced varchar (18),@nombre varchar (50),@telefono varchar(30),@correo varchar (50), @direccion varchar (50))
as
begin
update Clientes set Id_clientes=@id,Cedula=@ced,Nombre=@nombre,Telefono=@telefono,Correo=@correo,Direccion=@direccion 
where Id_clientes=@id             
end


------------recordar que cedula es unique no se puede repetir con ninguna otra en la tabla 
------------para trabajarlo en el back end hay que declarar variables y igualarlas al input en la el back end
exec update_client  2,'1-1678-0083','Kevin Ilama','8899662230','kev@hotmail.com','La Piedra'


select * from Clientes


-----proc para insertar values en el clientes 

go
create procedure insert_client(@Id int,@ced varchar (18),@nombre varchar (50),@telefono varchar(30),
@correo varchar (50), @direccion varchar (50))
as
begin
insert into Clientes(Id_clientes,Cedula,Nombre,Telefono,Correo,Direccion)
values(@Id,@ced,@nombre,@telefono,@correo, @direccion) 
end

--------------lo mismo por con este insert se deben declarar variables para tomar el input y hacer el insert solo se igualan con las variables que se usen en el backend 
------------ejemplo variables solo es una ejemplo de variables para trabajar con el back end 
declare @Idinput int,@cedinput varchar (18),@nombreinput varchar (50),@telefonoinput varchar(30),
@correoinput varchar (50), @direccioninput varchar (50)

exec insert_client 11,'1-1678-8883','Jonathan valverde','8599662230','JonaV@hotmail.com','Cristo Rey'

select * from clientes


---------views y proce para tabla beneficios 

go
create view view_benefits
as
select Id_Beneficios,Promo_1,Promo_2,Promo_3,Promo_4 from Beneficios_Km

select * from view_befits



go 
create proc update_benefits (@id int, @promo01 varchar(50),@promo02 varchar(50),@promo03 varchar(50),
@promo04 varchar(50))
as 

begin
update Beneficios_Km set Id_Beneficios=@id,Promo_1=@promo01,Promo_2=@promo02,Promo_3=@promo03,Promo_4=@promo04
where Id_Beneficios=@id             
end


exec update_benefits 4,'Lavado gratis','Encerado completo','Cambio aceite',''

select * from Beneficios_Km

-----procedure para insert en Beneficios_Km en este si tomamos en cuenta la columna id perfil 

go 
create proc insert_benefit(@id int, @promo01 varchar(50),@promo02 varchar(50),@promo03 varchar(50),
@promo04 varchar(50),@promo05 varchar(50),@id_per int)
as 
begin
insert into Beneficios_Km(Id_Beneficios,Promo_1,Promo_2,Promo_3,Promo_4,Promo_5,Id_perfil)
values(@id, @promo01,@promo02,@promo03,
@promo04,@promo05,@id_per) 
end

exec insert_benefit 5,'Rectificacion frenos','','','','',101
select * from Beneficios_Km

------------views y proc para perfil vehiculos

go 
create view view_perf_vehi
as 
select Id_perfil,Fabricante,Estilo,Cilindraje,Tipo_caja,Combustion,Capacidad from perfil_vehiculos

---puede tomar las columans que quiera usar de la view 
select Fabricante from view_perf_vehi

----------en caso que se llegue a ocupar para mostrar info una view con un join de tabla vehiculo y tabla perfil
go
create view join_vehiculo
as
select Placa,Year_Fabricante,Color,Fabricante,Cilindraje,Tipo_caja from vehiculo join perfil_vehiculos
on vehiculo.Id_perfil = perfil_vehiculos.Id_perfil

select * from join_vehiculo


---------proc to update 

go
create proc update_perfilV (@id int, @fabricante varchar(50),@estilo varchar(50),@cilindraje varchar(50),
@tipocaja varchar(20),@combustion varchar(20),@capacidad int)
as 

begin
update perfil_vehiculos set Id_perfil=@id,Fabricante=@fabricante,Estilo=@estilo,Cilindraje=@cilindraje,
Tipo_caja=@tipocaja,Combustion=@combustion,Capacidad=@capacidad
where Id_perfil=@id             
end

exec update_perfilV 101,'Honda','Civic','2.0','Manual','Gasolina',5

select * from perfil_vehiculos


go
create proc insert_perfV(@id int, @fabricante varchar(50),@estilo varchar(50),@cilindraje varchar(50),
@tipocaja varchar(20),@combustion varchar(20),@capacidad int)
as 
begin 
insert into perfil_vehiculos(Id_perfil,Fabricante,Estilo,Cilindraje,Tipo_caja,Combustion,Capacidad)
values(@id, @fabricante,@estilo,@cilindraje,
@tipocaja,@combustion,@capacidad)
end 

exec insert_perfV 111,'Honda','Civic','2.0','Automatico','Gasolina',5

select * from perfil_vehiculos

------tambien podemos hacer proc para un select pero es mas complejo voy a dejarle un ejemplo 
-----el input es el id o con el que desee buscar el resto van a ser outputs 

go
create proc select_perfifV (@id int, @fabricante varchar(50) output,@estilo varchar(50)output,@cilindraje varchar(50)output,
@tipocaja varchar(20)output,@combustion varchar(20)output,@capacidad int output) 
as 
	select @fabricante=Fabricante,@estilo=Estilo,@cilindraje=Cilindraje,
	@tipocaja=Tipo_caja,@combustion=Combustion,@capacidad=Capacidad
	from perfil_vehiculos
	where Id_perfil = @id
-----es necesario decalarar mas variables para el output y en este caso solo va a mostrar un unico valor 
-----para poder usarlo hay que declarar otra variable para el id y compararlo con lo que se trabaje en el back end 
-----para poder ver el resultado por aca deben de selecionar todo desde begin hasta end y correrlo
begin
declare @fabricanteout varchar(50),@estiloout varchar(50),@cilindrajeout varchar(50),
@tipocajaout varchar(20),@combustionout varchar(20),@capacidadout int 
exec select_perfifV 103,@fabricanteout out,@estiloout out,@cilindrajeout out,
@tipocajaout out,@combustionout out,@capacidadout out
print @fabricanteout
print @estiloout
print @cilindrajeout
print @tipocajaout
print @combustionout
print @capacidadout
end


---------views proc para vehiculo 

go 
create view view_vehiculo
as
select Id_vehiculo,Placa,Year_Fabricante,Kilometraje,Color,Fotos,Id_perfil,Extras from vehiculo

select * from view_vehiculo

go 
alter proc salect_vehic (@Placa varchar(20),@year int out, @kilometraje float out,@color varchar(20) out ,
@foto varbinary out,@id_per int out)
as 
declare @select varchar(100),@from varchar(50)
begin 
set @select = 'select @Placa=Placa, @year= Year_Fabricante,@kilometraje= Kilometraje,
           @color= Color,@foto= Fotos,@id_per= Id_perfil from vehiculo where Placa = @placa'
		  
end 
 Print @select


 exec salect_vehic 121232


select Placa,Year_Fabricante,Kilometraje,Color,Fotos,Id_perfil from vehiculo 



