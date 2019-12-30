CREATE TABLE [dbo].[Descriptions]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
	[Description] NVARCHAR(MAX),
	[TypeId] UNIQUEIDENTIFIER NOT NULL,
	[CommonNameId] NVARCHAR(MAX), 
	CONSTRAINT [PK_Descriptions] PRIMARY KEY NONCLUSTERED ([Id] ASC),
	FOREIGN KEY (TypeId) REFERENCES [Types](Id),
	FOREIGN KEY (CommanNameId) REFERENCES [CommanNames](Id)
)

CREATE TABLE [dbo].[Categories]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
	[Category] NVARCHAR(MAX) NOT NULL
	CONSTRAINT [PK_Categories] PRIMARY KEY NONCLUSTERED ([Id] ASC)
)

CREATE TABLE [dbo].[Types]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
	[TypeName] NVARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_Types] PRIMARY KEY NONCLUSTERED ([Id] ASC),
)

CREATE TABLE [dbo].[CommanNames]
(
	[Id] UNIQUEIDENTIFIER NOT NULL, 
	[Name] NVARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_Types] PRIMARY KEY NONCLUSTERED ([Id] ASC),
)

CREATE TABLE [dbo].[Transactions] (
[Id] UNIQUEIDENTIFIER NOT NULL, 
[Date] DATETIME NOT NULL,
[TypeId] UNIQUEIDENTIFIER NOT NULL,
[Description] NVARCHAR(MAX) NOT NULL,
[Amount] DECIMAL NOT NULL, 
[CategoryId] UNIQUEIDENTIFIER NOT NULL
CONSTRAINT [PK_Transactions] PRIMARY KEY NONCLUSTERED ([Id] ASC),
FOREIGN KEY (TypeId) REFERENCES [Types](Id),
FOREIGN KEY (CategoryId) REFERENCES [Categories](Id)
)