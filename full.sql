CREATE TABLE [dbo].[Role]
(
	[id_role] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[role_name] NVARCHAR(30) NOT NULL
)

CREATE TABLE [dbo].[User]
(
	[id_user] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  [fio] NVARCHAR(50) NOT NULL, 
  [login] NVARCHAR(50) NOT NULL, 
  [password] NVARCHAR(50) NOT NULL, 
  [id_role] INT NOT NULL, 
  CONSTRAINT [FK_User_ToRole] FOREIGN KEY ([id_role]) REFERENCES [Role]([id_role])
)

CREATE TABLE [dbo].[Order]
(
	[id_order] [int] IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[description] [nvarchar](500) NULL,
	[type] [nvarchar](50) NOT NULL,
	[serial_number] [nvarchar](15) NOT NULL,
	[start_time] [datetime] NOT NULL,
	[end_time] [datetime] NULL,
	[priority] [int] NOT NULL,
	[status] [nvarchar](20) NOT NULL,
	[id_client] [int] NOT NULL,
  CONSTRAINT [FK_Order_User] FOREIGN KEY ([id_client]) REFERENCES [User]([id_user])
)

BACKUP DATABASE 'Название' TO DISK = ‘C:\Users\student523\Desktop\...’ WITH FORMAT, NAME = ‘backup’, STATS = 10; 
