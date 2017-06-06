USE Airlines;
GO

/*********************************
		TABLE AIRPLANES
 *********************************/
IF OBJECT_ID('fnGetNumberOfSeats') IS NOT NULL
	DROP FUNCTION dbo.fnGetNumberOfSeats;
GO
CREATE FUNCTION [dbo].[fnGetNumberOfSeats](@AirplaneID int)
RETURNS int
BEGIN
	RETURN (SELECT [NumberOfSeats] 
			FROM [dbo].[Airplanes]
			WHERE [dbo].[Airplanes].[AirplaneID] = @AirplaneID
	)
END
GO

/*********************************
		TABLE BOOKINGS 
 *********************************/
IF OBJECT_ID('FilterBookingPassAge') IS NOT NULL
	DROP PROC dbo.FilterBookingPassAge;
GO
CREATE PROC dbo.FilterBookingPassAge(@from INT, @to INT)
AS
BEGIN
	SELECT * FROM dbo.Bookings
	WHERE (PassAge >= @from) AND (PassAge <= @to)
	ORDER BY PassAge ASC, PassName ASC
END

-- TESTS
EXEC dbo.FilterBookingPassAge @from = 18, @to = 30
EXEC dbo.FilterBookingPassAge @from = 20, @to = 20
GO

IF OBJECT_ID('FilterBookingCreateDate') IS NOT NULL
	DROP PROC dbo.FilterBookingCreateDate;
GO
CREATE PROC dbo.FilterBookingCreateDate(@from DATETIME, @to DATETIME)
AS
BEGIN
	SELECT * FROM dbo.Bookings
	WHERE (CreateDate >= @from) AND (CreateDate <= @to)
	ORDER BY CreateDate ASC, PassAge ASC, PassName ASC
END

-- TESTS
EXEC dbo.FilterBookingCreateDate @from = '2016-03-18', @to = '2016-03-18'
GO



/*********************************
		TABLE FLIGHTS 
 *********************************/
IF OBJECT_ID('GetAirportName') IS NOT NULL
	DROP FUNCTION dbo.GetAirportName;
GO
CREATE FUNCTION [dbo].[GetAirportName](@id INT)
RETURNS NVARCHAR(60)
AS
BEGIN
	RETURN (SELECT Title
			FROM dbo.Airports
			WHERE AirportID = @id
	)
END
GO

IF OBJECT_ID('GetAirportLocation') IS NOT NULL
	DROP FUNCTION dbo.GetAirportLocation;
GO
CREATE FUNCTION [dbo].[GetAirportLocation](@id INT)
RETURNS NVARCHAR(60)
AS
BEGIN
	RETURN (SELECT City
			FROM dbo.Airports
			WHERE AirportID = @id
	)
END
GO

IF OBJECT_ID('GetAirportIATA') IS NOT NULL
	DROP FUNCTION dbo.GetAirportIATA;
GO
CREATE FUNCTION [dbo].[GetAirportIATA](@id INT)
RETURNS NVARCHAR(10)
AS
BEGIN
	RETURN (SELECT IATA
			FROM dbo.Airports
			WHERE AirportID = @id
	)
END
GO

IF OBJECT_ID('GetAirlineTitle') IS NOT NULL
	DROP FUNCTION dbo.GetAirlineTitle;
GO
CREATE FUNCTION [dbo].[GetAirlineTitle](@id INT)
RETURNS NVARCHAR(60)
AS
BEGIN
	RETURN (SELECT Title
			FROM dbo.Airlines
			WHERE AirlineID = @id
	)
END
GO

-- TESTS	
SELECT dbo.GetAirportName(12) AS [Name]
SELECT dbo.GetAirportLocation(2) AS [Location], dbo.GetAirportIATA(2) AS [Code]
SELECT dbo.GetAirlineTitle(5) AS [Airline]
GO

IF OBJECT_ID('GetFullFlightInfor') IS NOT NULL
	DROP PROC dbo.GetFullFlightInfor;
GO
CREATE PROCEDURE dbo.GetFullFlightInfor
AS
BEGIN
	SELECT  FlightID,
			dbo.GetAirlineTitle(Flights.AirlineID) AS [Airline Title],
			FlightNumber,
			dbo.GetAirportName(Flights.Origin) + ' (' + dbo.GetAirportIATA(Flights.Origin) + ')' AS [Departure],
			dbo.GetAirportLocation(Flights.Origin) AS [Departure Location],
			dbo.GetAirportName(Flights.Destination) + ' (' + dbo.GetAirportIATA(Flights.Destination) + ')' AS [Arrival],
			dbo.GetAirportLocation(Flights.Destination) AS [Arrival Location],
			DepartureTime [Departure Time (GMT)], 
			ArrivalTime AS [Arrival Time (GMT)],
			ROUND((DATEDIFF(MINUTE, DepartureTime, ArrivalTime) / 60.0), 2) AS [Flight Time (hours)]
	FROM dbo.Flights;
END
GO

EXEC dbo.GetFullFlightInfor;
GO

