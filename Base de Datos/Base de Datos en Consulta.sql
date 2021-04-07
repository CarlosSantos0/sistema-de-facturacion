-- Creacion De Base De Datos SistemaDeFacturacion
create database SistemaDeFacturacion
go
use SistemaDeFacturacion
go
--Creacion de Tablas
create table Categoria_Cliente (ID int identity(0,1) primary key, Nombre varchar(40) not null)

create table Productos (ID int identity (1,1) primary key, Nombre Varchar(50) not null, Precio Decimal(10,2) not null )

create table Proveedores (ID int identity (1,1) primary key, Identificacion bigint unique not null, Nombre varchar(50) not null, Telefono varchar(10), Email varchar(50))

create table Clientes (ID int identity(1,1) primary key, Identificacion bigint unique not null, Nombre Varchar(50) not null, Telefono varchar(10), Email varchar(50), Categoria int, constraint Fk_ClienteCategoria foreign key (Categoria) references Categoria_Cliente(ID))

create table Entradas (ID int identity (1,1) primary key, ID_Producto int not null, Cantidad int not null, ID_Proveedor int not null, Fecha date default getdate(), constraint FK_ProductoEntrada foreign key (ID_Producto) references Productos(ID),
constraint FK_ProveedorEntrada foreign key (ID_Proveedor) references Proveedores(ID))

Create table Inventario (ID_Producto int primary key, Cantidad int, constraint FK_ProductoInventario foreign key (ID_Producto) references Productos(ID))

Create table Facturas (ID int identity (1,1) primary key, ID_Factura int not null, ID_Cliente int not null, ID_Producto int not null, 
Fecha date not null, Cantidad int not null, Importe Decimal(10,2), Descuento Decimal(10,2), constraint FK_FacturaCliente foreign key(ID_Cliente) references Clientes(ID),
 constraint FK_FacturaProducto foreign key(ID_Producto) references Productos(ID) )

--Creacion de TRIGGERS

-- Triger 01
Create trigger TRG_RegistrarEntrada ON Entradas
AFTER INSERT
as
  begin
     declare @ID int
     declare @ID_Producto int
     declare @Cantidad int

	 select @ID_Producto = ID_Producto , @Cantidad = Cantidad 
	 from inserted

	 declare c_datos  cursor for
	 select '' from Inventario where ID_Producto = @ID_Producto

	 open c_datos
	 fetch next from c_datos into @ID

	 if @@FETCH_STATUS = 0
	 begin
	      Update Inventario set Cantidad = Cantidad + @Cantidad
		  where ID_Producto = @ID_Producto
	 end
	   else
	     begin
	        Insert into Inventario values (@ID_Producto, @Cantidad)
	      end
close c_datos
deallocate c_datos

 end

 -- Trigger 02

 Create trigger TRG_RegistrarVenta ON Facturas
AFTER INSERT
as
  begin
     declare @ID_Producto int
     declare @Cantidad int

	 select @ID_Producto = ID_Producto , @Cantidad = Cantidad 
	 from inserted

    Update Inventario set Cantidad = Cantidad - @Cantidad
		  where ID_Producto = @ID_Producto
 end


 insert into Categoria_Cliente values ('Regular'),('Premium')

