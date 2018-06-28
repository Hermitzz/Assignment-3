CREATE TABLE [dbo].[Clients]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NULL, 
    [address] VARCHAR(200) NULL, 
    [landLine] VARCHAR(50) NULL, 
    [mobilePhone] VARCHAR(50) NULL, 
    [bussinessName] VARCHAR(50) NULL, 
    [email] VARCHAR(100) NULL
)
