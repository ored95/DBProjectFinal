USE Airlines;
GO

IF OBJECT_ID('FlightMap') IS NOT NULL
	DROP TABLE dbo.FlightMap;
GO
CREATE TABLE dbo.FlightMap
(
	[Origin] int NOT NULL,
	[Destination] int NOT NULL,
	[Times] FLOAT NOT NULL,
	[Price] FLOAT NOT NULL
)
GO

BULK INSERT dbo.FlightMap FROM 'D:\Database\Source\FlightMap.txt'
WITH (DATAFILETYPE = 'char', FIELDTERMINATOR = ';', ROWTERMINATOR = '\n');
GO

SELECT * FROM dbo.FlightMap
GO

/****************************************
			PROCEDURES of MAP
 ***************************************/
IF OBJECT_ID('GetFlightMapExtended') IS NOT NULL
	DROP PROC dbo.GetFlightMapExtended;
GO
CREATE PROC dbo.GetFlightMapExtended
AS
BEGIN
	SELECT	(1 + RAND() * 7) AS [AirlineID],
			Origin AS [OriginID],
			dbo.GetAirportName(Origin) + ' (' + dbo.GetAirportIATA(Origin) + ')' AS [Origin Title],
			dbo.GetAirportLocation(Origin) AS [Origin Location],
			Destination AS [DestinationID],
			dbo.GetAirportName(Destination) + ' (' + dbo.GetAirportIATA(Destination) + ')' AS [Destination Title],
			dbo.GetAirportLocation(Destination) AS [Destination Location],
			Times AS [Flight Time (hours)],
			Price AS [Flight Price (dollars)]
	FROM dbo.FlightMap
END
GO

EXEC dbo.GetFlightMapExtended;
GO

/*************************************************
			TRANSIT MAP SEARCH
 ************************************************/
IF OBJECT_ID('GetFlightMapTransit') IS NOT NULL
	DROP PROC dbo.GetFlightMapTransit;
GO
CREATE PROC dbo.GetFlightMapTransit(@from INT, @to INT)
AS
BEGIN
	SELECT	TMap.Origin AS [OriginID],
			dbo.GetAirportName(TMap.Origin) + ' (' + dbo.GetAirportIATA(TMap.Origin) + ')' AS [Origin Tilte],
			dbo.GetAirportLocation(TMap.Origin) AS [Origin Location],
			TMap.Destination AS [DestinationID],
			dbo.GetAirportName(TMap.Destination) + ' (' + dbo.GetAirportIATA(TMap.Destination) + ')' AS [Destination Title],
			dbo.GetAirportLocation(TMap.Destination) AS [Destination Location],
			N'Transit' AS [Transit],
			CAST(TMap.Origin AS NVARCHAR(5)) + ' - ' + CAST(TMap.Transit AS NVARCHAR(5)) + ' - '  + CAST(TMap.Destination AS NVARCHAR(5)) AS [Code],
			dbo.GetAirportIATA(TMap.Origin) + ' - ' + dbo.GetAirportIATA(TMap.Transit) + ' - ' + dbo.GetAirportIATA(TMap.Destination) AS [Direction],
			TMap.TotalTime AS [Flight Time],
			TMap.TransitPrice AS [Price]
	FROM (SELECT MapA.Origin AS [Origin],
				 MapA.Destination AS [Transit],
				 MapB.Destination AS [Destination],
				 ROUND((MapA.Times + ROUND((RAND() * 24), 2) + MapB.Times), 2) AS [TotalTime],
				 ROUND(((MapA.Price + MapB.Price) * (90.0 + ROUND((RAND() * 10), 2)) / 100), 2) AS [TransitPrice]
		  FROM dbo.FlightMap AS MapA JOIN dbo.FlightMap AS MapB ON MapA.Destination = MapB.Origin
		  WHERE MapA.Origin <> MapB.Destination
		 ) AS TMap
	WHERE TMap.Origin = @from AND TMap.Destination = @to
	ORDER BY [Flight Time]
END
GO

EXEC dbo.GetFlightMapTransit @from = 1, @to = 12
GO

IF OBJECT_ID('GetFlightMapDirect') IS NOT NULL
	DROP PROC dbo.GetFlightMapDirect;
GO
CREATE PROC dbo.GetFlightMapDirect(@from INT, @to INT)
AS
BEGIN
	SELECT	TMap.Origin AS [OriginID],
			dbo.GetAirportName(TMap.Origin) + ' (' + dbo.GetAirportIATA(TMap.Origin) + ')' AS [Origin Tilte],
			dbo.GetAirportLocation(TMap.Origin) AS [Origin Location],
			TMap.Destination AS [DestinationID],
			dbo.GetAirportName(TMap.Destination) + ' (' + dbo.GetAirportIATA(TMap.Destination) + ')' AS [Destination Title],
			dbo.GetAirportLocation(TMap.Destination) AS [Destination Location],
			N'Direct' AS [Transit],
			CAST(TMap.Origin AS NVARCHAR(5)) + ' - ' + CAST(TMap.Destination AS NVARCHAR(5)) AS [Code],
			dbo.GetAirportIATA(TMap.Origin) + ' - ' + dbo.GetAirportIATA(TMap.Destination) AS [Direction],
			TMap.Times [Flight Time],
			TMap.Price AS [Price]
	FROM dbo.FlightMap AS TMap
	WHERE TMap.Origin = @from AND TMap.Destination = @to
	ORDER BY [Flight Time]
END
GO

EXEC dbo.GetFlightMapDirect @from = 1, @to = 18
GO

