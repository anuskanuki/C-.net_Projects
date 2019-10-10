select * from Pedidos
select * from Clientes

SELECT * from Pedidos p
where p.ClienteId in(select c.Id from Clientes c
inner join Pedidos p on c.Id = p.ClienteId
where p.Numero in('N0000008','N0000006' ,'N0000003'))order by p.Valor desc     