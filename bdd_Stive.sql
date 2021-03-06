/****** Object:  Database [Stive]    Script Date: 22/04/2022 18:19:21 ******/
CREATE DATABASE [Stive]  (EDITION = 'Basic', SERVICE_OBJECTIVE = 'Basic', MAXSIZE = 2 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS;
GO
ALTER DATABASE [Stive] SET COMPATIBILITY_LEVEL = 130
GO
ALTER DATABASE [Stive] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Stive] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Stive] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Stive] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Stive] SET ARITHABORT OFF 
GO
ALTER DATABASE [Stive] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stive] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stive] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stive] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Stive] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stive] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Stive] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stive] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stive] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [Stive] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stive] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Stive] SET  MULTI_USER 
GO
ALTER DATABASE [Stive] SET ENCRYPTION ON
GO
ALTER DATABASE [Stive] SET QUERY_STORE = ON
GO
ALTER DATABASE [Stive] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 7), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 10, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** Les scripts des configurations délimitées à la base de données dans Azure doivent être exécutés dans la connexion à la base de données cible. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Table [dbo].[Fournisseur]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fournisseur](
	[Fou_Id] [int] IDENTITY(1,1) NOT NULL,
	[Fou_NomDomaine] [nvarchar](100) NOT NULL,
	[Fou_NomResp] [nvarchar](100) NOT NULL,
	[Fou_TelResp] [nvarchar](100) NOT NULL,
	[Fou_MailResp] [nvarchar](100) NOT NULL,
	[Fou_Fonction] [nvarchar](100) NULL,
	[Fou_DateCreation] [datetime] NOT NULL,
	[Fou_Rol_Id] [int] NOT NULL,
	[Fou_Uti_Id] [int] NOT NULL,
 CONSTRAINT [PK_Fournisseur] PRIMARY KEY CLUSTERED 
(
	[Fou_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Image]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Image](
	[Img_Id] [int] IDENTITY(1,1) NOT NULL,
	[Img_Pro_Id] [int] NOT NULL,
	[Img_Adresse] [nvarchar](500) NOT NULL,
	[Img_Nom] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Image] PRIMARY KEY CLUSTERED 
(
	[Img_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Produit]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Produit](
	[Pro_Id] [int] IDENTITY(1,1) NOT NULL,
	[Pro_Typ_Id] [int] NOT NULL,
	[Pro_Nom] [nvarchar](100) NOT NULL,
	[Pro_Ref] [nvarchar](100) NULL,
	[Pro_Fou_Id] [int] NOT NULL,
	[Pro_Cepage] [nvarchar](100) NULL,
	[Pro_Annee] [int] NULL,
	[Pro_Prix] [float] NOT NULL,
	[Pro_PrixLitre] [float] NULL,
	[Pro_SeuilAlerte] [float] NULL,
	[Pro_Quantite] [float] NOT NULL,
	[Pro_Volume] [float] NULL,
	[Pro_Description] [nvarchar](max) NULL,
	[Pro_CommandeAuto] [bit] NOT NULL,
	[Pro_IsWeb] [bit] NULL,
 CONSTRAINT [PK_Produit] PRIMARY KEY CLUSTERED 
(
	[Pro_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TypeProduit]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TypeProduit](
	[Typ_Id] [int] IDENTITY(1,1) NOT NULL,
	[Typ_Libelle] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_TypeProduit] PRIMARY KEY CLUSTERED 
(
	[Typ_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilisateur](
	[Uti_Id] [int] IDENTITY(1,1) NOT NULL,
	[Uti_Adresse] [nvarchar](500) NOT NULL,
	[Uti_CompAdresse] [nvarchar](100) NULL,
	[Uti_Cp] [nvarchar](50) NOT NULL,
	[Uti_Ville] [nvarchar](100) NOT NULL,
	[Uti_Pays] [nvarchar](100) NOT NULL,
	[Uti_TelContact] [nvarchar](50) NOT NULL,
	[Uti_Mdp] [nvarchar](500) NOT NULL,
	[Uti_VerifMdp] [nvarchar](500) NULL,
	[Uti_MailContact] [nvarchar](100) NOT NULL,
	[Uti_DateCreation] [datetime] NOT NULL,
 CONSTRAINT [PK_Utilisateur] PRIMARY KEY CLUSTERED 
(
	[Uti_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Produit]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_Produit]  
AS  
SELECT * from Produit inner join TypeProduit on Pro_Typ_Id = Typ_Id
					  inner join Fournisseur on Pro_Fou_Id = Fou_Id
					  inner join Utilisateur on Fou_Uti_Id = Uti_Id
					  left join Image on Img_Pro_Id=Pro_Id

GO
/****** Object:  Table [dbo].[Client]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[Cli_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cli_Nom] [nvarchar](500) NOT NULL,
	[Cli_Prenom] [nvarchar](100) NOT NULL,
	[Cli_DateNaissance] [datetime] NULL,
	[Cli_DateCreation] [datetime] NOT NULL,
	[Cli_Rol_Id] [int] NOT NULL,
	[Cli_Uti_Id] [int] NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[Cli_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CommandeClient]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommandeClient](
	[Coc_Id] [int] IDENTITY(1,1) NOT NULL,
	[Coc_DateCreation] [datetime] NOT NULL,
	[Coc_DateMaj] [datetime] NOT NULL,
	[Coc_Cli_Id] [int] NOT NULL,
	[Coc_Eta_Id] [int] NOT NULL,
 CONSTRAINT [PK_CommandeClient] PRIMARY KEY CLUSTERED 
(
	[Coc_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContenuCommandeClient]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContenuCommandeClient](
	[Ccc_Coc_Id] [int] NOT NULL,
	[Ccc_DateCreation] [datetime] NOT NULL,
	[Ccc_DateMaj] [datetime] NOT NULL,
	[Ccc_Pro_Id] [int] NOT NULL,
	[Ccc_Quantite] [int] NOT NULL,
 CONSTRAINT [PK_ContenuCommandeClient] PRIMARY KEY CLUSTERED 
(
	[Ccc_Coc_Id] ASC,
	[Ccc_DateCreation] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Etat]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Etat](
	[Eta_Id] [int] IDENTITY(1,1) NOT NULL,
	[Eta_Libelle] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Etat] PRIMARY KEY CLUSTERED 
(
	[Eta_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_ContenuCommandeClient]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ContenuCommandeClient]  
AS  
SELECT * from ContenuCommandeClient inner join CommandeClient on Ccc_Coc_Id = Coc_Id
					  inner join Produit  on Ccc_Pro_Id = Pro_Id
					  inner join Client on Coc_Cli_Id=Cli_Id
					  inner join Utilisateur on Cli_Uti_Id = Uti_Id
					  inner join Etat on Coc_Eta_Id=Eta_Id
			

GO
/****** Object:  Table [dbo].[CommandeFournisseur]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CommandeFournisseur](
	[Cof_Id] [int] IDENTITY(1,1) NOT NULL,
	[Cof_DateCreation] [datetime] NOT NULL,
	[Cof_DateMaj] [datetime] NOT NULL,
	[Cof_Fou_Id] [int] NOT NULL,
	[Cof_Eta_Id] [int] NOT NULL,
 CONSTRAINT [PK_CommandeFournisseur] PRIMARY KEY CLUSTERED 
(
	[Cof_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContenuCommandeFournisseur]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContenuCommandeFournisseur](
	[Ccf_Cof_Id] [int] NOT NULL,
	[Ccf_DateCreation] [datetime] NOT NULL,
	[Ccf_DateMaj] [datetime] NOT NULL,
	[Ccf_Pro_Id] [int] NOT NULL,
	[Ccf_Quantite] [int] NOT NULL,
 CONSTRAINT [PK_ContenuCommandeFournisseur] PRIMARY KEY CLUSTERED 
(
	[Ccf_Cof_Id] ASC,
	[Ccf_DateCreation] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_ContenuCommandeFournisseur]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ContenuCommandeFournisseur]  
AS  
SELECT * from ContenuCommandeFournisseur inner join CommandeFournisseur on Ccf_Cof_Id = Cof_Id
					  inner join Produit  on Ccf_Pro_Id = Pro_Id
					  inner join Fournisseur on Cof_Fou_Id =Fou_Id
					  inner join Utilisateur on Fou_Uti_Id = Uti_Id
					  inner join Etat on Cof_Eta_Id=Eta_Id
			

GO
/****** Object:  Table [dbo].[Role]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[Rol_Id] [int] IDENTITY(1,1) NOT NULL,
	[Rol_Libelle] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Rol_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_Fournisseur]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[View_Fournisseur]  
AS  
SELECT * from Fournisseur inner join Utilisateur on Fou_Uti_Id = Uti_Id
                            inner join Role on Fou_Rol_Id = Rol_Id
                    
            

GO
/****** Object:  View [dbo].[View_Client]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[View_Client]  
AS  
SELECT * from Client inner join Utilisateur on Cli_Uti_Id = Uti_Id
                            inner join Role on Cli_Rol_Id = Rol_Id
                    
            

GO
/****** Object:  View [dbo].[View_CommandeFournisseur]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[View_CommandeFournisseur]  
AS  
SELECT * from CommandeFournisseur
					  inner join Fournisseur on Cof_Fou_Id =Fou_Id
					  inner join Utilisateur on Fou_Uti_Id = Uti_Id
					  inner join Etat on Cof_Eta_Id=Eta_Id
			

GO
/****** Object:  View [dbo].[View_CommandeClient]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[View_CommandeClient]  
AS  
SELECT * from CommandeClient
					  inner join Client on Coc_Cli_Id =Cli_Id
					  inner join Utilisateur on Cli_Uti_Id = Uti_Id
					  inner join Etat on Coc_Eta_Id=Eta_Id
			

GO
/****** Object:  Table [dbo].[Inventaire]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventaire](
	[Inv_Id] [int] IDENTITY(1,1) NOT NULL,
	[Inv_DateCreation] [datetime] NOT NULL,
	[Inv_DateMaj] [datetime] NOT NULL,
	[Inv_StockRegul] [bit] NOT NULL,
 CONSTRAINT [PK_Inventaire] PRIMARY KEY CLUSTERED 
(
	[Inv_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ContenuInventaire]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ContenuInventaire](
	[Coi_Inv_Id] [int] NOT NULL,
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
/****** Object:  View [dbo].[View_ContenuInventaire]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_ContenuInventaire]  
AS  
SELECT * from ContenuInventaire inner join Inventaire on Coi_Inv_Id = Inv_Id
GO
/****** Object:  Table [dbo].[Lot]    Script Date: 22/04/2022 18:19:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lot](
	[Lot_Id] [int] IDENTITY(1,1) NOT NULL,
	[Lot_Pro_Id] [int] NOT NULL,
	[Lot_Quantite] [float] NOT NULL,
	[Lot_Volume] [float] NOT NULL,
	[Lot_Dlc] [datetime] NOT NULL,
	[Lot_DateCreation] [datetime] NOT NULL,
 CONSTRAINT [PK_Lot] PRIMARY KEY CLUSTERED 
(
	[Lot_Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Client] ADD  CONSTRAINT [DF_Client_Cli_DateCreation]  DEFAULT (getdate()) FOR [Cli_DateCreation]
GO
ALTER TABLE [dbo].[CommandeClient] ADD  CONSTRAINT [DF_CommandeClient_Coc_DateCreation]  DEFAULT (getdate()) FOR [Coc_DateCreation]
GO
ALTER TABLE [dbo].[CommandeClient] ADD  CONSTRAINT [DF_CommandeClient_Coc_DateMaj]  DEFAULT (getdate()) FOR [Coc_DateMaj]
GO
ALTER TABLE [dbo].[CommandeFournisseur] ADD  CONSTRAINT [DF_CommandeFournisseur_Cof_DateCreation]  DEFAULT (getdate()) FOR [Cof_DateCreation]
GO
ALTER TABLE [dbo].[CommandeFournisseur] ADD  CONSTRAINT [DF_CommandeFournisseur_Cof_DateMaj]  DEFAULT (getdate()) FOR [Cof_DateMaj]
GO
ALTER TABLE [dbo].[ContenuCommandeClient] ADD  CONSTRAINT [DF_ContenuCommandeClient_Ccc_DateCreation]  DEFAULT (getdate()) FOR [Ccc_DateCreation]
GO
ALTER TABLE [dbo].[ContenuCommandeClient] ADD  CONSTRAINT [DF_ContenuCommandeClient_Ccc_DateMaj]  DEFAULT (getdate()) FOR [Ccc_DateMaj]
GO
ALTER TABLE [dbo].[ContenuCommandeFournisseur] ADD  CONSTRAINT [DF_ContenuCommandeFournisseur_CoCo_DateCreation]  DEFAULT (getdate()) FOR [Ccf_DateCreation]
GO
ALTER TABLE [dbo].[ContenuCommandeFournisseur] ADD  CONSTRAINT [DF_ContenuCommandeFournisseur_CoCo_DateMaj]  DEFAULT (getdate()) FOR [Ccf_DateMaj]
GO
ALTER TABLE [dbo].[ContenuInventaire] ADD  CONSTRAINT [DF_CoI_DateCreation]  DEFAULT (getdate()) FOR [Coi_DateCreation]
GO
ALTER TABLE [dbo].[ContenuInventaire] ADD  CONSTRAINT [DF_CoI_DateMaj]  DEFAULT (getdate()) FOR [Coi_DateMaj]
GO
ALTER TABLE [dbo].[Fournisseur] ADD  CONSTRAINT [DF_Fournisseur_Fou_DateCreation]  DEFAULT (getdate()) FOR [Fou_DateCreation]
GO
ALTER TABLE [dbo].[Inventaire] ADD  CONSTRAINT [DF_Inv_DateCreation]  DEFAULT (getdate()) FOR [Inv_DateCreation]
GO
ALTER TABLE [dbo].[Inventaire] ADD  CONSTRAINT [DF_Inv_DateMaj]  DEFAULT (getdate()) FOR [Inv_DateMaj]
GO
ALTER TABLE [dbo].[Utilisateur] ADD  CONSTRAINT [DF_Utilisateur_Uti_DateCreation]  DEFAULT (getdate()) FOR [Uti_DateCreation]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Role] FOREIGN KEY([Cli_Rol_Id])
REFERENCES [dbo].[Role] ([Rol_Id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Role]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Utilisateur] FOREIGN KEY([Cli_Uti_Id])
REFERENCES [dbo].[Utilisateur] ([Uti_Id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Utilisateur]
GO
ALTER TABLE [dbo].[CommandeClient]  WITH CHECK ADD  CONSTRAINT [FK_CommandeClient_Client] FOREIGN KEY([Coc_Cli_Id])
REFERENCES [dbo].[Client] ([Cli_Id])
GO
ALTER TABLE [dbo].[CommandeClient] CHECK CONSTRAINT [FK_CommandeClient_Client]
GO
ALTER TABLE [dbo].[CommandeClient]  WITH CHECK ADD  CONSTRAINT [FK_CommandeClient_Etat] FOREIGN KEY([Coc_Eta_Id])
REFERENCES [dbo].[Etat] ([Eta_Id])
GO
ALTER TABLE [dbo].[CommandeClient] CHECK CONSTRAINT [FK_CommandeClient_Etat]
GO
ALTER TABLE [dbo].[CommandeFournisseur]  WITH CHECK ADD  CONSTRAINT [FK_CommandeFournisseur_Etat] FOREIGN KEY([Cof_Eta_Id])
REFERENCES [dbo].[Etat] ([Eta_Id])
GO
ALTER TABLE [dbo].[CommandeFournisseur] CHECK CONSTRAINT [FK_CommandeFournisseur_Etat]
GO
ALTER TABLE [dbo].[CommandeFournisseur]  WITH CHECK ADD  CONSTRAINT [FK_CommandeFournisseur_Fournisseur] FOREIGN KEY([Cof_Fou_Id])
REFERENCES [dbo].[Fournisseur] ([Fou_Id])
GO
ALTER TABLE [dbo].[CommandeFournisseur] CHECK CONSTRAINT [FK_CommandeFournisseur_Fournisseur]
GO
ALTER TABLE [dbo].[ContenuCommandeClient]  WITH CHECK ADD  CONSTRAINT [FK_ContenuCommandeClient_CommandeClient] FOREIGN KEY([Ccc_Coc_Id])
REFERENCES [dbo].[CommandeClient] ([Coc_Id])
GO
ALTER TABLE [dbo].[ContenuCommandeClient] CHECK CONSTRAINT [FK_ContenuCommandeClient_CommandeClient]
GO
ALTER TABLE [dbo].[ContenuCommandeClient]  WITH CHECK ADD  CONSTRAINT [FK_ContenuCommandeClient_Produit] FOREIGN KEY([Ccc_Pro_Id])
REFERENCES [dbo].[Produit] ([Pro_Id])
GO
ALTER TABLE [dbo].[ContenuCommandeClient] CHECK CONSTRAINT [FK_ContenuCommandeClient_Produit]
GO
ALTER TABLE [dbo].[ContenuCommandeFournisseur]  WITH CHECK ADD  CONSTRAINT [FK_ContenuCommandeFournisseur_CommandeFournisseur] FOREIGN KEY([Ccf_Cof_Id])
REFERENCES [dbo].[CommandeFournisseur] ([Cof_Id])
GO
ALTER TABLE [dbo].[ContenuCommandeFournisseur] CHECK CONSTRAINT [FK_ContenuCommandeFournisseur_CommandeFournisseur]
GO
ALTER TABLE [dbo].[ContenuCommandeFournisseur]  WITH CHECK ADD  CONSTRAINT [FK_ContenuCommandeFournisseur_Produit] FOREIGN KEY([Ccf_Pro_Id])
REFERENCES [dbo].[Produit] ([Pro_Id])
GO
ALTER TABLE [dbo].[ContenuCommandeFournisseur] CHECK CONSTRAINT [FK_ContenuCommandeFournisseur_Produit]
GO
ALTER TABLE [dbo].[ContenuInventaire]  WITH CHECK ADD  CONSTRAINT [FK_ContenuInventaire_Inventaire] FOREIGN KEY([Coi_Inv_Id])
REFERENCES [dbo].[Inventaire] ([Inv_Id])
GO
ALTER TABLE [dbo].[ContenuInventaire] CHECK CONSTRAINT [FK_ContenuInventaire_Inventaire]
GO
ALTER TABLE [dbo].[Fournisseur]  WITH CHECK ADD  CONSTRAINT [FK_Fournisseur_Role] FOREIGN KEY([Fou_Rol_Id])
REFERENCES [dbo].[Role] ([Rol_Id])
GO
ALTER TABLE [dbo].[Fournisseur] CHECK CONSTRAINT [FK_Fournisseur_Role]
GO
ALTER TABLE [dbo].[Fournisseur]  WITH CHECK ADD  CONSTRAINT [FK_Fournisseur_Utilisateur] FOREIGN KEY([Fou_Uti_Id])
REFERENCES [dbo].[Utilisateur] ([Uti_Id])
GO
ALTER TABLE [dbo].[Fournisseur] CHECK CONSTRAINT [FK_Fournisseur_Utilisateur]
GO
ALTER TABLE [dbo].[Image]  WITH CHECK ADD  CONSTRAINT [FK_Image_Produit] FOREIGN KEY([Img_Pro_Id])
REFERENCES [dbo].[Produit] ([Pro_Id])
GO
ALTER TABLE [dbo].[Image] CHECK CONSTRAINT [FK_Image_Produit]
GO
ALTER TABLE [dbo].[Lot]  WITH CHECK ADD  CONSTRAINT [FK_Lot_Produit] FOREIGN KEY([Lot_Pro_Id])
REFERENCES [dbo].[Produit] ([Pro_Id])
GO
ALTER TABLE [dbo].[Lot] CHECK CONSTRAINT [FK_Lot_Produit]
GO
ALTER TABLE [dbo].[Produit]  WITH CHECK ADD  CONSTRAINT [FK_Produit_Fournisseur] FOREIGN KEY([Pro_Fou_Id])
REFERENCES [dbo].[Fournisseur] ([Fou_Id])
GO
ALTER TABLE [dbo].[Produit] CHECK CONSTRAINT [FK_Produit_Fournisseur]
GO
ALTER TABLE [dbo].[Produit]  WITH CHECK ADD  CONSTRAINT [FK_Produit_TypeProduit] FOREIGN KEY([Pro_Typ_Id])
REFERENCES [dbo].[TypeProduit] ([Typ_Id])
GO
ALTER TABLE [dbo].[Produit] CHECK CONSTRAINT [FK_Produit_TypeProduit]
GO
ALTER DATABASE [Stive] SET  READ_WRITE 
GO
