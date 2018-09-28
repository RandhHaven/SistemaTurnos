select * from usuarios
select * from tipos_usuarios
select * from estados

insert into estados
values (1, 'Creado')

insert into estados
values (2, 'Activo')

insert into estados
values (3, 'Desactivo')

insert into estados
values (4, 'Proceso de Activaciòn')

insert into estados
values (5, 'Proceso de Desactivacion')

insert into estados
values (6, 'Bloqueado')

insert into tipos_usuarios
values (1, 'Administrador')

insert into tipos_usuarios
values (2, 'Paciente')

insert into tipos_usuarios
values (3, 'Medico')

insert into tipos_usuarios
values (4, 'Proceso de Desactivacion')

insert into usuarios (usuario, nombre, password, email, fecha_alta, usuario_alta, fecha_modificacion, usuario_modificacion, estado, tipo_usuario)
values ('RRANGEL', 'Randhall Rangel', 'Conexion10', 'rd@gmail.com', getdate(), 'RRANGEL', NULL, NULL, 1, 1)