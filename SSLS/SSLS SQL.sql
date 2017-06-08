create database  SSLS
go
use SSLS
go

--ͼ������ Category
create table Category
(
	Id			Int	identity(1,1),					--����Id
	Code		NVarchar(50)		NOT NULL,		--������룬���ڿ���¼��
	Name		NVarchar(250)		NOT NULL,		--��������
	Description	NVarchar(1000)		NULL,			--�������ϸ����
	Primary key(Id),
);   
                                    
--ͼ���Book
create table Book
(
	Id			Int identity(1,1),					--ͼ��ID
	CategoryID	Int					NOT NULL,		--�����ķ���ID	
	Code		NVarchar(50)		NOT NULL,		--ͼ����룬���ڿ���¼��
	Name		NVarchar(100)		NOT NULL,		--ͼ������
	Authors		NVarchar(100)		NOT NULL,		--ͼ����������
	Press		NVarchar(100)		NULL,			--ͼ�����������
	ImageUrl	NVarchar(1000)		NULL,			--ͼƬ�ļ����ڵ�·����->Ĭ��ͼƬ
	Description	NVarchar(2000)		NULL,			--ͼ�����ϸ����
	PublishDate	DateTime			NULL,			--��������
	Price		Decimal (20)		NULL,			--ͼ��۸�
	Status		NVarchar(100)		NULL,			--״̬δ�ڿ⡢�ڿ⡢���
	Num			Int					NULL			--ͼ������
	Primary key(Id),
	Foreign key (CategoryID) references Category(Id),
);

--���߱�Reader
create table Reader
(
	Id			Int identity(1,1),				--����Id
	Name		NVarchar(50)	NOT NULL,		--��������
	Money		Decimal (20)	NOT NULL,		--���߽��
	Class		NVarchar(50)	NULL,			--����Ȩ��
	Email		NVarchar(50)	NULL,			--��������
	Password	NVarchar(50)	NOT NULL,		--��������
	Primary key(Id),
);

create table Admin
(
	Id			Int identity(1,1),				--����Id
	Name		NVarchar(50)	NOT NULL,		--��������	
	Password	NVarchar(50)	NOT NULL,		--��������
	Primary key(Id),
);

--���ı�Borrow
create table Borrow
(
	Id	Int identity(1,1)				not null,		--����Id
	BookID				Int				not null,		--ͼ��Id
	BookName			NVarchar(50),	
	ReaderName			NVarchar(50),				
	ReaderID			Int				not null,		--����Id
	BorrowingDate		DateTime		not null,		--��������	
	ShouldReturnDate	DateTime		not null,		--Ӧ������
	ReaderReturnDate	DateTime,						--�黹����
	Renew				NVarchar(50),					--�Ƿ�����
	Primary key(Id),
	Foreign key (BookID) references Book(Id),
	Foreign key (ReaderID) references Reader(Id),		
);


--������ɱ�Fine
create table Fine
(
	Id	Int identity(1,1),					--�������Id
	BookID			int ,					--ͼ��id
	BookName		NVarchar(50) not null,	--ͼ����
	ReaderID		int	,					--����ID
	ReaderName		NVarchar(50) not null, --������
	BorrowID		Int			NOT NULL,	--����Id
	FineMoney		Decimal(20)	NOT NULL,	--������
	OverTime		Int	,					--��ʱʱ��
	FineDate		DateTime	,			--��������
	IsPay			NVarchar(50),			--�Ƿ����	
	Primary key(Id),
	Foreign key (BorrowID) references Borrow(Id),
);	

Insert into Category(Code,Name,Description) values('c1','����',NULL)
Insert into Category(Code,Name,Description) values('c2','���',NULL)
Insert into Category(Code,Name,Description) values('c3','����',NULL)
Insert into Category(Code,Name,Description) values('c4','����',NULL)
Insert into Category(Code,Name,Description) values('c5','����',NULL)
Insert into Category(Code,Name,Description) values('c6','����',NULL)
Insert into Category(Code,Name,Description) values('c7','��Ϸ',NULL)

--40
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('1','11_493239','��������','�������۷�','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('1','11_327976','��������','��С��','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('1','1_2750457','������','�������','���������',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('2','19_342974','��ҹ����','���꽭��','�ݺ�С˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('2','11_1291927','��������','����ܺڰ�','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('2','11_1616604','��ǿ�ĳ���','������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('3','11_1806098','������һ��','��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('3','11_1806098','������һ��','��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('3','11_1510954','��������','Ϊ��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('3','11_1401853','��������ͼ','��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('4','11_1806098','������һ��','��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('4','11_1510954','��������','Ϊ��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('4','11_1401853','��������ͼ','��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('5','11_1806098','������һ��','��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('5','11_1510954','��������','Ϊ��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('5','11_1401853','��������ͼ','��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('5','11_1806098','������һ��','��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('5','11_1510954','��������','Ϊ��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)
Insert into Book(CategoryID,Code,Name,Authors,Press,ImageUrl,Description,PublishDate,Price,Status,Num)
Values('5','11_1401853','��������ͼ','��������','17KС˵��',NULL,NULL,NULL,NULL,'�ڿ�',5)





Insert into Reader(Name,Money,Class,Email,Password)
Values('����2771735','100','visitor',NULL,'123')
Insert into Reader(Name,Money,Class,Email,Password)
Values('��ʱ���ռ�','100','member',NULL,'123')
Insert into Reader(Name,Money,Class,Email,Password)
Values('���û','100','author',NULL,'123')
Insert into Reader(Name,Money,Class,Email,Password)
Values('Sophie_220','100','author',NULL,'123')
Insert into Reader(Name,Money,Class,Email,Password)
Values('������','100','member',NULL,'123')
Insert into Reader(Name,Money,Class,Email,Password)
Values('A001','100','admin','1247079575@qq.com','123')
Insert into Reader(Name,Money,Class,Email,Password)
Values('A002','100','visitor','1247079575@qq.com','123')
Insert into Reader(Name,Money,Class,Email,Password)
Values('A002','100','member','1247079575@qq.com','123')

Insert into Admin(Name,Password)
Values('admin','123')
Insert into Admin(Name,Password)
Values('am','123')

-- visitor member admin author

select * from Category
select * from Reader
select * from Book
select * from Reader
select * from [Admin]
select * from Borrow
select * from Fine

--			delete Borrow
--			delete Book
--			delete Fine
--			delete Reader