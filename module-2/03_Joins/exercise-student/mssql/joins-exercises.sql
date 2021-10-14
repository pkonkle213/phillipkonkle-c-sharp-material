-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)

SELECT
	f.title,
	a.first_name,
	a.last_name
FROM
	film f
	INNER JOIN film_actor fa ON fa.film_id=f.film_id
	INNER JOIN actor a ON a.actor_id=fa.actor_id
WHERE
	fa.actor_id=44
	-- a.first_name='Nick' AND a.last_name='Stallone'


-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)

SELECT
	f.title,
	a.actor_id,
	a.first_name,
	a.last_name
FROM
	film f
	INNER JOIN film_actor fa ON fa.film_id=f.film_id
	INNER JOIN actor a ON a.actor_id=fa.actor_id
WHERE
	fa.actor_id=135
	-- a.first_name='Rita' AND a.last_name='Reynolds'

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)

SELECT
	f.title,
	a.actor_id,
	a.first_name,
	a.last_name
FROM
	film f
	INNER JOIN film_actor fa ON fa.film_id = f.film_id
	INNER JOIN actor a ON a.actor_id = fa.actor_id
WHERE
	fa.actor_id=35 OR fa.actor_id=143
	-- a.last_name='Dean'
	-- (a.first_name='River' AND a.last_name='Dean') OR (a.first_name='Judy' AND a.last_name='Dean')

-- 4. All of the the ‘Documentary’ films
-- (68 rows)

SELECT
	f.title,
	c.name
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
WHERE
	c.name='Documentary'

-- 5. All of the ‘Comedy’ films
-- (58 rows)

SELECT
	f.title,
	c.name
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
WHERE
	c.name='Comedy'

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)

SELECT
	f.title,
	f.rating,
	c.name
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
WHERE
	c.name='Children' AND f.rating='G'

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)

SELECT
	f.title,
	f.rating,
	f.length,
	c.name
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
WHERE
	c.name='Family' AND f.rating='G' AND f.length<120

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)

SELECT
	f.title,
	f.rating,
	a.actor_id,
	a.first_name,
	a.last_name
FROM
	film f
	INNER JOIN film_actor fa ON fa.film_id = f.film_id
	INNER JOIN actor a ON a.actor_id=fa.actor_id
WHERE
	f.rating='G' AND a.actor_id=103
	-- f.rating='G' AND a.first_name='Matthew' AND a.last_name='Leigh'
	-- f.rating='G' AND a.last_name='Leigh'

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)

SELECT
	f.title,
	f.release_year,
	c.name
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
WHERE
	c.name='Sci-Fi' AND f.release_year=2006
	

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)

SELECT
	f.title,
	c.name,
	a.first_name,
	a.last_name
FROM
	film f
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
	INNER JOIN film_actor fa ON fa.film_id = f.film_id
	INNER JOIN actor a ON a.actor_id = fa.actor_id
WHERE
	c.name='Action' AND f.release_year=2006 AND fa.actor_id=44

-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)

SELECT
	a.address,
	c.city,
	a.district,
	cty.country
FROM
	store s
	INNER JOIN address a ON a.address_id = s.address_id
	INNER JOIN city c ON c.city_id = a.city_id
	INNER JOIN country cty ON cty.country_id = c.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)

SELECT
	sto.store_id,
	a.address,
	sta.first_name,
	sta.last_name
FROM
	store sto
	INNER JOIN address a ON a.address_id = sto.address_id
	INNER JOIN staff sta ON sta.staff_id = sto.manager_staff_id

-- 13. The first and last name of the top ten customers ranked by number of rentals
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)

SELECT TOP 10
	c.first_name+' '+c.last_name AS CustomerName,
	COUNT(1) AS NumberOfRentals
FROM
	rental r
	INNER JOIN customer c ON r.customer_id = c.customer_id
GROUP By
	c.first_name,
	c.last_name
