-- INSERT

-- 1. Add Klingon as a spoken language in the USA

-- 2. Add Klingon as a spoken language in Great Britain (GBR)

-- UPDATE

-- 1. Update the capital of the USA to Houston

-- 2. Update the capital of the USA to Washington DC and the head of state

-- 3. Try updating all of the cities to be in the USA and roll it back

-- DELETE

-- 1. Delete English as a spoken language in the USA

-- 2. Delete all occurrences of the Klingon language 

-- 3. Try deleting all of the rows from the country language table and roll it back.

-- REFERENTIAL INTEGRITY

-- 1. Try just adding Elvish to the country language table.

-- 2. Try inserting English as a spoken language in the country ZZZ. What happens?

-- 3. Try deleting the country USA. What happens?

-- CONSTRAINTS

-- 1. Try inserting English as a spoken language in the USA

-- 2. Try again. What happens?

-- 3. Let's relocate the USA to the continent - 'Outer Space'

-- How to view all of the constraints

--SELECT * FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
--SELECT * FROM INFORMATION_SCHEMA.CONSTRAINT_COLUMN_USAGE
--SELECT * FROM INFORMATION_SCHEMA.REFERENTIAL_CONSTRAINTS

-- Demonstrate two different SQL connections trying to access the same table where one happens to be 
-- inside of a transaction but hasn't committed yet.
