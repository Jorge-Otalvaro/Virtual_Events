CREATE TABLE [dbo].[AttendanceAttanchments] (
    [AttendanceAttachmentId] INT          IDENTITY (1, 1) NOT NULL,
    [AttendanceId]           INT          NOT NULL,
    [Name]                   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_AttendanceAttanchments] PRIMARY KEY CLUSTERED ([AttendanceAttachmentId] ASC),
    CONSTRAINT [FK_AttendanceAttanchments_Attendances] FOREIGN KEY ([AttendanceId]) REFERENCES [dbo].[Attendances] ([AttendanceId])
);



