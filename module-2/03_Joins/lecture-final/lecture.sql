-- ********* INNER JOIN ***********

-- Let's find out who made payment 16666:
SELECT * FROM payment WHERE payment_id = 16666 -- Customer ID is 204

-- Ok, that gives us a customer_id, but not the name. We can use the customer_id to get the name FROM the customer table
SELECT * FROM customer WHERE customer_id = 204

SELECT
	*
FROM
	payment p
	INNER JOIN customer c ON c.customer_id = p.customer_id
WHERE
	p.payment_id = 16666

-- We can see that the * pulls back everything from both tables. We just want everything from payment and then the first 
-- and last name of the customer:
SELECT
	p.*,
	c.first_name,
	c.last_name
FROM
	customer c
	INNER JOIN payment p ON p.customer_id = c.customer_id
WHERE
	p.payment_id = 16666

-- But when did they return the rental? Where would that data come from? From the rental table, so let’s join that.
SELECT
	p.*,
	c.first_name,
	c.last_name,
	r.return_date
FROM
	customer c
	INNER JOIN payment p ON p.customer_id = c.customer_id
	--INNER JOIN rental r ON r.customer_id = c.customer_id
	INNER JOIN rental r ON r.rental_id = p.rental_id
WHERE
	p.payment_id = 16666
	--AND r.rental_id = p.rental_id

-- What did they rent? Film id can be gotten through inventory.
SELECT
	p.*,
	c.first_name,
	c.last_name,
	r.return_date,
	f.title,
	f.description
FROM
	customer c
	INNER JOIN payment p ON p.customer_id = c.customer_id
	INNER JOIN rental r ON r.rental_id = p.rental_id
	INNER JOIN inventory i ON i.inventory_id = r.inventory_id
	INNER JOIN film f ON f.film_id = i.film_id
WHERE
	p.payment_id = 16666

-- What if we wanted to know who acted in that film?
SELECT * FROM  film_actor

SELECT
	p.*,
	c.first_name + ' ' + c.last_name AS 'Customer Name',
	r.return_date,
	f.title,
	f.description,
	a.first_name + ' ' + a.last_name AS 'Actor Name'
FROM
	customer c
	INNER JOIN payment p ON p.customer_id = c.customer_id
	INNER JOIN rental r ON r.rental_id = p.rental_id
	INNER JOIN inventory i ON i.inventory_id = r.inventory_id
	INNER JOIN film f ON f.film_id = i.film_id
	INNER JOIN film_actor fa ON fa.film_id = f.film_id
	INNER JOIN actor a ON a.actor_id = fa.actor_id
WHERE
	p.payment_id = 16666

-- What if we wanted a list of all the films and their categories ordered by film title
SELECT
	f.title,
	f.description,
	c.name AS 'Category'
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
ORDER BY
	f.title

-- Show all the 'Comedy' films ordered by film title
SELECT
	f.title,
	f.description,
	c.name AS 'Category'
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
WHERE
	c.name = 'Comedy'
ORDER BY
	f.title

-- Finally, let's count the number of films under each category
SELECT
	COUNT(*),
	c.name AS 'Category'
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
GROUP BY
	c.name
ORDER BY
	c.name

-- ********* EXISTS **************

-- Find all rentals that have at least one payment for them after 2007
SELECT
	r.*
FROM
	rental r
	INNER JOIN payment p ON p.rental_id = r.rental_id
WHERE
	p.payment_date >= '1/1/2008'

SELECT
	r.*
FROM
	rental r
WHERE
	EXISTS (SELECT * FROM payment p WHERE p.rental_id = r.rental_id AND p.payment_date >= '1/1/2008')

SELECT	r.*FROM	rental rWHERE	EXISTS (SELECT * FROM payment p WHERE p.rental_id = r.rental_id AND p.payment_date >='1/1/2008')

-- Find all rentals items that have NO payments for them after 2007
SELECT
	r.*
FROM
	rental r
WHERE
	NOT EXISTS (SELECT * FROM payment p WHERE p.rental_id = r.rental_id AND p.payment_date >= '1/1/2008')

-- ********* LEFT JOIN ***********

-- (There aren't any great examples of left joins in the "dvdstore" database, so the following queries are for the "world" database)

-- A Left join, selects all records from the "left" table and matches them with records from the "right" table if a matching record exists.

-- Let's display a list of all countries and their capitals, if they have some.
SELECT
	ctr.name AS Country,
	cty.name as CapitalCity
FROM
	country ctr
	--INNER JOIN city cty ON cty.countrycode = ctr.code
	INNER JOIN city cty ON cty.id = ctr.capital

-- Only 232 rows
-- But we’re missing entries:

-- There are 239 countries. So how do we show them all even if they don’t have a capital?
-- That’s because if the rows don’t exist in both tables, we won’t show any information for it. 
-- If we want to show data FROM the left side table everytime, we can use a different join:
SELECT
	ctr.name AS Country,
	cty.name as CapitalCity
FROM
	country ctr
	LEFT OUTER JOIN city cty ON ctr.capital = cty.id

-- *********** UNION *************

-- Back to the "dvdstore" database...

-- Gathers a list of all first names used by actors and customers
-- By default removes duplicates
SELECT DISTINCT
	a.first_name,
	a.last_name,
	'A' AS RecordType
FROM
	actor a

UNION

SELECT DISTINCT
	c.first_name,
	c.last_name,
	'C'
FROM
	customer c

UNION

SELECT DISTINCT
	s.first_name,
	s.last_name,
	'S'
FROM
	staff s

-- Gather the list, but this time note the source table with 'A' for actor and 'C' for customer

-- ******** MOAR PRACTICE ********

-- Display all the films and their language

-- Display all the films and in English

-- Display all the films with their category

-- Display all the films with a category of Horror

-- Display all the films with a category of Horror and title that begins with the letter F

-- Who acted in what together?

-- How many times have two actors appeared together?

-- What movies did the two most often acted together actors appear in together?
