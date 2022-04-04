CREATE TABLE [dbo].[Events] (
    [EventId]     INT           IDENTITY (1, 1) NOT NULL,
    [OrganizerId] VARCHAR (50)  NOT NULL,
    [Title]       VARCHAR (250) NOT NULL,
    [StartDate]   DATE          NOT NULL,
    [StartTime]   TIME (7)      NOT NULL,
    [EndDate]     DATE          NOT NULL,
    [EndTime]     TIME (7)      NOT NULL,
    [Url]         VARCHAR (MAX) NOT NULL,
    [Notes]       VARCHAR (MAX) NULL,
    CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED ([EventId] ASC)
);

