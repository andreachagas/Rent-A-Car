CREATE TABLE [dbo].[Cars] (
    [CarId]    INT            IDENTITY (1, 1) NOT NULL,
    [CarMake]  NVARCHAR (MAX) NOT NULL,
    [CarModel] NVARCHAR (MAX) NOT NULL,
    [CarType]  NVARCHAR (MAX) NOT NULL,
    [CarPrice] INT            NOT NULL,
    CONSTRAINT [PK_dbo.Cars] PRIMARY KEY CLUSTERED ([CarId] ASC)
);

