CREATE TABLE [TbPoi] (
    [Id] int NOT NULL IDENTITY,
    [Name] varchar(20) NOT NULL,
	CoordX int not null,
	CoordY int not null,
    CONSTRAINT [PK_POI] PRIMARY KEY ([Id])
);