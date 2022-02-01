insert into Utilisateur values ('square des pins','banc numero4','31000','toulouse','france',
                               '0145852325','123','123','b@a.fr',GETDATE())

select * from utilisateur
select * from Role
select *from fournisseur
select * from View_Fournisseur

update Fournisseur
set Fou_Uti_Id=11 where Fou_Id =3

insert into Fournisseur values ('Les vins du sud','Durand','0201212523','cc@a.fr','Directeur',
                               GETDATE(),3,12)