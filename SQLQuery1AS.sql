drop table Usuarios;

CREATE TABLE Usuarios

(

	Id_usuario		        int	 primary key identity,

	Nombre			varchar(100)	not null,

	Usuario	        varchar(100)	not null,

	Contraseña		varchar(100)	not null,

	Tipo_usuario	         varchar(100)	not null,
	unique(nombre)


);

INSERT INTO Usuarios('Ignacio Luarca', 'adimin1','123','Admin');	
					('Jose Luis', 'adimin1','123','Admin');
INSERT INTO Usuarios('Ignacio Luarca', 'adimin1','123','Admin'),
INSERT INTO Usuarios('Ignacio Luarca', 'adimin1','123','Admin'),