USE TrentsTroubleMakersDb; 
GO 
-- GET TABLE STPs --

IF OBJECT_ID('dbo.stp_getAddressTable') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getAddressTable] AS SELECT 1 TEST';
END
GO

ALTER PROCEDURE [dbo].[stp_getAddressTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Address_Id] 
	, [Address_Type]
	, [Street]
	, [Supplemental]
	, [City]
	, [State]
	, [ZipCode]
	, [Person_Id]

	FROM dbo.Address;
			
END
GO 

IF OBJECT_ID('dbo.stp_getAppointmentTable') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getAppointmentTable] AS SELECT 1 TEST';
END
GO

ALTER PROCEDURE [dbo].[stp_getAppointmentTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Appt_Id] 
	, [Pet_Id]
	, [CheckInDateTime]
	, [CheckOutDateTime]
	, [SpecialInstructions]

	FROM dbo.Appointment;
			
END
GO 

IF OBJECT_ID('dbo.stp_getCustomerTable') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getCustomerTable] AS SELECT 1 TEST';
END
GO

ALTER PROCEDURE [dbo].[stp_getCustomerTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Customer_Id] 
	, [Person_Id]
	, [RegistrationDate]

	FROM dbo.Customer;
			
END
GO 

IF OBJECT_ID('dbo.stp_getEmailTable') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getEmailTable] AS SELECT 1 TEST';
END
GO

ALTER PROCEDURE [dbo].[stp_getEmailTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Email_Id] 
	, [Personal_Email]
	, [Work_Email]

	FROM dbo.Email;
			
END
GO 

IF OBJECT_ID('dbo.stp_getEmployeeTable') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getEmployeeTable] AS SELECT 1 TEST';
END
GO

ALTER PROCEDURE [dbo].[stp_getEmployeeTable]

AS
BEGIN
	SET NOCOUNT ON;

		SELECT [Employee_Id] 
			, [Title]
			, [HireDate]
			, [username]
			, [password]
			, [Role]
			, [Person_Id]


		FROM dbo.Employee
		
END
GO

IF OBJECT_ID('dbo.stp_getPersonTable') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getPersonTable] AS SELECT 1 TEST';
END
GO

ALTER PROCEDURE [dbo].[stp_getPersonTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Person_Id] 
	, [FirstName]
	, [LastName]
	, [Phone_Id]
	, [Email_Id]

	FROM dbo.Person;
			
END
GO

IF OBJECT_ID('dbo.stp_getPetTable') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getPetTable] AS SELECT 1 TEST';
END
GO

ALTER PROCEDURE [dbo].[stp_getPetTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Pet_id] 
	, [Name]
	, [AnimalType]
	, [Breed]
	, [Age]
	, [Weight]
	, [Sex]
	, [Customer_Id]

	FROM dbo.Pet;
			
END
GO 

IF OBJECT_ID('dbo.stp_getPhoneTable') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getPhoneTable] AS SELECT 1 TEST';
END
GO

ALTER PROCEDURE [dbo].[stp_getPhoneTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Phone_Id] 
	, [Mobile]
	, [Home]
	, [Business]

	FROM dbo.Phone;
			
END
GO

IF OBJECT_ID('dbo.stp_getSpeciesTable') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getSpeciesTable] AS SELECT 1 TEST';
END
GO

ALTER PROCEDURE [dbo].[stp_getSpeciesTable]

AS
BEGIN
	SET NOCOUNT ON;

	SELECT [SpeciesID] 
	, [Name]

	FROM dbo.Species;
			
END
GO
-- Address STPs --
IF OBJECT_ID('dbo.stp_deleteAddressById') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_deleteAddressById] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_deleteAddressById] @addressId INT

AS
BEGIN
	SET NOCOUNT OFF;

		DELETE FROM dbo.Address WHERE Address_Id = @addressId
		SELECT @@ROWCOUNT
END
GO

IF OBJECT_ID('dbo.stp_getBillingAddressByPersonId') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getBillingAddressByPersonId] AS SELECT 1 TEST';
END
GO 

