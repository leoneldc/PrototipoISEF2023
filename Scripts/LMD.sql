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