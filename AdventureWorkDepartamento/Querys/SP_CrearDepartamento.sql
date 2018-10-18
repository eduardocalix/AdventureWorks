USE AdventureWorks2014
GO

ALTER PROCEDURE sp_crearDepartamentos(
	@name NVARCHAR(50),
	@groupName NVARCHAR(50),
	@date DATETIME
)
AS
BEGIN
	INSERT INTO HumanResources.Department(Name, GroupName, ModifiedDate)
			VALUES(@name,@groupName,@date)
	RETURN 1
END