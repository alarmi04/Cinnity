create database if not exists Cinnity character set utf8;
use Cinnity;

create table if not exists Usuario 
(
id int primary key auto_increment,
nombre varchar(45) not null,
apellidos varchar(100) not null,
correoElectronico varchar(100) not null,
contrasenya varchar(50) not null,
pais varchar(45) not null,
fechaNaci Datetime not null
);

create table if not exists Cartelera
(
idCartelera int primary key auto_increment,
fecha date not null,
hora time not null
);

create table if not exists Pelicula
(
idPelicula int primary key auto_increment,
fotoCaratula blob not null,
nombrePeli varchar(45) not null,
genero varchar(45) not null,
director varchar(45) not null,
reparto varchar(300) not null,
duraccion int not null,
sinopsis varchar(300) not null,
fechaEstreno datetime not NULL,
idCartelera INT NOT NULL 
);


create table if not exists Entradas
(
idEntradas int primary key auto_increment,
precio double not null,
fecha_compra datetime not null,
carteleraID int not NULL,
idUsuario INT NOT null
);

ALTER TABLE Pelicula ADD CONSTRAINT fk_carte FOREIGN KEY (idCartelera) REFERENCES Cartelera(idCartelera);
ALTER TABLE Entradas ADD CONSTRAINT fk_cartelera FOREIGN KEY (carteleraID) REFERENCES Cartelera(idCartelera);
ALTER TABLE Entradas ADD CONSTRAINT fk_usuario FOREIGN KEY (idUsuario) REFERENCES Usuario(id);

