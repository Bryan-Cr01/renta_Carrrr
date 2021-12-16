create database renta_car

use renta_car

create table perfil_vehiculos(
Id_perfil int not null,
Fabricante varchar(30),
Estilo varchar (30),
Cilindraje varchar (30),
Tipo_caja varchar (30),
Combustion varchar (30),
Capacidad int
)

--------to add constraint in Id_perfil 

alter table perfil_vehiculos
add constraint Perf_vehi_ID_PK primary key (Id_perfil ) 


-----some inserts into perfil vehiculo

insert into perfil_vehiculos
values
(101,'Honda','civic','2.0','Automatica','Gasolina',4),
(102,'Toyota','Hilux','2.8','Manual','Diesel',4),
(103,'Isuzu','Dmax','3.0','Manual','Diesel',4),
(104,'Isuzu','Dmax','3.0','Automatico','Diesel',3),
(105,'Mitsubishi','L200','2.2','Manual','Diesel',4),
(106,'Mitsubishi','Montero Sport','3.8','Automatico','Gasolina',5),
(107,'Toyota','Corolla','2.0','Manual','Gasolina',5),
(108,'Nissan','Frontier','2.5','Automatico','Diesel',5),
(109,'Toyota','Tacoma','3.5','Automatico','Gasolina',5),
(110,'Volkswagen','Amarok','2.0','Manual','Gasolina',5)



select * from perfil_vehiculos




create table Precios_Perfil(
Id_precios int,
Fecha_inicio Date,
Fecha_cierre Date,
Precio float,
Id_perfil int  
)


alter table Precios_Perfil
alter column Id_precios int not null

alter table Precios_Perfil
add constraint Id_precios_PK primary key (Id_precios)

alter table Precios_Perfil
add constraint perfil_vehi_Precios_Perf_FK foreign key (Id_perfil) references perfil_vehiculos  (Id_perfil) 

insert into Precios_Perfil
values (01,'11/30/2021','12/31/2021',10000,101),
(02,'11/30/2021','12/30/2021',12000,102),
(03,'11/30/2021','12/31/2021',11000,103),
(04,'11/30/2021','12/31/2021',13000,104),
(05,'11/30/2021','12/30/2021',14000,105),
(06,'11/30/2021','12/30/2021',13000,106),
(07,'09/01/2021','10/30/2021',15000,107),
(08,'10/02/2021','11/15/2021',12000,108),
(09,'11/12/2021','12/06/2021',11000,109),
(10,'11/01/2021','01/01/2022',14000,110)

select * from Precios_Perfil

create table Beneficios_Km (
Id_Beneficios int not null,
Promo_1 varchar (50),
Promo_2 varchar (50),
Promo_3 varchar (50),
Promo_4  varchar (50),
Promo_5 varchar (50),
Id_perfil int 
)

alter table Beneficios_Km
add constraint Beneficios_Id_PK primary key (Id_Beneficios)

alter table Beneficios_Km 
add constraint perfil_vehi_benef_FK Foreign key (Id_perfil) references  perfil_vehiculos(Id_perfil)

insert into Beneficios_Km
values 
(01,'Cambio de aceite','Encerado pintura','','','',102),
(02,'','','','Cambio de escobillas','',103),
(03,'','Pulir parabrisas','','','',104),
(04,'Polarisados','','','','',105)

select * from Beneficios_Km

create table Clientes( 
Id_clientes int not null,
Cedula varchar (18),
Nombre varchar(30), 
Telefono varchar (15),
Correo varchar (25),
Direccion varchar (50)
)


alter table Clientes 
add constraint Clientes_Id_PK primary key (Id_clientes)

alter table Clientes 
add constraint ced_unique unique (Cedula)


insert into Clientes 
values (01,'1-2707-0667','Dilanna Arias','86215590','dilannaarias74@gmail.com','Los Chiles'),
(02,'1-3308-0689','Glorianna Villalobos','88285243','glorivillalobos@gmail.com','Alajuela'),
(03,'1-1678-0081','Melissa Aguilar','70643357','meliaguilar@hotmail.com','Buenos Aires'),
(04,'1-1177-6967','Pablo Navas','69432118','plablonavas@gmail.com','Villa Ligia'),
(05,'1-0098-1143','Ericka Lopez','87765413','lopezericka@gmail.com','Cartago'),
(06,'1-9983-7769','Laura Sanchez','70279988','lausanchez@hotmail.com','Rivas'),
(07,'1-2707-0089','Henry Arias','70898909','henryarias@gmail.com','Tierra Prometida'),
(08,'1-3345-1190','Mariana Gomez','83544789','marianagomez@gmail.com','Buenos Aires'),
(09,'1-2728-1512','Miguel Santana','64567643','miguelsanta21@hotmail.com','Chimirol'),
(10,'1-1514-0809','Manuel Jimenez','87711190','manuel08jimenez@gmail.com','General Viejo')

