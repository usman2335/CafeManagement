create table Customer(
customerId int primary key,
firstName varchar(255),
lastName varchar(255),
username varchar(255),
password varchar(255)
)

insert into Customer(customerId,firstName,lastName,username,password)
values (1,'Usman','Afzal','usman2335','usman123');
select * from Customer

SELECT TOP 1 customerId FROM Customer ORDER BY customerId DESC

select 1 from Customer where customerId = 2