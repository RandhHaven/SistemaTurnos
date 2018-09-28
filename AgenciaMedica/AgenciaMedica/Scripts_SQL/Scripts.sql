CREATE TABLE estados (
    id int NOT NULL,
    descripcion varchar(100),
	PRIMARY KEY (id)
);

CREATE TABLE tipos_usuarios (
    id int NOT NULL,
    descripcion varchar(100),
	PRIMARY KEY (id)
);

CREATE TABLE usuarios (
    id int not null,
    usuario varchar(20) not null,
    nombre varchar(100) not null,
    password varchar(20) not null,
	email varchar(50),
	fecha_alta date not null,
	usuario_alta varchar(20) not null,
	fecha_modificacion date,
	usuario_modificacion varchar(20),
	estado int not null,
	tipo_usuario int not null,
	primary key (id),
	foreign key (estado) REFERENCES estados(id),
    foreign key (tipo_usuario) REFERENCES tipos_usuarios(id)
);