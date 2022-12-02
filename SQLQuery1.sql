create table Brands(
	BrandId int primary key identity(1,1),
	BrandName varchar(50)
)

create table Colors(
	ColorId int primary key identity(1,1),
	ColorName varchar(50)
)

create Table Cars(
	Id int primary key identity(1,1),
	BrandId int,
	ColorId int,
	FOREIGN KEY (BrandId) REFERENCES Brands(BrandId),
	FOREIGN KEY (ColorId) REFERENCES Colors(ColorId),
	ModelYear smallint,
	DailyPrice decimal,
	Descriptions nvarchar(250),
)