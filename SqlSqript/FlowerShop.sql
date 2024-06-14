﻿USE [master]
GO
/****** Object:  Database [FlowerShop]    Script Date: 11.06.2024 16:52:47 ******/
CREATE DATABASE [FlowerShop]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FlowerShop', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\FlowerShop.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FlowerShop_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\FlowerShop_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [FlowerShop] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FlowerShop].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FlowerShop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FlowerShop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FlowerShop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FlowerShop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FlowerShop] SET ARITHABORT OFF 
GO
ALTER DATABASE [FlowerShop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FlowerShop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FlowerShop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FlowerShop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FlowerShop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FlowerShop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FlowerShop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FlowerShop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FlowerShop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FlowerShop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FlowerShop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FlowerShop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FlowerShop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FlowerShop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FlowerShop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FlowerShop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FlowerShop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FlowerShop] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FlowerShop] SET  MULTI_USER 
GO
ALTER DATABASE [FlowerShop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FlowerShop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FlowerShop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FlowerShop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FlowerShop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FlowerShop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FlowerShop] SET QUERY_STORE = ON
GO
ALTER DATABASE [FlowerShop] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [FlowerShop]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Product_id] [int] IDENTITY(1,1) NOT NULL,
	[Product_name] [varchar](50) NOT NULL,
	[Product_unit_of_measurement] [varchar](10) NOT NULL,
	[Product_cost] [decimal](10, 2) NOT NULL,
	[Product_max_discount] [tinyint] NOT NULL,
	[Product_supplier] [varchar](100) NOT NULL,
	[Product_category] [varchar](30) NOT NULL,
	[Product_discount] [tinyint] NOT NULL,
	[Product_quantity_in_stock] [smallint] NOT NULL,
	[Product_description] [varchar](255) NOT NULL,
	[Product_photo] [varchar](20) NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewProducts]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewProducts]
AS
SELECT        Product_id AS ID, Product_name AS Название, Product_unit_of_measurement AS [Ед. измерения], Product_cost AS Стоимость, Product_max_discount AS [Макс. размер скидки], Product_supplier AS Поставщик, 
                         Product_category AS Категория, Product_discount AS [Действ. скидка], Product_quantity_in_stock AS [Кол-во на складе], Product_description AS Описание, 
                         CAST(Product_cost - Product_cost / 100 * Product_discount AS DECIMAL(10, 2)) AS [Цена со скидкой], Product_photo AS Фото
