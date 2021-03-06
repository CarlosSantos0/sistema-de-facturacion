USE [master]
GO
/****** Object:  Database [SistemaDeFacturacion]    Script Date: 7/25/2020 3:21:13 AM ******/
CREATE DATABASE [SistemaDeFacturacion]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SistemaDeFacturacion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaDeFacturacion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'SistemaDeFacturacion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\SistemaDeFacturacion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [SistemaDeFacturacion] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SistemaDeFacturacion].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SistemaDeFacturacion] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET ARITHABORT OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [SistemaDeFacturacion] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SistemaDeFacturacion] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SistemaDeFacturacion] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET  ENABLE_BROKER 
GO
ALTER DATABASE [SistemaDeFacturacion] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SistemaDeFacturacion] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SistemaDeFacturacion] SET  MULTI_USER 
GO
ALTER DATABASE [SistemaDeFacturacion] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SistemaDeFacturacion] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SistemaDeFacturacion] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SistemaDeFacturacion] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SistemaDeFacturacion] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SistemaDeFacturacion] SET QUERY_STORE = OFF
GO
USE [SistemaDeFacturacion]
GO
/****** Object:  Table [dbo].[Categoria_Cliente]    Script Date: 7/25/2020 3:21:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria_Cliente](
	[ID] [int] IDENTITY(0,1) NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 7/25/2020 3:21:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [bigint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Telefono] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[Categoria] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Entradas]    Script Date: 7/25/2020 3:21:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Entradas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
	[Fecha] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 7/25/2020 3:21:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facturas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_Factura] [int] NOT NULL,
	[ID_Cliente] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Fecha] [date] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Importe] [decimal](10, 2) NULL,
	[Descuento] [decimal](10, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 7/25/2020 3:21:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[ID_Producto] [int] NOT NULL,
	[Cantidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Productos]    Script Date: 7/25/2020 3:21:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Productos](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Proveedores]    Script Date: 7/25/2020 3:21:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedores](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Identificacion] [bigint] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Telefono] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categoria_Cliente] ON 

INSERT [dbo].[Categoria_Cliente] ([ID], [Nombre]) VALUES (0, N'Regular')
INSERT [dbo].[Categoria_Cliente] ([ID], [Nombre]) VALUES (1, N'Premium')
SET IDENTITY_INSERT [dbo].[Categoria_Cliente] OFF
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 

INSERT [dbo].[Clientes] ([ID], [Identificacion], [Nombre], [Telefono], [Email], [Categoria]) VALUES (6, 95821426, N'Carlos Eliezel Santos Aybar', N'8099948248', N'Carlos@hotmail.com', 1)
INSERT [dbo].[Clientes] ([ID], [Identificacion], [Nombre], [Telefono], [Email], [Categoria]) VALUES (7, 8239415, N'Maria Hernandes Trinidad', N'8294909212', N'Maria@gmail.com', 0)
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Entradas] ON 

INSERT [dbo].[Entradas] ([ID], [ID_Producto], [Cantidad], [ID_Proveedor], [Fecha]) VALUES (1, 1, 10, 1, CAST(N'2020-07-25' AS Date))
INSERT [dbo].[Entradas] ([ID], [ID_Producto], [Cantidad], [ID_Proveedor], [Fecha]) VALUES (2, 4, 10, 2, CAST(N'2020-07-25' AS Date))
INSERT [dbo].[Entradas] ([ID], [ID_Producto], [Cantidad], [ID_Proveedor], [Fecha]) VALUES (3, 4, 12, 2, CAST(N'2020-07-25' AS Date))
SET IDENTITY_INSERT [dbo].[Entradas] OFF
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON 

INSERT [dbo].[Facturas] ([ID], [ID_Factura], [ID_Cliente], [ID_Producto], [Fecha], [Cantidad], [Importe], [Descuento]) VALUES (1, 1, 6, 1, CAST(N'2020-07-25' AS Date), 2, CAST(30001.98 AS Decimal(10, 2)), CAST(1500.10 AS Decimal(10, 2)))
INSERT [dbo].[Facturas] ([ID], [ID_Factura], [ID_Cliente], [ID_Producto], [Fecha], [Cantidad], [Importe], [Descuento]) VALUES (2, 2, 7, 1, CAST(N'2020-07-25' AS Date), 1, CAST(15000.99 AS Decimal(10, 2)), CAST(0.00 AS Decimal(10, 2)))
INSERT [dbo].[Facturas] ([ID], [ID_Factura], [ID_Cliente], [ID_Producto], [Fecha], [Cantidad], [Importe], [Descuento]) VALUES (3, 3, 6, 1, CAST(N'2020-07-25' AS Date), 1, CAST(15000.99 AS Decimal(10, 2)), CAST(750.05 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Facturas] OFF
GO
INSERT [dbo].[Inventario] ([ID_Producto], [Cantidad]) VALUES (1, 6)
INSERT [dbo].[Inventario] ([ID_Producto], [Cantidad]) VALUES (4, 22)
GO
SET IDENTITY_INSERT [dbo].[Productos] ON 

INSERT [dbo].[Productos] ([ID], [Nombre], [Precio]) VALUES (1, N'Iphone X', CAST(15000.99 AS Decimal(10, 2)))
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio]) VALUES (2, N'Samsung S10', CAST(22450.50 AS Decimal(10, 2)))
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio]) VALUES (3, N'Huawei P30', CAST(18450.98 AS Decimal(10, 2)))
INSERT [dbo].[Productos] ([ID], [Nombre], [Precio]) VALUES (4, N'Nokia (Edicion Especial)', CAST(50000.00 AS Decimal(10, 2)))
SET IDENTITY_INSERT [dbo].[Productos] OFF
GO
SET IDENTITY_INSERT [dbo].[Proveedores] ON 

INSERT [dbo].[Proveedores] ([ID], [Identificacion], [Nombre], [Telefono], [Email]) VALUES (1, 99984726, N'Apple ', N'8498882192', N'appleinc@gmail.com')
INSERT [dbo].[Proveedores] ([ID], [Identificacion], [Nombre], [Telefono], [Email]) VALUES (2, 82914031, N'Samsung Inc', N'8299001231', N'Samsung@Yahoo.com')
SET IDENTITY_INSERT [dbo].[Proveedores] OFF
GO
/****** Object:  Index [UQ__Clientes__D6F931E523F48B1D]    Script Date: 7/25/2020 3:21:15 AM ******/
ALTER TABLE [dbo].[Clientes] ADD UNIQUE NONCLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [UQ__Proveedo__D6F931E5E5891F8F]    Script Date: 7/25/2020 3:21:15 AM ******/
ALTER TABLE [dbo].[Proveedores] ADD UNIQUE NONCLUSTERED 
(
	[Identificacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Entradas] ADD  DEFAULT (getdate()) FOR [Fecha]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [Fk_ClienteCategoria] FOREIGN KEY([Categoria])
REFERENCES [dbo].[Categoria_Cliente] ([ID])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [Fk_ClienteCategoria]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [FK_ProductoEntrada] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [FK_ProductoEntrada]
GO
ALTER TABLE [dbo].[Entradas]  WITH CHECK ADD  CONSTRAINT [FK_ProveedorEntrada] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedores] ([ID])
GO
ALTER TABLE [dbo].[Entradas] CHECK CONSTRAINT [FK_ProveedorEntrada]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_FacturaCliente] FOREIGN KEY([ID_Cliente])
REFERENCES [dbo].[Clientes] ([ID])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_FacturaCliente]
GO
ALTER TABLE [dbo].[Facturas]  WITH CHECK ADD  CONSTRAINT [FK_FacturaProducto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID])
GO
ALTER TABLE [dbo].[Facturas] CHECK CONSTRAINT [FK_FacturaProducto]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_ProductoInventario] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Productos] ([ID])
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_ProductoInventario]
GO
/****** Object:  Trigger [dbo].[TRG_RegistrarEntrada]    Script Date: 7/25/2020 3:21:15 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[TRG_RegistrarEntrada] ON [dbo].[Entradas]
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
GO
ALTER TABLE [dbo].[Entradas] ENABLE TRIGGER [TRG_RegistrarEntrada]
GO
/****** Object:  Trigger [dbo].[TRG_RegistrarVenta]    Script Date: 7/25/2020 3:21:16 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create trigger [dbo].[TRG_RegistrarVenta] ON [dbo].[Facturas]
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
GO
ALTER TABLE [dbo].[Facturas] ENABLE TRIGGER [TRG_RegistrarVenta]
GO
USE [master]
GO
ALTER DATABASE [SistemaDeFacturacion] SET  READ_WRITE 
GO
