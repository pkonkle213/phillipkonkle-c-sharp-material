-- SELECT ... FROM
-- Selecting the names for all countries
SELECT * FROM city;

SELECT name FROM city; 

SELECT * FROM country;

SELECT * FROM country

SELECT name, surfacearea FROM country

-- Selecting the name and population of all countries

SELECT * FROM country;

SELECT name, population FROM country;


-- Selecting all columns from the city table

SELECT * FROM city  --this is a comment also

-- SELECT ... FROM ... WHERE
-- Selecting the cities in Ohio
/*
This is a comment
and this
*/


SELECT * FROM city

SELECT * FROM city WHERE district = 'OHIO'


SELECT * 
FROM city 
WHERE district = 'OHIO'


-- Selecting countries that gained independence in the year 1776

SELECT *  FROM country

SELECT *  FROM country
WHERE indepyear = 1776


-- Selecting countries not in Asia

SELECT *  FROM country

SELECT * FROM country 
WHERE continent = 'Asia'

SELECT * FROM country 
WHERE continent != 'Asia'



-- Selecting countries that do not have an independence year

SELECT * FROM country 

SELECT * FROM country 
WHERE indepyear IS NULL




-- Selecting countries that do have an independence year

SELECT * FROM country 
WHERE indepyear IS NOT NULL

-- Selecting countries that have a population greater than 5 million

SELECT * FROM country 
WHERE population > 5000000


-- SELECT ... FROM ... WHERE ... AND/OR
-- Selecting cities in Ohio and Population greater than 400,000

SELECT * FROM city

SELECT * FROM city
WHERE district = 'Ohio'


SELECT * FROM city
WHERE district = 'Ohio'
AND population > 400000




-- Selecting country names on the continent North America or South America

SELECT * FROM country
WHERE continent = 'North America'
OR continent = 'South America'



-- SELECTING DATA w/arithmetic
-- Selecting the population, life expectancy, and population per area
--	note the use of the 'as' keyword
	
SELECT population/surfacearea AS Density,name AS Name FROM country

SELECT name AS Name, population/surfacearea AS Density FROM country

SELECT name Name, population/surfacearea Density FROM country



-- LIKE

SELECT * FROM country
WHERE name LIKE 'an%'

SELECT * FROM country
WHERE name LIKE '%ay'

SELECT * FROM country
WHERE name LIKE '%island%'
