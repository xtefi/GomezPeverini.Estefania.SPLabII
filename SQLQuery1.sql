create database Libreria
GO
use Libreria
GO

--Crear tabla Lapices
create table Lapices (
	id int identity primary key, 
	marca varchar(120) not null, 
	precio float not null, 
	color varchar(120) not null,
	tamano varchar(120) not null)

--Crear tabla Gomas
create table Gomas (
	id int identity primary key, 
	marca varchar(120) not null, 
	precio float not null, 
	forma varchar(120) not null)
	
--Crear tabla Sacapuntas
create table Sacapuntas (
	id int identity primary key, 
	marca varchar(120) not null, 
	precio float, 
	forma varchar(120) not null,
	conDeposito bit not null,
	material varchar(120))

--Insertar Lapices
insert into Lapices (marca, precio, color, tamano) values
('Faber Castell', 15, 'Verde', '2B'),
('Faber Castell', 12, 'Rojo', '2B'),
('Faber Castell', 27, 'Azul', '2B'),
('Staedtler', 1, 'Negro', '4B');

--Insertar Gomas
insert into Gomas(marca, precio, forma) values
('Staedtler', 112,'Conejo'),
('Faber Castell', 399.99,'Cuadrada'),
('Generica', 62.50,'Emoji');

--Insertar Sacapuntas
insert into Sacapuntas(marca, precio, forma, conDeposito, material) values
('Staedtler', 11, 'Avion', 0, 'plastico'),
('Staedtler', 99, 'Capsula', 1, 'plastico'),
('Derwent', 199, 'Capsula', 1, 'metal'),
('Mapped', 15, 'Rectangulo', 0, 'metal');