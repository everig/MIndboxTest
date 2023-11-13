/*
Создаем таблицу продуктов
*/
CREATE TABLE Products
(
	Id int primary key,
	Name text
);
/*
Создаем таблицу категорий
*/
CREATE TABLE Categories
(
	Id int primary key,
	Name text
);
/*
Создаем промежуточную таблицу категорий продуктов
для реализации связи многие-ко-многим
*/
CREATE TABLE ProductCategories(
	ProductId int foreign key references Products(Id),
	CategoryId int foreign key references Categories(Id)
	primary key (ProductID, CategoryID)
);
/*
Заполняем таблицу продуктов
*/
INSERT INTO Products
VALUES
	(1, "Carrot"),
	(2, "Copybook"),
	(3, "Vacuum cleaner");
/*
Заполняем таблицу категорий
*/
INSERT INTO Categories
VALUES
	(1, "Vegetable"),
	(2, "Food"),
	(3, "Appliances");
/*
Заполняем промежуточную таблицу категорий
*/
INSERT INTO ProductCategories
VALUES
	(1,1),
	(1,2),
	(3,3);
/*
Запрос для выбора всех пар «Имя продукта – Имя категории». 
*/
SELECT Products.Name, Categories.Name
FROM Products
LEFT JOIN ProductCategories
	on Products.Id = ProductCategories.ProductId
LEFT JOIN Categories
	on ProductCategories.CategoryId = Categories.Id;