ORDER BY
	COUNT(1) DESC

-- 14. The first and last name of the top ten customers ranked by dollars spent
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)

SELECT TOP 10
	c.first_name+' '+c.last_name AS CustomerName,
	SUM(p.amount) AS SumSpent
FROM
	payment p
	INNER JOIN customer c ON c.customer_id = p.customer_id
GROUP BY
	c.first_name,
	c.last_name
ORDER BY
	SUM(p.amount) DESC


-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that while a customer has only one primary store, they may rent from either store.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)

SELECT
	s.store_id,
	a.address,
	COUNT(r.rental_id) AS NumberOfRentals,
	SUM(p.amount) AS AmountOfSales,
	AVG(p.amount) AS AverageSales
FROM
	store s
	INNER JOIN inventory i ON i.store_id = s.store_id
	INNER JOIN rental r ON r.inventory_id = i.inventory_id
	INNER JOIN address a ON a.address_id = s.address_id
	INNER JOIN payment p ON p.rental_id = r.rental_id
GROUP BY
	s.store_id,
	a.address
ORDER BY
	s.store_id

-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)

SELECT TOP 10
	f.title,
	COUNT(1)
FROM
	rental r
	INNER JOIN inventory i ON i.inventory_id = r.inventory_id
	INNER JOIN film f ON f.film_id = i.film_id
GROUP BY
	f.title
ORDER BY
	COUNT(1) DESC


-- 17. The top five film categories by number of rentals
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)

SELECT TOP 5
	c.name,
	COUNT(c.name) AS NumberOfRentals
FROM
	rental r
	INNER JOIN inventory i ON i.inventory_id = r.inventory_id
	INNER JOIN film f ON f.film_id = i.film_id
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
GROUP BY
	c.name
ORDER BY
	COUNT(c.name) DESC


-- 18. The top five Action film titles by number of rentals
-- (#1 should have 30 rentals and #5 should have 28 rentals)

SELECT TOP 5
	f.title,
	COUNT(1)
FROM
	rental r
	INNER JOIN inventory i ON i.inventory_id = r.inventory_id
	INNER JOIN film f ON f.film_id = i.film_id
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
WHERE
	c.name='Action'
GROUP BY
	f.title
ORDER BY
	COUNT(1) DESC

-- 19. The top 10 actors ranked by number of rentals of films starring that actor
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
-- HINT: There's something special about Susan Davis and she shouldn't be in there (there's two actresses named Susan Davis)

SELECT TOP 10
	a.first_name,
	a.last_name,
	COUNT(1)
FROM
	rental r
	INNER JOIN inventory i ON i.inventory_id = r.inventory_id
	INNER JOIN film f ON f.film_id = i.film_id
	INNER JOIN film_actor fa ON fa.film_id = f.film_id
	INNER JOIN actor a ON a.actor_id = fa.actor_id
GROUP BY
	a.actor_id,
	a.first_name,
	a.last_name
ORDER BY
	COUNT(1) DESC

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor
-- (#1 should have 87 rentals and #5 should have 72 rentals)
-- HINT: your query should involve film, inventory, rental, film_actor, actor, film_category, and category. If your totals don't match, try changing how you join between these tables

SELECT TOP 5
	a.first_name,
	a.last_name,
	COUNT(1)
FROM
	rental r
	INNER JOIN inventory i ON i.inventory_id = r.inventory_id
	INNER JOIN film f ON f.film_id = i.film_id
	INNER JOIN film_category fc ON fc.film_id = f.film_id
	INNER JOIN category c ON c.category_id = fc.category_id
	INNER JOIN film_actor fa ON fa.film_id = f.film_id
	INNER JOIN actor a ON a.actor_id = fa.actor_id
WHERE
	c.name = 'Comedy'
GROUP BY
	a.actor_id,
	a.first_name,
	a.last_name
ORDER BY
	COUNT(1) DESC