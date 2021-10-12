-- SELECT to find countries in North America
SELECT
	name,
	continent
FROM
	country
WHERE
	continent='North America'

-- IN / NOT IN to find countries in the Americas
SELECT
	name,
	continent
FROM
	country
WHERE
	continent LIKE '%America'

SELECT
	name,
	continent
FROM
	country
WHERE
	continent IN ('North America','South America') -- Basically an "OR" statement

SELECT
	name,
	continent
FROM
	country
WHERE
	continent NOT IN ('North America','South America') -- AND !=

-- BETWEEN to find countries with life expectancy between 30 and 70 years
SELECT
	name,
	lifeexpectancy
FROM
	country
WHERE
	lifeexpectancy >= 30
	and lifeexpectancy <= 70

SELECT
	name,
	lifeexpectancy
FROM
	country
WHERE
	lifeexpectancy BETWEEN 30 AND 70

-- New Content ------------------------------------------------------------------------------------

-- CONCATENATING OUTPUTS

-- The name & state of all cities like "city, state", sorted by state then city
SELECT
	name+', '+district AS CityState,
	name,
	UPPER(district) as UppercaseState
FROM
	city
ORDER BY
	district,
	name


-- ORDERING RESULTS

-- Populations of all countries in descending order by population
SELECT
	name,
	population
FROM
	country
--WHERE would go here
ORDER BY 
	population DESC

-- Names of countries and continents in ascending order by continent and then name
SELECT
	name,
	population,
	continent
FROM
	country
ORDER BY
	continent,
	name ASC -- ASC is optional due to ascending being the default


-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.
SELECT TOP 10
	name,
	lifeexpectancy
FROM
	country
ORDER BY
	lifeexpectancy DESC

-- The 10 largest countries in the world (by surface area)
SELECT TOP 10
	name,
	surfacearea
FROM
	country
ORDER BY
	surfacearea DESC

-- DISTINCT
-- Find the unique names of each continent
SELECT DISTINCT
	continent,
	governmentform
FROM
	country
ORDER BY 
	continent


-- Find the unique city names
SELECT DISTINCT
	name
FROM
	city
ORDER BY
	name ASC


-- SUBQUERIES
-- Find the names of cities under a given government leader (Elisabeth II)
SELECT code FROM country WHERE headofstate = 'Elisabeth II'

--Keep in mind the following is bad and will be cleaned up tomorrow
SELECT name FROM city WHERE countrycode IN (SELECT code FROM country WHERE headofstate = 'Elisabeth II')

SELECT
	name
FROM
	city
WHERE
	countrycode IN (SELECT
						code
					FROM
						country
					WHERE
						headofstate = 'Elisabeth II'
					)

-- Find the names of cities whose country they belong to has not declared independence yet
SELECT
	name,
	countrycode
FROM
	city
WHERE
	countrycode IN (SELECT code FROM country WHERE indepyear IS NULL)


-- AGGREGATE FUNCTIONS
-- AVG - Average Life Expectancy in the World
SELECT AVG(lifeexpectancy) AS LifeExpectancy FROM country;

-- SUM - Total population in Ohio
SELECT SUM(population) as TotalPopulation,AVG(population) as AveragePopulation FROM city where district = 'Ohio';

-- MIN - The surface area of the smallest country in the world
SELECT MIN(surfacearea) AS SurfaceArea FROM country;

-- MAX - The largest city in the world (in population)
SELECT MAX(population) AS MaxPopulation FROM city
SELECT name,district FROM city WHERE population = (SELECT MAX(population) AS MaxPopulation FROM city)

-- COUNT - Count the number of rows in the city table
SELECT
	COUNT(name)
FROM
	city

-- COUNT - The number of countries who declared independence in 1991
SELECT COUNT(1)
FROM country
WHERE indepyear=1991;

-- GROUP BY
-- Count the number of countries where each language is spoken, ordered from most countries to least
SELECT language, COUNT(language) as NumCountries, AVG(percentage) AS AveragePercentageOfSpokenLanguage
FROM countrylanguage
GROUP BY language
ORDER BY NumCountries DESC

-- Average life expectancy of each continent ordered from highest to lowest
SELECT AVG(lifeexpectancy) AS AverageLifeExpectancy, continent -- Note that continent exists in group by, hence it's selectable
FROM country
GROUP BY continent
ORDER BY AVG(lifeexpectancy) DESC

SELECT AVG(lifeexpectancy) AS AverageLifeExpectancy, continent -- Note that continent exists in group by, hence it's selectable
FROM country
GROUP BY continent
ORDER BY AverageLifeExpectancy DESC -- Note that this works by the select naming the new column

-- Exclude Antarctica from consideration for average life expectancy
SELECT AVG(lifeexpectancy) AS AverageLifeExpectancy, continent
FROM country
WHERE lifeexpectancy IS NOT NULL
GROUP BY continent
ORDER BY AVG(lifeexpectancy) DESC

-- Sum of the population of cities in each state in the USA ordered by state name
SELECT district,SUM(population) AS StatePopulation,AVG(population) AS AveragePopulation
FROM city
WHERE countrycode = 'USA'
GROUP BY district
ORDER BY district ASC

-- The average population of cities in each state in the USA ordered by state name
SELECT
	countrycode,
	district,
	SUM(population) AS StatePopulation,
	AVG(population) AS AveragePopulation
FROM
	city
WHERE
	countrycode IN ('USA','CAN')
GROUP BY
	countrycode,
	district
ORDER BY
	countrycode ASC, district DESC

-- Additional samples
-- You may alias column and table names to be more descriptive
SELECT
	city.name,
	city.district,
	city.id
FROM
	city
	
-- Alias can also be used to create shorthand references, such as "c" for city and "co" for country.
SELECT
	co.name,
	co.headofstate,
	co.continent
FROM
	country co


-- Ordering allows columns to be displayed in ascending order, or descending order (Look at Arlington)

-- Most database platforms provide string functions that can be useful for working with string data. In addition to string functions, string concatenation is also usually supported, which allows us to build complete sentences if necessary.

-- Gets the SUM of the population field in the city table, as well as
-- the AVG population, and a COUNT of the total number of rows.

-- Gets the MIN population and the MAX population from the city table.

-- Using a GROUP BY with aggregate functions allows us to summarize information for a specific column. For instance, we are able to determine the MIN and MAX population for each countrycode in the city table.

-- While you can use TOP to limit the number of results returned by a query,
-- in SQL Server it is recommended to use OFFSET and FETCH if you want to get
-- "pages" of results. For instance, to get the first 10 rows in the city table
-- ordered by the name, you could use the following query.
-- (Skip 0 rows, and return only the first 10 rows from the sorted result set.)

SELECT name, population
FROM city
ORDER BY name
OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY;