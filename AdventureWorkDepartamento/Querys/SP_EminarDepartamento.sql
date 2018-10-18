USE AdventureWorks2014
GO

CREATE PROCEDURE sp_EliminarDepartamento (
	@departmentID SMALLINT
)
AS
DELETE FROM HumanResources.Department
WHERE DepartmentID = @departmentID