ALTER PROCEDURE [dbo].[stp_getBillingAddressByPersonId] @personId INT
AS
BEGIN
	SET NOCOUNT ON;

		SELECT Address_Id
			, Address_Type
			, Street
			, Supplemental
			, City
			, State
			, ZipCode
			, Address.Person_Id
		FROM dbo.Address JOIN dbo.Person ON Person.Person_Id = Address.Person_Id
		WHERE Address.Person_Id = @personId AND Address_Type=1;

END
GO

IF OBJECT_ID('dbo.stp_getShippingAddressByPersonId') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getShippingAddressByPersonId] AS SELECT 1 TEST';
END
GO 

ALTER PROCEDURE [dbo].[stp_getShippingAddressByPersonId] @personId INT
AS
BEGIN
	SET NOCOUNT ON;

		SELECT Address_Id
			, Address_Type
			, Street
			, Supplemental
			, City
			, State
			, ZipCode
			, Address.Person_Id
		FROM dbo.Address JOIN dbo.Person ON Person.Person_Id = Address.Person_Id
		WHERE Address.Person_Id = @personId AND Address_Type=0;

END
GO

IF OBJECT_ID('dbo.stp_insertNewAddress') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_insertNewAddress] AS SELECT 1 TEST';
END
GO 

ALTER PROCEDURE [dbo].[stp_insertNewAddress] @addressType INT, @street VARCHAR(50), @supplemental VARCHAR(50), @city VARCHAR(50), @state Int, @zipCode VARCHAR(50), @personId INT
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Address(Address_Type, Street, Supplemental, City, State, ZipCode, Person_Id)
		VALUES(@addressType, @street, @supplemental, @city, @state, @zipCode, @personId)

	SELECT SCOPE_IDENTITY();

END
GO

IF OBJECT_ID('dbo.stp_updateAddress') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_updateAddress] AS SELECT 1 TEST';
END
GO 
ALTER PROCEDURE [dbo].[stp_updateAddress] @address_Type INT, @street VARCHAR(50), @supplemental VARCHAR(50), @city VARCHAR(50), @state Int, @zipCode VARCHAR(50), @personId INT, @addressId INT
AS
BEGIN
	SET NOCOUNT ON;

		Update dbo.Address SET Address_Type = @address_Type, Street = @street, Supplemental = @supplemental, City = @city, State = @state, ZipCode = @zipCode, Person_Id = @personId WHERE Address_Id = @addressId 
		SELECT @@ROWCOUNT;
END
GO

-- Appointment STPs --
IF OBJECT_ID('dbo.stp_updateAppointment') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_updateAppointment] AS SELECT 1 TEST';
END
GO 
ALTER PROCEDURE [dbo].[stp_updateAppointment] @ApptId INT, @petId INT, @checkInDate DATE, @checkOutDate DATE, @specialInstructions VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

		Update dbo.Appointment SET Pet_Id = @petId, CheckInDateTime = @checkInDate, CheckOutDateTime = @checkOutDate WHERE Appt_Id = @ApptId 
		SELECT @@ROWCOUNT;
END
GO

IF OBJECT_ID('dbo.stp_insertNewAppointment') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_insertNewAppointment] AS SELECT 1 TEST';
END
GO 

ALTER PROCEDURE [dbo].[stp_insertNewAppointment] @pet_Id INT, @checkInDate DATETIME, @checkOutDate DATETIME, @specialInstructions VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

		INSERT INTO dbo.Appointment(Pet_Id, CheckInDateTime, CheckOutDateTime, SpecialInstructions)
		VALUES(@pet_Id, @checkInDate, @checkOutDate, @specialInstructions)

		SELECT SCOPE_IDENTITY();

END
GO

IF OBJECT_ID('dbo.stp_getTodaysCheckIns') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getTodaysCheckIns] AS SELECT 1 TEST';
END
GO 

