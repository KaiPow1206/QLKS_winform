CREATE TABLE [dbo].[rooms] (
    [roomid]      INT           IDENTITY (1, 1) NOT NULL,
    [roomNum]     VARCHAR (250) NOT NULL,
    [roomType]    VARCHAR (250) NOT NULL,
    [bed]         VARCHAR (250) NOT NULL,
    [price]       BIGINT        NOT NULL,
    [statusRoom]  VARCHAR (50)  DEFAULT ('Chill') NULL,
    [service]     VARCHAR (50)  NOT NULL,
    [statusClean] VARCHAR (50)  DEFAULT ('Cleaned') NULL,
    PRIMARY KEY CLUSTERED ([roomid] ASC)
);

