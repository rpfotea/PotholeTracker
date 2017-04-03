-- *************************************************************************************************
-- This script creates all of the database objects (tables, constraints, etc) for the database
-- *************************************************************************************************

BEGIN TRANSACTION;

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
	repairDate		dateTime,
	severity		int,
	comment			varchar(256),

	constraint pk_pothole PRIMARY KEY (potholeID),
	constraint fk_whoReported FOREIGN KEY (whoReported) references appUser (userID),
	constraint fk_whoInspected FOREIGN KEY (whoInspected) references appUser (userID),
)

COMMIT TRANSACTION;