ALTER PROCEDURE [dbo].[stp_getTodaysCheckIns] @today DATE
AS
BEGIN
	SET NOCOUNT ON;

	SELECT pt.Pet_id as PetId	
		, pt.Name as PetName
		, pn.FirstName as CustomerFirstName
		, pn.LastName as CustomerLastName
		, Appt_Id
		, CheckInDateTime
		, CheckOutDateTime
		, SpecialInstructions

	FROM dbo.Appointment as a
		JOIN dbo.Pet as pt ON a.Pet_Id = pt.Pet_Id
		JOIN dbo.Customer as c ON pt.Customer_Id = c.Customer_Id
		JOIN dbo.Person as pn ON c.Person_Id = pn.Person_Id
	WHERE CheckInDateTime = @today
	ORDER BY CheckInDateTime ASC;

END
GO

IF OBJECT_ID('dbo.stp_getTodaysCheckOuts') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getTodaysCheckOuts] AS SELECT 1 TEST';
END
GO 

ALTER PROCEDURE [dbo].[stp_getTodaysCheckOuts] @today DATE
AS
BEGIN
	SET NOCOUNT ON;

	SELECT pt.Pet_id as PetId	
		, pt.Name as PetName
		, pn.FirstName as CustomerFirstName
		, pn.LastName as CustomerLastName
		, Appt_Id
		, CheckInDateTime
		, CheckOutDateTime
		, SpecialInstructions

	FROM dbo.Appointment as a
		JOIN dbo.Pet as pt ON a.Pet_Id = pt.Pet_Id
		JOIN dbo.Customer as c ON pt.Customer_Id = c.Customer_Id
		JOIN dbo.Person as pn ON c.Person_Id = pn.Person_Id
	WHERE CheckOutDateTime = @today
	ORDER BY CheckOutDateTime ASC;

END
GO

IF OBJECT_ID('dbo.stp_getApptByPetId') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getApptByPetId] AS SELECT 1 TEST';
END
GO 

ALTER PROCEDURE [dbo].[stp_getApptByPetId] @petId INT
AS
BEGIN
	SET NOCOUNT ON;

		SELECT Appt_Id
			,Pet_Id
			,CheckInDateTime
			,CheckOutDateTime
			,SpecialInstructions
	
		FROM dbo.Appointment
		WHERE Pet_Id = @petId

END
GO
-- Customer STPs-- 
IF OBJECT_ID('dbo.stp_updateCustomer') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_updateCustomer] AS SELECT 1 TEST';
END
GO 
ALTER PROCEDURE [dbo].[stp_updateCustomer] @registrationDate DATE, @customerId INT
AS
BEGIN
	SET NOCOUNT ON;

		Update dbo.Customer SET RegistrationDate = @registrationDate WHERE Customer_Id = @customerId
		SELECT @@ROWCOUNT;
END
GO
-- Email STPs-- 
IF OBJECT_ID('dbo.stp_updateEmail') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_updateEmail] AS SELECT 1 TEST';
END
GO 
ALTER PROCEDURE [dbo].[stp_updateEmail] @personalEmail VARCHAR(50), @emailId INT
AS
BEGIN
	SET NOCOUNT ON;

		Update dbo.Email SET Personal_Email = @personalEmail WHERE Email_Id = @emailId
		SELECT @@ROWCOUNT;
END
GO
-- PERSON STPs --
IF OBJECT_ID('dbo.stp_updatePerson') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_updatePerson] AS SELECT 1 TEST';
END
GO 
ALTER PROCEDURE [dbo].[stp_updatePerson] @firstName VARCHAR(50), @lastName VARCHAR(50), @personId INT
AS
BEGIN
	SET NOCOUNT ON;

		Update dbo.Person SET FirstName = @firstName, LastName= @lastName WHERE Person_Id = @personId
		SELECT @@ROWCOUNT;
END
GO

-- PET STPs --
IF OBJECT_ID('dbo.stp_updatePet') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_updatePet] AS SELECT 1 TEST';
END
GO 
ALTER PROCEDURE [dbo].[stp_updatePet] @name VARCHAR(50), @animalType INT, @breed VARCHAR(50), @age INT, @weight INT, @sex INT, @petId INT
AS
BEGIN
	SET NOCOUNT ON;

		Update dbo.Pet SET Name = @name, AnimalType = @animalType, Breed = @breed, Age = @age, Weight = @weight, Sex = @sex WHERE Pet_id = @petId
		SELECT @@ROWCOUNT;
END
GO

