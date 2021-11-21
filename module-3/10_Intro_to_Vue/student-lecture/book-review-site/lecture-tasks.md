We need to do the following things:

## Components and Templates

Add a review-list component with the following things:

-[ ] Header with "Product Reviews for MY_PRODUCT_NAME_HERE"
-[ ] A paragraph listing the # of reviews with the average rating per review (placeholders are fine)
-[ ] An input allowing users to enter in search text
-[ ] An option allowing users to specify the minimum rating for reviews to be displayed
-[ ] Placeholder text to display the search text and minimum rating

## Binding

-[ ] Add pieces of data to the model
-[ ] Bind the inputs to data in the model using v-model
-[ ] Play with the Vue dev tools
-[ ] Make sure that numeric input is treated as numeric
-[ ] Display bound data in placeholders using mustache syntax

## V-For

-[ ] Add a template for a single review in the HTML. Hard-coded data is fine for now
-[ ] Add a piece of data for the reviews
-[ ] Use v-for to change the single review to multiple reviews
-[ ] Set the properties of each review in the template
-[ ] Use v-bind:class to specify which classes should be applied
-[ ] Use v-bind:title or v-bind:id to illustrate other aspects of v-bind
-[ ] Talk about : shorthand for v-bind
-[ ] Use v-for to represent the images

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