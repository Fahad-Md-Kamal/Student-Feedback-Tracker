﻿
-- User Roles Table
CREATE TABLE [dbo].[UserRoles]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [uRole] VARCHAR(50) NOT NULL
)


-- Users Table
CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Username] VARCHAR(100) NOT NULL, 
    [First Name] VARCHAR(50) NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Email] VARCHAR(100) NULL, 
    [Passsword] VARCHAR(20) NOT NULL, 
    [DoB] DATETIME2 NULL, 
    [JoinDate] DATETIME2 NULL,
    [LastLogin] DATETIME2 NULL, 
    [RoleId] INT NOT NULL, 
    CONSTRAINT [FK_Users_ToUserRoles] FOREIGN KEY ([RoleId]) REFERENCES [UserRoles]([Id]),
)


-- Courses Table
CREATE TABLE [dbo].[Courses]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1, 1), 
    [CourseName] VARCHAR(50) NOT NULL,
)



-- User's Courses Table
CREATE TABLE [dbo].[UserCourses]
(
	[UserId] INT NOT NULL, 
    [CourseId] INT NOT NULL, 
    CONSTRAINT [FK_UserCourses_ToUsers] FOREIGN KEY ([UserId]) REFERENCES [Users]([Id]), 
    CONSTRAINT [FK_UserCourses_ToCouses] FOREIGN KEY ([CourseId]) REFERENCES [Courses]([Id])
)



-- Subjects Table
CREATE TABLE [dbo].[Subjects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [SubjectName] VARCHAR(50) NOT NULL
)


-- Course Subejcts Table
CREATE TABLE [dbo].[CourseSubejcts]
(
	[CourseId] INT NOT NULL, 
    [SubjectId] INT NOT NULL, 
    CONSTRAINT [FK_CourseSubejcts_ToCourses] FOREIGN KEY ([CourseId]) REFERENCES [Courses]([Id]), 
    CONSTRAINT [FK_CourseSubejcts_ToSubjects] FOREIGN KEY ([SubjectId]) REFERENCES [Subjects]([Id])
)


-- AssessmentType Table
CREATE TABLE [dbo].[AssessmentType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [AssessmentType] VARBINARY(50) NOT NULL
)


-- Assessment Table
CREATE TABLE [dbo].[Assessments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [AssessmentDetail] VARCHAR(MAX) NOT NULL, 
    [CreationDate] DATETIME2 NOT NULL, 
    [Grade] FLOAT NULL, 
    [SubjectId] INT NOT NULL, 
    [AssessmentType] INT NOT NULL, 
    CONSTRAINT [FK_Assessments_ToSubjects] FOREIGN KEY ([SubjectId]) REFERENCES [Subjects]([Id]), 
    CONSTRAINT [FK_Assessments_ToAssessmentType] FOREIGN KEY ([AssessmentType]) REFERENCES [AssessmentType]([Id])
)

-- Feedback Type Table
CREATE TABLE [dbo].[FeedbackType]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY (1,1), 
    [FeedbackType] VARCHAR(50) NOT NULL,
)



-- Feedbacks Table
CREATE TABLE [dbo].[Feedbacks]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Details] VARCHAR(MAX) NULL, 
    [FeedbackDate] DATETIME2 NULL, 
    [AssessementId] INT NOT NULL, 
    [FeedbackTypeId] INT NOT NULL, 
    CONSTRAINT [FK_Feedbacks_ToAssessments] FOREIGN KEY ([AssessementId]) REFERENCES [Assessments]([Id]),
	CONSTRAINT [FK_Feedbacks_ToFeedbackType] FOREIGN KEY ([FeedbackTypeId]) REFERENCES [FeedbackType] ([Id])
)