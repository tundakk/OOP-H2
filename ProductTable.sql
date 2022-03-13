use pacm3
go
drop table product

go
 

create table product
(
productId int identity(1,1) primary key,
productName nvarchar(30),
productDescription nvarchar(100),
currentPrice decimal(10,2),
created datetime,
--role int, -- 1 admin, 3 employee, 5 customer
--inActive bit
--typeOffCustomer int -- 0 is private, 1 is business, 2 something else
)

go

insert into product values 
('Tomat','Rød og rund. De er i season',18.95, '07-02-2022'),
('Agurk','indeholder 98% vand. Frisk og god til salat og tzatziki',7.95, '07-02-2022'),
('Selleri','Børn hader den, men den er god i gryderetter og som snacks',11,95, '07-02-2022')

select * from product