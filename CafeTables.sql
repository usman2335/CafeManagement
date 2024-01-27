




-- Order

-- Name is dubious??






-- Report 
-- abcd
create table Report(
	ReportID int Primary Key, 
	Comments varchar(255),
	ReportDate varchar(255),
);

-- Vendor 
create table Vendor(
	VendorID int primary key, 

	--dubious name??

	Name varchar(255),
	ContractEnd varchar(255),
	PhoneNo varchar(14),
);

-- Product 
create table Product(
	ProductID int Primary Key, 
	ProductName  varchar(255),
	UnitPrice float, 
	Category varchar(255),
	VendorID int, 
	Foreign Key (VendorID) references Vendor(VendorID),
);

-- Inventory 
create table Inventory(
	InventoryID int primary key, 
	Quantity int ,
	ExpiryDate varchar(255),
	Category varchar(255),
	ProductID int, 
	foreign key (ProductID) references Product(ProductID),
);



-- Menu 
create table Menu(
	MenuID int primary key, 
	ItemPrice float, 
	ItemName varchar(255),

	-- dubious name??

	Status varchar(255),
	Category varchar(255),
	ProductID int, 
	Foreign Key (ProductID) references Product(ProductID),
);


-- Expenses
create table Expenses(
		ExpensesID int primary key, 
		Amount float, 
		Category varchar(255),

		--dubious name??

		Description varchar(255)
);

-- Cafe Manager Table 
create table CafeManager(
	CManagerID int primary key, 
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
	CashierID int primary key, 
	FName varchar(255),
	LName varchar(255),
	PhoneNo varchar(14),
	HireDate varchar(255),
	EntryTime varchar(10),
	LeavingTime varchar(10),
	CManagerID int, 
	Foreign Key (CManagerID) references CafeManager(CManagerID),
);

create table Orders(
	OrderID int primary key, 
	Bill varchar(255),
	OrderDate varchar(255),

	-- dubious name ?? 

	Status varchar(255),
	CashierID int, 
	MenuID int, 
	Foreign Key (CashierID) references Cashier(CashierID),
	Foreign Key (MenuID) references Menu(MenuID),
);

-- Customer Table 
create table Customer(
	CustomerID int primary key, 
	FName varchar(255),
	LName varchar(255),
	username varchar(255),
	password  varchar(255),
	LoyaltyPoints int, 
	RegisterationDate varchar(15),
	OrderID int, 

	-- if order name is changed change here too

	foreign key (OrderID) references Orders(OrderID),

	-- does this need a phoneNumber? 
);

-- Payment 
create table Payment(
	PaymentID int primary key, 
	Amount float, 
	PaymentMethod varchar(255),
	Tip float, 
	CustomerID int, 
	OrderID int, 
	foreign key (CustomerID) references Customer(CustomerID),

	-- Order name is turning blue why?? 

	Foreign key (OrderID) references Orders(OrderId),
);

-- Inventory Manager 
create table InventoryManager(
	InvManagerID int primary key, 
	FName varchar(255),
	LName varchar(255),
	PhoneNo varchar(255),
	HireDate varchar(255),
	CManagerID int, 
	InventoryID int, 
	foreign key (CManagerID) references CafeManager(CManagerID),
	foreign key (InventoryID) references Inventory(InventoryID),
);

--Feedback 
create table FeedBack(
	FeedbackID int Primary key, 
	FeedbackDate varchar(255),
	RatingStars int, 
	Comments varchar(255),
	OrderId int, 

	-- if order is changed then this should be changed too

	foreign key (OrderID) references Orders(OrderID),
	CustomerID int, 
	Foreign key (CustomerID) references Customer(CustomerID),
);