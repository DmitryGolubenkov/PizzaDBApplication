CREATE TABLE [dbo].[orders]
(
	[OrderId] INT NOT NULL PRIMARY KEY IDENTITY,
	[ClientId] INT NOT NULL,
	[Sum] INT NOT NULL,
	[OrderTime] DATETIME NOT NULL,
	[StatusId] INT NOT NULL, 
	[OrderContents] NVARCHAR(1000) NOT NULL,
	[EmployeeId] INT NOT NULL,
	FOREIGN KEY ([ClientId]) REFERENCES dbo.table_clients([ClientId]),
	FOREIGN KEY ([EmployeeId]) REFERENCES dbo.employees_table([EmployeeId])
)
