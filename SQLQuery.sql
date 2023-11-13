/*
������� ������� ���������
*/
CREATE TABLE Products
(
	Id int primary key,
	Name text
);
/*
������� ������� ���������
*/
CREATE TABLE Categories
(
	Id int primary key,
	Name text
);
/*
������� ������������� ������� ��������� ���������
��� ���������� ����� ������-��-������
*/
CREATE TABLE ProductCategories(
	ProductId int foreign key references Products(Id),
	CategoryId int foreign key references Categories(Id)
	primary key (ProductID, CategoryID)
);
/*
��������� ������� ���������
*/
INSERT INTO Products
VALUES
	(1, "Carrot"),
	(2, "Copybook"),
	(3, "Vacuum cleaner");
/*
��������� ������� ���������
*/
INSERT INTO Categories
VALUES
	(1, "Vegetable"),
	(2, "Food"),
	(3, "Appliances");
/*
��������� ������������� ������� ���������
*/
INSERT INTO ProductCategories
VALUES
	(1,1),
	(1,2),
	(3,3);
/*
������ ��� ������ ���� ��� ���� �������� � ��� ���������. 
*/
SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN ProductCategories
	on Products.Id = ProductCategories.ProductId
LEFT JOIN Categories
	on ProductCategories.CategoryId = Categories.Id;
