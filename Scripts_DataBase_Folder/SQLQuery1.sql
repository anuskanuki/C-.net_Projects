CREATE DATABASE BaseDeDadosHbsis
GO
USE BaseDeDadosHbsis
GO
CREATE TABLE [dbo].[Marcas] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [Codigo]     INT           NULL,
    [Nome]       NVARCHAR (20) NULL,
    [TipoCodigo] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Tipos] (
    [Id]     INT           IDENTITY (1, 1) NOT NULL,
    [Codigo] INT           NULL,
    [Nome]   NVARCHAR (20) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Veiculos] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Descricao]   NVARCHAR (30) NULL,
    [MarcaCodigo] INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


INSERT INTO Tipos values
(1,'Carro'),(2,'Moto')
GO
INSERT INTO Marcas values (1,'BMW',1),(2,'BMW',2), (3,'KIA',1),(4,'KAWASAKI',2)
GO
INSERT INTO Veiculos values('M6',1),('R 1200',2),('Besta',3),('Sportage',3),('Z 1000',4),('Z 900',4)



--selecionar que quero moto
select * from Tipos
--selecionar a marca que quero
select * from Marcas
--exibir as motos que quero q estao na tabela veiculos
select * from Veiculos

--select super bonus
select 
vei.Id,
vei.Descricao,
mar.Nome as 'Marca',
tip.Nome as 'Tipo'
from Veiculos vei  inner join Marcas mar
on vei.MarcaCodigo=mar.Codigo
inner join Tipos tip on mar.TipoCodigo=tip.Codigo
where mar.Codigo=4

--select super bonus
select 
vei.Id,
vei.Descricao,
mar.Nome as 'Marca',
tip.Nome as 'Tipo'
from Veiculos vei  inner join Marcas mar
on vei.MarcaCodigo=mar.Codigo
inner join Tipos tip on mar.TipoCodigo=tip.Codigo
where mar.Codigo=3