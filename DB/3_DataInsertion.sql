USE [Vehicles]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
  
  Insert into [Vehicles].[dbo].[User] values (1, 'Asier', 'Areizaga', '11111111A', 'B', 999999999);
  Insert into [Vehicles].[dbo].[User] values (2, 'Juan', 'Garcia', '22222222A', 'B', 888888888);
  Insert into [Vehicles].[dbo].[User] values (3, 'Pablo', 'Gomez', '33333333A', 'B', 777777777);
  Insert into [Vehicles].[dbo].[User] values (4, 'Nuria', 'Perez', '44444444A', 'C', 555555555);
  Insert into [Vehicles].[dbo].[User] values (5, 'Laura', 'Vicent', '55555555A', 'B', 333333333);
  Insert into [Vehicles].[dbo].[User] values (6, 'Maria', 'Smith', '66666666A', 'A', 222222222);

  Insert into [Vehicles].[dbo].[Vehicle] values (1, 'Renault', 'Megan', 120, 2, 1);
  Insert into [Vehicles].[dbo].[Vehicle] values (2, 'Mercedes', 'Benz', 140, 1, 1);
  Insert into [Vehicles].[dbo].[Vehicle] values (3, 'Ford', 'Mondeo', 120, 2, 2);
  Insert into [Vehicles].[dbo].[Vehicle] values (4, 'Dacia', 'Logan', 100, 3, 2);
  Insert into [Vehicles].[dbo].[Vehicle] values (5, 'Renault', 'Megan', 120, 2, 3);
  Insert into [Vehicles].[dbo].[Vehicle] values (6, 'Renault', 'Megan', 120, 2, 4);
  Insert into [Vehicles].[dbo].[Vehicle] values (7, 'Mercedes', 'Benz', 140, 1, 6);
  Insert into [Vehicles].[dbo].[Vehicle] values (8, 'Ford', 'Mondeo', 120, 2, 5);
  Insert into [Vehicles].[dbo].[Vehicle] values (9, 'Dacia', 'Logan', 100, 3, 5);
  Insert into [Vehicles].[dbo].[Vehicle] values (10, 'Renault', 'Megan', 120, 2, 5);