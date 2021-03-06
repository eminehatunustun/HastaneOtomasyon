/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Enterprise Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [MHRS]
GO
/****** Object:  Table [dbo].[Hastane]    Script Date: 16.10.2017 06:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hastane](
	[HastaneID] [int] IDENTITY(1,1) NOT NULL,
	[HastaneAdi] [nvarchar](50) NOT NULL,
	[IlceID] [int] NOT NULL,
 CONSTRAINT [PK_Hastane] PRIMARY KEY CLUSTERED 
(
	[HastaneID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ilceler]    Script Date: 16.10.2017 06:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ilceler](
	[IlceID] [int] IDENTITY(1,1) NOT NULL,
	[IlceAdi] [nvarchar](20) NOT NULL,
	[IlID] [int] NOT NULL,
 CONSTRAINT [PK_Ilceler] PRIMARY KEY CLUSTERED 
(
	[IlceID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Iller]    Script Date: 16.10.2017 06:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Iller](
	[IlID] [int] IDENTITY(1,1) NOT NULL,
	[IlAdi] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Iller] PRIMARY KEY CLUSTERED 
(
	[IlID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Klinik]    Script Date: 16.10.2017 06:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Klinik](
	[KlinikID] [int] IDENTITY(1,1) NOT NULL,
	[KlinikAdi] [nvarchar](50) NOT NULL,
	[HastaneID] [int] NOT NULL,
 CONSTRAINT [PK_Klinik] PRIMARY KEY CLUSTERED 
(
	[KlinikID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kullanicilar]    Script Date: 16.10.2017 06:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kullanicilar](
	[KullaniciID] [int] IDENTITY(1,1) NOT NULL,
	[KullaniciTC] [nvarchar](11) NOT NULL,
	[Sifre] [nvarchar](20) NOT NULL,
	[Ad] [nvarchar](20) NOT NULL,
	[Soyad] [nvarchar](20) NOT NULL,
	[DogumTarihi] [date] NULL,
	[Cinsiyet] [bit] NOT NULL,
 CONSTRAINT [PK_Kullanicilar] PRIMARY KEY CLUSTERED 
(
	[KullaniciID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Randevular]    Script Date: 16.10.2017 06:25:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Randevular](
	[RandevuID] [int] IDENTITY(1,1) NOT NULL,
	[IlID] [int] NOT NULL,
	[IlceID] [int] NOT NULL,
	[HastaneID] [int] NOT NULL,
	[KlinikID] [int] NOT NULL,
	[RandevuSaati] [time](7) NOT NULL,
	[KullaniciID] [int] NOT NULL,
	[RandevuTarihi] [date] NOT NULL,
 CONSTRAINT [PK__Randevul__B795F36BAECEE526] PRIMARY KEY CLUSTERED 
(
	[RandevuID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Hastane] ON 

INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (2, N'Sait Çiftçi Devlet Hastanesi', 1)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (3, N'Göztepe Ağız ve Diş Sağlığı Merkezi', 3)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (4, N'Erenköy Fizik Tedavi ve Rehabilitasyon Merkezi', 3)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (5, N'Beyoğlu Göz Eğitim ve Araştırma Hastanesi', 4)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (6, N'Dr. Sadi Konuk Eğitim ve Araştırma Hastanesi', 5)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (7, N'29 Mayıs Devlet Hastenesi', 7)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (8, N'Atatürk Eğitim ve Araştırma Hastanesi', 7)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (9, N'Dr. Hulusi Alataş Elmadağ Devlet Hastanesi', 8)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (10, N'Gölbaşı Ağız ve Diş Sağlığı Merkezi', 9)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (11, N'Mudanya Devlet Hastanesi', 10)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (12, N'İnegöl Devlet Hastanesi', 11)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (13, N'İnegöl Ağız ve Diş Sağlığı Merkezi', 11)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (14, N'Dört Çelik Çocuk Hastalıkları Hastanesi', 12)
INSERT [dbo].[Hastane] ([HastaneID], [HastaneAdi], [IlceID]) VALUES (15, N'Ağız ve Diş Sağlığı Merkezi', 12)
SET IDENTITY_INSERT [dbo].[Hastane] OFF
SET IDENTITY_INSERT [dbo].[Ilceler] ON 

INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (1, N'Beşiktaş', 1)
INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (3, N'Kadıköy', 1)
INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (4, N'Beyoğlu', 1)
INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (5, N'Bakırköy', 1)
INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (7, N'Çankaya', 2)
INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (8, N'Elmadağ', 2)
INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (9, N'Gölbaşı', 2)
INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (10, N'Mudanya', 3)
INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (11, N'İnegöl', 3)
INSERT [dbo].[Ilceler] ([IlceID], [IlceAdi], [IlID]) VALUES (12, N'Nilüfer', 3)
SET IDENTITY_INSERT [dbo].[Ilceler] OFF
SET IDENTITY_INSERT [dbo].[Iller] ON 

INSERT [dbo].[Iller] ([IlID], [IlAdi]) VALUES (2, N'Ankara')
INSERT [dbo].[Iller] ([IlID], [IlAdi]) VALUES (3, N'Bursa')
INSERT [dbo].[Iller] ([IlID], [IlAdi]) VALUES (1, N'İstanbul')
SET IDENTITY_INSERT [dbo].[Iller] OFF
SET IDENTITY_INSERT [dbo].[Klinik] ON 

INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (1, N'Göz Hastalıkları', 2)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (2, N'Göğüs Hastalıkları', 2)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (3, N'Genel Cerrahi', 2)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (4, N'Ağız,Diş ve çene Cerrahisi', 3)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (5, N'Genel Diş', 3)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (6, N'Nöroloji', 5)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (7, N'Göz Hastalıkları', 5)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (9, N'Genel Cerrahi', 5)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (10, N'Göğüs Hastalıkları', 6)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (11, N'Göz Hastalıkları', 6)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (12, N'İç Hastalıkları', 6)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (13, N'Beyin ve Sinir Cerrahisi', 7)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (14, N'Çocuk Cerrahisi', 7)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (15, N'Genel Cerrahi', 7)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (16, N'Genel cerrahisi', 8)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (17, N'Göğüs Hastalıkları', 8)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (18, N'Genel Cerrahi', 9)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (20, N'Göğüs Cerrahi', 9)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (22, N'Genel Cerrahi', 10)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (23, N'Gögüs Cerrahisi', 10)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (24, N'Genel Cerrahi', 11)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (25, N'Göğüs Cerrahisi', 11)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (26, N'Diş Cerrahisi', 12)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (27, N'Göz Hastalıkları', 12)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (28, N'Nöroloji', 13)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (29, N'İç Hastalıkları', 13)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (30, N'Ortopedi', 14)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (31, N'Üroloji', 14)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (34, N'Üroloji', 15)
INSERT [dbo].[Klinik] ([KlinikID], [KlinikAdi], [HastaneID]) VALUES (35, N'Ortopedi', 15)
SET IDENTITY_INSERT [dbo].[Klinik] OFF
SET IDENTITY_INSERT [dbo].[Kullanicilar] ON 

INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciTC], [Sifre], [Ad], [Soyad], [DogumTarihi], [Cinsiyet]) VALUES (5, N'33333333333', N'77777777', N'eöm', N'ldf', CAST(N'2017-03-10' AS Date), 1)
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciTC], [Sifre], [Ad], [Soyad], [DogumTarihi], [Cinsiyet]) VALUES (11, N'55555555555', N'12345678', N'emine', N'üstün', CAST(N'2017-04-10' AS Date), 1)
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciTC], [Sifre], [Ad], [Soyad], [DogumTarihi], [Cinsiyet]) VALUES (14, N'99999999999', N'12345678', N'emine', N'üstün', CAST(N'1995-09-30' AS Date), 1)
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciTC], [Sifre], [Ad], [Soyad], [DogumTarihi], [Cinsiyet]) VALUES (15, N'77777777777', N'12345678', N'kl', N'ösdç', CAST(N'2017-10-10' AS Date), 1)
INSERT [dbo].[Kullanicilar] ([KullaniciID], [KullaniciTC], [Sifre], [Ad], [Soyad], [DogumTarihi], [Cinsiyet]) VALUES (16, N'22222222222', N'12345678', N'kl', N'ösdç', CAST(N'2017-10-10' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Kullanicilar] OFF
SET IDENTITY_INSERT [dbo].[Randevular] ON 

INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (1, 1, 3, 3, 4, CAST(N'10:00:00' AS Time), 15, CAST(N'2017-12-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (4, 3, 11, 13, 28, CAST(N'00:00:00' AS Time), 15, CAST(N'2017-11-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (6, 1, 1, 2, 1, CAST(N'08:00:00' AS Time), 15, CAST(N'2017-12-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (7, 1, 1, 2, 1, CAST(N'09:00:00' AS Time), 15, CAST(N'2017-12-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (8, 1, 1, 2, 1, CAST(N'10:00:00' AS Time), 15, CAST(N'2017-12-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (9, 1, 1, 2, 1, CAST(N'11:00:00' AS Time), 15, CAST(N'2017-12-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (10, 1, 1, 2, 1, CAST(N'12:00:00' AS Time), 15, CAST(N'2017-12-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (11, 1, 1, 2, 1, CAST(N'13:00:00' AS Time), 15, CAST(N'2017-12-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (12, 2, 8, 9, 18, CAST(N'08:00:00' AS Time), 15, CAST(N'2017-10-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (13, 2, 8, 9, 20, CAST(N'00:00:00' AS Time), 15, CAST(N'2017-11-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (14, 2, 8, 9, 20, CAST(N'08:00:00' AS Time), 15, CAST(N'2017-11-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (15, 2, 8, 9, 20, CAST(N'09:00:00' AS Time), 15, CAST(N'2017-11-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (19, 3, 10, 11, 24, CAST(N'12:00:00' AS Time), 15, CAST(N'2017-04-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (20, 3, 10, 11, 24, CAST(N'12:00:00' AS Time), 15, CAST(N'2017-12-10' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (21, 2, 8, 9, 18, CAST(N'11:00:00' AS Time), 15, CAST(N'2017-10-03' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (22, 2, 8, 9, 18, CAST(N'11:00:00' AS Time), 15, CAST(N'2017-10-21' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (23, 3, 11, 13, 29, CAST(N'00:00:00' AS Time), 15, CAST(N'2017-10-20' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (24, 3, 11, 13, 29, CAST(N'00:00:00' AS Time), 15, CAST(N'2017-10-03' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (25, 3, 11, 13, 28, CAST(N'12:00:00' AS Time), 15, CAST(N'2017-10-13' AS Date))
INSERT [dbo].[Randevular] ([RandevuID], [IlID], [IlceID], [HastaneID], [KlinikID], [RandevuSaati], [KullaniciID], [RandevuTarihi]) VALUES (26, 1, 1, 2, 1, CAST(N'08:00:00' AS Time), 15, CAST(N'2017-10-16' AS Date))
SET IDENTITY_INSERT [dbo].[Randevular] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Iller__325646C868678526]    Script Date: 16.10.2017 06:25:25 ******/
ALTER TABLE [dbo].[Iller] ADD UNIQUE NONCLUSTERED 
(
	[IlAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Kullanic__E01189C6C495E3F3]    Script Date: 16.10.2017 06:25:25 ******/
ALTER TABLE [dbo].[Kullanicilar] ADD  CONSTRAINT [UQ__Kullanic__E01189C6C495E3F3] UNIQUE NONCLUSTERED 
(
	[KullaniciTC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Hastane]  WITH CHECK ADD  CONSTRAINT [FK_Hastane_Ilceler] FOREIGN KEY([IlceID])
REFERENCES [dbo].[Ilceler] ([IlceID])
GO
ALTER TABLE [dbo].[Hastane] CHECK CONSTRAINT [FK_Hastane_Ilceler]
GO
ALTER TABLE [dbo].[Ilceler]  WITH CHECK ADD  CONSTRAINT [FK_Ilceler_Iller] FOREIGN KEY([IlID])
REFERENCES [dbo].[Iller] ([IlID])
GO
ALTER TABLE [dbo].[Ilceler] CHECK CONSTRAINT [FK_Ilceler_Iller]
GO
ALTER TABLE [dbo].[Klinik]  WITH CHECK ADD  CONSTRAINT [FK_Klinik_Hastane] FOREIGN KEY([HastaneID])
REFERENCES [dbo].[Hastane] ([HastaneID])
GO
ALTER TABLE [dbo].[Klinik] CHECK CONSTRAINT [FK_Klinik_Hastane]
GO
ALTER TABLE [dbo].[Randevular]  WITH CHECK ADD  CONSTRAINT [FK_Randevular_Hastane] FOREIGN KEY([HastaneID])
REFERENCES [dbo].[Hastane] ([HastaneID])
GO
ALTER TABLE [dbo].[Randevular] CHECK CONSTRAINT [FK_Randevular_Hastane]
GO
ALTER TABLE [dbo].[Randevular]  WITH CHECK ADD  CONSTRAINT [FK_Randevular_Ilceler] FOREIGN KEY([IlceID])
REFERENCES [dbo].[Ilceler] ([IlceID])
GO
ALTER TABLE [dbo].[Randevular] CHECK CONSTRAINT [FK_Randevular_Ilceler]
GO
ALTER TABLE [dbo].[Randevular]  WITH CHECK ADD  CONSTRAINT [FK_Randevular_Iller] FOREIGN KEY([IlID])
REFERENCES [dbo].[Iller] ([IlID])
GO
ALTER TABLE [dbo].[Randevular] CHECK CONSTRAINT [FK_Randevular_Iller]
GO
ALTER TABLE [dbo].[Randevular]  WITH CHECK ADD  CONSTRAINT [FK_Randevular_Klinik] FOREIGN KEY([KlinikID])
REFERENCES [dbo].[Klinik] ([KlinikID])
GO
ALTER TABLE [dbo].[Randevular] CHECK CONSTRAINT [FK_Randevular_Klinik]
GO
ALTER TABLE [dbo].[Randevular]  WITH CHECK ADD  CONSTRAINT [FK_Randevular_Kullanicilar] FOREIGN KEY([KullaniciID])
REFERENCES [dbo].[Kullanicilar] ([KullaniciID])
GO
ALTER TABLE [dbo].[Randevular] CHECK CONSTRAINT [FK_Randevular_Kullanicilar]
GO
