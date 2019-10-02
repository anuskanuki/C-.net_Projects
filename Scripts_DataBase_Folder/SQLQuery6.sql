INSERT INTO Clientes
VALUES
('Gabriela',0,75,1,3,3,'10/02/2019','10/02/2019'),
('Anuska',1,20,1,3,3,'10/02/2019','10/02/2019'),
('Guilherme',0,22,1,3,3,'10/02/2019','10/02/2019')

select * from Clientes


INSERT INTO Pedidos(Numero,ClienteId,Valor)
values
('N0000002',4,39.00),('N0000003',4,800.67),('N0000004',4,40.15)

INSERT INTO Pedidos(Numero,ClienteId,Valor)
values
('N0000005',5,780.54),('N0000006',5,543.46),('N0000007',5,100.88)

INSERT INTO Pedidos(Numero,ClienteId,Valor)
values
('N0000008',6,35.97),('N0000009',6,957.46),('N0000010',6,87.45)


update  Clientes
set Nome = 'Daniel' , Idade = 40
where Id=4

select * from Pedidos

select *from Pedidos
where ClienteId=4


select 
c.Nome as 'Cliente',
p.Numero as 'Numero do pedido',
p.Valor
from Pedidos p inner join Clientes 
c on p.ClienteId=c.Id order by Cliente asc--where c.Id=4


select p.ClienteId as 'Id Cliente', 
C.NOME as 'Nome Cliente', 
SUM(Valor) as 'Valor Total' 
from Pedidos
p inner join Clientes 
c on p.ClienteId=c.Id
--where c.id = 5
group by p.ClienteId, C.Nome








