CREATE TABLE Product
(
	Id int NOT NULL PRIMARY KEY,
	ProductName nvarchar(100)
)

CREATE TABLE Category
(
	Id int NOT NULL PRIMARY KEY,
	CategoryName nvarchar(100)
)

CREATE TABLE ProductCategory
(
	ProductId int NOT NULL FOREIGN KEY REFERENCES Product(Id),
	CategoryId int NOT NULL FOREIGN KEY REFERENCES Category(Id),
	PRIMARY KEY (ProductId, CategoryId)
)


SELECT p.ProductName, c.CategoryName
FROM Product p
LEFT JOIN ProductCategory pc ON p.Id = pc.ProductId
LEFT JOIN Category c ON pc.CategoryId = c.Id