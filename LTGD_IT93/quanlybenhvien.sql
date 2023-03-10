USE [BenhVienDB]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 02/07/2022 02:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBenhNhan] [nchar](10) NOT NULL,
	[HoTen] [nvarchar](50) NULL,
	[SoDienThoai] [varchar](50) NULL,
	[BenhLy] [nvarchar](50) NULL,
	[ChiTietBenhLy] [nvarchar](50) NULL,
 CONSTRAINT [PK_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaBenhNhan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[HoSo]    Script Date: 02/07/2022 02:52:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoSo](
	[MaHoSo] [nchar](10) NOT NULL,
	[MaBenhNhan] [nchar](10) NOT NULL,
	[MaBacSi] [nchar](10) NULL,
	[HoTenBacSi] [nvarchar](50) NULL,
	[ThongTinDieuTri] [nvarchar](50) NULL,
 CONSTRAINT [PK_HoSo] PRIMARY KEY CLUSTERED 
(
	[MaHoSo] ASC,
	[MaBenhNhan] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_HoSo_BenhNhan]    Script Date: 02/07/2022 02:52:37 ******/
ALTER TABLE [dbo].[HoSo]  WITH CHECK ADD  CONSTRAINT [FK_HoSo_BenhNhan] FOREIGN KEY([MaBenhNhan])
REFERENCES [dbo].[BenhNhan] ([MaBenhNhan])
GO
ALTER TABLE [dbo].[HoSo] CHECK CONSTRAINT [FK_HoSo_BenhNhan]
GO
