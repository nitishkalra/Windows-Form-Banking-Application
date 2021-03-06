USE [ApteanEdgeBank]
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 7/29/2020 11:36:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[AccId] [int] IDENTITY(1,1) NOT NULL,
	[balance] [decimal](18, 0) NULL,
	[IsActive] [bit] NOT NULL,
	[AccountTypeId] [int] NOT NULL,
	[CustId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[AccId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountTypes]    Script Date: 7/29/2020 11:36:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountTypes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[accountTypeName] [nvarchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Activities]    Script Date: 7/29/2020 11:36:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activities](
	[ActivityId] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [decimal](18, 0) NOT NULL,
	[TimeStamp] [datetime] NOT NULL,
	[ActivityCode] [nchar](2) NOT NULL,
	[Note] [nvarchar](200) NULL,
	[AccId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ActivityId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 7/29/2020 11:36:39 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[DateOfJoining] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Accounts] ON 

INSERT [dbo].[Accounts] ([AccId], [balance], [IsActive], [AccountTypeId], [CustId]) VALUES (1, CAST(12000 AS Decimal(18, 0)), 1, 1, NULL)
INSERT [dbo].[Accounts] ([AccId], [balance], [IsActive], [AccountTypeId], [CustId]) VALUES (2, CAST(0 AS Decimal(18, 0)), 0, 4, 1)
INSERT [dbo].[Accounts] ([AccId], [balance], [IsActive], [AccountTypeId], [CustId]) VALUES (3, CAST(0 AS Decimal(18, 0)), 0, 3, 2)
INSERT [dbo].[Accounts] ([AccId], [balance], [IsActive], [AccountTypeId], [CustId]) VALUES (4, CAST(0 AS Decimal(18, 0)), 0, 2, 1)
INSERT [dbo].[Accounts] ([AccId], [balance], [IsActive], [AccountTypeId], [CustId]) VALUES (5, CAST(2000 AS Decimal(18, 0)), 1, 4, 3)
SET IDENTITY_INSERT [dbo].[Accounts] OFF
GO
SET IDENTITY_INSERT [dbo].[AccountTypes] ON 

INSERT [dbo].[AccountTypes] ([id], [accountTypeName]) VALUES (1, N'BankAccount')
INSERT [dbo].[AccountTypes] ([id], [accountTypeName]) VALUES (2, N'TaxFree')
INSERT [dbo].[AccountTypes] ([id], [accountTypeName]) VALUES (3, N'Liability')
INSERT [dbo].[AccountTypes] ([id], [accountTypeName]) VALUES (4, N'Chequing')
SET IDENTITY_INSERT [dbo].[AccountTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Activities] ON 

INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (1, CAST(1000 AS Decimal(18, 0)), CAST(N'2020-07-29T23:25:13.560' AS DateTime), N'1 ', N'Deposited', 2)
INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (2, CAST(5000 AS Decimal(18, 0)), CAST(N'2020-07-29T23:25:26.847' AS DateTime), N'1 ', N'Deposited', 2)
INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (3, CAST(2 AS Decimal(18, 0)), CAST(N'2020-07-29T23:29:15.880' AS DateTime), N'1 ', N'Deposited', 4)
INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (4, CAST(5000 AS Decimal(18, 0)), CAST(N'2020-07-29T23:29:46.280' AS DateTime), N'2 ', N'Took Loan', 3)
INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (5, CAST(3000 AS Decimal(18, 0)), CAST(N'2020-07-29T23:29:57.817' AS DateTime), N'1 ', N'Payed Loan', 3)
INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (6, CAST(2000 AS Decimal(18, 0)), CAST(N'2020-07-29T23:30:08.090' AS DateTime), N'1 ', N'Payed Loan', 3)
INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (7, CAST(2 AS Decimal(18, 0)), CAST(N'2020-07-29T23:30:18.833' AS DateTime), N'1 ', N'Withdrawn', 4)
INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (8, CAST(6000 AS Decimal(18, 0)), CAST(N'2020-07-29T23:30:24.257' AS DateTime), N'1 ', N'Withdrawn', 2)
INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (9, CAST(5000 AS Decimal(18, 0)), CAST(N'2020-07-29T23:34:07.463' AS DateTime), N'1 ', N'Deposited', 5)
INSERT [dbo].[Activities] ([ActivityId], [Amount], [TimeStamp], [ActivityCode], [Note], [AccId]) VALUES (10, CAST(3000 AS Decimal(18, 0)), CAST(N'2020-07-29T23:34:25.527' AS DateTime), N'1 ', N'Withdrawn', 5)
SET IDENTITY_INSERT [dbo].[Activities] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustId], [Name], [IsActive], [DateOfJoining]) VALUES (1, N'Nitish Kalra', 0, CAST(N'2020-07-29T22:59:44.197' AS DateTime))
INSERT [dbo].[Customers] ([CustId], [Name], [IsActive], [DateOfJoining]) VALUES (2, N'Abcd', 0, CAST(N'2020-07-29T22:59:57.813' AS DateTime))
INSERT [dbo].[Customers] ([CustId], [Name], [IsActive], [DateOfJoining]) VALUES (3, N'Nitish', 1, CAST(N'2020-07-29T23:33:45.753' AS DateTime))
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
ALTER TABLE [dbo].[Accounts] ADD  DEFAULT ((0.0)) FOR [balance]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD FOREIGN KEY([AccountTypeId])
REFERENCES [dbo].[AccountTypes] ([id])
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD FOREIGN KEY([CustId])
REFERENCES [dbo].[Customers] ([CustId])
GO
ALTER TABLE [dbo].[Activities]  WITH CHECK ADD FOREIGN KEY([AccId])
REFERENCES [dbo].[Accounts] ([AccId])
GO
