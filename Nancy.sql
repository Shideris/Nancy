CREATE DATABASE NANCY;
go;

USE NANCY;
go;

CREATE TABLE TIENDA
(
    ID_TIENDA INT NOT NULL IDENTITY PRIMARY KEY,
    NOMBRE_TIENDA VARCHAR(30) NOT NULL,
    NIT INT NOT NULL,
    DIRECCION VARCHAR(150) NOT NULL,
    TELEFONO INT NOT NULL,
);
go;

CREATE TABLE PERSONAL
(
    ID_PER INT NOT NULL IDENTITY PRIMARY KEY,
    CI VARCHAR(30) NOT NULL,
    NOM_EMP VARCHAR(50) NOT NULL,
    APE_EMP VARCHAR(50) NOT NULL,
    EDAD INT NOT NULL,
    SEXO VARCHAR(15) NOT NULL,
    DIRECCION VARCHAR(100) NOT NULL,
    TELEFONO INT NOT NULL,
    CARGO VARCHAR(100) NOT NULL,
    USUARIO VARCHAR(20) NOT NULL,
    CONTRASENA varchar(20) NOT NULL,
    ID_TIENDA INT NOT NULL,
    FOREIGN KEY (ID_TIENDA) REFERENCES TIENDA(ID_TIENDA)
);
GO;

CREATE TABLE PROVEEDOR
(
    ID_PROV INT NOT NULL IDENTITY PRIMARY KEY,
    CI VARCHAR(20) NOT NULL,
    NOM_PROV VARCHAR(50) NOT NULL,
    APE_PROV VARCHAR(50) NOT NULL,
    MARCA VARCHAR(50) NOT NULL,
    DIRECCION VARCHAR(150) NOT NULL,
    EDAD INT NOT NULL,
    SEXO VARCHAR(15) NOT NULL,
    TELEFONO INT NOT NULL,
    ID_TIENDA INT NOT NULL,
    FOREIGN KEY (ID_TIENDA) REFERENCES TIENDA(ID_TIENDA)
);
GO;

CREATE TABLE CLIENTE
(
    ID_CLI INT NOT NULL IDENTITY PRIMARY KEY,
    NOM_CLI VARCHAR(50) NOT NULL,
    APE_CLI VARCHAR(50) NOT NULL,
    NIT_O_CI INT NOT NULL,-- NIT O CI

);
GO;

CREATE TABLE BODEGA
(
    ID_BODEGA INT NOT NULL IDENTITY PRIMARY KEY,
    NUMERO int not null,
    SECCION CHAR (2) NOT NULL
);
GO;


CREATE TABLE COLORES
(
        ID_COLOR INT NOT NULL IDENTITY PRIMARY KEY,
        COLOR VARCHAR(50)
);

CREATE TABLE MODELO
(
    ID_MODELO INT NOT NULL IDENTITY PRIMARY KEY,
    MODELO VARCHAR(50)
)
go;

CREATE TABLE DISENO
(
    ID_DISENO INT NOT NULL IDENTITY PRIMARY KEY,
    NOMBRE VARCHAR(50) NOT NULL,
    FECHA SMALLDATETIME NOT NULL,
    REGISTRO VARCHAR(1000) NOT NULL,
);
GO;

CREATE TABLE TELAS_VENTA
(
    ID_TELA INT NOT NULL IDENTITY PRIMARY KEY,
    MODELO VARCHAR(50) NOT NULL,
    COLOR VARCHAR(80) NOT NULL,
    PRECIO INT NOT NULL,
);
GO;


CREATE TABLE INVENTARIO
(
    ID_INVENTARIO INT NOT NULL IDENTITY PRIMARY KEY,
    ID_TELA INT NOT NULL,
    MODELO VARCHAR (50) NOT NULL,
    CODIGO VARCHAR(10) NOT NULL,
    CANTIDAD_COLORES INT NOT NULL,
    METROS_TOTAL INT NOT NULL,
    PRECIO_MAYOR INT NOT NULL,
    PRECIO_MENOR INT NOT NULL,
    PRECIO_COMPRA INT NOT NULL,
    BODEGA INT NOT NULL,
    DISEÑO varchar(50) NOT NULL,
    FOREIGN KEY(ID_TELA) REFERENCES TELAS_VENTA(ID_TELA)
);
GO;

CREATE TABLE REGISTRO_EMPLEADO
(
    ID_REGISTRO_EMPLEADO INT NOT NULL identity PRIMARY KEY,
    ID_PER INT NOT NULL,
    HORARIO_ENTRADA SMALLDATETIME NOT NULL,
    HORARIO_SALIDA SMALLDATETIME NOT NULL,
    CARGO VARCHAR(100) NOT NULL,
    UBICACION_EMPLEADO VARCHAR(50) NOT NULL,
    FOREIGN KEY (ID_PER) REFERENCES PERSONAL(ID_PER)
);
GO;

CREATE TABLE FACTURA
(
    ID_FACTURA INT NOT NULL IDENTITY PRIMARY KEY ,
    FECHA SMALLDATETIME NOT NULL,
    NOMRE_COMPRADOR VARCHAR(100) NOT NULL,
    NIT_CI INT,
    ID_TELA INT NOT NULL,
    MODELO VARCHAR(100) NOT NULL,
    CANTIDAD INT NOT NULL,
    PRECIO FLOAT NOT NULL,
    IMPORTE FLOAT NOT NULL,
    TOTAL_FINAL FLOAT NOT NULL,
    EFECTIVO FLOAT NOT NULL,
    CAMBIO FLOAT NOT NULL,
    IMPORTE_LITERAL VARCHAR (200) NOT NULL,
    ID_PER INT NOT NULL,
    NOMBRE_CAJERO VARCHAR(100) NOT NULL,
    NUMERO_FACTURA INT NOT NULL,
    FOREIGN KEY (ID_PER) REFERENCES PERSONAL(ID_PER),
    FOREIGN KEY (ID_TELA) REFERENCES TELAS_VENTA(ID_TELA)
);
GO;

