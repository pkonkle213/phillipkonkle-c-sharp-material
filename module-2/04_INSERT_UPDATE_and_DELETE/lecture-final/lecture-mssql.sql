-- Note from Matt: Guess who lost his lecture final? This guy! Thankfully, I was able to pull the following code from a student who followed along and share with you all!
-- Remember to save your work regularly in SSMS! This may happen to you even if you get paid to teach SQL for 3 weeks every year.

-- INSERT

-- 1. Add Klingon as a spoken language in the USA

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES ('USA', 'Klingon', 0, 0.1)

SELECT * FROM countrylanguage WHERE countrycode = 'USA'

-- 2. Add Klingon as a spoken language in Great Britain (GBR)

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)
VALUES 
	('GBR', 'Klingon', 0, 0.42),
	('CAN', 'Klingon', 0, 25)

SELECT * FROM countrylanguage WHERE countrycode = 'GBR' OR countrycode = 'CAN'

-- UPDATE

-- 1. Update the capital of the USA to Houston

SELECT * FROM country WHERE code = 'USA' -- capital is 3813

SELECT * FROM city WHERE name = 'Houston' -- ID is 3796

UPDATE 
	country
SET
	capital = 3796 -- Houston
WHERE 
	code = 'USA'


-- 2. Update the capital of the USA to Washington DC and the head of state

UPDATE
	country
SET
	capital = 3813, -- Washington D.C.
	headofstate = 'me'
WHERE
	code = 'USA'

UPDATE
	country
SET
	capital = (SELECT id FROM city WHERE name = 'Washington' AND district = 'District of Columbia'), -- Washington D.C.
	headofstate = 'me'
WHERE
	code = 'USA'

-- 3. Try updating all of the cities to be in the USA and roll it back

BEGIN TRANSACTION -- Start a draft of changes

UPDATE 
	city
SET
	countrycode = 'USA',
	population = 42

SELECT * FROM city
ROLLBACK TRANSACTION -- Undo my changes

-- DELETE

-- 1. Delete English as a spoken language in the USA

BEGIN TRANSACTION

DELETE FROM countrylanguage WHERE language = 'English' AND countrycode = 'USA'

ROLLBACK TRANSACTION

-- 2. Delete all occurrences of the Klingon language 

BEGIN TRANSACTION

DELETE FROM countrylanguage WHERE language = 'Klingon'

COMMIT TRANSACTION

-- 3. Try deleting all of the rows from the country language table and roll it back.

BEGIN TRANSACTION

DELETE FROM countrylanguage

ROLLBACK TRANSACTION

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.

INSERT INTO countrylanguage (language) VALUES ('Elvish')

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)

VALUES
	('ZZZ', 'English', 1, 100)

-- 3. Try deleting the country USA. What happens?

BEGIN TRANSACTION

UPDATE 
	country
SET 
	capital = NULL
WHERE 
	code = 'USA'

DELETE FROM city WHERE countrycode = 'USA'

DELETE FROM countrylanguage WHERE countrycode = 'USA'

DELETE FROM country WHERE code = 'USA'

ROLLBACK TRANSACTION

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA

INSERT INTO countrylanguage (countrycode, language, isofficial, percentage)

VALUES	
	('USA', 'English', 1, 100)

-- 2. Try again. What happens?

-- 3. Let's relocate the USA to the continent - 'Outer Space'
BEGIN TRANSACTION

UPDATE country
SET 
	continent = 'Europe'
WHERE 
	code = 'USA'

ROLLBACK TRANSACTION

-- How to view all of the constraints

SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

-- Inserting a record with an ID

USE dvdstore

BEGIN TRANSACTION

SELECT * FROM country

INSERT INTO country (country)

VALUES 
	('Wakanda'),
	('DotNetia')

SET IDENTITY_INSERT country ON

INSERT INTO country
	(country_id, country)
VALUES
	(4200, 'Canda')

SET IDENTITY_INSERT country OFF

SELECT * FROM country

ROLLBACK TRANSACTION
-- Demonstrate two different SQL connections trying to access the same table where one happens to be 
-- inside of a transaction but hasn't committed yet.
