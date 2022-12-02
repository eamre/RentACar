CREATE TABLE Users (
   Id int NOT NULL IDENTITY(1,1) PRIMARY KEY,
   FirstName varchar(30),
   LastName varchar(30),
   Email varchar(80) unique,
   password varchar(30)
);

CREATE TABLE Customers (
   CustomerId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
   UserId int not null foreign key references Users(Id),
   CompanyName varchar(80),
);

CREATE TABLE Rentals (
   RentalId int NOT NULL IDENTITY(1,1) PRIMARY KEY,
   CarId int not null foreign key references Cars(Id),
   CustomerId int not null foreign key references Customers(CustomerId),
   RentDate DateTime,
   ReturnDate DateTime

);
