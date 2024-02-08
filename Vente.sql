create database EMarket;
use EMarket;
create table Client 
(
  ClCode varchar(30) primary key not null,
  FirstName varchar(40) not null,
  LastName varchar(40) not null,
  Addre varchar(100) not null,
  Phone varchar(15) not null,
  Email varchar(255) Unique not null,
  City varchar(30) not null,
);
create table Categories  
(
  CatCode varchar(30) primary key not null,
  Lable varchar(30) not null,
);
create table Article  
(
  ArtCode varchar(30) primary key not null,
  Designation varchar(40)  not null,
  PU varchar(30) not null,
  QStock int not null,
  Photo image not null,
  CodeCategories varchar(30) foreign key references Categories(CatCode) not null,
);
create table Ordered  
(
  OrdNum varchar(20) primary key not null,
  OrdDate datetime not null,
  CodeCl varchar(30) foreign key references Client(ClCode) not null,
);
create table Detail   
(
  OrdNum varchar(20) foreign key references Ordered(OrdNum) not null, 
  ArtCode varchar(30) foreign key references Article(ArtCode) not null,
  OrdCount int not null,
);
create table Bill   
(
  BillNum varchar(30) primary key not null,
  BillDate datetime  not null,
  BillAmnt varchar(30) not null,
  OrdNum varchar(20) foreign key references Ordered(OrdNum) not null, 
);