IF OBJECT_ID('dbo.stp_insertNewPet') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_insertNewPet] AS SELECT 1 TEST';
END
GO 


ALTER PROCEDURE [dbo].[stp_insertNewPet] @name VARCHAR(50), @animalType INT, @breed VARCHAR(50), @age INT, @weight INT, @sex INT, @customerId INT
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Pet(Name, AnimalType, Breed, Age, Weight, Sex, Customer_Id)
		VALUES(@name, @animalType, @breed, @age, @weight, @sex, @customerId)

	SELECT SCOPE_IDENTITY();

END
GO

IF OBJECT_ID('dbo.stp_savePet') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_savePet] AS SELECT 1 TEST';
END
GO

IF OBJECT_ID('dbo.stp_getPetsByCustomerId') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getPetsByCustomerId] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_getPetsByCustomerId] @customerId INT

AS
BEGIN
	SET NOCOUNT ON;
	SELECT Pet_Id
		, Name
		, AnimalType
		, Breed
		, Age
		, Weight
		, Sex
		, Customer_Id
	FROM Pet
	WHERE Customer_Id = @customerId;
END
GO

IF OBJECT_ID('dbo.stp_getPetById') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getPetById] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_getPetById] @petId INT

AS
BEGIN
	SET NOCOUNT ON;

		SELECT Pet_Id
			, Name
			, AnimalType
			, Breed
			, Age
			, Weight
			, Sex
			, Customer_Id
		FROM Pet
		WHERE Pet_Id = @petId;
END
GO

IF OBJECT_ID('dbo.stp_deletePetById') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_deletePetById] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_deletePetById] @petId INT

AS
BEGIN
	SET NOCOUNT OFF;

		DELETE FROM dbo.Pet WHERE Pet_id = @petId
		SELECT @@ROWCOUNT
END
GO

IF OBJECT_ID('dbo.stp_getPetsByCustFirstAndLastName') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getPetsByCustFirstAndLastName] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_getPetsByCustFirstAndLastName] @custFirstName VARCHAR(50), @custLastName VARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;

		SELECT Pet_Id
			, Name
			, AnimalType
			, Breed
			, Age
			, Weight
			, Sex
			, pet.Customer_Id

		FROM dbo.Pet JOIN dbo.Customer ON Customer.Customer_Id = Pet.Customer_Id
			JOIN dbo.Person ON Customer.Person_Id = Person.Person_Id
		WHERE Person.FirstName = @custFirstName AND Person.LastName = @custLastName;

END
GO

IF OBJECT_ID('dbo.stp_getPetByName') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getPetByName] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_getPetByName] @petName VARCHAR(50)
AS
BEGIN
	SET NOCOUNT ON;

		SELECT Pet_Id
			, Name
			, AnimalType
			, Breed
			, Age
			, Weight
			, Sex
			, Customer_Id

		FROM dbo.Pet 
		WHERE Name = @petName;

END
GO

-- Phone STPs-- 
IF OBJECT_ID('dbo.stp_updatePhone') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_updatePhone] AS SELECT 1 TEST';
END
GO 
ALTER PROCEDURE [dbo].[stp_updatePhone] @mobilePhone VARCHAR(50), @homePhone VARCHAR(50), @phoneId INT
AS
BEGIN
	SET NOCOUNT ON;

		Update dbo.Phone SET Mobile = @mobilePhone, Home = @homePhone WHERE Phone_Id = @phoneId
		SELECT @@ROWCOUNT;
END
GO


-- Customer STPs --
IF OBJECT_ID('dbo.stp_getCustomerById') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getCustomerById] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_getCustomerById] @customerId INT

