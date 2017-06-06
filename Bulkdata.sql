USE Airlines;
GO

BULK INSERT dbo.Airlines FROM 'D:\Database\Source\Airlines.txt'
WITH (DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n');
GO

BULK INSERT dbo.Airplanes FROM 'D:\Database\Source\Airplanes.txt'
WITH (DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n');
GO

BULK INSERT dbo.Airports FROM 'D:\Database\Source\Airports.txt'
WITH (DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n');
GO

BULK INSERT dbo.Flights FROM 'D:\Database\Source\Flights.txt'
WITH (DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n');
GO

BULK INSERT dbo.Bookings FROM 'D:\Database\Source\Bookings.txt'
WITH (DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n');
GO

DELETE FROM dbo.Bookings;
GO