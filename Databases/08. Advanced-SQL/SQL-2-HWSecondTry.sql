USE TelerikAcademy

-- 1. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
	-- Use a nested SELECT statement.

SELECT e.FirstName,e.LastName,e.Salary
 FROM Employees e
 WHERE e.Salary=(SELECT MIN(e.Salary) FROM Employees e)

-- 2. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.

SELECT e.FirstName,e.LastName,e.Salary[10 % Above Minimal Salary]
FROM Employees e
WHERE e.Salary<(SELECT MIN(e.Salary) FROM Employees e) * 1.1

-- 3. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
	--Use a nested SELECT statement.

SELECT CONCAT(e.FirstName, ' ', e.MiddleName, '. ', e.LastName)[Full Name] , e.Salary, d.Name[Department]
FROM Employees e
JOIN Departments d 
ON e.DepartmentID = d.DepartmentID
WHERE e.Salary=
	(SELECT MIN(e.Salary) FROM Employees e WHERE e.DepartmentID=d.DepartmentID)
ORDER BY e.Salary DESC

-- 4. Write a SQL query to find the average salary in the department #1.

SELECT AVG(e.Salary)[Avg Salary In Department #1]
FROM Employees e
WHERE e.DepartmentID = 1

-- 5. Write a SQL query to find the average salary in the "Sales" department.

SELECT AVG(e.Salary)[Avg Salary In Sales Department]
FROM Employees e
JOIN Departments d
ON e.DepartmentID = d.DepartmentID
WHERE d.Name='Sales'

-- 6. Write a SQL query to find the number of employees in the "Sales" department.

SELECT COUNT(e.EmployeeID)[Number of Employees In Sales Department]
FROM Employees e
JOIN Departments d
	ON e.DepartmentID = d.DepartmentID
WHERE d.Name='Sales'

-- 7. Write a SQL query to find the number of all employees that have manager.

SELECT COUNT(*)[Number of Employees that have a Manager]
	 FROM Employees e 
	 WHERE e.ManagerID IS NOT NULL

-- 8. Write a SQL query to find the number of all employees that have no manager.

SELECT COUNT(*)[Number of Employees that DON'T have a Manager]
	 FROM Employees e 
	 WHERE e.ManagerID IS NULL

-- 9. Write a SQL query to find all departments and the average salary for each of them.

SELECT DISTINCT d.Name[Department Name], AVG(e.Salary)[Average Salary]	
	 FROM Departments d 
	 JOIN Employees e ON d.DepartmentID = e.DepartmentID
	 GROUP BY d.Name

-- 10. Write a SQL query to find the count of all employees in each department and for each town.
-- Донякъде вярна...

SELECT d.Name[Department Name], COUNT(e.EmployeeID)[Number of Employess in Department], t.Name[Town Name], COUNT(e.EmployeeID)[Number of Employess in Town]
	 FROM Departments d
	 JOIN Employees e ON d.DepartmentID = e.DepartmentID
	 JOIN Addresses a ON e.AddressID = a.AddressID
	 JOIN Towns t ON a.TownID = t.TownID
	 GROUP BY d.Name, t.Name   
	 ORDER BY d.Name

-- 11. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.

SELECT m.FirstName + ' ' + m.LastName[Manager Full Name]
	FROM Employees e
	JOIN Employees m ON e.ManagerID = m.EmployeeID
	GROUP BY m.FirstName,m.LastName
	HAVING COUNT(m.EmployeeID) = 5	

-- 12. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".

SELECT CONCAT(e.FirstName, ' ', e.LastName) as [Employee],
       ISNULL(m.FirstName + ' ' +  m.LastName, 'No manager') as [Manager]
FROM Employees e 
LEFT JOIN Employees m
    ON e.ManagerID = m.EmployeeID

-- 13. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.

SELECT e.LastName[Employees Last Name with Exactly 5 Chars]
FROM Employees e 
WHERE LEN(e.LastName) = 5

-- 14. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
	--Search in Google to find how to format dates in SQL Server.

SELECT FORMAT(GETDATE(),'dd.MM.yyyy hh:mm:ss:fff')[Current Data and Time]    ----- exactly as described 
-------- second way
SELECT CONVERT(VARCHAR, GETDATE(), 113)[Current Data and Time]    ----- NOT exactly as described month is with words!!!

-- 15. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
	--Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
	--Define the primary key column as identity to facilitate inserting records.
	--Define unique constraint to avoid repeating usernames.
	--Define a check constraint to ensure the password is at least 5 characters long.

CREATE TABLE Users
(
	Id INT PRIMARY KEY IDENTITY,
	Username NVARCHAR(15) UNIQUE NOT NULL,
	Password NVARCHAR(15) CHECK(DATALENGTH([Password]) >= 5) NOT NULL,
	[Full Name] NVARCHAR(55),
	[Last login time] DATETIME
)
   
-- 16. Write a SQL statement to create a view that displays the users from the Users table that have been in the system today.
	--Test if the view works correctly.

CREATE VIEW [Users in system today] AS
SELECT Username, [Last login time]
FROM Users
WHERE
CONVERT(VARCHAR(10), [Last login time], 102) <= CONVERT(VARCHAR(10) ,GETDATE(), 102)
GO

-- 17. Write a SQL statement to create a table Groups. Groups should have unique name (use unique constraint).
	-- Define primary key and identity column.

CREATE TABLE Groups
(
	Id INT IDENTITY,
	Name NVARCHAR(25) UNIQUE NOT NULL,
	CONSTRAINT PK_Groups PRIMARY KEY(Id)
) 

-- 18. Write a SQL statement to add a column GroupID to the table Users.
	-- Fill some data in this new column and as well in the `Groups table.
	-- Write a SQL statement to add a foreign key constraint between tables Users and Groups tables.

ALTER TABLE Users 
	ADD GroupId INT FOREIGN KEY REFERENCES Groups(Id)
------- second way --------
ALTER TABLE Users
ADD GroupId int

ALTER TABLE Users
ADD CONSTRAINT FK_Users_Groups
FOREIGN KEY (GroupId)
REFERENCES Groups(GroupId)

-- 19. Write SQL statements to insert several records in the Users and Groups tables.

INSERT INTO Groups (Name)
	VALUES ('Programming'),('Drawing')

INSERT INTO Users(Username, Password, [Full Name], [Last login time], GroupId)
	VALUES('Nikodim', '12345', 'Nikodim Ivanov', GETDATE(),1),
		('Esteban', '54321', 'Esteban Petrov', GETDATE(),2)

-- 20. Write SQL statements to update some of the records in the Users and Groups tables.

UPDATE Groups 
	SET Name = 'Math'
	WHERE Name ='Drawing'

UPDATE Users 
	SET Username = 'Nikodim13'
	WHERE Username = 'Nikodim'

UPDATE Users
	SET [Last login time] = GETDATE()
	WHERE Username = 'Nikodim13'

-- 21. Write SQL statements to delete some of the records from the Users and Groups tables.

DELETE FROM Groups
	WHERE Name = 'Programming'

DELETE FROM Users
	WHERE Username = 'Esteban'

-- 22.Write SQL statements to insert in the Users table the names of all employees from the Employees table.
	-- Combine the first and last names as a full name.
	-- For username use the first letter of the first name + the last name (in lowercase).
	-- Use the same for the password, and NULL for last login time.

INSERT INTO Users (Username, Password, [Full Name],[Last login time])
	 SELECT e.FirstName + CONVERT(VARCHAR(10),e.EmployeeID),e.FirstName + '123', e.FirstName + ' ' + e.LastName, GETDATE()
	  FROM Employees e
-------------- second way --------------- it's a bit different, less parameters....
INSERT INTO Users (Username, Password, [Full Name])
SELECT LOWER(LEFT(FirstName, 3) + LastName),
		LOWER(LEFT(FirstName, 3) + LastName),
		FirstName + ' ' + LastName
FROM Employees

-- 23. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.

UPDATE Users 
	SET Password = 'NULL'
	WHERE [Last login time] < '10.03.2010'
--------- second way---------- good as well
UPDATE Users
SET [Password] = 'NULL'
WHERE [Last login time] < CONVERT(DATETIME, '2010-03-10')

-- 24.Write a SQL statement that deletes all users without passwords (NULL password).

DELETE FROM Users
	WHERE Password = 'NULL'

-- 25. Write a SQL query to display the average employee salary by department and job title.

SELECT AVG(e.Salary)[Average Salary], d.Name[Department Name], e.JobTitle
FROM Employees e
	JOIN Departments d 
		ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle, d.Name 

-- 26. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.

SELECT MIN(e.Salary)[Minimal Salary], d.Name[Department Name], e.JobTitle, e.FirstName +' '+e.LastName[Employee Name]
FROM Employees e
	JOIN Departments d 
		ON e.DepartmentID = d.DepartmentID
GROUP BY e.JobTitle, d.Name , e.FirstName, e.LastName

-- 27. Write a SQL query to display the town where maximal number of employees work.

SELECT TOP 1 t.Name[Town], COUNT(e.EmployeeID)[Number of Employess]
FROM Employees e
	JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID = t.TownID
GROUP BY t.Name
ORDER BY [Number of Employess] DESC

-- 28. 

SELECT t.Name[Town], COUNT(e.EmployeeID)[Number of Managers]
FROM Employees e
	JOIN Addresses a ON e.AddressID = a.AddressID
	JOIN Towns t ON a.TownID = t.TownID
WHERE e.JobTitle LIKE '%Manager%'
GROUP BY t.Name
ORDER BY [Number of Managers] DESC

-- 29. Write a SQL to create table WorkHours to store work reports for each employee (employee id, date, task, hours, comments).
-- Don't forget to define identity, primary key and appropriate foreign key.
-- Issue few SQL statements to insert, update and delete of some data in the table.
-- Define a table WorkHoursLogs to track all changes in the WorkHours table with triggers.
	-- For each change keep the old record data, the new record data and the command (insert / update / delete).

CREATE TABLE WorkHours (
	EmployeeId INT IDENTITY,
	[Date] DATETIME,
	Task NVARCHAR(100),
	[Hours] INT,
	Comments NVARCHAR(300)
	CONSTRAINT PK_WorkHours PRIMARY KEY(EmployeeId)
	CONSTRAINT FK_WorkHours_Employees FOREIGN KEY(EmployeeId)
	REFERENCES Employees(EmployeeId)
)
GO

INSERT INTO WorkHours
VALUES (GETDATE(), 'Write homework', 5, 'Homework about advanced SQL'),
		(GETDATE(), 'Go go Lecture', 4, 'Attend to lecture in Telerik Academy'),
		(GETDATE(), 'Rest', 2, 'Rest after hard day')

UPDATE WorkHours
SET Date = '2015-10-05 18:00'
WHERE Task LIKE '%Lecture%'

DELETE FROM WorkHours
WHERE [Hours] < 3

CREATE TABLE WorkHoursLogs(
	LogId INT IDENTITY,
	OldRecord nvarchar(500),
	NewRecord nvarchar(500),
	Command nvarchar(10),
	EmployeeId INT,
	CONSTRAINT PK_WorkHoursLogs PRIMARY KEY(LogId),
	CONSTRAINT FK_WorkHoursLogs_WorkHours FOREIGN KEY(EmployeeId) 
	REFERENCES WorkHours(EmployeeId)
)
GO

CREATE TRIGGER tr_WorkHoursInsert ON WorkHours FOR INSERT
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES('',
		   (SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments
			FROM Inserted),
		   'INSERT',
		   (SELECT EmployeeID FROM Inserted))
GO

CREATE TRIGGER tr_WorkHoursUpdate ON WorkHours FOR UPDATE
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES((SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' +
					 ' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Deleted),
		   (SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Inserted),
		   'UPDATE',
		   (SELECT EmployeeID FROM Inserted))
GO

CREATE TRIGGER tr_WorkHoursDelete ON WorkHours FOR DELETE
AS
	INSERT INTO WorkHoursLogs(OldRecord, NewRecord, Command, EmployeeId)
	VALUES((SELECT 'Day: ' + CAST(Date AS nvarchar(50)) + ' ' + ' Task: ' + Task + ' ' + 
					' Hours: ' + CAST([Hours] AS nvarchar(50)) + ' ' + Comments FROM Deleted),
		   '',
		   'DELETE',
		   (SELECT EmployeeID FROM Deleted))
GO

INSERT INTO WorkHours
VALUES(GETDATE(), 'Sleep', 8, 'Sleep when its dark outside')

DELETE FROM WorkHours
WHERE Task = 'Rest'

UPDATE WorkHours
SET Task = 'Win Money'
WHERE EmployeeID = 1

-- 30. Start a database transaction, delete all employees from the 'Sales' department along with all dependent records from the pother tables.
	--At the end rollback the transaction.

BEGIN TRAN
	ALTER TABLE Departments
	DROP CONSTRAINT FK_Departments_Employees

	ALTER TABLE WorkHours
	DROP CONSTRAINT FK_WorkHours_Employees

	DELETE FROM Employees
	SELECT d.Name
	FROM Employees e
		JOIN Departments d
			ON e.DepartmentID = d.DepartmentID
	WHERE d.Name = 'Sales'
	GROUP BY d.Name
ROLLBACK TRAN

-- 31. Start a database transaction and drop the table EmployeesProjects.
	-- Now how you could restore back the lost table data?
  
--BEGIN TRAN
--	DROP TABLE EmployeesProjects
--ROLLBACK TRAN

-- 32. Find how to use temporary tables in SQL Server.
 	-- Using temporary tables backup all records from EmployeesProjects and restore them back after dropping and re-creating the table.

CREATE TABLE #TemporaryTable (
	EmployeeId INT,
	ProjectId INT
)

INSERT INTO #TemporaryTable
SELECT EmployeeId, ProjectId
FROM EmployeesProjects

DROP TABLE EmployeesProjects

CREATE TABLE EmployeesProjects (
	EmployeeId INT,
	ProjectId INT,
	CONSTRAINT PK_EmployeesProjects PRIMARY KEY(EmployeeID, ProjectID),
	CONSTRAINT FK_EmployeesProjects_Employees FOREIGN KEY(EmployeeID) 
	REFERENCES Employees(EmployeeID),
	CONSTRAINT FK_EmployeesProjects_Projects FOREIGN KEY(ProjectID) 
	REFERENCES Projects(ProjectID)
)

INSERT INTO EmployeesProjects
SELECT EmployeeId, ProjectId
FROM #TemporaryTable
