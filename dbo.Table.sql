CREATE TABLE [dbo].[rooms] (
    [roomid]   INT           IDENTITY (1, 1)  PRIMARY KEY,
    [roomNum]   VARCHAR (250) NOT NULL,
    [roomType] VARCHAR (250) NOT NULL,
    [bed]      VARCHAR (250) NOT NULL,
    [price]    BIGINT        NOT NULL,
    [statusRoom]   VARCHAR (50)  NOT NULL,
	[service] VARCHAR(50) NOT NULL,
    [statusClean]   VARCHAR (50) Default ('Cleaned') NULL,

);
