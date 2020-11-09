CREATE TABLE [dbo].[Table] (
    [Id]        INT NOT NULL IDENTITY,
    [name]     VARCHAR (50) NULL,
    [surname]       VARCHAR (50) NULL,
    [email]    VARCHAR (50) NULL,
    [password] VARCHAR (50) NULL,
    [dateOfBirth]    VARCHAR (50) NULL,
    [cardType]  VARCHAR (50) NULL,
    [cardNumber]  VARCHAR (50) NULL,
    [expiryDate]         VARCHAR (50) NULL,
    [ccv]    VARCHAR (50) NULL,
    [duration]          VARCHAR(50) NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])
);

