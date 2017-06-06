CREATE DATABASE [Airlines]	-- create database
GO

DROP DATABASE [Airlines]	-- drop database
GO

USE [Airlines]	-- using database
GO

IF OBJECT_ID('Airports') IS NOT NULL
	DROP TABLE dbo.Airports;
GO
CREATE TABLE [dbo].[Airports]
(
	[AirportID] int IDENTITY(1,1) NOT NULL,
	[City] nvarchar(60) NOT NULL,
	[Title] nvarchar(60) NOT NULL,
	CONSTRAINT [PK_Airports_AirportID] PRIMARY KEY CLUSTERED 
	([AirportID] ASC)
);
GO

IF OBJECT_ID('Airplanes') IS NOT NULL
	DROP TABLE dbo.Airplanes;
GO
CREATE TABLE [dbo].[Airplanes]
(
	[AirplaneID] int IDENTITY(1,1) NOT NULL,
	[AirplaneType] nvarchar(60) NOT NULL,
	[NumberOfSeats] int NOT NULL,
	CONSTRAINT [PK_Airplanes_AirplaneID] PRIMARY KEY CLUSTERED 
	([AirplaneID] ASC)
);
GO

IF OBJECT_ID('Airlines') IS NOT NULL
	DROP TABLE dbo.Airlines;
GO
CREATE TABLE [dbo].[Airlines]
(
	[AirlineID] int IDENTITY(1,1) NOT NULL,
	[Title] nvarchar(60) NOT NULL,
	[Rating] tinyint NOT NULL,
	CONSTRAINT [PK_Airlines_AirlineID] PRIMARY KEY CLUSTERED 
	([AirlineID] ASC)
);
GO

IF OBJECT_ID('Flights') IS NOT NULL
	DROP TABLE dbo.Flights;
GO
CREATE TABLE [dbo].[Flights]
(
	[FlightID] int IDENTITY(1,1) NOT NULL,
	[AirplaneID] int NOT NULL,
	[AirlineID] int NOT NULL,
	[FlightNumber] int NOT NULL,
	[Origin] int NOT NULL,
	[DepartureTime] datetime NOT NULL,
	[Destination] int NOT NULL,
	[ArrivalTime] datetime NOT NULL,
	[FreeSeats] int NOT NULL,
	[Price] money NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	CONSTRAINT [PK_Flights_FlightID] PRIMARY KEY NONCLUSTERED 
	([FlightID] ASC)
);
GO

IF OBJECT_ID('Bookings') IS NOT NULL
	DROP TABLE dbo.Bookings;
GO
CREATE TABLE [dbo].[Bookings]
(
	[BookingID] int NOT NULL,
	[FlightID] int NOT NULL,
	[PassportNumber] nvarchar(9) NOT NULL,
	[PassName] nvarchar(50) NOT NULL,
	[PassAge] [tinyint] NOT NULL,
	[PassGender] [bit] NOT NULL,
	[CreateDate] [datetime] NOT NULL,
	CONSTRAINT [PK_Bookings_BookingID] PRIMARY KEY NONCLUSTERED 
	([BookingID] ASC)
)
GO

ALTER TABLE [dbo].[Airlines] ADD DEFAULT ((0)) FOR [Rating]
GO
ALTER TABLE [dbo].[Flights] ADD DEFAULT (getdate()) FOR [CreateDate]
GO
ALTER TABLE [dbo].[Airplanes] WITH NOCHECK ADD CONSTRAINT [CK_NumberOfSeats] CHECK (([NumberOfSeats]>(0)))
GO
ALTER TABLE [dbo].[Airplanes] CHECK CONSTRAINT [CK_NumberOfSeats]
GO
ALTER TABLE [dbo].[Flights] WITH NOCHECK ADD CONSTRAINT [FreeSeats] CHECK (([FreeSeats]>=(0) AND [FreeSeats]<=[dbo].[fnGetNumberOfSeats]([AirplaneID])))
GO
ALTER TABLE [dbo].[Flights] CHECK CONSTRAINT [FreeSeats]
GO

ALTER TABLE [dbo].[Flights] WITH NOCHECK ADD CONSTRAINT [FK_AirlineID] FOREIGN KEY([AirlineID])
REFERENCES [dbo].[Airlines] ([AirlineID])
GO
ALTER TABLE [dbo].[Flights] CHECK CONSTRAINT [FK_AirlineID]
GO

ALTER TABLE [dbo].[Flights] WITH NOCHECK ADD CONSTRAINT [FK_AirplaneID] FOREIGN KEY([AirplaneID])
REFERENCES [dbo].[Airplanes] ([AirplaneID])
GO
ALTER TABLE [dbo].[Flights] CHECK CONSTRAINT [FK_AirplaneID]
GO

ALTER TABLE [dbo].[Flights] WITH NOCHECK ADD CONSTRAINT [FK_DestinationID] FOREIGN KEY([Destination])
REFERENCES [dbo].[Airports] ([AirportID])
GO
ALTER TABLE [dbo].[Flights] CHECK CONSTRAINT [FK_DestinationID]
GO

ALTER TABLE [dbo].[Flights] WITH NOCHECK ADD CONSTRAINT [FK_OriginID] FOREIGN KEY([Origin])
REFERENCES [dbo].[Airports]([AirportID])
GO
ALTER TABLE [dbo].[Flights] CHECK CONSTRAINT [FK_OriginID]
GO

ALTER TABLE [dbo].[Bookings] ADD DEFAULT (getdate()) FOR [CreateDate]
GO

ALTER TABLE [dbo].[Bookings] WITH CHECK ADD CONSTRAINT [FK_FlightID] FOREIGN KEY([FlightID])
REFERENCES [dbo].[Flights] ([FlightID])
GO
ALTER TABLE [dbo].[Bookings] CHECK CONSTRAINT [FK_FlightID]
GO

ALTER TABLE [dbo].[Airports] ADD
	[IATA] nvarchar(10) NOT NULL;
GO