select * from Clientes

create table vehiculo(
Id_vehiculo int not null,
Placa varchar (50),
Year_Fabricante int,
Kilometraje float,
Color varchar (20),
Fotos varBinary,
Id_perfil int,
Extras bit
)


alter table vehiculo
add constraint Id_vehi_PK primary key (Id_vehiculo)

alter table vehiculo 
add constraint perfil_vehiculo_FK Foreign key (Id_perfil) references  perfil_vehiculos(Id_perfil)


insert into vehiculo (Id_vehiculo,Placa,Year_Fabricante,Kilometraje,Color,Id_perfil)
values(01,'283853',2018,10000,'gris',101),
(02,'BMO493',2017,12000,'rojo',102),
(03,'BRH686',2019,11000,'azul',103),
(04,'146479',2018,14000,'negro',104),
(05,'VNN124',2020,15000,'gris',105),
(06,'121232',2019,17000,'blaco',106),
(07,'JGF989',2014,11000,'vino',107),
(08,'291821',2016,10400,'Celeste',108),
(09,'QLP567',2015,12500,'Turquesa',109),
(10,'KIS411',2016,15500,'gris',110)

select * from vehiculo

create table Visita_taller(
Id_visita_taller int not null,
Fecha_entrada date,
Fecha_salida date,
Detalles varchar (500),
Fotos varBinary,
videos varBinary,
Id_vehiculo int
)

alter table Visita_taller
add constraint Visita_taller_Id_PK primary key (Id_visita_taller)

alter table Visita_taller
add constraint visita_taller_vehiculo_FK foreign key (Id_vehiculo) references vehiculo (Id_vehiculo)

select * from Visita_taller
insert into Visita_taller
values(01,'10/31/2021','11/01/2021','Reparacion de frenos y ajuste',01,01,01),
(02,'10/31/2021','11/01/2021','Cambio de aceite de motor y caja, ademas cambio de filtros',01,01,02),
(03,'10/27/2021','11/05/2021','Repacion de arrancador',01,01,03),
(04,'10/29/2021','11/01/2021','Cambio de llantas, alineacion y balanceo',01,01,04),
(05,'10/28/2021','11/03/2021','Cambio de rotulas de suspencion',01,01,05),
(06,'11/20/2021','12/05/2021','Cambio de compensadores traseros',01,01,06),
(07,'11/20/2021','12/02/2021','Limpieza de valvulas',01,01,07),
(08,'11/30/2021','12/15/2021','Reparacion de cremallera, alineado',01,01,08),
(09,'11/30/2021','12/12/2021','Cambio de aceite de motor y caja, ademas cambio de filtros',01,01,09),
(10,'11/24/2021','12/17/2021','Cambio de compensadores delanteros',01,01,10)

select * from Visita_taller

create table Codigos(
Id_codigo int not null,
Nombre varchar (25),
Dia_inicio date,
Dia_cierre date,
Limite int,
Tipo_desc int,
Vigencia int
)

alter table Codigos 
add constraint Control_cod_Id_PK primary key (Id_codigo)

 insert into Codigos(Id_codigo,Nombre,Dia_inicio,Dia_cierre,Limite,Tipo,Vigencia)
 values (01,'Promo Diciembre','12/01/21','12/30/2021',100,1,100),
 (02,'Promo Enero','01/01/2022','01/30/2022',80,1,100),
 (03,'Promo Febrero','02/01/21','02/28/2022',80,1,100)
 select * from Codigos


Create table Control_codigos (
Id_control_cod int identity (1,1) not null,
Id_codigo int,
Contador int,
Estados varchar(30),
Id_vehiculo int,
Id_clientes int
)
alter table Control_codigos
add constraint Id_control_cod_PK primary key (Id_control_cod)

alter table Control_codigos
add constraint Control_cod_Id_FK Foreign key  (Id_codigo) references Codigos (Id_codigo)

alter table Control_codigos
add constraint vehiculo_ContCod_Fk foreign key (Id_vehiculo) references vehiculo (Id_vehiculo)

insert into Control_codigos (Id_codigo,
Contador,
Estados,
Id_vehiculo,
Id_clientes)
values 
(01,1,'Canjeado',2,01),
(02,1,'Canjeado',3,02),
(03,1,'Canjeado',4,07),
(03,1,'Pendiente',4,07)


select * from Control_codigos

create table Reserva(
Id_reserva   int not null,
Id_clientes int,
Id_vehiculo int,
Id_Beneficios int,
Id_perfil int,
Fecha_inicio date,
Fecha_final date
)
alter table Reserva 
add constraint Reserva_ID_PK primary key (Id_reserva)


alter table Reserva
add constraint Reserva_client_FK Foreign key (Id_clientes) references  Clientes (Id_clientes)

