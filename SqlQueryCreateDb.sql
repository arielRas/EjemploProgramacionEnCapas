CREATE DATABASE DbProgramacionEnCapas;
GO 

USE DbProgramacionEnCapas;

CREATE TABLE Producto(
	id_producto INT IDENTITY(1,1),
	descripcion VARCHAR(200) UNIQUE,
	precio DECIMAL(8,2),
	CONSTRAINT PK_Producto PRIMARY KEY (id_producto)
);

CREATE TABLE Pedido(
	id_pedido INT IDENTITY(1,1),
	dni_cliente BIGINT,
	fecha DATETIME,
	CONSTRAINT PK_Pedido PRIMARY KEY(id_pedido)
);

CREATE TABLE Productos_Pedido(
	id_pedido INT,
	id_producto INT,
	Cantidad INT,
	Subtotal DECIMAL(8,2),
	CONSTRAINT PK_Productos_Pedido PRIMARY KEY(id_pedido,id_producto),
	CONSTRAINT FK_Pedidos FOREIGN KEY(id_pedido) REFERENCES Pedido(id_pedido),
	CONSTRAINT FK_Productos FOREIGN KEY(id_producto) REFERENCES Producto(id_producto)
);
GO

INSERT INTO Producto VALUES
	('ASUS GeForce GTX 1650 4GB GDDR6', 159290),
	('ASUS GeForce GTX 1630 4GB GDDR6', 212450),
	('ASUS GeForce RTX 2060 6GB GDDR6', 304350),
	('ASUS GeForce RTX 4070 12GB GDDR6X TUF GAMING OC', 633230),
	('ASUS GeForce RTX 3070 8GB GDDR6 ROG STRIX GAMING OC V2', 500000),
	('ASUS GeForce RTX 4070 12GB GDDR6X DUAL OC', 675800),
	('Procesador Intel Celeron G5925 3.6GHz', 48900),
	('Procesador Intel Core i3 10100F 4.3GHz', 61950),
	('Procesador Intel Core i5 10400 4.3GHz', 146500),
	('Procesador Intel Core i7 11700KF 5.0GHz', 325300),
	('Procesador AMD RYZEN 3 3200G 4.0GHz', 84900),
	('Procesador AMD RYZEN 5 3600 4.2GHz', 123500),
	('Procesador AMD Ryzen 7 5800X3D 4.5G', 341550),
	('Notebook Asus X515EA 15.6" FHD Core I5 1135G7 8GB 256GB', 516000);	
GO

--SELECT * FROM Pedido;

--SELECT * FROM Producto;

--SELECT * FROM Productos_Pedido;