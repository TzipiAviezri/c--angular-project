create database finalAngularDb
use finalAngularDb
create table category
(
id smallInt primary key IDentity(1,1)
,nameCategory varchar(20)
)
create table products(
productId smallInt primary key  idEntity(1,1),
productName varchar(20),
idCategory smallInt,
price smallInt,
img varchar(30),
color varchar(30),
amount smallInt)

create table customer(
cusId smallInt primary key  idEntity(1,1),

cusName varchar(20),
cusCard varchar(50))
create table shoping(
shopingId smallInt primary key  idEntity(1,1),
customerId smallint foreign key References customer(cusId),
shopingDate date,
shopingSum smallint)
create table details(
detailsId smallInt primary key  idEntity(1,1),
shopingId smallint foreign key References shoping(shopingId),
productId smallint foreign key References products(productId),
amount smallInt
)


