We need to do the following things:

## Components and Templates

Add a review-list component with the following things:

-[x] Header with "Product Reviews for MY_PRODUCT_NAME_HERE"
-[x] A paragraph listing the # of reviews with the average rating per review (placeholders are fine)
-[x] An input allowing users to enter in search text
-[x] An option allowing users to specify the minimum rating for reviews to be displayed
-[x] Placeholder text to display the search text and minimum rating

## Binding

-[x] Add pieces of data to the model
-[x] Bind the inputs to data in the model using v-model
-[x] Play with the Vue dev tools
-[x] Make sure that numeric input is treated as numeric
-[x] Display bound data in placeholders using mustache syntax

## V-For

-[x] Add a template for a single review in the HTML. Hard-coded data is fine for now
-[x] Add a piece of data for the reviews
-[x] Use v-for to change the single review to multiple reviews
-[x] Set the properties of each review in the template
-[x] Use v-bind:class to specify which classes should be applied
-[x] Use v-bind:title or v-bind:id to illustrate other aspects of v-bind
-[x] Talk about : shorthand for v-bind
-[x] Use v-for to represent the images

## Styles

-[ ] Talk about scoped vs non-scoped

## Computed

-[ ] Add a computed section
-[ ] Calculate the number of reviews
-[ ] Display the number of reviews in the header
-[ ] Calculate the average per review
-[ ] Display the average per review
-[ ] If we feel like it, chop off long decimals from the average

## Searching

-[ ] Add a computed for search
-[ ] Factor the title into the search
-[ ] Make the list display the search results instead of all items
-[ ] Factor in  the minimum # of reviews