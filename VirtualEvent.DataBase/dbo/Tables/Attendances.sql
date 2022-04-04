CREATE TABLE [dbo].[Attendances] (
    [AttendanceId]   INT           IDENTITY (1, 1) NOT NULL,
    [EventId]        INT           NOT NULL,
    [FullName]       VARCHAR (250) NOT NULL,
    [Email]          VARCHAR (50)  NOT NULL,
    [Notes]          VARCHAR (MAX) NULL,
    [AttendanceDate] DATE          NOT NULL,
    CONSTRAINT [PK_Attendance] PRIMARY KEY CLUSTERED ([AttendanceId] ASC),
    CONSTRAINT [FK_Attendances_Events] FOREIGN KEY ([EventId]) REFERENCES [dbo].[Events] ([EventId])
);

