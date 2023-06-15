use sig;
/*--------------------SEGURIDAD---------------*/
-- -----MODULOS

INSERT INTO `tbl_modulos` VALUES
('1000', 'SEGURIDAD', 'Seguridad', 1),
('2000', 'CINE', 'Cine', 1);

-- -----APLICACIONES
INSERT INTO `tbl_aplicaciones` VALUES
('1', 'Login', 'PARA SEGURIDAD', '1'),
('999', 'Logout', 'PARA SEGURIDAD', '1'),
('1000', 'MDI SEGURIDAD', 'PARA SEGURIDAD', '1'),
('1001', 'Mant. Usuario', 'PARA SEGURIDAD', '1'),
('1002', 'Mant. Aplicación', 'PARA SEGURIDAD', '1'),
('1003', 'Mant. Modulo', 'PARA SEGURIDAD', '1'),
('1004', 'Mant. Perfil', 'PARA SEGURIDAD', '1'),
('1101', 'Asign. Modulo Aplicacion', 'PARA SEGURIDAD', '1'),
('1102', 'Asign. Aplicacion Perfil', 'PARA SEGURIDAD', '1'),
('1103', 'Asign. Perfil Usuario', 'PARA SEGURIDAD', '1'),
('1201', 'Pcs. Cambio Contraseña', 'PARA SEGURIDAD', '1'),
('1301', 'Pcs. BITACORA', 'PARA SEGURIDAD', '1'),
('2000', 'MDI CINE', 'PARA CINE', '1'),
('2001', 'Mant. Clientes', 'PARA CINE', '1');

-- -----USUARIOS
INSERT INTO `tbl_usuarios` VALUES
('1', 'admin', 'admin', 'admin', 'HO0aGo4nM94=', 'esduardo@gmail.com', '1', 'COLOR FAVORITO', 'X9yc1/l1b2A=');

-- -----PERFILES
INSERT INTO `tbl_perfiles` VALUES
('1', 'ADMINISTRADOR', 'contiene todos los permisos del programa', 1),
('2', 'SEGURIDAD', 'contiene todos los permisos de seguridad', 1),
('3', 'CINE', 'contiene todos los permisos de cine', 1);

-- -----ASIGNACIÓNES MODULO A APLICACION
INSERT INTO `tbl_asignacionmoduloaplicacion` VALUES
('1000', '1000'),
('1000', '1001'),
('1000', '1002'),
('1000', '1003'),
('1000', '1004'),
('1000', '1102'),
('1000', '1103'),
('1000', '1201'),
('1000', '1301'),
('2000', '2000'),
('2000', '2001');

-- -----PERMISOS DE APLICACIONES A PERFILES
INSERT INTO `tbl_permisosAplicacionPerfil` VALUES
('1', '1000', '1', '1', '1', '1', '1'),
('1', '1001', '1', '1', '1', '1', '1'),
('1', '1002', '1', '1', '1', '1', '1'),
('1', '1003', '1', '1', '1', '1', '1'),
('1', '1004', '1', '1', '1', '1', '1'),
('1', '1101', '1', '1', '1', '1', '1'),
('1', '1102', '1', '1', '1', '1', '1'),
('1', '1103', '1', '1', '1', '1', '1'),
('1', '1201', '1', '1', '1', '1', '1'),
('1', '1301', '1', '1', '1', '1', '1'),
('1', '2000', '1', '1', '1', '1', '1'),
('1', '2001', '1', '1', '1', '1', '1');

-- -----ASIGNACIÓN DE PERFIL A USUARIO
INSERT INTO `tbl_asignacionesPerfilsUsuario` VALUES
('1', '1'); 