CREATE TABLE VENTAS
(
    ID_VENTA INT NOT NULL IDENTITY PRIMARY KEY,
    ID_FACTURA INT NOT NULL,
    ID_TELA INT NOT NULL,
    ID_PER INT NOT NULL,
    CANTIDAD INT NOT NULL,
    FOREIGN KEY (ID_TELA) REFERENCES TELAS_VENTA(ID_TELA),
    FOREIGN KEY (ID_PER) REFERENCES PERSONAL(ID_PER),
    FOREIGN KEY (ID_FACTURA) REFERENCES FACTURA(ID_FACTURA)
);
GO;

CREATE TABLE PEDIDOS_COSTURA
(
    ID_PEDIDO INT NOT NULL IDENTITY PRIMARY KEY,
    NOMBRE_CLIENTE VARCHAR(120) NOT NULL,
    FECHA SMALLDATETIME NOT NULL,
    TELEFONO VARCHAR(10) NOT NULL,
    COSTURA VARCHAR(50) NOT NULL ,
    MODELO VARCHAR(50) NOT NULL,
    TALLA INT NOT NULL,
    BASTAS INT NOT NULL,
    COLOR VARCHAR(50) NOT NULL,
    METROS INT NOT NULL,
    CINTURA INT NOT NULL,
    ANCHO INT NOT NULL,
    ID_TELA INT NOT NULL,
    A_CUENTA INT NOT NULL,
    SALDO INT NOT NULL,
    ESTADO_ENTREGA VARCHAR(80) NOT NULL,
    COSTURERA VARCHAR(120) NOT NULL,
    FECHA_ENTREGA SMALLDATETIME NOT NULL,
    ESTADO VARCHAR(80) NOT NULL
    FOREIGN KEY(ID_TELA) REFERENCES TELAS_VENTA(ID_TELA),
);
GO;


INSERT INTO TIENDA (NOMBRE_TIENDA, NIT, DIRECCION, TELEFONO) VALUES ('Creaciones NANCY',11059781, 'Av.Alfredo Franco Valle. Zona 12 de octubre, entre calle 3 y 4', 76529248)
go;

INSERT INTO PERSONAL(CI, NOM_EMP, APE_EMP, EDAD, SEXO, DIRECCION, TELEFONO, CARGO, USUARIO, CONTRASENA, ID_TIENDA) VALUES ('LP1345879', 'Amelia','Choque', 30, 'Femenino', 'Ceja',7859632,'Costurera', 'Empleado',  '1254',	1)
go;

INSERT INTO PERSONAL(CI, NOM_EMP, APE_EMP, EDAD, SEXO, DIRECCION, TELEFONO, CARGO, USUARIO, CONTRASENA, ID_TIENDA) VALUES ('LP2847969',	'Karla','Valencia',	25	,'Femenino',	'Ballivian',	6589421	, 'vendedora','Empleado', '1456',	1)
go;

INSERT INTO PROVEEDOR(CI, NOM_PROV, APE_PROV, MARCA, DIRECCION, EDAD, SEXO, TELEFONO, ID_TIENDA) VALUES ('1549330',	'Chinita', 'Yuan Shi',	'TELAS CHINAS SR',	'CHINA',	45,	'Femenino',795379891,	1)
go;

INSERT INTO CLIENTE(NOM_CLI, APE_CLI, NIT_O_CI) VALUES ('Clementina',	'Canaviri',	145678),
                                                               ('Sahara','Llusco'	,16711341),
                                                               ('Juan','Flores'	,4646313)
go;

INSERT INTO BODEGA(NUMERO,SECCION) VALUES (1,'A1'), (1,'A2'),(1,'A3'),(2,'B1')
go;

INSERT INTO DISENO(NOMBRE,FECHA,  REGISTRO) VALUES ('Flores Rojas','2022-06-24 15:05:05','Flores rojas, azules en telas de colores pasteles como: rosa, azul, verde y amarillo' ), ('Rosas','2022-07-07 09:10:58',  'Flores rosas, blancas en telas de colores pasteles como: rosa, azul, verde y amarillo')
go;

INSERT INTO COLORES (COLOR) VALUES ('Azul'), ('Rosa'), ('Palo de rosa'), ('Crema'), ('Verde'), ('Marengo'), ('Lila');
go;

INSERT INTO MODELO(MODELO) values ('GASA COREANA'), ('GASA LINO'), ('SEDA'), ('GALLETA'),('BURBUJA');
go;


INSERT INTO REGISTRO_EMPLEADO(ID_PER, HORARIO_ENTRADA, HORARIO_SALIDA, CARGO, UBICACION_EMPLEADO) VALUES (1,	'2022-07-07 08:05:00',	'16:00:00'	,'Costurera',	'Las mesas'),(2,	'2022/07/07 9:05:00',	'2022/07/07 17:00:00','Vendedora',	'La puerta')
go;

select *
from TELAS_VENTA
where MODELO='GASA' OR COLOR='fd8' or PRECIO=58;


USE master;
DROP DATABASE NANCY;