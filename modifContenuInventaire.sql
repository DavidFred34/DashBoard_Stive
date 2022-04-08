ALTER TABLE [dbo].[ContenuInventaire] DROP CONSTRAINT [FK_ContenuInventaire_Inventaire]
GO

ALTER TABLE [dbo].[ContenuInventaire] DROP CONSTRAINT [DF_CoI_DateMaj]
GO

ALTER TABLE [dbo].[ContenuInventaire] DROP CONSTRAINT [DF_CoI_DateCreation]
GO

/****** Object:  Table [dbo].[ContenuInventaire]    Script Date: 29/03/2022 21:13:52 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContenuInventaire]') AND type in (N'U'))
DROP TABLE [dbo].[ContenuInventaire]
GO

/****** Object:  Table [dbo].[ContenuInventaire]    Script Date: 29/03/2022 21:13:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ContenuInventaire](
	[Coi_Inv_Id] [int] IDENTITY(1,1) NOT NULL,
	[Coi_DateCreation] [datetime] NOT NULL,
	[Coi_DateMaj] [datetime] NOT NULL,
	[Coi_Pro_Id] [int] NOT NULL,
	[Coi_Inventaire] [int] NULL,
	[Coi_Pro_Nom] [varchar](255) NULL,
	[Coi_Typ_Libelle] [varchar](255) NULL,
	[Coi_Fou_NomDomaine] [varchar](255) NULL,
	[Coi_Pro_Quantite] [int] NOT NULL,
 CONSTRAINT [PK_ContenuInventaire] PRIMARY KEY CLUSTERED 
(
	[Coi_Inv_Id] ASC,
	[Coi_Pro_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ContenuInventaire] ADD  CONSTRAINT [DF_CoI_DateCreation]  DEFAULT (getdate()) FOR [Coi_DateCreation]
GO

ALTER TABLE [dbo].[ContenuInventaire] ADD  CONSTRAINT [DF_CoI_DateMaj]  DEFAULT (getdate()) FOR [Coi_DateMaj]
GO

ALTER TABLE [dbo].[ContenuInventaire]  WITH CHECK ADD  CONSTRAINT [FK_ContenuInventaire_Inventaire] FOREIGN KEY([Coi_Inv_Id])
REFERENCES [dbo].[Inventaire] ([Inv_Id])
GO

ALTER TABLE [dbo].[ContenuInventaire] CHECK CONSTRAINT [FK_ContenuInventaire_Inventaire]
GO