INSERT INTO Peliculas (Nombre, Clasificación, Genero, Subtitulado, Idioma, precio) VALUES ('Pelicula 1', 'A', 'Drama', 'Sí', 'Español', 10.99);
INSERT INTO Peliculas (Nombre, Clasificación, Genero, Subtitulado, Idioma, precio) VALUES ('Pelicula 2', 'B', 'Comedia', 'No', 'Inglés', 9.99);
INSERT INTO Peliculas (Nombre, Clasificación, Genero, Subtitulado, Idioma, precio) VALUES ('Pelicula 3', 'C', 'Acción', 'Sí', 'Español', 12.99);
INSERT INTO Peliculas (Nombre, Clasificación, Genero, Subtitulado, Idioma, precio) VALUES ('Pelicula 4', 'A', 'Suspenso', 'No', 'Inglés', 11.99);
INSERT INTO Peliculas (Nombre, Clasificación, Genero, Subtitulado, Idioma, precio) VALUES ('Pelicula 5', 'B', 'Romance', 'Sí', 'Español', 10.99);

INSERT INTO Cines (Nombre, Dirección) VALUES ('Cine 1', 'Calle Principal 123');
INSERT INTO Cines (Nombre, Dirección) VALUES ('Cine 2', 'Avenida Central 456');
INSERT INTO Cines (Nombre, Dirección) VALUES ('Cine 3', 'Paseo de la Reforma 789');
INSERT INTO Cines (Nombre, Dirección) VALUES ('Cine 4', 'Plaza Principal 321');
INSERT INTO Cines (Nombre, Dirección) VALUES ('Cine 5', 'Boulevard Juárez 654');

INSERT INTO Salas (fkCine, Descripción, formatoPeli, puntos, precioSala) VALUES (1, 'Sala 1', 'Digital', 50, 8.99);
INSERT INTO Salas (fkCine, Descripción, formatoPeli, puntos, precioSala) VALUES (1, 'Sala 2', 'IMAX', 70, 12.99);
INSERT INTO Salas (fkCine, Descripción, formatoPeli, puntos, precioSala) VALUES (2, 'Sala 3', 'Digital', 60, 10.99);
INSERT INTO Salas (fkCine, Descripción, formatoPeli, puntos, precioSala) VALUES (3, 'Sala 4', 'IMAX', 80, 14.99);
INSERT INTO Salas (fkCine, Descripción, formatoPeli, puntos, precioSala) VALUES (4, 'Sala 5', 'Digital', 55, 9.99);

INSERT INTO horarioCine (fkPelicula, fkSala, fechaHorario) VALUES (1, 1, '2023-06-15 10:00:00');
INSERT INTO horarioCine (fkPelicula, fkSala, fechaHorario) VALUES (2, 2, '2023-06-15 12:30:00');
INSERT INTO horarioCine (fkPelicula, fkSala, fechaHorario) VALUES (3, 3, '2023-06-15 15:00:00');
INSERT INTO horarioCine (fkPelicula, fkSala, fechaHorario) VALUES (4, 4, '2023-06-15 17:30:00');
INSERT INTO horarioCine (fkPelicula, fkSala, fechaHorario) VALUES (5, 5, '2023-06-15 20:00:00');

INSERT INTO Derechos (fkPelicula, estadoDerechos) VALUES (1, 1);
INSERT INTO Derechos (fkPelicula, estadoDerechos) VALUES (2, 0);
INSERT INTO Derechos (fkPelicula, estadoDerechos) VALUES (3, 1);
INSERT INTO Derechos (fkPelicula, estadoDerechos) VALUES (4, 0);
INSERT INTO Derechos (fkPelicula, estadoDerechos) VALUES (5, 1);

INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (1, 10, 'A');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (1, 10, 'B');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (1, 10, 'C');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (1, 10, 'D');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (2, 10, 'A');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (2, 10, 'B');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (2, 10, 'C');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (2, 10, 'D');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (3, 10, 'A');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (3, 10, 'B');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (3, 10, 'C');
INSERT INTO Asientos (fkSala, Fila, Columna) VALUES (3, 10, 'D');