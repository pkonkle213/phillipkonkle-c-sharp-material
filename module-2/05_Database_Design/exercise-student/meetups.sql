
-- Switch to the system (aka master) database
USE master;
GO

-- Delete the AnimalHospital Database (IF EXISTS)
IF EXISTS(select * from sys.databases where name='Meetups')
DROP DATABASE Meetups;
GO

-- Create a new Meetups Database
CREATE DATABASE Meetups;
GO

-- Switch to the Meetups Database
USE Meetups
GO

-- Begin a TRANSACTION that must complete with no errors
BEGIN TRANSACTION;


CREATE TABLE member (
    memberNumber integer NOT NULL,
	lastName varchar(20) NOT NULL,
    firstName varchar(20) NOT NULL,
	emailAddress varchar(20) NOT NULL,
	phoneNumber bigint NOT NULL,
	dateOfBirth date NOT NULL,
	reminderEmails bit,
    CONSTRAINT pk_member_Number PRIMARY KEY (memberNumber)
);

CREATE TABLE interestGroup (
	groupNumber int NOT NULL,
	groupName varchar (100) NOT NULL,
	CONSTRAINT pk_group_number_group_name PRIMARY KEY (groupNumber, groupName)
);

CREATE TABLE event (
	eventNumber integer NOT NULL,
	name varchar (255) NOT NULL,
	description varchar (500) NOT NULL,
	startDateTime datetime NOT NULL,
	duration int NOT NULL,
	groupRunning integer NOT NULL,
	CONSTRAINT pk_event_number PRIMARY KEY (eventNumber),
	CONSTRAINT fk_group_running FOREIGN KEY (groupRunning) REFERENCES interestGroup (groupNumber)
);
COMMIT TRANSACTION