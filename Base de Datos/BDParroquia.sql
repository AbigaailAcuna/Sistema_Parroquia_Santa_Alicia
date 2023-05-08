
create database Parroquia1
use Parroquia1

--tipos de acta
create table tipoActa(
idActa varchar(5) primary key,
NombreTipo varchar(50)
)

--Tabla de información para actas

--tabla informacionBautizo--
create table informacionBautizo(
idinfo int primary key identity(1,1),
Nombre varchar(100),
Dui varchar(10) ,
NombreSacerdote varchar(100),
NombrePadre varchar(150),
NombreMadre varchar(150),
NombreMadrina varchar(150),
NombrePadrino varchar(150),
LugarNacimiento varchar (150),
fechanacimiento date,
fecharegistro date,
estado varchar(15),
idActa varchar(5) FOREIGN KEY REFERENCES  tipoActa(idActa),
);

--tabla informacionPrimeraComunion--
create table informacionPrimeraComunion(
idinfo int primary key identity(1,1),
Nombre varchar(100),
Dui varchar(10),
NombreSacerdote varchar(100),
NombrePadre varchar(150),
NombreMadre varchar(150),
LugarNacimiento varchar (150),
fechanacimiento date,
fecharegistro date,
estado varchar(15),
idActa varchar(5) FOREIGN KEY REFERENCES  tipoActa(idActa),
);

--tabla informacionConfirma--
create table informacionConfirma(
idinfo int primary key identity(1,1),
Nombre varchar(100),
Dui varchar(10) ,
NombreSacerdote varchar(100),
NombrePadre varchar(150),
NombreMadre varchar(150),
NombreMadrinadeConfirma varchar(150),
NombrePadrinodeConfirma varchar(150),
LugarNacimiento varchar (150),
LugardeBautismo varchar (150),
fechanacimiento date,
fechaConfirmacion date,
fechaExpedicion date,
estado varchar(15),
idActa varchar(5) FOREIGN KEY REFERENCES  tipoActa(idActa),
);

--tabla informacionMatrimoni--
create table informacionMatrimonio(
idinfo int primary key identity(1,1),
fechaBoda date,
edadNovio int,
edadNovia int,
nombreSacerdote varchar(100),
nombreNovio varchar(100),
nombreNovia varchar(100),
padreNovio varchar(100),
madreNovio varchar(100),
padreNovia varchar(100),
madreNovia varchar(100),
DuiNovio varchar(10),
DuiNovia varchar(10),
estado varchar(15),
idActa  varchar(5) FOREIGN KEY REFERENCES tipoActa(idActa),
);

--tabla encargado--
create table encargado(
Nombres varchar(100),
Apellido varchar(100),
Dui varchar(10) primary key,
correo varchar(50),
clave varchar(50)
)


------------------------------------------------------------------
insert into tipoActa values('M01','Matrimonio')
insert into tipoActa values('M02','Bautizo')
insert into tipoActa values('M03','PrimeraComunion')
insert into tipoActa values('M04','Confirma')

select*from tipoActa
select * from detalle
select*from informacionBautizo
select*from informacionMatrimonio
select*from informacionConfirma
select*from informacionPrimeraComunion
 
 


