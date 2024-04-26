use master
go
create database Supply
go

USE [Supply]
GO
/****** Object:  Table [dbo].[Item]    Script Date: 04.04.2022 13:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Item](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Manufacturer] [varchar](50) NOT NULL,
	[Price] [money] NOT NULL,
 CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 04.04.2022 13:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[Id] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Phone] [varchar](17) NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supply]    Script Date: 04.04.2022 13:15:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supply](
	[Supplier] [int] NOT NULL,
	[Item] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Volume] [int] NULL,
 CONSTRAINT [PK_Supply] PRIMARY KEY CLUSTERED 
(
	[Supplier] ASC,
	[Item] ASC,
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Item] ([ID], [Name], [Manufacturer], [Price]) VALUES (1, N'Ложка', N'Леруа Мерлен', 10.0000)
GO
INSERT [dbo].[Item] ([ID], [Name], [Manufacturer], [Price]) VALUES (2, N'Вилка', N'Вилочный завод', 50.0000)
GO
INSERT [dbo].[Item] ([ID], [Name], [Manufacturer], [Price]) VALUES (3, N'Нож', N'Ножи от Семёна', 30.0000)
GO
INSERT [dbo].[Item] ([ID], [Name], [Manufacturer], [Price]) VALUES (4, N'Тарелка', N'Мир керамики', 50.0000)
GO
INSERT [dbo].[Item] ([ID], [Name], [Manufacturer], [Price]) VALUES (5, N'Кружка', N'Апельсин', 100.0000)
GO
INSERT [dbo].[Supplier] ([ID], [Name], [Address], [Phone]) VALUES (1, N'Иванов', N'Рязань', N'465825')
GO
INSERT [dbo].[Supplier] ([ID], [Name], [Address], [Phone]) VALUES (2, N'Петров', N'Рязань', N'592625')
GO
INSERT [dbo].[Supplier] ([ID], [Name], [Address], [Phone]) VALUES (3, N'Сидоров', N'Рязань', N'482625')
GO
INSERT [dbo].[Supplier] ([ID], [Name], [Address], [Phone]) VALUES (4, N'Кузнецов', N'Рязань', N'201736')
GO
INSERT [dbo].[Supply] ([Supplier], [Item], [Date], [Volume]) VALUES (1, 1, CAST(N'2020-09-10' AS Date), 100)
GO
INSERT [dbo].[Supply] ([Supplier], [Item], [Date], [Volume]) VALUES (1, 2, CAST(N'2020-10-12' AS Date), 200)
GO
INSERT [dbo].[Supply] ([Supplier], [Item], [Date], [Volume]) VALUES (1, 3, CAST(N'2020-11-14' AS Date), 300)
GO
INSERT [dbo].[Supply] ([Supplier], [Item], [Date], [Volume]) VALUES (1, 4, CAST(N'2020-09-11' AS Date), 500)
GO
INSERT [dbo].[Supply] ([Supplier], [Item], [Date], [Volume]) VALUES (2, 1, CAST(N'2020-09-20' AS Date), 150)
GO
INSERT [dbo].[Supply] ([Supplier], [Item], [Date], [Volume]) VALUES (2, 2, CAST(N'2020-09-21' AS Date), 250)
GO
INSERT [dbo].[Supply] ([Supplier], [Item], [Date], [Volume]) VALUES (2, 3, CAST(N'2020-01-01' AS Date), 100)
GO
INSERT [dbo].[Supply] ([Supplier], [Item], [Date], [Volume]) VALUES (3, 1, CAST(N'2020-12-30' AS Date), 1000)
GO
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_Supply_Supplier] FOREIGN KEY([Supplier])
REFERENCES [dbo].[Supplier] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_Supply_Supplier]
GO
ALTER TABLE [dbo].[Supply]  WITH CHECK ADD  CONSTRAINT [FK_Supply_Item] FOREIGN KEY([Item])
REFERENCES [dbo].[Item] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Supply] CHECK CONSTRAINT [FK_Supply_Item]
GO
