USE [Stive]
GO
--modif table ContenuCommandeClient
ALTER TABLE ContenuCommandeClient
ADD Ccc_Quantite int NOT NULL
GO

--modif table ContenuCommandeFournisseur /////pb impossible de mettre en non null

update ContenuCommandeFournisseur
set Ccf_Quantite = 10

ALTER TABLE ContenuCommandeFournisseur
ADD Ccf_Quantite int NOT NULL
GO



--modif table Produit
ALTER TABLE Produit
ADD Pro_IsWeb bit
GO
update Produit
set Pro_isWeb = 1

--modif table ContenuInventaire
   --renommage de la colonne CoI_Inv_Id
EXECUTE sp_rename N'dbo.ContenuInventaire.CoI_Inv_Id', N'Coi_Inv_Id', 'COLUMN'
GO
   --renommage de la colonne Coi_ProId
EXECUTE sp_rename N'dbo.ContenuInventaire.Coi_ProId', N'Coi_Pro_Id', 'COLUMN'
GO
   --rajout colonnes
ALTER TABLE ContenuInventaire
ADD Coi_Pro_Nom VARCHAR(255)
GO
ALTER TABLE ContenuInventaire
ADD Coi_Typ_Libelle VARCHAR(255)
GO
ALTER TABLE ContenuInventaire
ADD Coi_Fou_NomDomaine VARCHAR(255)
GO
ALTER TABLE ContenuInventaire
ADD Coi_Pro_Quantite int NOT NULL
GO

   --supp colonne /////////////pb   fait à la main
ALTER TABLE ContenuInventaire
DROP Coi_ProLibelle
GO
ALTER TABLE ContenuInventaire
DROP Coi_ProQuantite
GO

--modif vue contenuCommandeClient
ALTER VIEW [dbo].[View_ContenuCommandeClient]  
AS  
SELECT * from ContenuCommandeClient inner join CommandeClient on Ccc_Coc_Id = Coc_Id
					  inner join Produit  on Ccc_Pro_Id = Pro_Id
					  inner join Client on Coc_Cli_Id=Cli_Id
					  inner join Utilisateur on Cli_Uti_Id = Uti_Id
					  inner join Etat on Coc_Eta_Id=Eta_Id
			

GO

--modif vue contenuCommandeFournisseur
ALTER VIEW [dbo].[View_ContenuCommandeFournisseur]  
AS  
SELECT * from ContenuCommandeFournisseur inner join CommandeFournisseur on Ccf_Cof_Id = Cof_Id
					  inner join Produit  on Ccf_Pro_Id = Pro_Id
					  inner join Fournisseur on Cof_Fou_Id =Fou_Id
					  inner join Utilisateur on Fou_Uti_Id = Uti_Id
					  inner join Etat on Cof_Eta_Id=Eta_Id
			

GO

--modif vue contenuInventaire
ALTER VIEW [dbo].[View_ContenuInventaire]  
AS  
SELECT * from ContenuInventaire inner join Inventaire on Coi_Inv_Id = Inv_Id
GO

--modif vue Produit
ALTER VIEW [dbo].[View_Produit]  
AS  
SELECT * from Produit inner join TypeProduit on Pro_Typ_Id = Typ_Id
					  inner join Fournisseur on Pro_Fou_Id = Fou_Id
					  inner join Utilisateur on Fou_Uti_Id = Uti_Id
					  left join Image on Img_Pro_Id=Pro_Id

GO