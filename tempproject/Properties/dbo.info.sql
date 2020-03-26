CREATE TABLE [dbo].[info] (
    [Id]             INT            NOT NULL,
    [FirstName]      NVARCHAR (50)  NULL,
    [MiddleName]     NVARCHAR (50)  NULL,
    [LastName]       NVARCHAR (50)  NULL,
    [FatherName]     NVARCHAR (50)  NULL,
    [MotherName]     NVARCHAR (50)  NULL,
    [PresentAddress] NVARCHAR (150) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