AS
BEGIN
	SET NOCOUNT ON;

		SELECT Address.Address_Id
			, Address_Type
			, Street
			, Supplemental
			, City
			, State
			, ZipCode
			,Address.Person_Id
		FROM dbo.Address
			LEFT JOIN dbo.Person ON Address.Person_Id = Person.Person_Id
			LEFT JOIN dbo.Customer ON Person.Person_Id = Customer.Person_Id
		WHERE Customer_Id = @customerId;

		SELECT Customer_Id
			, Person_Id
			, RegistrationDate
		FROM dbo.Customer
		WHERE Customer_Id = @customerId;

		SELECT Email.Email_Id
			, Personal_Email
			, Work_Email
		FROM dbo.Email
			LEFT JOIN dbo.Person ON Email.Email_Id = Person.Email_Id
			LEFT JOIN dbo.Customer ON Person.Person_Id = Customer.Person_Id
		WHERE Customer_Id = @customerId;

		SELECT Person.Person_Id
			, FirstName
			, LastName
			, Phone_Id
			, Email_Id
		FROM dbo.Person
			LEFT JOIN dbo.Customer ON Person.Person_Id = Customer.Person_Id
		WHERE Customer_Id = @customerId;

		SELECT Pet_Id
			, Name
			, AnimalType
			, Breed
			, Age
			, Weight
			, Sex
			, Customer_Id
		FROM dbo.Pet
		WHERE Customer_Id = @customerId;

		SELECT Phone.Phone_Id
			, Mobile
			, Home
			, Business
		FROM dbo.Phone
			LEFT JOIN dbo.Person ON Phone.Phone_Id = Person.Phone_Id
			LEFT JOIN dbo.Customer ON Person.Person_Id = Customer.Person_Id
		WHERE Customer_Id = @customerId;

END
GO

IF OBJECT_ID('dbo.stp_getCustomerByFirstAndLastNames') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getCustomerByFirstAndLastNames] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_getCustomerByFirstAndLastNames] @firstName VARCHAR(50), @lastName VARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;

	SELECT Person.Person_Id
		, Customer.Customer_Id
		, Person.FirstName
		, Person.LastName
		, Email.Personal_Email

	FROM dbo.Person JOIN dbo.Customer ON Person.Person_Id = Customer.Person_Id
	LEFT JOIN dbo.Email ON Email.Email_Id = Person.Email_Id
	WHERE Person.FirstName = @firstName AND Person.LastName = @lastName;

END
GO

IF OBJECT_ID('dbo.stp_insertNewCustomer') IS NULL
BEGIN
    EXEC sys.sp_executesql N'CREATE PROCEDURE dbo.stp_insertNewCustomer AS SELECT 1 AS TEST';
END;
GO

