-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.

INSERT INTO actor (first_name,last_name)
VALUES
	('HAMPTON','AVENUE'),
	('LISA','BYWAY')

-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.

INSERT INTO film (title,description,release_year,language_id,length)
VALUES ('Euclidean PI','The epic story of Euclid as a pizza delivery boy in ancient Greece',2008,1,198)

-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.

INSERT INTO film_actor (film_id,actor_id)
VALUES
	(1001,201),
	(1001,202)

-- 4. Add Mathmagical to the category table.

INSERT INTO category (name)
VALUES ('Mathmagical')

-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"

UPDATE film_category
SET	category_id=17
WHERE film_id IN (274,494,714,996)

INSERT INTO film_category (film_id,category_id)
VALUES (1001,17)

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)

UPDATE f
SET rating='G'
FROM
film f
INNER JOIN film_category fc ON fc.film_id = f.film_id
INNER JOIN category c ON c.category_id = fc.category_id
WHERE c.name='Mathmagical'


-- 7. Add a copy of "Euclidean PI" to all the stores.

INSERT INTO inventory (film_id,store_id)
VALUES
	(1001,1),
	(1001,2)

-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?)
--Cannot delete due to film_actor still has a reference to the movie
--The conflict occurred in database "dvdstore", table "dbo.film_actor", column 'film_id'.

DELETE FROM film
WHERE title='Euclidean PI'


-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?)
-- Cannot delete due to a film ID that still still uses this category and its ID

DELETE FROM category
WHERE name='Mathmagical'


-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?)
-- Yes, because film doesn't reference the category_id

DELETE FROM film_category
WHERE category_id=17

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?)
-- I am able to delete Mathemagical as nothing references it anymore.
-- I am still unable to delete Euclidean as actor still references its film_id



-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
-- All actors who acted in the movie and no other movie will need to be erased, then the movie will be able to be erased.
