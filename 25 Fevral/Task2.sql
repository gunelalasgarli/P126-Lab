create database Mark

use Mark

create table Customer(
Id int identity primary key,
Name nvarchar(200),
Shop int
)

drop table Customer

create table Seller(
Id int identity primary key,
Name nvarchar(200),
Income int
)

create table Branch(
Id int identity primary key,
Name nvarchar(200)
)

create table Trade(
Id int identity primary key,
CustomerId int foreign key references Customer(Id),
SellerId int foreign key references Seller(Id),
BranchId int foreign key references Branch(Id),
)

select Customer.Name as 'Customer Name', Seller.Name as 'Seller Name', Branch.Name as 'Branch Name', Customer.Shop, Seller.Income from Trade
inner join Customer
on Customer.Id = Trade.CustomerId
inner join Seller
on Seller.Id = Trade.SellerId
inner join Branch
on Branch.Id = Trade.BranchId
order by Income asc


---Like example
Select * from Seller
Where Income Like '2%'

Select * from Seller
Where Name Like 'a%'