FROM            dbo.Product
GO
/****** Object:  Table [dbo].[Order_product]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_product](
	[Order_id] [int] NOT NULL,
	[Product_id] [int] NOT NULL,
	[Quantity] [smallint] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewOrderProduct]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewOrderProduct]
AS
SELECT        Order_id, Product_id AS ID, Quantity AS [Кол-во на складе]
FROM            dbo.Order_product
GO
/****** Object:  View [dbo].[ViewCount]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[ViewCount]
AS
SELECT    [Product_id] AS [ID], [Product_quantity_in_stock] AS [Кол-во на складе]
FROM      [dbo].[Product]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Order_id] [int] IDENTITY(1,1) NOT NULL,
	[Order_user_id] [int] NULL,
	[Order_date] [datetime] NULL,
	[Order_delivery_date] [datetime] NULL,
	[Order_status] [varchar](30) NULL,
	[Order_cost] [decimal](10, 2) NULL,
	[Order_adress] [varchar](100) NULL,
	[Order_discount] [tinyint] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[User_id] [int] IDENTITY(1,1) NOT NULL,
	[User_role_id] [int] NOT NULL,
	[User_surname] [varchar](30) NOT NULL,
	[User_name] [varchar](30) NOT NULL,
	[User_patronymic] [varchar](30) NOT NULL,
	[User_login] [varchar](30) NULL,
	[User_password] [varchar](15) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewOrders]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewOrders]
AS
SELECT        dbo.[Order].Order_id AS OrderId, dbo.Product.Product_name AS Наименование, dbo.Product.Product_category AS Ктегория, dbo.Order_product.Quantity AS [Кол-во], dbo.[Order].Order_date AS [Дата заказа], 
                         dbo.[Order].Order_delivery_date AS [Дата доставки], dbo.[Order].Order_status AS Статус, dbo.[Order].Order_cost AS Цена, dbo.[Order].Order_discount AS Скидка, dbo.[Order].Order_adress AS Адрес, 
                         dbo.[User].User_surname AS Фамилия, dbo.[User].User_name AS Имя, dbo.[User].User_patronymic AS Отчество
FROM            dbo.[Order] INNER JOIN
                         dbo.Order_product ON dbo.[Order].Order_id = dbo.Order_product.Order_id INNER JOIN
                         dbo.Product ON dbo.Order_product.Product_id = dbo.Product.Product_id INNER JOIN
                         dbo.[User] ON dbo.[Order].Order_user_id = dbo.[User].User_id
GO
/****** Object:  View [dbo].[ViewOrder]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewOrder]
AS
SELECT        Order_id, Order_user_id AS OrderClient, Order_date AS [Дата заказа], Order_delivery_date AS [Дата доставки], Order_status AS [Статус заказа], Order_cost AS Стоимость, Order_adress AS Адрес, 
                         Order_discount AS Скидка
FROM            dbo.[Order]
GO
/****** Object:  Table [dbo].[Delivery_guy]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Delivery_guy](
	[Delivery_guy_id] [int] IDENTITY(1,1) NOT NULL,
	[Delivery_guy_user_id] [int] NOT NULL,
 CONSTRAINT [PK_Delivery_guy] PRIMARY KEY CLUSTERED 
(
	[Delivery_guy_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_delivery_guy]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_delivery_guy](
	[Delivery_guy_id] [int] NOT NULL,
	[Order_id] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Role_id] [int] IDENTITY(1,1) NOT NULL,
	[Role_name] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Delivery_guy] ON 

INSERT [dbo].[Delivery_guy] ([Delivery_guy_id], [Delivery_guy_user_id]) VALUES (1, 4)
INSERT [dbo].[Delivery_guy] ([Delivery_guy_id], [Delivery_guy_user_id]) VALUES (2, 5)
SET IDENTITY_INSERT [dbo].[Delivery_guy] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([Order_id], [Order_user_id], [Order_date], [Order_delivery_date], [Order_status], [Order_cost], [Order_adress], [Order_discount]) VALUES (4, 1, CAST(N'2024-06-02T07:51:38.150' AS DateTime), CAST(N'2024-06-02T22:20:00.000' AS DateTime), N'В ожидании', CAST(836.70 AS Decimal(10, 2)), N'Ул, Алексеевскаяя  д, ''142''  кв, ''113''', 5)

SET IDENTITY_INSERT [dbo].[Order] OFF
GO
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (1, N'Роза Красная', N'шт.', CAST(150.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 25, 146, N'Роза красная форевер янг', N'1')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (4, N'Роза Белая', N'шт.', CAST(135.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 8, 147, N'Роза белая полар стар', N'2')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (6, N'Тюльпан белый', N'шт.', CAST(110.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 10, 200, N'Белые тюльпаны – это воплощение чистоты, невинности и изысканности. Их белоснежные лепестки, как снежные хлопья, создают ощущение свежести и легкости', N'3')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (8, N'Тюльпан розовый', N'шт.', CAST(120.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 5, 120, N'Розовые тюльпаны излучают нежность, романтику и очарование. Их мягкие оттенки розового поднимают настроение и создают атмосферу любви и радости', N'4')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (9, N'Пионы розовые', N'шт.', CAST(95.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 5, 200, N'Пионы – королевские цветы, олицетворяющие красоту, роскошь и изящество. Розовые пионы - это символ романтики, нежности и любви. Их пышные бутоны словно созданы для того, чтобы радовать глаз и наполнять сердце радостью', N'5')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (11, N'Хризантема розовая', N'шт.', CAST(70.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 20, 60, N'Хризантемы - цветы с глубоким символизмом, олицетворяющие долголетие, радость и оптимизм. Розовые хризантемы - это нежный и красивый цвет, который подходит для создания ярких и жизнерадостных композиций', N'6')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (13, N'Букет из гипсофилы', N'шт.', CAST(1650.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Букеты', 10, 10, N'Гипсофила - это нежные и легкие цветы, которые идеально подходят для создания воздушных и романтичных букетов. Их мелкие цветы создают эффект нежности и легкости, а разнообразие оттенков позволяет создавать уникальные композиции', N'7')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (15, N'Гипсофила розовая', N'шт.', CAST(50.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 5, 800, N'Гипсофила - это нежные и легкие цветы, которые идеально подходят для создания воздушных и романтичных букетов. Их мелкие цветы создают эффект нежности и легкости, а разнообразие оттенков позволяет создавать уникальные композиции', N'8')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (16, N'Рускус для украшения', N'шт.', CAST(15.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 20, 60, N'Подойдет для украшения любой вашей композиции!', N'9')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (17, N'Деревянный ящичек', N'шт.', CAST(550.00 AS Decimal(10, 2)), 50, N'FlowersPlus', N'Сопутствующие товары', 10, 5, N'Деревянный ящичект вместит в себя большую композицию и добавит ей красоты', N'10')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (18, N'Деревянные надписи для букетов', N'шт.', CAST(70.00 AS Decimal(10, 2)), 50, N'FlowersPlus', N'Сопутствующие товары', 40, 100, N'Деревянные надписи идеально впишутся в вашу цветочную композицию', N'11')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (19, N'Мягкая игрушка', N'шт.', CAST(330.00 AS Decimal(10, 2)), 50, N'FlowersPlus', N'Сопутствующие товары', 2, 40, N'Плюшевый медведь, который никого не оставит равнодушным!', N'12')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (20, N'Упаковочная лента', N'Метры', CAST(20.00 AS Decimal(10, 2)), 50, N'FlowersPlus', N'Сопутствующие товары', 10, 200, N'Дополнит цветочную композицию элегантностью и изысканностью', N'13')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (21, N'Гербера розовая', N'шт.', CAST(180.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 20, 160, N'Розовая гербера - символ радости, оптимизма и жизнерадостности. Ее яркие лепестки словно искрятся от счастья и приносят в дом атмосферу праздника', N'14')
INSERT [dbo].[Product] ([Product_id], [Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description], [Product_photo]) VALUES (22, N'Лилия белая', N'шт.', CAST(145.00 AS Decimal(10, 2)), 50, N'FantasyFlowers', N'Срезанные цветы', 10, 300, N'Белая лилия - это классический символ чистоты, элегантности и нежности. Ее изящные лепестки словно созданы для того, чтобы выразить искренние чувства и создать атмосферу утонченности', N'15')
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([Role_id], [Role_name]) VALUES (1, N'Клиент')
INSERT [dbo].[Role] ([Role_id], [Role_name]) VALUES (2, N'Доставщик')
INSERT [dbo].[Role] ([Role_id], [Role_name]) VALUES (3, N'Администратор')
INSERT [dbo].[Role] ([Role_id], [Role_name]) VALUES (4, N'Гость')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([User_id], [User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password]) VALUES (1, 1, N'Широков', N'Александр', N'Тимофеевич', N'ааа', N'ааа')
INSERT [dbo].[User] ([User_id], [User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password]) VALUES (3, 1, N'Лебедев', N'Арсений', N'Максимович', N'а', N'а')
INSERT [dbo].[User] ([User_id], [User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password]) VALUES (4, 2, N'Михайлов', N'Алексей', N'Ильич', N'ббб', N'ббб')
INSERT [dbo].[User] ([User_id], [User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password]) VALUES (5, 2, N'Козлов', N'Ярослав', N'Владиславович', N'б', N'б')
INSERT [dbo].[User] ([User_id], [User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password]) VALUES (6, 3, N'Новиков', N'Олег', N'Алексеевич', N'ввв', N'ввв')
INSERT [dbo].[User] ([User_id], [User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password]) VALUES (7, 3, N'Комаров', N'Роман', N'Владимирович', N'в', N'в')
INSERT [dbo].[User] ([User_id], [User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password]) VALUES (8, 1, N'Иванов', N'Захар', N'Васильевич', N'zzz', N'zzz')
INSERT [dbo].[User] ([User_id], [User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password]) VALUES (9, 3, N'Аксаков', N'Георгий', N'Ильич', N'ggg', N'ggg')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Delivery_guy]  WITH CHECK ADD  CONSTRAINT [FK_Delivery_guy_User] FOREIGN KEY([Delivery_guy_user_id])
REFERENCES [dbo].[User] ([User_id])
GO
ALTER TABLE [dbo].[Delivery_guy] CHECK CONSTRAINT [FK_Delivery_guy_User]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([Order_user_id])
REFERENCES [dbo].[User] ([User_id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User]
GO
ALTER TABLE [dbo].[Order_delivery_guy]  WITH CHECK ADD  CONSTRAINT [FK_Order_delivery_guy_Delivery_guy] FOREIGN KEY([Delivery_guy_id])
REFERENCES [dbo].[Delivery_guy] ([Delivery_guy_id])
GO
ALTER TABLE [dbo].[Order_delivery_guy] CHECK CONSTRAINT [FK_Order_delivery_guy_Delivery_guy]
GO
ALTER TABLE [dbo].[Order_delivery_guy]  WITH CHECK ADD  CONSTRAINT [FK_Order_delivery_guy_Order] FOREIGN KEY([Order_id])
REFERENCES [dbo].[Order] ([Order_id])
GO
ALTER TABLE [dbo].[Order_delivery_guy] CHECK CONSTRAINT [FK_Order_delivery_guy_Order]
GO
ALTER TABLE [dbo].[Order_product]  WITH CHECK ADD  CONSTRAINT [FK_Order_product_Order] FOREIGN KEY([Order_id])
REFERENCES [dbo].[Order] ([Order_id])
GO
ALTER TABLE [dbo].[Order_product] CHECK CONSTRAINT [FK_Order_product_Order]
GO
ALTER TABLE [dbo].[Order_product]  WITH CHECK ADD  CONSTRAINT [FK_Order_product_Product] FOREIGN KEY([Product_id])
REFERENCES [dbo].[Product] ([Product_id])
GO
ALTER TABLE [dbo].[Order_product] CHECK CONSTRAINT [FK_Order_product_Product]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([User_role_id])
REFERENCES [dbo].[Role] ([Role_id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
/****** Object:  StoredProcedure [dbo].[AddPhoto]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[AddPhoto]

	@ProductPhoto varchar(20),
	@ProductName varchar(50)

AS
BEGIN
	
	UPDATE dbo.Product
	SET Product_photo = @ProductPhoto
	WHERE Product_name = @ProductName
END
GO
/****** Object:  StoredProcedure [dbo].[AddProduct]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[AddProduct]

	@ProductName varchar(50),
	@ProductUnitOfMeasurement varchar(10),
	@ProductCost decimal(10, 2),
	@ProductMaxDiscount tinyint,
	@ProductSupplier varchar(100),
	@ProductCategory varchar(30),
	@ProductDiscount tinyint,
	@ProductQuantityInStock smallint,
	@ProductDescription varchar(255)

AS
BEGIN

	INSERT INTO [dbo].[Product] ([Product_name], [Product_unit_of_measurement], [Product_cost], [Product_max_discount], [Product_supplier], [Product_category], [Product_discount], [Product_quantity_in_stock], [Product_description])
	VALUES (@ProductName, @ProductUnitOfMeasurement, @ProductCost, @ProductMaxDiscount, @ProductSupplier, @ProductCategory, @ProductDiscount, @ProductQuantityInStock, @ProductDescription)
END
GO
/****** Object:  StoredProcedure [dbo].[Authorization]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Authorization] 
	
	@UserLogin varchar(30),
	@UserPassword varchar(15)

AS
BEGIN
	
	SELECT * FROM [dbo].[User] WHERE @UserLogin = [User_login] and @UserPassword = [User_password]

END
GO
/****** Object:  StoredProcedure [dbo].[DeleteProduct]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[DeleteProduct]

@ProductId int

AS
BEGIN
	DELETE 
	FROM [dbo].[ViewOrderProduct]
	WHERE [ID] = @ProductId
	DELETE 
	FROM [dbo].[ViewProducts]
	WHERE [ID] = @ProductId 
END
GO
/****** Object:  StoredProcedure [dbo].[GetCompletedOrders]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetCompletedOrders]

	@DateFrom datetime,
    @DateBefore datetime

AS
BEGIN

	SELECT [Наименование]
      ,[Ктегория]
      ,[Кол-во]
      ,[Дата заказа]
      ,[Дата доставки]
      ,[Статус]
      ,[Цена]
      ,[Скидка]
      ,[Адрес]
      ,[Фамилия]
      ,[Имя]
      ,[Отчество]
  FROM [FlowerShop].[dbo].[ViewOrders]
  WHERE [Статус] = ('Доставлено')
  AND [Дата заказа] >= @DateFrom and [Дата заказа] <= @DateBefore

END
GO
/****** Object:  StoredProcedure [dbo].[GetCurrentOrders]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetCurrentOrders]

	@DateFrom datetime,
    @DateBefore datetime

AS
BEGIN

	SELECT [Наименование]
      ,[Ктегория]
      ,[Кол-во]
      ,[Дата заказа]
      ,[Дата доставки]
      ,[Статус]
      ,[Цена]
      ,[Скидка]
      ,[Адрес]
      ,[Фамилия]
      ,[Имя]
      ,[Отчество]
  FROM [FlowerShop].[dbo].[ViewOrders]
  WHERE [Статус] IN ('В пути', 'В ожидании')
  AND [Дата заказа] >= @DateFrom and [Дата заказа] <= @DateBefore

END
GO
/****** Object:  StoredProcedure [dbo].[GetDeliveryGuyOrders]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetDeliveryGuyOrders]
    @DeliveryGuyId INT
AS
BEGIN
    SELECT 
        o.[OrderId],
        o.[Дата заказа],
        o.[Адрес],
        o.[Фамилия],
		o.[Имя],
		o.[Отчество]
    FROM dbo.ViewOrders o
    JOIN dbo.Order_delivery_guy odg ON o.OrderId = odg.Order_id
    WHERE odg.Delivery_guy_id = @DeliveryGuyId
	and [Статус] = 'В пути'
END
GO
/****** Object:  StoredProcedure [dbo].[GetDiscountLessTen]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetDiscountLessTen]
AS
BEGIN
	SELECT *
	FROM [dbo].[ViewProducts]
	WHERE [Действ. скидка] BETWEEN 0 and 9
END
GO
/****** Object:  StoredProcedure [dbo].[GetDiscountMoreTen]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetDiscountMoreTen]
AS
BEGIN
	SELECT *
	FROM [dbo].[ViewProducts]
	WHERE [Действ. скидка] >= 10
END
GO
/****** Object:  StoredProcedure [dbo].[GetHistory]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[GetHistory]

	@DateFrom datetime,
    @DateBefore datetime

AS
BEGIN

	SELECT [Наименование]
      ,[Ктегория]
      ,[Кол-во]
      ,[Дата заказа]
      ,[Дата доставки]
      ,[Статус]
      ,[Цена]
      ,[Скидка]
      ,[Адрес]
      ,[Фамилия]
      ,[Имя]
      ,[Отчество]
  FROM [FlowerShop].[dbo].[ViewOrders]
  WHERE [Дата заказа] >= @DateFrom and [Дата заказа] <= @DateBefore

END
GO
/****** Object:  StoredProcedure [dbo].[GetOrders]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetOrders]
AS
BEGIN
	
	SELECT *
	FROM dbo.ViewOrders

END
GO
/****** Object:  StoredProcedure [dbo].[GetOrdersDiscountLessTen]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[GetOrdersDiscountLessTen]
AS
BEGIN
	SELECT *
	FROM [dbo].[ViewOrders]
	WHERE [Скидка] BETWEEN 0 and 9
END
GO
/****** Object:  StoredProcedure [dbo].[GetOrdersDiscountMoreTen]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[GetOrdersDiscountMoreTen]
AS
BEGIN
	SELECT *
	FROM [dbo].[ViewOrders]
	WHERE [Скидка] >= 10
END
GO
/****** Object:  StoredProcedure [dbo].[GetProductCount]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[GetProductCount]

@count smallint,
@productId int 

AS
BEGIN
	UPDATE [dbo].[ViewCount]
	SET [Кол-во на складе] = 
	CASE 
		WHEN [Кол-во на складе] > 0 THEN [Кол-во на складе] - @count 
		ELSE [Кол-во на складе]
	END 
	WHERE [ID] = @productId
END
GO
/****** Object:  StoredProcedure [dbo].[GetProducts]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetProducts] 
AS

BEGIN
	SELECT *
	FROM [dbo].[ViewProducts]
END
GO
/****** Object:  StoredProcedure [dbo].[GetQuantityInStock]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[GetQuantityInStock]

	@ProductId int

AS
BEGIN
	
	SELECT [ID]
	FROM [dbo].[ViewCountId]
	WHERE ID = @ProductId
END
GO
/****** Object:  StoredProcedure [dbo].[InsertDeliveryGuyOrders]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertDeliveryGuyOrders]

    @DeliveryGuyId int,
	@OrderId int,
    @Status varchar(30) = 'В пути'

AS
BEGIN

    INSERT INTO [dbo].[Order_delivery_guy] ([Delivery_guy_id], [Order_id])
    VALUES (@DeliveryGuyId, @OrderId);

    UPDATE [dbo].[ViewOrders]
    SET [Статус] = @Status
    WHERE [OrderId] = @OrderId
        
END

GO
/****** Object:  StoredProcedure [dbo].[InsertOrder]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[InsertOrder]
	
	@OrderClient int,
	@OrderDate datetime,
	@OrderDeliveryDate datetime,
	@OrderCost decimal(10, 2),
	@OrderAdress varchar(100),
	@OrderDiscount tinyint

AS
BEGIN

	INSERT INTO [dbo].[ViewOrder] ([OrderClient],[Дата заказа],[Дата доставки],[Статус заказа],[Стоимость],[Адрес],[Скидка])
	OUTPUT INSERTED.[Order_id]
	VALUES (@OrderClient, @OrderDate, @OrderDeliveryDate, 'В ожидании', @OrderCost, @OrderAdress, @OrderDiscount)
END
GO
/****** Object:  StoredProcedure [dbo].[InsertOrderProduct]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[InsertOrderProduct]

	@OrderID int,
	@ProductId int,
	@Quantity smallint

AS
BEGIN

	INSERT INTO [dbo].[ViewOrderProduct] ([Order_id], [ID], [Кол-во на складе])
	VALUES (@OrderID, @ProductId, @Quantity)
END
GO
/****** Object:  StoredProcedure [dbo].[Registration]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Registration]

	@UserRoleId int = 1,
	@UserSurname varchar(30),
	@UserName varchar(30),
	@UserPatronymic varchar(30),
	@UserLogin varchar(30),
	@UserPassword varchar(15)

AS
BEGIN

INSERT INTO

	[dbo].[User] ([User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password])
	VALUES (@UserRoleId, @UserSurname, @UserName, @UserPatronymic, @UserLogin, @UserPassword)

END
GO
/****** Object:  StoredProcedure [dbo].[RegistrationWorker]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[RegistrationWorker]

	@UserRoleId int = 2,
	@UserSurname varchar(30),
	@UserName varchar(30),
	@UserPatronymic varchar(30),
	@UserLogin varchar(30),
	@UserPassword varchar(15)

AS
BEGIN

INSERT INTO

	[dbo].[User] ([User_role_id], [User_surname], [User_name], [User_patronymic], [User_login], [User_password])
	VALUES (@UserRoleId, @UserSurname, @UserName, @UserPatronymic, @UserLogin, @UserPassword)

END
GO
/****** Object:  StoredProcedure [dbo].[UpdateDiscount]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[UpdateDiscount]

@NewDiscount tinyint,
@ProductId int
AS
BEGIN
	UPDATE [dbo].[Product] 
	SET [Product_discount] = @NewDiscount
	WHERE [Product_id] = @ProductId
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateOrder]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[UpdateOrder]

@OrderId int
AS
BEGIN
	UPDATE dbo.ViewOrders
	SET [Статус] = 'Доставлено'
	WHERE [OrderId] = @OrderId
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateQuantityInStock]    Script Date: 11.06.2024 16:52:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateQuantityInStock]
	
	@ProductId int,
	@Quantity int

AS
BEGIN
	
	UPDATE [dbo].[Product]
	SET [Product_quantity_in_stock] = @Quantity
	WHERE [Product_id] = @ProductId

END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 231
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewOrder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewOrder'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Order_product"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 119
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewOrderProduct'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewOrderProduct'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Order"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 231
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "Order_product"
            Begin Extent = 
               Top = 6
               Left = 269
               Bottom = 119
               Right = 439
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Product"
            Begin Extent = 
               Top = 6
               Left = 477
               Bottom = 136
               Right = 728
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "User"
            Begin Extent = 
               Top = 120
               Left = 269
               Bottom = 250
               Right = 447
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewOrders'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewOrders'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Product"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 289
            End
            DisplayFlags = 280
            TopColumn = 7
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewProducts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewProducts'
GO
USE [master]
GO
ALTER DATABASE [FlowerShop] SET  READ_WRITE 
GO
