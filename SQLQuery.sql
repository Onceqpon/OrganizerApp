-- Tworzenie tabeli "Users"
CREATE TABLE [dbo].[Users] (
  [Id] INT IDENTITY(1,1) PRIMARY KEY,
  [Name] NVARCHAR(100) NOT NULL,
  [Email] NVARCHAR(100) NOT NULL,
  [Password] NVARCHAR(100) NOT NULL
);

-- Tworzenie tabeli "Categories"
CREATE TABLE [dbo].[Categories] (
  [Id] INT IDENTITY(1,1) PRIMARY KEY,
  [Name] NVARCHAR(50) NOT NULL,
  [Description] NVARCHAR(MAX)
);

-- Tworzenie tabeli "Notes"
CREATE TABLE [dbo].[Notes] (
  [Id] INT IDENTITY(1,1) PRIMARY KEY,
  [UserId] INT NOT NULL,
  [CategoryId] INT NOT NULL,
  [Title] NVARCHAR(100) NOT NULL,
  [Content] NVARCHAR(MAX),
  [CreatedAt] DATETIME DEFAULT GETDATE(),
  FOREIGN KEY ([UserId]) REFERENCES [Users]([Id]),
  FOREIGN KEY ([CategoryId]) REFERENCES [Categories]([Id])
);

-- Tworzenie tabeli "Tasks"
CREATE TABLE [dbo].[Tasks] (
  [Id] INT IDENTITY(1,1) PRIMARY KEY,
  [UserId] INT NOT NULL,
  [Title] NVARCHAR(100) NOT NULL,
  [Description] NVARCHAR(MAX),
  [Priority] NVARCHAR(20),
  [Deadline] DATE,
  [IsCompleted] BIT DEFAULT 0,
  FOREIGN KEY ([UserId]) REFERENCES [Users]([Id])
);