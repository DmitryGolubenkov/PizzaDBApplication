CREATE TABLE [dbo].[employees_table]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY,
	[FirstName] NVARCHAR(100) NOT NULL,
	[LastName] NVARCHAR(100) NOT NULL,
	[MiddleName] NVARCHAR(100) NOT NULL,
	[EmployeePosition] NVARCHAR(100) NOT NULL
)
