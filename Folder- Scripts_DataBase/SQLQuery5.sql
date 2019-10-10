select 
car.Model,--column from Cars table, named model 
bra.Name,--column from Brands (Name space) table
car.Plate,--column from Cars (the column name is plates) table
car.Year--same thing
from --to select a table to work on
Cars --selected table
car--just a name, could be "avocado", like a instance
inner --indicates that both tables must be connected with the data
join--to join both tables 
Brands bra --same from cars
on--to show how to relate those infos
car.BrandCode=bra.Code--we informed that cars have the same code at brands, so, the brands reference
--would be the code column and by that, he brings the row who contains this reference
--and we can use all those row columns with info


select car.Model,
bra.Name,car.Plate,car.Year from Cars car inner join Brands bra 
on car.BrandCode=bra.Code