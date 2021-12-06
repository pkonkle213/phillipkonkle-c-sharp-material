USE master
GO

-- Drop database if it exists
IF DB_ID('final_capstone') IS NOT NULL
BEGIN
	ALTER DATABASE final_capstone SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE final_capstone;
END

CREATE DATABASE final_capstone
GO

USE final_capstone
GO

-- Create Tables
CREATE TABLE users (
	user_id int IDENTITY(1,1) NOT NULL,
	username varchar(50) NOT NULL,
	password_hash varchar(200) NOT NULL,
	salt varchar(200) NOT NULL,
	user_role varchar(50) NOT NULL
	CONSTRAINT PK_user PRIMARY KEY (user_id)
)

CREATE TABLE Mattisms (
	id int IDENTITY(1,1) NOT NULL,
	text nvarchar(150) NOT NULL,
	createdByUserId int NOT NULL,
	isFavorite bit NOT NULL,
	frequency nvarchar(15) CONSTRAINT Check_Mattisms CHECK (frequency in ('Low', 'High', 'Sociopathic'))
	CONSTRAINT PK_mattisms PRIMARY KEY (id)
	CONSTRAINT FK_mattisms_users FOREIGN KEY (createdByUserId) REFERENCES users (user_id)
)

-- Populate default data for testing: user and admin with password of 'password'
-- These values should not be kept when going to Production
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('user','Jg45HuwT7PZkfuKTz6IB90CtWY4=','LHxP4Xh7bN0=','user');
INSERT INTO users (username, password_hash, salt, user_role) VALUES ('admin','YhyGVQ+Ch69n4JMBncM4lNF/i9s=', 'Ar/aB2thQTI=','admin');
GO

INSERT INTO Mattisms (text, createdByUserId, isFavorite, frequency)
VALUES
('Because Microsoft didn''t ask me', 1, 1, 'High'),
('I''m not a sociopath', 1, 1, 'Sociopathic'),
('Because it''s Thursday', 1, 0, 'Low'),
('Who do I want to pick on? Let''s say ... Kevin!', 1, 0, 'High')
