CREATE DATABASE NETVENTAS
GO 
USE NETVENTAS
GO
CREATE TABLE ARTICULOS(
CODIGOART VARCHAR(6) PRIMARY KEY,
NOMBREART VARCHAR(50),
PRECIOART VARCHAR(10)
)
INSERT INTO ARTICULOS VALUES('ART001','CAFE ALTOMAYO','2')
INSERT INTO ARTICULOS VALUES('ART002','AZUCAR RUBIA','3')
INSERT INTO ARTICULOS VALUES('ART003','MANTEQUILLA LAIVE','4')
INSERT INTO ARTICULOS VALUES('ART004','PAN DE MOLDE BIMBO','5')
INSERT INTO ARTICULOS VALUES('ART005','MERMELADA GLORIA','1')
INSERT INTO ARTICULOS VALUES('ART006','LECHE GLORIA','3')
INSERT INTO ARTICULOS VALUES('ART007','JAMON DEL PAIS','4')
INSERT INTO ARTICULOS VALUES('ART008','QUESO LAIVE','3')
INSERT INTO ARTICULOS VALUES('ART009','PAN INTEGRAL','5')
