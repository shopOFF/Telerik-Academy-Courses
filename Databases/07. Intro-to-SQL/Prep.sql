USE PracticeDB

SELECT FacultyNumber as 'Fucking number' 
FROM Students
WHERE FacultyNumber='1313'

SELECT Name
FROM Towns
WHERE Name='Sofia' OR Name='Pernik' OR Name='Blagoevgrad'

SELECT *
FROM Students
WHERE CoursesId > 3
ORDER BY Name DESC, Id

SELECT *
FROM Students s
JOIN Courses c ON s.CoursesId = c.Id 
JOIN Towns t ON t.Id = c.TownId

--// TOVA E SA6TOTO, KATO GORNOTO, PRAVI INNER JOIN !!!
SELECT *
FROM Students s, Courses c, Towns t
WHERE s.CoursesId = c.Id AND t.Id = c.TownId  

--TOVA E INSERT zaqvka
INSERT INTO Courses(Name, TownId)
VALUES ('DB',6)

--TOVA E UPDATE zaqvka
UPDATE Courses
SET Name = 'PhisicsUpdated'
WHERE Name = 'Phisics'

--TOVA E DELETE zaqvka
--DELETE 
--FROM Courses
--WHERE Name='DB'
