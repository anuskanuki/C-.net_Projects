update Books
set Active=0
where Id=29

select Id, Name from Books
where Active=1