ALTER PROCEDURE dbo.stp_insertNewCustomer ( 
    @firstName                VARCHAR(50)     = NULL
  , @lastName                 VARCHAR(50)     = NULL
  , @registrationDate	      Date            = Null
  , @mobilePhone	          VARCHAR(50)     = NULL
  , @homePhone 		          VARCHAR(50)     = NULL
  , @businessPhone            VARCHAR(50)     = NULL
  , @personalEmail            VARCHAR(50)     = NULL
  , @workEmail                VARCHAR(50)     = NULL
  , @addressType	          INT			  = NULL
  , @street                   VARCHAR(50)     = NULL
  , @supplemental             VARCHAR(50)     = NULL
  , @city                     VARCHAR(50)     = NULL
  , @state                    VARCHAR(50)     = NULL
  , @zipCode                  VARCHAR(50)     = NULL
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        /* ********* Variables ******************/
        DECLARE @addressId INT = NULL, @phoneId INT = NULL, @emailId INT = NULL, @personId INT = NULL, @customerId INT = NULL, @now DATETIME = GETDATE();

		INSERT INTO [dbo].[Address] (Address_Type, Street, Supplemental, City, State, ZipCode, Person_Id)
		VALUES (@addressType, @street, @supplemental, @city, @state, @zipCode, @personId)

		SELECT @addressId = SCOPE_IDENTITY();

		INSERT INTO	[dbo].[Phone] (Mobile, Home, Business)
		VALUES (@mobilePhone, @homePhone, @businessPhone)

		SELECT @phoneId = SCOPE_IDENTITY();

		INSERT INTO	[dbo].[Email] (Personal_Email, Work_Email)
		VALUES (@personalEmail, @workEmail)

		SELECT @emailId = SCOPE_IDENTITY();

        INSERT INTO [dbo].[Person] (FirstName, LastName, Phone_Id, Email_Id)
        VALUES ( @firstName, @lastName, @phoneId, @emailId)

		SELECT @personId = SCOPE_IDENTITY();

		INSERT INTO [dbo].[Customer] (Person_Id, RegistrationDate)
		VALUES ( @personId, @registrationDate)

		SELECT @customerId = SCOPE_IDENTITY();

		 
        IF (ISNULL(@addressId, 0) <= 1)
            RAISERROR(N'ERROR!  Address ID (%i) should be greater than zero!!!' ,16 ,1 , @addressId)
		IF (ISNULL(@phoneId, 0) <= 1)
            RAISERROR(N'ERROR!  Phone ID (%i) should be greater than zero!!!' ,16 ,1 , @phoneId)
		IF (ISNULL(@emailId, 0) <= 1)
            RAISERROR(N'ERROR!  Email ID (%i) should be greater than zero!!!' ,16 ,1 , @emailId)
		IF (ISNULL(@personId, 0) <= 1)
            RAISERROR(N'ERROR!  Person ID (%i) should be greater than zero!!!' ,16 ,1 , @personId)
		IF (ISNULL(@customerId, 0) <= 1)
            RAISERROR(N'ERROR!  Customer ID (%i) should be greater than zero!!!' ,16 ,1 , @customerId)

		SELECT Address_Id
			, Address_Type
			, Street
			, Supplemental
			, City
			, State
			, ZipCode
			,Person_Id
		FROM dbo.Address
		WHERE Address_Id = @addressId;

		SELECT Customer_Id
			, Person_Id
			, RegistrationDate
		FROM dbo.Customer
		WHERE Customer_Id = @customerId;

		SELECT Email_Id
			, Personal_Email
			, Work_Email
		FROM dbo.Email
		WHERE Email_Id = @emailId;

		SELECT Person_Id
			, FirstName
			, LastName
			, Phone_Id
			, Email_Id
		FROM dbo.Person
		WHERE Person_Id = @personId;

		SELECT Phone_Id
			, Mobile
			, Home
			, Business
		FROM dbo.Phone
		WHERE Phone_Id = @phoneId

        /* ********* END ********************/
        --ROLLBACK TRANSACTION;

        --PRINT CHAR(13) + '!TRANSACTION ROLLED BACK!';
    COMMIT TRANSACTION; PRINT CHAR(13) + '!TRANSACTION COMMITTED!'
    END TRY
    BEGIN CATCH
        DECLARE @errorMessage  VARCHAR(1000) = ERROR_MESSAGE()
              , @errorSeverity INT           = ERROR_SEVERITY()
              , @errorState    INT           = ERROR_STATE();

        ROLLBACK TRANSACTION;

        RAISERROR(@errorMessage, @errorSeverity, @errorState);
    END CATCH;
END;
GO


-- EMPLOYEE STPs --
IF OBJECT_ID('dbo.stp_updateEmployeeWithTermination') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_updateEmployeeWithTermination] AS SELECT 1 TEST';
END
GO 
ALTER PROCEDURE [dbo].[stp_updateEmployeeWithTermination] @title VARCHAR(50), @hireDate DATE, @terminationDate DATE, @role INT, @employeeId INT
AS
BEGIN
	SET NOCOUNT ON;

		Update dbo.Employee SET Title = @title, HireDate = @hireDate, TerminationDate = @terminationDate, Role = @role WHERE Employee_Id = @employeeId 
		SELECT @@ROWCOUNT;
END
GO
IF OBJECT_ID('dbo.stp_updateEmployeeNoTermination') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_updateEmployeeNoTermination] AS SELECT 1 TEST';
END
GO 
ALTER PROCEDURE [dbo].[stp_updateEmployeeNoTermination] @title VARCHAR(50), @hireDate DATE, @role INT, @employeeId INT
AS
BEGIN
	SET NOCOUNT ON;

		Update dbo.Employee SET Title = @title, HireDate = @hireDate, Role = @role WHERE Employee_Id = @employeeId 
		SELECT @@ROWCOUNT;
END
GO

IF OBJECT_ID('dbo.stp_getEmployeeById') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getEmployeeById] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_getEmployeeById] @employeeId INT