alter table Reserva 
add constraint Reserva_vehiculo_Fk foreign key (Id_vehiculo) references vehiculo (Id_vehiculo)

alter table Reserva 
add constraint Reserva_benef_FK foreign key (Id_Beneficios) references Beneficios_Km (Id_Beneficios)

alter table Reserva
add constraint Reserv_perfil_vehiculo_FK Foreign key (Id_perfil) references  perfil_vehiculos(Id_perfil)

select * from reserva 

insert into Reserva 
values 
(01,1,1,1,101,'2021/12/07','2022/30/01'),
(02,4,9,1,102,'07/12/2021','31/01/2022'),
(03,5,10,2,103,'07/12/2021','31/01/2022'),
(04,8,8,2,104,'07/12/2021','31/01/2022'),
(05,6,2,3,105,'07/12/2021','31/01/2022'),
(06,2,7,3,106,'07/12/2021','31/01/2022'),
(07,3,3,4,107,'07/12/2021','31/01/2022'),
(08,9,6,4,108,'07/12/2021','31/01/2022'),
(09,10,4,1,109,'07/12/2021','31/01/2022'),
(10,7,5,2,110,'07/12/2021','31/01/2022')

select * from Reserva

create table Renta(
Id_renta int identity (1,1) not null,
Id_reserva int,
Id_clientes int,
Id_vehiculo int,
Total_pago float,
Comentarios varchar (500)

)

alter table Renta 
add constraint Renta_Id_PK primary key (Id_renta) 

alter table Renta
add constraint Reserv_ID_Rent_FK foreign key  (Id_reserva) references Reserva (Id_reserva)

alter table Renta
add constraint Renta_client_FK Foreign key (Id_clientes) references  Clientes (Id_clientes)

alter table Renta
add constraint Renta_vehiculo_Fk foreign key (Id_vehiculo) references vehiculo (Id_vehiculo)


insert into Renta
values
(01,01,01,01,'',''),
(02,02,04,09,'',''),
(03,03,05,10,'',''),
(04,04,08,08,'',''),
(05,05,06,02,'',''),
(06,06,02,07,'',''),
(07,07,03,03,'',''),
(08,08,09,06,'',''),
(09,09,10,04,'',''),
(10,10,07,05,'','')

select * from Renta



select * from Precios_Perfil 
select * from Reserva
select * from Renta

select * from vehiculo
select * from perfil_vehiculos
go
alter trigger when_car_rent 
on Reserva
after update 
	as 
	begin 

	-----------variables para guardar los valores de las columnas y compararlos en la tabla reserva
	declare @monto float, @fecha_cierre_per date, @id_per int 
	declare @id_reper int, @fecha_final_rese date,
	@id_cliente int, @id_reser int
	 declare @id_vehiculo int, @dias_atraso int, @monto2fin float

	 	select @id_per=PP.Id_perfil,
		@monto=PP.Precio,
		@fecha_cierre_per=PP.Fecha_cierre,
		@fecha_final_rese=R.Fecha_final,
		@id_reser=R.Id_reserva,
		@id_cliente=R.Id_clientes,
		@id_vehiculo=V.Id_vehiculo,
	@dias_atraso=DATEDIFF(day,R.Fecha_final,GETDATE())
	from Reserva R join Precios_Perfil PP on R.Id_perfil = PP.Id_perfil
	join vehiculo V on R.Id_perfil = V.Id_perfil 
	
	begin 
		if @fecha_cierre_per = @fecha_final_rese
		insert into Renta (Id_renta,Id_reserva,Id_clientes,Id_vehiculo,Total_pago)
		values (14,@id_reser,@id_cliente,@id_vehiculo,@monto)
		
	     else if @fecha_cierre_per <> @fecha_final_rese
	
		insert into Renta (Id_renta,Id_reserva,Id_clientes,Id_vehiculo,Total_pago)
		values (14,@id_reser,@id_cliente,@id_vehiculo, @dias_atraso*1500 + @monto)
		end
	end
	
	update Reserva 
	set Fecha_final = '2021/12/31'
	where Id_reserva = 12

	delete Renta where Id_renta = 11
	select *from Renta

	select * from Reserva
	insert into Reserva values (12,7,6,4,101,'2021/11/07','2021/12/07')
	select * from Renta

	select * from Precios_Perfil
	select * from Reserva
	select PP.Id_perfil,PP.Precio,PP.Fecha_cierre,R.Fecha_final,R.Id_reserva,R.Id_clientes,V.Id_vehiculo,
	DATEDIFF(day,R.Fecha_final,GETDATE())
	from Reserva R join Precios_Perfil PP on R.Id_perfil = PP.Id_perfil
	join vehiculo V on R.Id_perfil = V.Id_perfil 



		select * from vehiculo

	


