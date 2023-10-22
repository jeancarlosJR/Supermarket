use Supermarket

create table Product
(
Product_Id int identity (100000, 1) primary key,
Product_Name nvarchar (50) not null,
Product_Observation nvarchar (50) not null,

);

go 

insert into Product values ('Huevos', 'Huevos pasados' )
insert into Product values ('Guanabana', 'Guanabana vencida')