AS
BEGIN
	SET NOCOUNT ON;

		SELECT Employee_Id
			, Person_Id
			, Title
			, HireDate
			, TerminationDate
			, Role
		FROM dbo.Employee
		WHERE Employee_Id  = @employeeId;

		SELECT Person.Person_Id
			, FirstName
			, LastName
		FROM dbo.Person JOIN dbo.Employee ON Employee.Person_Id = Person.Person_Id
		WHERE Employee_Id  = @employeeId;

		SELECT Phone.Phone_Id
			, Mobile
			, Home
		FROM dbo.Phone JOIN dbo.Person ON Person.Phone_Id = Phone.Phone_Id
			JOIN dbo.Employee on Employee.Person_Id = Person.Person_Id
		WHERE Employee_Id  = @employeeId;

		SELECT Email.Email_Id
			, Personal_Email
		FROM dbo.Email JOIN dbo.Person ON Person.Email_Id = Email.Email_Id
			JOIN dbo.Employee ON Employee.Person_Id = Person.Person_Id
		WHERE Employee_Id  = @employeeId;

		SELECT Address.Address_Id
			, Address_Type
			, Street
			, Supplemental
			, City
			, State
			, ZipCode
			, Address.Person_Id
		FROM dbo.Address JOIN dbo.Person ON Person.Person_Id = Address.Person_Id
			JOIN dbo.Employee ON Employee.Person_Id = Person.Person_Id
		WHERE Employee_Id  = @employeeId;
END
GO

IF OBJECT_ID('dbo.stp_getEmployeeByUsername') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getEmployeeByUsername] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_getEmployeeByUsername] @username NVARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;

		SELECT [Employee_Id] 
	, [Title]
	, [HireDate]
	, [username]
	, [password]
	, [Role]

	FROM dbo.Employee

	WHERE [Username] = @username;

END
GO

IF OBJECT_ID('dbo.stp_getEmployeeByFirstAndLastNames') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_getEmployeeByFirstAndLastNames] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_getEmployeeByFirstAndLastNames] @firstName NVARCHAR(50), @lastName NVARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;
	 
	SELECT Person.Person_Id
		, Employee.Employee_Id
		, Person.FirstName
		, Person.LastName
		, Employee.Title
		, Employee.HireDate
		, Employee.TerminationDate

	FROM dbo.Person JOIN dbo.Employee ON Employee.Person_Id = Person.Person_Id
	WHERE Person.FirstName = @firstName AND Person.LastName = @lastName;

END
GO

IF OBJECT_ID('dbo.stp_employeeLogin') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE PROCEDURE [stp_employeeLogin] AS SELECT 1 TEST';
END 
GO

ALTER PROCEDURE [dbo].[stp_employeeLogin] @username NVARCHAR(50), @password NVARCHAR(50)

AS
BEGIN
	SET NOCOUNT ON;

	SELECT [Employee_Id] 
	, [Title]
	, [HireDate]
	, [username]
	, [password]
	, [Role]
	, [Person_Id]

	FROM dbo.Employee

	WHERE [Username] = @username AND [password] = @password;

END
GO

IF OBJECT_ID('dbo.stp_insertNewEmployee') IS NULL
BEGIN
    EXEC sys.sp_executesql N'CREATE PROCEDURE dbo.stp_insertNewEmployee AS SELECT 1 AS TEST';
END;
GO

