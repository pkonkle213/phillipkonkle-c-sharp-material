-- SELECT to find countries in North America

-- IN / NOT IN to find countries in the Americas

-- BETWEEN to find countries with life expectancy between 30 and 70 years

-- New Content ------------------------------------------------------------------------------------

-- CONCATENATING OUTPUTS

-- The name & state of all cities like "city, state", sorted by state then city

-- ORDERING RESULTS

-- Populations of all countries in descending order by population

-- Names of countries and continents in ascending order by continent and then name

-- LIMITING RESULTS
-- The name and average life expectancy of the countries with the 10 highest life expectancies.

-- The 10 largest countries in the world (by surface area)

-- DISTINCT
-- Find the unique names of each continent
-- Find the unique city names

-- SUBQUERIES
-- Find the names of cities under a given government leader (Elisabeth II)

-- Find the names of cities whose country they belong to has not declared independence yet

-- AGGREGATE FUNCTIONS
-- AVG - Average Life Expectancy in the World

-- SUM - Total population in Ohio

-- MIN - The surface area of the smallest country in the world

-- MAX - The largest city in the world (in population)

-- COUNT - Count the number of rows in the city table

-- COUNT - The number of countries who declared independence in 1991

-- GROUP BY
-- Count the number of countries where each language is spoken, ordered from most countries to least

-- Average life expectancy of each continent ordered from highest to lowest

-- Exclude Antarctica from consideration for average life expectancy

-- Sum of the population of cities in each state in the USA ordered by state name

-- The average population of cities in each state in the USA ordered by state name

-- Additional samples
-- You may alias column and table names to be more descriptive

-- Alias can also be used to create shorthand references, such as "c" for city and "co" for country.

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

--SELECT name, population
--FROM city
--ORDER BY name
--OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY;