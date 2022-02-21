ALTER TABLE [dbo].[ContenuInventaire] DROP CONSTRAINT [FK_ContenuInventaire_Inventaire]
GO

ALTER TABLE [dbo].[ContenuInventaire] DROP CONSTRAINT [DF_Coi_ProQuantite]
GO

ALTER TABLE [dbo].[ContenuInventaire] DROP CONSTRAINT [DF_CoI_DateMaj]
GO

ALTER TABLE [dbo].[ContenuInventaire] DROP CONSTRAINT [DF_CoI_DateCreation]
GO

/****** Object:  Table [dbo].[ContenuInventaire]    Script Date: 21/02/2022 11:26:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ContenuInventaire]') AND type in (N'U'))
DROP TABLE [dbo].[ContenuInventaire]
GO

/****** Object:  Table [dbo].[ContenuInventaire]    Script Date: 21/02/2022 11:26:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ContenuInventaire](
	[CoI_Inv_Id] [int] IDENTITY(1,1) NOT NULL,
	[Coi_DateCreation] [datetime] NOT NULL,
	[Coi_DateMaj] [datetime] NOT NULL,
	[Coi_ProId] [int] NOT NULL,
	[Coi_ProLibelle] [int] NOT NULL,
	[Coi_ProQuantite] [int] NOT NULL,
	[Coi_Inventaire] [int] NOT NULL,
 CONSTRAINT [PK_ContenuInventaire] PRIMARY KEY CLUSTERED 
(
	[CoI_Inv_Id] ASC,
	[Coi_ProId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[ContenuInventaire] ADD  CONSTRAINT [DF_CoI_DateCreation]  DEFAULT (getdate()) FOR [Coi_DateCreation]
GO

ALTER TABLE [dbo].[ContenuInventaire] ADD  CONSTRAINT [DF_CoI_DateMaj]  DEFAULT (getdate()) FOR [Coi_DateMaj]
GO

ALTER TABLE [dbo].[ContenuInventaire] ADD  CONSTRAINT [DF_Coi_ProQuantite]  DEFAULT ((0)) FOR [Coi_ProQuantite]
GO

ALTER TABLE [dbo].[ContenuInventaire]  WITH CHECK ADD  CONSTRAINT [FK_ContenuInventaire_Inventaire] FOREIGN KEY([CoI_Inv_Id])
REFERENCES [dbo].[Inventaire] ([Inv_Id])
GO

ALTER TABLE [dbo].[ContenuInventaire] CHECK CONSTRAINT [FK_ContenuInventaire_Inventaire]
GO


