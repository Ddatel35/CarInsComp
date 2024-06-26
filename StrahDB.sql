USE [StrahovanieDB]
GO
/****** Object:  Table [dbo].[ContractAndClient]    Script Date: 26.06.2024 20:32:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContractAndClient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[MiddleName] [nvarchar](50) NOT NULL,
	[Number] [nvarchar](50) NOT NULL,
	[Insurance] [nvarchar](50) NOT NULL,
	[DateFirts] [date] NULL,
	[Tern] [date] NULL,
	[IncurancePayment] [nvarchar](50) NOT NULL,
	[GosNumber] [nvarchar](50) NOT NULL,
	[NameCar] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ContractAndClient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 26.06.2024 20:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 26.06.2024 20:32:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Role_ID] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ContractAndClient] ON 

INSERT [dbo].[ContractAndClient] ([id], [FirstName], [Name], [MiddleName], [Number], [Insurance], [DateFirts], [Tern], [IncurancePayment], [GosNumber], [NameCar]) VALUES (6, N'Иконников', N'Артем', N'Олегович', N'79121444996', N'ОСАГО', CAST(N'2023-05-02' AS Date), CAST(N'2023-05-24' AS Date), N'21500.00', N'е666ее', N'BMW')
INSERT [dbo].[ContractAndClient] ([id], [FirstName], [Name], [MiddleName], [Number], [Insurance], [DateFirts], [Tern], [IncurancePayment], [GosNumber], [NameCar]) VALUES (7, N'Шуметов', N'Максим', N'Сергеевич', N'89123664698', N'КАСКО', CAST(N'2024-06-05' AS Date), CAST(N'2024-11-01' AS Date), N'50000', N'а999аа', N'Lada')
SET IDENTITY_INSERT [dbo].[ContractAndClient] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([ID], [Name]) VALUES (1, N'Администратор')
INSERT [dbo].[Roles] ([ID], [Name]) VALUES (2, N'Пользователь')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([id], [Login], [Password], [Role_ID]) VALUES (1, N'admin', N'admin', 1)
INSERT [dbo].[User] ([id], [Login], [Password], [Role_ID]) VALUES (2, N'danil', N'123', 2)
INSERT [dbo].[User] ([id], [Login], [Password], [Role_ID]) VALUES (1003, N'maksim', N'123', 1)
INSERT [dbo].[User] ([id], [Login], [Password], [Role_ID]) VALUES (1004, N'artem', N'123', 1)
INSERT [dbo].[User] ([id], [Login], [Password], [Role_ID]) VALUES (1005, N'1', N'1', 1)
INSERT [dbo].[User] ([id], [Login], [Password], [Role_ID]) VALUES (1006, N'2', N'2', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Roles] FOREIGN KEY([Role_ID])
REFERENCES [dbo].[Roles] ([ID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Roles]
GO
