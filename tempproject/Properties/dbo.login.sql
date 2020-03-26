CREATE TABLE [dbo].[login] (
    [Id]           INT            ,
    [UserName]     NVARCHAR (50)  ,
    [Password]     NVARCHAR (50)  ,
    [EmailAddress] NVARCHAR (100) ,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);


