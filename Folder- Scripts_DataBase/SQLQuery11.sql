CREATE DATABASE BaseDeDadosHbsis
GO
USE BaseDeDadosHbsis
GO
CREATE TABLE [dbo].[Carros]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [NomeModelo] NCHAR(100) NULL, 
    [CodigoMarca] INT NOT NULL
)
GO
CREATE TABLE [dbo].[CarrosMarca] (
    [Id]        INT         IDENTITY (1, 1) NOT NULL,
    [Codigo]    INT         NOT NULL,
    [Descricao] NCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
CREATE TABLE [dbo].[Motos]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [NomeModelo] NCHAR(100) NULL, 
    [CodigoMarca] INT NOT NULL
)
GO
CREATE TABLE [dbo].[MotosMarca] (
    [Id]        INT         IDENTITY (1, 1) NOT NULL,
    [Codigo]    INT         NOT NULL,
    [Descricao] NCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
GO
--criando marcas de CARRO
insert into CarrosMarca
([Codigo],[Descricao])
values
(6,'Ford'),(5,'Fiat'),(10,'KIA')
GO
--criando CARROS das marcas 
insert into Carros
(CodigoMarca, NomeModelo)
values
(5,'Duna'),(6,'Bronco'),(5,'Argo'),(6,'Aspire'),(6,'Escort'),
(10,'Clarus'),(10,'Ceres'),(10,'Rio'),(10,'Picanto'),(10,'Sephia')
GO
--criando marcas de MOTO
insert into MotosMarca
([Codigo],[Descricao])
values
(5,'Kawasaki')
GO
--criando MOTOS das marcas 
insert into Motos
(CodigoMarca, NomeModelo)
values
(5,'Concours'),(5,'Ninja'),(5,'KZ'),(5,'Voyager'),(5,'Versys')
GO

--imprimindo as informações de ambas as tabelas
select * from Carros
GO
select * from Motos
GO


select 
c.NomeModelo,
m.Descricao as 'Marca'
from
Carros c inner join CarrosMarca
m on c.CodigoMarca=m.Codigo where m.Codigo=10

select 
c.NomeModelo,
m.Descricao as 'Marca'
from
Motos c inner join MotosMarca
m on c.CodigoMarca=m.Codigo where m.Codigo=5


