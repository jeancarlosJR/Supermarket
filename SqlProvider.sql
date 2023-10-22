use Supermarket

create table Provider 

(

Provider_Id int identity (100000, 1) primary key,
Provider_Name nvarchar (50) not null,
Provider_Observation nvarchar (50) not null,
)

go

insert into Provider values ('Nutriavicola', 'Empresa Nacional')
insert into Provider values ('Quest', 'Empresa de Ropa') 
