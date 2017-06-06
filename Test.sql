Use Airlines;
GO

Select * from dbo.Airports where City like '%Russ%';
GO

SELECT * FROM dbo.Bookings WHERE FlightID = 96
GO

select * from Airplanes
insert into dbo.Airplanes values('Boeing ZZZ', 2); 
set identity_insert dbo.Airplanes off;
delete from dBo.Airplanes where AirplaneID >= 8;