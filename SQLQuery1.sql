-- Crear base de datos
CREATE DATABASE GestionComercial;
GO

-- Usar la base de datos
USE GestionComercial;
GO

-- Crear tablas
CREATE TABLE Categoria (
    IdCategoria NVARCHAR(10) PRIMARY KEY NOT NULL,
    Nombre NVARCHAR(50) NOT NULL
);

CREATE TABLE Proveedor (
    IdProveedor NVARCHAR(10) PRIMARY KEY,
    Nombre NVARCHAR(100),
    Telefono NVARCHAR(20),
    Correo NVARCHAR(100),
    Direccion NVARCHAR(200),
    Estado BIT
);

CREATE TABLE Usuario (
    IdUsuario NVARCHAR(10) PRIMARY KEY NOT NULL,
    NombreCompleto NVARCHAR(100) NOT NULL,
    UsuarioNombre NVARCHAR(100) NOT NULL UNIQUE,
    Clave NVARCHAR(100) NOT NULL,
    Rol NVARCHAR(50) NOT NULL,
    Estado BIT NOT NULL
);

CREATE TABLE Cliente (
    IdCliente NVARCHAR(10) PRIMARY KEY NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(20) NOT NULL,
    Direccion NVARCHAR(200) NOT NULL,
    TipoMenbresia NVARCHAR(50) NOT NULL,
    MenbresiaEstado BIT NOT NULL,
    Foto VARBINARY(MAX),
    PuntosCompra INT
);

CREATE TABLE Producto (
    IdProducto NVARCHAR(10) PRIMARY KEY NOT NULL,
    Nombre NVARCHAR(100) NOT NULL,
    PrecioCompra DECIMAL(18,2) NOT NULL,
    PrecioVenta DECIMAL(18,2) NOT NULL,
    Stock INT NOT NULL,
    StockMinimo INT NOT NULL,
    FechaVencimiento DATETIME NOT NULL,
    Estado BIT NOT NULL,
    IdProveedor NVARCHAR(10) NOT NULL,
    IdCategoria NVARCHAR(10) NOT NULL,
    FOREIGN KEY (IdProveedor) REFERENCES Proveedor(IdProveedor),
    FOREIGN KEY (IdCategoria) REFERENCES Categoria(IdCategoria)
);

CREATE TABLE Compra (
    IdCompra NVARCHAR(10) PRIMARY KEY NOT NULL,
    FechaCompra DATETIME NOT NULL,
    Total DECIMAL(18,2) NOT NULL,
    IdProveedor NVARCHAR(10) NOT NULL,
    FOREIGN KEY (IdProveedor) REFERENCES Proveedor(IdProveedor)
);

CREATE TABLE DetalleCompra (
    IdDetalleCompra NVARCHAR(10) PRIMARY KEY NOT NULL,
    IdCompra NVARCHAR(10) NOT NULL,
    IdProducto NVARCHAR(10) NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(18,2) NOT NULL,
    Total DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (IdCompra) REFERENCES Compra(IdCompra),
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
);

CREATE TABLE Factura (
    IdFactura NVARCHAR(10) PRIMARY KEY NOT NULL,
    Fecha DATETIME NOT NULL,
    Subtotal DECIMAL(18,2) NOT NULL,
    Impuesto DECIMAL(18,2) NOT NULL,
    Total DECIMAL(18,2) NOT NULL,
    IdUsuario NVARCHAR(10) NOT NULL,
    IdCliente NVARCHAR(10) NOT NULL,
    FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
    FOREIGN KEY (IdCliente) REFERENCES Cliente(IdCliente)
);

CREATE TABLE DetalleFactura (
    IdDetalle NVARCHAR(10) PRIMARY KEY NOT NULL,
    IdFactura NVARCHAR(10) NOT NULL,
    IdProducto NVARCHAR(10) NOT NULL,
    Cantidad INT NOT NULL,
    PrecioUnitario DECIMAL(18,2) NOT NULL,
    Total DECIMAL(18,2) NOT NULL,
    FOREIGN KEY (IdFactura) REFERENCES Factura(IdFactura),
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
);

CREATE TABLE Movimiento (
    IdMovimiento NVARCHAR(10) PRIMARY KEY NOT NULL,
    IdProducto NVARCHAR(10) NOT NULL,
    TipoMovimiento NVARCHAR(50) NOT NULL,
    Cantidad INT NOT NULL,
    FechaMovimiento DATETIME NOT NULL,
    Observacion NVARCHAR(200) NOT NULL,
    FOREIGN KEY (IdProducto) REFERENCES Producto(IdProducto)
);
