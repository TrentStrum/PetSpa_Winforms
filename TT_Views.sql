use TrentsTroubleMakersDb; 
go 

IF OBJECT_ID('dbo.Get_Pet_And_Owners') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE VIEW [Get_Pet_And_Owners] AS SELECT 1 TEST';
END
GO 

-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
ALTER VIEW dbo.Get_Pet_And_Owners 
AS 
	SELECT	* 
	FROM	Pet p
	INNER JOIN
			Person pp
			on p.Customer_Id = pp.Person_Id; 

IF OBJECT_ID('dbo.Get_PetCustomerAppointments') IS NULL
BEGIN
	EXEC SYS.sp_executesql N'CREATE VIEW [Get_PetCustomerAppointments] AS SELECT 1 TEST';
END
GO 

ALTER VIEW dbo.Get_PetCustomerAppointments
AS 
	SELECT	pt.Name
		, pn.FirstName
		, pn.LastName
		, CheckInDateTime
		, CheckOutDateTime
		, SpecialInstructions

	FROM dbo.Appointment as a
		JOIN dbo.Pet as pt ON a.Pet_Id = pt.Pet_Id
		JOIN dbo.Customer as c ON pt.Customer_Id = c.Customer_Id
		JOIN dbo.Person as pn ON c.Customer_Id = pn.Person_Id;


