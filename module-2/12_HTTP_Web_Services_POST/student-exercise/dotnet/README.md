# Consuming APIs: POST, PUT, and DELETE (C#)

In this exercise, you'll continue working on the command-line application that displays online auction info. The functionality that you wrote in the previous lesson is provided.

Your task is to add web API calls using RestSharp to create new auctions (`POST`), update existing auctions (`PUT`), and delete auctions (`DELETE`).

## Step One: Explore the API

The auction API has some auto-generated documentation available at https://te-mockauction-server.azurewebsites.net/swagger/index.html

Look through this documentation related to Auction GET, PUT, POST, and DELETE methods as these are the methods you will be dealing with.

Wherever you see a `{}`, that indicates a placeholder for something. Here, `studentId` refers to the number on your laptop (typically on a sticker on or underneath the laptop). So if my laptop's ID was `12345`, I could get all auctions by doing a GET to `https://te-mockauction-server.azurewebsites.net/students/12345/auctions`

This step is necessary so the auction API tracks your data separately from other students.

**If you ever want to reset your data to the default starting state, open up POSTMAN and do a DELETE to `https://te-mockauction-server.azurewebsites.net/students/{studentId}` where `{studentId}` refers to your laptop number. **

These are the endpoints you'll work on for this exercise:

- POST: https://te-mockauction-server.azurewebsites.net/students/{studentId}/auctions
- PUT: https://te-mockauction-server.azurewebsites.net/students/{studentId}/auctions/{id}
- DELETE: https://te-mockauction-server.azurewebsites.net/students/{studentId}/auctions/{id}

## Step Two: Evaluation criteria and functional requirements

* All unit tests pass in `AuctionApp.Tests`.
* Code is clean, concise, and readable.

To complete this exercise, you need to complete the `APIService` class by implementing the `AddAuction()`, `UpdateAuction()`, and `DeleteAuction()` methods.

### Tips and tricks

* The `Auction` class has a constructor which takes a CSV string containing either four or five elements: Title, Description, User, Current Bid, and optionally, Auction ID.
* The URL for the API is declared in `APIService.cs`. You may need to append a slash depending on the API method you're using.
* The `AddAuction()` method takes an `Auction` object as a parameter that's passed from `Program.cs`. Have the `AddAuction()` method return the `Auction` object returned from the API when it's successful. Return `null` if unsuccessful.
* The `UpdateAuction()` method takes an `Auction` object as a parameter that's passed from `Program.cs`. Have the `UpdateAuction()` method return the `Auction` object returned from the API when it's successful. Return `null` if unsuccessful.
* The `DeleteAuction()` method takes an `int` as a parameter that's passed from the console. It's the `Id` of the auction to delete. Have the `DeleteAuction()` method return `true` if successful, `false` if not successful.
* Consider that the server may return an error, or that the server might not be reached. Implement the necessary error handling.

## Step Four: Add a new auction

The `AddAuction()` method creates a new auction. Make sure to handle any exceptions that might be thrown:

```csharp
public Auction AddAuction(Auction newAuction) {
    // place code here
    throw new NotImplementedException();
}
```

When you've completed the `AddAuction()` method, run the unit tests, and verify that the `AddAuction_ExpectSuccess`, `AddAuction_ExpectFailureResponse`, and `AddAuction_ExpectNoResponse` tests pass.

## Step Five: Update an existing auction

The `UpdateAuction()` method overwrites the existing auction with an updated one for a given ID. Make sure to handle any exceptions that might be thrown:

```csharp
public Auction UpdateAuction(Auction auctionToUpdate) {
    // place code here
    throw new NotImplementedException();
}
```

When you've completed the `UpdateAuction()` method, run the unit tests, and verify that the `UpdateAuction_ExpectSuccess`, `UpdateAuction_ExpectFailureResponse`, and `UpdateAuction_ExpectNoResponse` tests pass.

## Step Six: Delete an auction

The `DeleteAuction()` method removes an auction from the system. Make sure to handle any exceptions that might come up. What happens if you enter an ID for an auction that doesn't exist?

```csharp
public bool DeleteAuction(int auctionId) {
    // place code here
    throw new NotImplementedException();
}
```

When you've completed the `DeleteAuction()` method, run the unit tests, and verify that the `DeleteAuction_ExpectSuccess`, `DeleteAuction_ExpectFailureResponse`, and `DeleteAuction_ExpectNoResponse` tests pass.

Once all unit tests pass, you've completed this exercise.
