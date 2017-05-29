USE NORTHWND

-- task-1 - Create table Cities with (CityId, Name)

CREATE TABLE Cities
(
	CityId INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(15)
)

-- task-2 - Insert into Cities all the Cities from Employees, Suppliers, Customers tables (RESULT: 95 row(s) affected)

INSERT INTO Cities
	SELECT City FROM Employees 
		UNION
	SELECT City FROM Suppliers 
		UNION
	SELECT City FROM Customers  

-- task-3 - Add CityId into Employees, Suppliers, Customers tables which is Foreign Key to CityId in Cities

ALTER TABLE Employees 
	ADD CityId INT FOREIGN KEY REFERENCES Cities(CityId)

ALTER TABLE Suppliers
	ADD CityId INT FOREIGN KEY REFERENCES Cities(CityId)

ALTER TABLE Customers 
	ADD CityId INT FOREIGN KEY REFERENCES Cities(CityId)

-- task-4 - Update Employees, Suppliers, Customers tables with CityId which is in the Cities table

	-- Employees (RESULT: 9 row(s) affected)

	-- Suppliers (RESULT: 29 row(s) affected)

	-- Customers (RESULT: 91 row(s) affected)

UPDATE Employees 
SET CityId = c.CityId
FROM (
	SELECT CityId, Name 
	FROM Cities) c
WHERE c.Name= Employees.City

UPDATE Suppliers 
SET CityId = c.CityId
FROM (
	SELECT CityId, Name 
	FROM Cities) c
WHERE c.Name =Suppliers.City

UPDATE Customers 
SET CityId = c.CityId
FROM (
	SELECT CityId, Name 
	FROM Cities) c
WHERE c.Name= Customers.City

-- task-5 - Make the column Name in Cities Unique

ALTER TABLE Cities
ADD CONSTRAINT Unique_Name UNIQUE(Name)

-- task-6 - Now after looking at the database again we found there are Cities (ShipCity) in the Orders table as well :D (always read before start coding).
	-- Insert those cities please. (RESULT: 1 row(s) affected)

INSERT INTO Cities(Name)
	 SELECT DISTINCT ShipCity 
	 FROM Orders WHERE ShipCity NOT IN(SELECT Name FROM Cities)

-- task-7 - Add CityId column in Orders with Foreign Key to CityId in Cities

ALTER TABLE Employees 
	ADD CityId INT FOREIGN KEY REFERENCES Cities(CityId)

-- task-8 - Now rename that column to be ShipCityId to be consistent (use stored procedure :) )

EXEC sp_RENAME 'Orders.CityId' , 'ShipCityId', 'COLUMN'

-- task-9 - Update ShipCityId in Orders table with values from Cities table (RESULT: 830 row(s) affected)

UPDATE Orders
SET Orders.ShipCityId = c.CityId
FROM
	( 
	SELECT CityId, Name
	FROM Cities) c
WHERE c.Name = Orders.ShipCity

-- task-10 - Create table Countries with columns CountryId and Name (Unique)

ALTER TABLE Orders
	DROP COLUMN ShipCity

-- task-11 - Add CountryId to Cities with Foreign Key to CountryId in Countries
CREATE TABLE Countries
(
	CountryId INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(15) UNIQUE
)
------second way------
CREATE TABLE dbo.Countries
(
	CountryId INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(20) CONSTRAINT Uni_Name UNIQUE(Name)
	
)

-- task-12 - Insert all the Countries from Employees, Customers, Suppliers and Orders (RESULT: 25 row(s) affected)

ALTER TABLE Cities 
	ADD CountryId INT FOREIGN KEY REFERENCES Countries(CountryId)

-- task-13 - Update CountryId in Cities table with values from Countries table

INSERT INTO Countries(Name) 
	SELECT Country FROM Employees WHERE Country IS NOT NULL
		UNION
	SELECT Country FROM Customers WHERE Country IS NOT NULL
		UNION
	SELECT Country FROM Suppliers WHERE Country IS NOT NULL
		UNION
	SELECT ShipCountry FROM Orders WHERE ShipCountry IS NOT NULL

-- task-14 - Drop column City and ShipCity from Employees, Suppliers, Customers and Orders tables

UPDATE Cities
SET Cities.CountryId = CitiesInCountries.CountryId
FROM (
		(SELECT DISTINCT UnionCountries.CityId,
						 UnionCountries.Country,
						 Countries.CountryId 
		FROM 
			(SELECT Country, CityId 
				FROM Employees 
				WHERE CityId IS NOT NULL 
			UNION 
			SELECT Country, CityId 
				FROM Suppliers 
				WHERE CityId IS NOT NULL 
			UNION 
			SELECT Country, CityId 
				FROM Customers 
				WHERE CityId IS NOT NULL 
			UNION 
			SELECT ShipCountry, ShipCityId 
				FROM Orders 
				WHERE ShipCityId IS NOT NULL) UnionCountries 
		JOIN Countries ON
			Countries.Name = UnionCountries.Country)
		) CitiesInCountries
WHERE 
    Cities.CityId = CitiesInCountries.CityId

-- task-15 - Drop column City and ShipCity from Employees, Suppliers, Customers and Orders tables

ALTER TABLE Suppliers
DROP COLUMN City

ALTER TABLE Employees
DROP COLUMN City

ALTER TABLE Orders
DROP COLUMN ShipCity

DROP INDEX Customers.City
ALTER TABLE Customers
DROP COLUMN City

-- task-16 - Drop column Country and ShipCountry from Employees, Customers, Suppliers and Orders tables

ALTER TABLE Employees
	DROP COLUMN Country 

ALTER TABLE Customers
	DROP COLUMN Country 

ALTER TABLE Suppliers
	DROP COLUMN Country 

ALTER TABLE Orders
	DROP COLUMN ShipCountry




