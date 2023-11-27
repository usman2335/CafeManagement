




-- Order

-- Name is dubious??






-- Report 
create table Report(
	ReportID int identity(1,1) Primary Key, 
	Comments varchar(255),
	ReportDate varchar(255),
);

-- Vendor 
create table Vendor(
	VendorID int identity(1,1) primary key, 
	Name varchar(255),
	ContractEnd varchar(255),
	PhoneNo varchar(14),
);

-- Product 
create table Product(
	ProductID int identity(1,1) Primary Key, 
	ProductName  varchar(255),
	UnitPrice float, 
	Category varchar(255),
	VendorID int, 
	Foreign Key (VendorID) references Vendor(VendorID),
);

-- Inventory 
create table Inventory(
	InventoryID int identity(1,1) primary key, 
	Quantity int ,
	ExpiryDate varchar(255),
	Category varchar(255),
	ProductID int, 
	foreign key (ProductID) references Product(ProductID),
);



-- Menu 
create table Menu(
	MenuID int identity(1,1) primary key, 
	ItemPrice float, 
	ItemName varchar(255),
	Category varchar(255),
	ProductID int, 
	Foreign Key (ProductID) references Product(ProductID),
);


-- Expenses
create table Expenses(
		ExpensesID int identity(1,1) primary key, 
		Amount float, 
		Category varchar(255),
		Description varchar(255)
);

-- Cafe Manager Table 
create table CafeManager(
	CManagerID int identity(1,1) primary key, 
	FName varchar(255),
	LName varchar(255),
	PhoneNo varchar(14),
	username varchar(255),
	password varchar(255),
	ExpensesID int, 
	MenuID int, 
	foreign key (ExpensesID) references Expenses(ExpensesID),
	foreign key (MenuID) references Menu(MenuID),
);

-- Cashier 
create table Cashier(
	CashierID int identity(1,1) primary key, 
	FName varchar(255),
	LName varchar(255),
	PhoneNo varchar(14),
	CManagerID int, 
	username varchar(255),
	password varchar(255),
	hireDate varchar(255),
	
	Foreign Key (CManagerID) references CafeManager(CManagerID),
);



create table Orders(
	OrderID int identity(1,1) primary key, 
	Bill varchar(255),
	OrderDate varchar(255),
	Status varchar(255),
	CashierID int, 
	MenuID int, 
	Foreign Key (CashierID) references Cashier(CashierID),
	Foreign Key (MenuID) references Menu(MenuID),
);

-- Customer Table 
create table Customer(
	CustomerID int identity(1,1) primary key, 
	FName varchar(255),
	LName varchar(255),
	username varchar(255),
	password  varchar(255),
	LoyaltyPoints int, 
	RegisterationDate varchar(15),
	OrderID int,
	phoneNo varchar(255)
	foreign key (OrderID) references Orders(OrderID),
);

insert into Customer values ('test' , 'test' , 'test123', 'test123', null, null, null, '0312229487')
insert into Users values ('usman2335','admin123','Admin')

insert into CafeManager values ('Usman', 'Afzal', '03122293847' , 'usman2335','admin123',null,null)
select * from CafeManager
select * from Customer
select * from Product
select * from Users
delete from Customer
-- Payment 
create table Payment(
	PaymentID int identity(1,1) primary key, 
	Amount float, 
	PaymentMethod varchar(255),
	Tip float, 
	CustomerID int, 
	OrderID int, 
	foreign key (CustomerID) references Customer(CustomerID),
	Foreign key (OrderID) references Orders(OrderId),
);

-- Inventory Manager 
create table InventoryManager(
	InvManagerID int identity(1,1) primary key, 
	FName varchar(255),
	LName varchar(255),
	PhoneNo varchar(255),
	HireDate varchar(255),
	CManagerID int, 
	InventoryID int, 
	username varchar(255),
	password varchar(255),
	foreign key (CManagerID) references CafeManager(CManagerID),
	foreign key (InventoryID) references Inventory(InventoryID),
);

--Feedback 
create table FeedBack(
	FeedbackID int identity(1,1) Primary key, 
	FeedbackDate varchar(255),
	RatingStars int, 
	Comments varchar(255),
	OrderId int, 
	foreign key (OrderID) references Orders(OrderID),
	CustomerID int, 
	Foreign key (CustomerID) references Customer(CustomerID),
);

create table Users(
userID int identity(1,1) primary key,
username varchar(255),
password varchar(255), 
role varchar(255) not null
)

select * from users
select * from Customer
select * from Cashier

insert into CafeManager values (1, 'Usman', 'Afzal', '03470004311','usman2335','admin123',null,null)
insert into Users values (3, 'usman2335','admin123','Admin')
select * from Product




