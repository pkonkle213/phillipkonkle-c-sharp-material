
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

CREATE TABLE interestGroup (
	groupNumber int NOT NULL,
	groupName varchar (100) NOT NULL,
	CONSTRAINT pk_group_number_group_name PRIMARY KEY (groupNumber, groupName)
);

CREATE TABLE member (
    memberNumber integer NOT NULL,
	lastName varchar(20) NOT NULL,
    firstName varchar(20) NOT NULL,
	emailAddress varchar(30) NOT NULL,
	phoneNumber bigint,
	dateOfBirth date NOT NULL,
	reminderEmails bit,
	groupIn int NOT NULL,
    CONSTRAINT pk_member_Number PRIMARY KEY (memberNumber),
);


CREATE TABLE event (
	eventNumber integer NOT NULL,
	name varchar (255) NOT NULL,
	description varchar (500) NOT NULL,
	startDateTime datetime NOT NULL,
	duration int NOT NULL,
	groupRunning integer NOT NULL,
	CONSTRAINT pk_event_number PRIMARY KEY (eventNumber),
	CONSTRAINT event_duration CHECK (duration >=30)
);

INSERT INTO interestGroup (groupNumber, groupName) VALUES (1,'Nonya');
INSERT INTO interestGroup (groupNumber, groupName) VALUES (2,'Biznass');
INSERT INTO interestGroup (groupNumber, groupName) VALUES (3,'HOLLA');

INSERT INTO member (memberNumber, lastName, firstName, emailAddress, phoneNumber, dateOfBirth,reminderEmails,groupIn) VALUES (1,'Konkle','Phillip','sum1unopk@gmail.com','5132555099','8/20/1987',0,1);
INSERT INTO member (memberNumber, lastName, firstName, emailAddress, phoneNumber, dateOfBirth,reminderEmails,groupIn) VALUES (2,'Teos','Kevin','waterboy@gmail.com','6148675309','7/4/1985',1,1);
INSERT INTO member (memberNumber, lastName, firstName, emailAddress, phoneNumber, dateOfBirth,reminderEmails,groupIn) VALUES (3,'Kovalishin','Kulie','whateveryouwant@gmail.com','1234567890','10/10/1990',0,2);
INSERT INTO member (memberNumber, lastName, firstName, emailAddress, phoneNumber, dateOfBirth,reminderEmails,groupIn) VALUES (4,'Eland','Matt','iWishIWasBatman@gmail.com','0987654321','1/1/1887',1,2);
INSERT INTO member (memberNumber, lastName, firstName, emailAddress, phoneNumber, dateOfBirth,reminderEmails,groupIn) VALUES (5,'Wayne','Bruce','ImBatman@gmail.com','999999999','7/11/1957',1,3);
INSERT INTO member (memberNumber, lastName, firstName, emailAddress, phoneNumber, dateOfBirth,reminderEmails,groupIn) VALUES (6,'Konkle','Ben','supersmart@gmail.com','6141234567','7/14/1979',0,3);
INSERT INTO member (memberNumber, lastName, firstName, emailAddress, phoneNumber, dateOfBirth,reminderEmails,groupIn) VALUES (7,'ComeOn','Seriously','whycantIbedoneyet@gmail.com','999999999','12/25/1988',0,1);
INSERT INTO member (memberNumber, lastName, firstName, emailAddress, phoneNumber, dateOfBirth,reminderEmails,groupIn) VALUES (8,'Johnson','Dwayne','finally@gmail.com','1110800815','3/25/1977',0,2);

INSERT INTO event (eventNumber, name, description, startDateTime, duration, groupRunning) VALUES (1,'Game Night','For squirrels after they''re done smoking','2021-01-01 00:00:00','60',2);
INSERT INTO event (eventNumber, name, description, startDateTime, duration, groupRunning) VALUES (2,'Green Beer Day','Silly college students doing silly things','2021-03-16 00:00:00','120',1);
INSERT INTO event (eventNumber, name, description, startDateTime, duration, groupRunning) VALUES (3,'Study Hour','Wonderful study buddies','2021-08-20 18:00:00','60',3);
INSERT INTO event (eventNumber, name, description, startDateTime, duration, groupRunning) VALUES (4,'Retirement Party','Mainly because everyone will miss Kevin','2021-12-03 20:00:00','270',3);

COMMIT TRANSACTION