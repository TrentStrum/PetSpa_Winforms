use TrentsTroubleMakersDb; 
go 

IF OBJECT_ID('dbo.Address') IS NULL
BEGIN
	CREATE TABLE dbo.Address(
		[Address_Id] int IDENTITY(1,1) NOT NULL,
		[Address_Type] int NOT NULL,
		[Street] varchar(50) NOT NULL,
		[Supplemental] varchar(50) NOT NULL,
		[City] varchar(50) NOT NULL,
		[State] varchar(50) NOT NULL,
		[ZipCode] varchar(50) NOT NULL,
		[Person_Id] int NOT NULL
	
	)
END
GO

IF OBJECT_ID('dbo.Appointment') IS NULL
BEGIN
	CREATE TABLE dbo.Appointment(
		[Appt_Id] int IDENTITY(1,1) NOT NULL,
		[Pet_Id] int NOT NULL,
		[CheckInDateTime] datetime NOT NULL,
		[CheckOutDateTime] datetime NOT NULL,
		[SpecialInstructions] text NOT NULL
	)
END
GO

IF OBJECT_ID('dbo.Customer') IS NULL
BEGIN
	CREATE TABLE dbo.Customer(
		[Customer_Id] int IDENTITY(1,1) NOT NULL,
		[Person_Id] int NOT NULL,
		[RegistrationDate] date NOT NULL
	)
END
GO

IF OBJECT_ID('dbo.Email') IS NULL
BEGIN
	CREATE TABLE dbo.Email(
		[Email_Id] int IDENTITY(1,1) NOT NULL,
		[Personal_Email] varchar(50) NOT NULL,
		[Work_Email] varchar(50) NOT NULL,
	)
END
GO

IF OBJECT_ID('dbo.Employee') IS NULL
BEGIN
	CREATE TABLE dbo.Employee(
		[Employee_Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[Title] VARCHAR(50) NOT NULL,
		[HireDate] Date NOT NULL,
		[TerminationDate] Date NULL,
		[Username] VARCHAR(50) NOT NULL,
		[Password] VARCHAR(50) NOT NULL,
		[Role] Int NOT NULL,
		[Person_Id] Int NOT NULL,
	)
END
GO

IF OBJECT_ID('dbo.Person') IS NULL
BEGIN
	CREATE TABLE dbo.Person(
		[Person_Id] INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
		[FirstName] VARCHAR(50) NOT NULL,
		[LastName] VARCHAR(50) NOT NULL,
		[Phone_Id] int NOT NULL,
		[Email_Id] int NOT NULL,
	)
END
GO

IF OBJECT_ID('dbo.Pet') IS NULL
BEGIN
	CREATE TABLE dbo.Pet(
		[Pet_id] int IDENTITY(1,1) NOT NULL,
		[Name] VARCHAR(50) NOT NULL,
		[AnimalType] VARCHAR(50) NOT NULL,
		[Breed] VARCHAR(50) NOT NULL,
		[Age] INT NOT NULL,
		[Weight] INT NOT NULL,
		[Sex] VARCHAR(50) NOT NULL,
		[Owner_Id] INT NOT NULL,

		CONSTRAINT PK_Pet_1 PRIMARY KEY CLUSTERED  ( Pet_id ASC)
	)
END
GO 

IF OBJECT_ID('dbo.Phone') IS NULL
BEGIN
	CREATE TABLE dbo.Phone(
		[Phone_id] int IDENTITY(1,1) NOT NULL,
		[Mobile] VARCHAR(50) NOT NULL,
		[Home] VARCHAR(50) NULL,
		[Business] VARCHAR(50) NULL,
	)
END
GO

IF OBJECT_ID('dbo.Species') IS NULL
BEGIN
	CREATE TABLE dbo.Species(
		[Species_id] int IDENTITY(1,1) NOT NULL,
		[Name] VARCHAR(50) NOT NULL,
	)
END
GO

