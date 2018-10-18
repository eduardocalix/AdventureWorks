USE AdventureWorks2014
GO

CREATE PROCEDURE sp_actualizarDepartamentos(
	@Id SMALLINT,
	@name NVARCHAR(50),
	@groupName NVARCHAR(50),
	@date DATE
)
AS
BEGIN
	UPDATE HumanResources.Department
	SET Name=@name,GroupName=@groupName,ModifiedDate=@date
    WHERE @Id=DepartmentID
END