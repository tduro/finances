CREATE TABLE [dbo].[Expenses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[Date] DATE NOT NULL, 
	[Value] DECIMAL(10, 3) NOT NULL, 
	[AreaId] INT NOT NULL,
	[Description] NVARCHAR(50) NULL, 
	[Observations] NVARCHAR(250) NULL, 
	CONSTRAINT [FK_Expenses_Areas] FOREIGN KEY ([AreaId]) REFERENCES [Areas]([Id])
)
