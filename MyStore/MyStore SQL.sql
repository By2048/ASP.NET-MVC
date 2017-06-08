create database MyStore
go
use MyStore

create table Category
(
	Id int identity(1,1) NOT NULL,
	Name nvarchar(100) NOT NULL,
	primary key(Id)
)

create table Product
(
	Id int identity(1,1) NOT NULL,
	Name varchar(100) NOT NULL,
	CategoryId int NOT NULL,
	Price decimal(18,2) NOT NULL,
	ImageUrl nvarchar(500) NULL,
	Description nvarchar(500) NULL,
	primary key(Id),
	foreign key(CategoryId)references Category(Id)	
)

create table Customer
(
	Id int identity(1,1) NOT NULL,
	UserName nvarchar(100) NULL,
	Password nvarchar(100) NULL,
	Email nvarchar(100) NULL,
	Balance decimal(18, 2) NULL,
	primary key(Id),
)

create table [Order]
(
	Id int identity(1,1) NOT NULL,
	CustomerId int NOT NULL,
	OrderDate datetime NOT NULL,
	Name nvarchar(100) NULL,
	Province nvarchar(100) NULL,
	City nvarchar(100) NULL,
	District nvarchar(100) NULL,
	DetailAddress nvarchar(100) NULL,
	Zip nvarchar(100) NULL,
	Phone nvarchar(100) NULL,
	GiftWrap bit NULL,
	Primary key(Id),
	Foreign key (CustomerId) references Customer(Id),
)

create table OrderDetail
(
	Id int IDENTITY(1,1) NOT NULL,
	OrderId int NULL,
	ProductId int NULL,
	Price decimal(18, 2) NULL,
	Quantity int NULL,
	Primary key(Id),
	Foreign key (OrderId) references [Order](Id),
	Foreign key (ProductId) references Product(Id),
)


insert into Category (Name) values ('Cat_1')
insert into Category (Name) values ('Cat_2')
insert into Category (Name) values ('Cat_3')
insert into Category (Name) values ('Cat_4')
insert into Category (Name) values ('Cat_5')
insert into Category (Name) values ('Cat_6')

insert into Product(Name,CategoryId,Price,ImageUrl,Description)
values ('Product_1',1,100,'..\Images\img1.jpg',NULL)
insert into Product(Name,CategoryId,Price,ImageUrl,Description)
values ('Product_2',1,200,'..\Images\img2.jpg',NULL)
insert into Product(Name,CategoryId,Price,ImageUrl,Description)
values ('Product_3',1,300,'..\Images\img3.jpg',NULL)
insert into Product(Name,CategoryId,Price,ImageUrl,Description)
values ('Product_4',2,400,'..\Images\img4.jpg',NULL)
insert into Product(Name,CategoryId,Price,ImageUrl,Description)
values ('Product_5',2,500,'..\Images\img5.jpg',NULL)
insert into Product(Name,CategoryId,Price,ImageUrl,Description)
values ('Product_6',2,600,'..\Images\img6.jpg',NULL)

insert into Customer(UserName,Password,Email,Balance)
values ('A001','123','1247079575@qq.com',100)
insert into Customer(UserName,Password,Email,Balance)
values ('A002','123','1247079575@qq.com',100)

select *from Category
select *from Product
select *from Customer
