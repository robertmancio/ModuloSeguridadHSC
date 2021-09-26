
DROP DATABASE ComponenteSeguridad;
CREATE DATABASE ComponenteSeguridad;

USE ComponenteSeguridad;

CREATE TABLE Empleado(
pkIdEmpleado varchar(15) PRIMARY KEY,
nombre varchar(25) NOT NULL,
apellido varchar(25) NOT NULL
)ENGINE = InnoDB;


CREATE TABLE Usuario(
pkId VARCHAR(15) PRIMARY KEY,
fkIdEmpleado varchar(15) NOT NULL, 
nombre VARCHAR(30) NOT NULL,
contraseña VARCHAR(100) NOT NULL,
estado VARCHAR(1) NOT NULL,
intento INT NULL,

FOREIGN KEY (fkIdEmpleado) REFERENCES  Empleado(pkIdEmpleado)
)ENGINE = InnoDB;

CREATE TABLE Aplicacion(
pkId VARCHAR(15) PRIMARY KEY,
nombre VARCHAR(45) NULL,
estado INT NOT NULL,
idReporteAsociado varchar(15)
)ENGINE = InnoDB;

CREATE TABLE BitacoraUsuario(
pkId INT AUTO_INCREMENT PRIMARY KEY,
ip VARCHAR(11) NULL,
conexionFecha DATE NULL,
conexionHora TIME NULL,
conexionTiempo VARCHAR(45) NULL,
fkIdUsuario VARCHAR(15) NOT NULL,
fkIdAplicacion VARCHAR(15) NOT NULL,

FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId),
FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion(pkID)
)ENGINE = InnoDB;

CREATE TABLE Perfil(
pkId VARCHAR(15) PRIMARY KEY,
nombre VARCHAR(45) NULL,
estado VARCHAR(45) NULL
)ENGINE = InnoDB;

CREATE TABLE UsuarioPerfil(
fkIdUsuario VARCHAR(15) NOT NULL PRIMARY KEY,
fkIdPerfil VARCHAR(15) NOT NULL,

FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId),
FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
)ENGINE = InnoDB;

CREATE TABLE UsuarioAplicacion(
fkIdUsuario VARCHAR(15) PRIMARY KEY,
fkIdAplicacion VARCHAR(15) NOT NULL,
permisoEscritura int Not null,
permisoLectura int Not null,
permisoModificar int NOT NULL,
permisoEliminar int NOT NULL,
permisoImprimir int NOT NULL,

FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
FOREIGN KEY (fkIdUsuario) REFERENCES Usuario (pkId)
)ENGINE = InnoDB;

CREATE TABLE IF NOT EXISTS AplicacionPerfil (
fkIdPerfil VARCHAR(15) PRIMARY KEY,
fkIdAplicacion VARCHAR(15) NOT NULL,
permisoEscritura int Not null,
permisoLectura int Not null,
permisoModificar int NOT NULL,
permisoEliminar int NOT NULL,
permisoImprimir int NOT NULL,

FOREIGN KEY (fkIdAplicacion) REFERENCES Aplicacion (pkId),
FOREIGN KEY (fkIdPerfil) REFERENCES Perfil (pkId)
)ENGINE = InnoDB;