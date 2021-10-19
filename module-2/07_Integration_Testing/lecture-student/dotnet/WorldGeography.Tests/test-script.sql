-- Delete all of the data
DELETE FROM countrylanguage;
UPDATE country SET capital = NULL;
DELETE FROM city;
DELETE FROM country;

-- Insert fake countries
INSERT INTO country (code, name, continent, region, surfacearea, indepyear, population, lifeexpectancy, gnp, gnpold, localname, governmentform, headofstate, capital, code2)
VALUES ('USA', 'United States of America', 'North America', 'Region', 100, null, 100, null, null, null, 'United States of America', 'Under AI Control', 'HAL-9000', null, 'US');

-- Insert fake cities
SET IDENTITY_INSERT city ON -- Identity insert lets us specify the ID of an auto-generated PK

INSERT INTO city (id, name, countrycode, district, population) 
VALUES (1, 'Flavortown', 'USA', 'Ohio', 42000);

SET IDENTITY_INSERT city OFF

-- Insert a fake country language
INSERT INTO countrylanguage (countrycode, language, isofficial, percentage) 
VALUES ('USA', 'C#', 1, 100);

-- Assign the fake city to be the capital of the fake country
UPDATE country SET capital = 1 WHERE code = 'USA';