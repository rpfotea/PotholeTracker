-- *************************************************************************************************
-- This script creates all of the database objects (tables, constraints, etc) for the database
-- *************************************************************************************************

BEGIN TRANSACTION;

DROP TABLE pothole;
DROP TABLE appUser;

create table appUser(

	userId			int identity(1,1),
	name			varchar(32),
	email			varchar(256) UNIQUE,
	password		varchar(256),
	userType		varchar(1),
	salt			varchar(64),

	constraint pk_user	PRIMARY KEY (userId),
)

create table pothole(

	potholeID		int identity(1,1),
	latitude		real,
	longitude		real,
	whoReported		int,
	whoInspected	int,
	picture			varchar(256),
	reportDate		dateTime,
	inspectDate		dateTime,
	repairStartDate	dateTime,
	repairEndDate	dateTime,
	severity		int,
	comment			varchar(256),

	constraint pk_pothole PRIMARY KEY (potholeID),
	constraint fk_whoReported FOREIGN KEY (whoReported) references appUser (userID),
	constraint fk_whoInspected FOREIGN KEY (whoInspected) references appUser (userID),
)

-- Email is First and last Initial @te.com   example: Harlan Levine  = HL@te.com
-- Passwords are TechElevator1!

INSERT INTO appUser (name, email, password, userType, salt) VALUES ( 'Harlan Levine', 'HL@te.com', 'h0QzvMm9oNihS+9jN40NbuzdHQ8=','r','TGClx61O7Dk='); 
INSERT INTO appUser (name, email, password, userType, salt) VALUES ( 'Aaron Perkins', 'AP@te.com', 'h0QzvMm9oNihS+9jN40NbuzdHQ8=','r','TGClx61O7Dk='); 
INSERT INTO appUser (name, email, password, userType, salt) VALUES ( 'Subhadra Pullabhatla', 'SP@te.com', 'h0QzvMm9oNihS+9jN40NbuzdHQ8=','r','TGClx61O7Dk='); 
INSERT INTO appUser (name, email, password, userType, salt) VALUES ( 'Radu Fotea', 'RF@te.com', 'h0QzvMm9oNihS+9jN40NbuzdHQ8=','r','TGClx61O7Dk='); 
INSERT INTO appUser (name, email, password, userType, salt) VALUES ( 'City Worker', 'CW@te.com', 'h0QzvMm9oNihS+9jN40NbuzdHQ8=','e','TGClx61O7Dk='); 

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.50527, -81.68499,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.5038261, -81.68992,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.5052719, -81.67717,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.5094376, -81.6811752,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.50468, -81.69959,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.5004539, -81.68404,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.5000038, -81.69232,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.5028, -81.66357,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.51077, -81.67545,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);

INSERT INTO pothole (latitude, longitude, whoReported, whoInspected, picture, reportDate, inspectDate, repairStartDate, repairEndDate, severity, comment)
VALUES				(41.5030861, -81.68936,	2,			NULL,			NULL, '2017-04-07', NULL,		NULL,			NULL,			NULL,	NULL);


COMMIT TRANSACTION;