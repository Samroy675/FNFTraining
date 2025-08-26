CREATE TABLE TblEmpManager(
 Emp_Id INT PRIMARY KEY IDENTITY(1,1),
 Name NVARCHAR(50),
 Salary money,
)

CREATE TABLE TblManager (
Manager_Id INT PRIMARY KEY IDENTITY(1,1),
Name NVARCHAR(50)
)

ALTER TABLE TblEmpManager
ADD Manager_Id int NOT NULL REFERENCES TblManager(Manager_Id) 


INSERT INTO TblEmpManager(Name, Salary, Manager_Id) VALUES('Rohit',20000,1);
INSERT INTO TblEmpManager(Name, Salary, Manager_Id) VALUES('Sangeeta',12000,3);
INSERT INTO TblEmpManager(Name, Salary, Manager_Id) VALUES('Sanjay',10000,2);
INSERT INTO TblEmpManager(Name, Salary, Manager_Id) VALUES('Arun',25000,3);
INSERT INTO TblEmpManager(Name, Salary, Manager_Id) VALUES('Zaheer',3000,2);


INSERT INTO TblManager(Name) VALUES('Sanjay');
INSERT INTO TblManager(Name) VALUES('Zaheer');
INSERT INTO TblManager(Name) VALUES('Arun');


SELECT * FROM TblEmpManager
SELECT * FROM TblManager



SELECT E.Name AS EmployeeName, M.Name AS ManagerName
FROM TblEmpManager E
JOIN TblManager M ON E.Manager_Id = M.Manager_Id
ORDER BY E.Name;