ALTER PROCEDURE dbo.stp_insertNewEmployee ( 
    @firstName        VARCHAR(50)     = NULL
  , @lastName         VARCHAR(50)     = NULL
  , @title            VARCHAR(50)     = NULL
  , @hireDate         DATE            = NULL
  , @role			  INT			  = NULL
  , @userName         VARCHAR(50)     = NULL
  , @password         VARCHAR(50)     = NULL
  , @mobilePhone	  VARCHAR(50)     = NULL
  , @homePhone 		  VARCHAR(50)     = NULL
  , @businessPhone    VARCHAR(50)     = NULL
  , @personalEmail    VARCHAR(50)     = NULL
  , @workEmail        VARCHAR(50)     = NULL
  , @addressType	  INT			  = NULL
  , @street           VARCHAR(50)     = NULL
  , @supplemental     VARCHAR(50)     = NULL
  , @city             VARCHAR(50)     = NULL
  , @state            VARCHAR(50)     = NULL
  , @zipCode          VARCHAR(50)     = NULL
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        /* ********* Variables ******************/
        DECLARE @addressId INT = NULL, @phoneId INT = NULL, @emailId INT = NULL, @personId INT = NULL, @employeeId INT = NULL, @now DATETIME = GETDATE();

		INSERT INTO [dbo].[Address] (Address_Type, Street, Supplemental, City, State, ZipCode, Person_Id)
		VALUES (@addressType, @street, @supplemental, @city, @state, @zipCode, @personId)

		SELECT @addressId = SCOPE_IDENTITY();

		INSERT INTO	[dbo].[Phone] (Mobile, Home, Business)
		VALUES (@mobilePhone, @homePhone, @businessPhone)

		SELECT @phoneId = SCOPE_IDENTITY();

		INSERT INTO	[dbo].[Email] (Personal_Email, Work_Email)
		VALUES (@personalEmail, @workEmail)

		SELECT @emailId = SCOPE_IDENTITY();

        INSERT INTO [dbo].[Person] (FirstName, LastName, Phone_Id, Email_Id)
        VALUES ( @firstName, @lastName, @phoneId, @emailId)

		SELECT @personId = SCOPE_IDENTITY();

		INSERT INTO [dbo].[Employee] (Title, HireDate, Role, Username, Password, Person_Id)
		VALUES (@title , @hireDate, @role, @userName, @password, @personId)

		SELECT @employeeId = SCOPE_IDENTITY();

        IF (ISNULL(@addressId, 0) <= 1)
            RAISERROR(N'ERROR!  Address ID (%i) should be greater than zero!!!' ,16 ,1 , @addressId)
		IF (ISNULL(@phoneId, 0) <= 1)
            RAISERROR(N'ERROR!  Phone ID (%i) should be greater than zero!!!' ,16 ,1 , @phoneId)
		IF (ISNULL(@emailId, 0) <= 1)
            RAISERROR(N'ERROR!  Email ID (%i) should be greater than zero!!!' ,16 ,1 , @emailId)
		IF (ISNULL(@personId, 0) <= 1)
            RAISERROR(N'ERROR!  Person ID (%i) should be greater than zero!!!' ,16 ,1 , @personId)
		IF (ISNULL(@employeeId, 0) <= 1)
            RAISERROR(N'ERROR!  Employee ID (%i) should be greater than zero!!!' ,16 ,1 , @employeeId)

		SELECT Address_Id
			, Address_Type
			, Street
			, Supplemental
			, City
			, State
			, ZipCode
			, Address.Person_Id
		FROM dbo.Address
		WHERE Address_Id = @addressId;

		SELECT Email_Id
			, Personal_Email
			, Work_Email
		FROM dbo.Email
		WHERE Email_Id = @emailId;

		SELECT Employee_Id
			, Title
			, HireDate
			, Role
			, Username
			, Password
			, Person_Id

		FROM dbo.Employee
		WHERE Employee_Id = @employeeId;

		SELECT Person_Id
			, FirstName
			, LastName
			, Phone_Id
			, Email_Id
		FROM dbo.Person
		WHERE Person_Id = @personId;

		SELECT Phone_Id
			, Mobile
			, Home
			, Business
		FROM dbo.Phone
		WHERE Phone_Id = @phoneId

        /* ********* END ********************/
        --ROLLBACK TRANSACTION;

        --PRINT CHAR(13) + '!TRANSACTION ROLLED BACK!';
    COMMIT TRANSACTION; PRINT CHAR(13) + '!TRANSACTION COMMITTED!'
    END TRY
    BEGIN CATCH
        DECLARE @errorMessage  VARCHAR(1000) = ERROR_MESSAGE()
              , @errorSeverity INT           = ERROR_SEVERITY()
              , @errorState    INT           = ERROR_STATE();

        ROLLBACK TRANSACTION;

        RAISERROR(@errorMessage, @errorSeverity, @errorState);
    END CATCH;
END;
GO
