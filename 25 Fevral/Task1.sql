CREATE TABLE Department(
Id INT IDENTITY PRIMARY KEY,
[Name] NVARCHAR(50),
[Address] NVARCHAR(50),
)



CREATE TABLE Employee(
Id INT IDENTITY PRIMARY KEY,
[Name] NVARCHAR(50),
Position NVARCHAR(50),
DepartmentID INT FOREIGN KEY REFERENCES Department(Id)
)

INSERT INTO Department([Name],[Address])
VALUES('Code Academy','28 May')

INSERT INTO Employee([Name],Position,DepartmentID)
VALUES('Emin','Absolute',1)
INSERT INTO Employee([Name],Position,DepartmentID)
VALUES('Esger','Relative',1)

SELECT Employee.Id,concat(Employee.Name,' ',EmployeeSurname) as 'Employee FullName', Department.Name AS Department
FROM Employee
INNER JOIN Department
ON Employee.DepartmentID=Department.Id

Alter Table Employee
add EmployeeSurname nvarchar(50)

update Employee
set EmployeeSurname = 'Kazim'
where Id = 1

update Employee
set EmployeeSurname = 'Esgerov'
where Id = 2