IF OBJECT_ID('FlightSearching') IS NOT NULL
	DROP PROC dbo.FlightSearching;
GO
CREATE PROC dbo.FlightSearching(@from INT, @to INT)
AS
BEGIN
	-- USING TEMPORATORY TABLE TO SAVE RESULT OF SEARCHING.. (DYNAMICAL METHOD)
	CREATE TABLE #Temp
	(
		[OriginID] INT,
		[Origin Tilte] NVARCHAR(100),
		[Origin Location] NVARCHAR(60),
		[DestinationID] INT,
		[Destination Title] NVARCHAR(100),
		[Destination Location] NVARCHAR(60),
		[Transit] NVARCHAR(10),
		[Code] NVARCHAR(20),
		[Direction] NVARCHAR(20),
		[Flight Time] FLOAT,
		[Price] FLOAT
	)
	
	-- INSERT DATA TO TABLE (USING EXEC)
	INSERT #Temp
	EXEC dbo.GetFlightMapDirect @from = @from, @to = @to
	
	INSERT #Temp
	EXEC dbo.GetFlightMapTransit @from = @from, @to = @to
	
	-- SELECT DATA
	SELECT * FROM #Temp
	
	-- FREE TABLE (DYNAMICALLY)
	DROP TABLE #Temp
END
GO

EXEC dbo.FlightSearching @from = 1, @to = 24
GO

IF OBJECT_ID('FlightFromMoscowSearching') IS NOT NULL
	DROP PROC dbo.FlightFromMoscowSearching;
GO
CREATE PROC dbo.FlightFromMoscowSearching(@destination INT)
AS
BEGIN
	-- USING TEMPORATORY TABLE TO SAVE RESULT OF SEARCHING.. (DYNAMICAL METHOD)
	CREATE TABLE #Temp
	(
		[OriginID] INT,
		[Origin Tilte] NVARCHAR(100),
		[Origin Location] NVARCHAR(60),
		[DestinationID] INT,
		[Destination Title] NVARCHAR(100),
		[Destination Location] NVARCHAR(60),
		[Transit] NVARCHAR(10),
		[Code] NVARCHAR(20),
		[Direction] NVARCHAR(20),
		[Flight Time] FLOAT,
		[Price] FLOAT
	)
	
	-- INSERT DATA TO TABLE (USING EXEC)
	INSERT #Temp
	EXEC dbo.GetFlightMapDirect @from = 1, @to = @destination
	
	INSERT #Temp
	EXEC dbo.GetFlightMapTransit @from = 1, @to = @destination
	
	INSERT #Temp
	EXEC dbo.GetFlightMapDirect @from = 2, @to = @destination
	
	INSERT #Temp
	EXEC dbo.GetFlightMapTransit @from = 2, @to = @destination
	
	INSERT #Temp
	EXEC dbo.GetFlightMapDirect @from = 3, @to = @destination
	
	INSERT #Temp
	EXEC dbo.GetFlightMapTransit @from = 3, @to = @destination
	
	INSERT #Temp
	EXEC dbo.GetFlightMapDirect @from = 4, @to = @destination
	
	INSERT #Temp
	EXEC dbo.GetFlightMapTransit @from = 4, @to = @destination
	
	-- SELECT DATA
	SELECT * FROM #Temp
	
	-- FREE TABLE (DYNAMICALLY)
	DROP TABLE #Temp
END
GO

EXEC dbo.FlightFromMoscowSearching @destination = 23
GO

IF OBJECT_ID('FlightToMoscowSearching') IS NOT NULL
	DROP PROC dbo.FlightToMoscowSearching;
GO
CREATE PROC dbo.FlightToMoscowSearching(@origin INT)
AS
BEGIN
	-- USING TEMPORATORY TABLE TO SAVE RESULT OF SEARCHING.. (DYNAMICAL METHOD)
	CREATE TABLE #Temp
	(
		[OriginID] INT,
		[Origin Tilte] NVARCHAR(100),
		[Origin Location] NVARCHAR(60),
		[DestinationID] INT,
		[Destination Title] NVARCHAR(100),
		[Destination Location] NVARCHAR(60),
		[Transit] NVARCHAR(10),
		[Code] NVARCHAR(20),
		[Direction] NVARCHAR(20),
		[Flight Time] FLOAT,
		[Price] FLOAT
	)
	
	-- INSERT DATA TO TABLE (USING EXEC)
	INSERT #Temp
	EXEC dbo.GetFlightMapDirect @from = @origin, @to = 1
	
	INSERT #Temp
	EXEC dbo.GetFlightMapTransit @from = @origin, @to = 1
	
	INSERT #Temp
	EXEC dbo.GetFlightMapDirect @from = @origin, @to = 2
	
	INSERT #Temp
	EXEC dbo.GetFlightMapTransit @from = @origin, @to = 2
	
	INSERT #Temp
	EXEC dbo.GetFlightMapDirect @from = @origin, @to = 3
	
	INSERT #Temp
	EXEC dbo.GetFlightMapTransit @from = @origin, @to = 3
	
	INSERT #Temp
	EXEC dbo.GetFlightMapDirect @from = @origin, @to = 4
	
	INSERT #Temp
	EXEC dbo.GetFlightMapTransit @from = @origin, @to = 4
	
	-- SELECT DATA
	SELECT * FROM #Temp
	
	-- FREE TABLE (DYNAMICALLY)
	DROP TABLE #Temp
END
GO

EXEC dbo.FlightToMoscowSearching @origin = 23
GO
