using HotelReservationsClient.Exceptions;
using System;
using System.Collections.Generic;

namespace HotelReservationsClient
{
    class Program
    {
        private static readonly APIService apiService = new APIService();
        private static readonly ConsoleService console = new ConsoleService();

        static void Main(string[] args)
        {
            Run();
        }

        private static void Run()
        {
            Console.WriteLine("Welcome to Online Hotels! Please make a selection:");
            MenuSelection();
        }

        private static void MenuSelection()
        {
            int menuSelection;
            do
            {
                menuSelection = GetMainMenuChoice();

                switch (menuSelection)
                {
                    case 1: // List Hotels
                        ListHotels();
                        break;

                    case 2: // List Reservations
                        ListReservations();
                        break;

                    case 3: // Create new reservation
                        AddNewReservation();
                        break;

                    case 4: // Update an existing reservation
                        UpdateExistingReservation();
                        break;

                    case 5: // Delete reservation
                        DeleteReservation();
                        break;

                    case 6: // Toggle Logged In Status
                        if (apiService.LoggedIn)
                        {
                            LogOut();
                        }
                        else
                        {
                            LogIn();
                        }
                        break;

                    case 0: // Quit
                        Console.WriteLine("Goodbye!");
                        // The do / while's while condition will exit when we've chosen quit
                        break;

                    default:
                        Console.WriteLine("That's not a valid choice!");
                        break;
                }
            } while (menuSelection != 0);
        }

        private static void ListHotels()
        {
            try
            {
                List<Hotel> hotels = apiService.GetHotels();
                if (hotels != null && hotels.Count > 0)
                {
                    console.PrintHotels(hotels);
                }
            }
            catch (HotelException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void ListReservations()
        {
            try
            {
                List<Hotel> hotels = apiService.GetHotels();
                if (hotels != null && hotels.Count > 0)
                {
                    int hotelId = console.PromptForHotelID(hotels, "list reservations");
                    if (hotelId != 0)
                    {
                        List<Reservation> reservations = apiService.GetReservations(hotelId);
                        if (reservations != null)
                        {
                            console.PrintReservations(reservations, hotelId);
                        }
                    }
                }
            }
            catch (HotelException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void AddNewReservation()
        {
            string newReservationString = console.PromptForReservationData();
            Reservation reservationToAdd = new Reservation(newReservationString);

            if (reservationToAdd.IsValid)
            {
                try
                {
                    Reservation addedReservation = apiService.AddReservation(reservationToAdd);
                    if (addedReservation != null)
                    {
                        Console.WriteLine("Reservation successfully added.");
                    }
                    else
                    {
                        Console.WriteLine("Reservation not added.");
                    }
                }
                catch (HotelException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static void UpdateExistingReservation()
        {
            try
            {
                List<Reservation> reservations = apiService.GetReservations();
                if (reservations != null)
                {
                    int reservationId = console.PromptForReservationID(reservations, "update");
                    Reservation oldReservation = apiService.GetReservation(reservationId);
                    if (oldReservation != null)
                    {
                        string updReservationString = console.PromptForReservationData(oldReservation);
                        Reservation reservationToUpdate = new Reservation(updReservationString);

                        if (reservationToUpdate.IsValid)
                        {
                            Reservation updatedReservation = apiService.UpdateReservation(reservationToUpdate);
                            if (updatedReservation != null)
                            {
                                Console.WriteLine("Reservation successfully updated.");
                            }
                            else
                            {
                                Console.WriteLine("Reservation not updated.");
                            }
                        }
                    }
                }
            }
            catch (HotelException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void DeleteReservation()
        {
            try
            {
                List<Reservation> reservations = apiService.GetReservations();
                if (reservations != null)
                {
                    int reservationId = console.PromptForReservationID(reservations, "delete");

                    bool deleteSuccess = apiService.DeleteReservation(reservationId);
                    if (deleteSuccess)
                    {
                        Console.WriteLine("Reservation successfully deleted.");
                    }
                    else
                    {
                        Console.WriteLine("Reservation not deleted.");
                    }
                }
            }
            catch (HotelException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void LogIn()
        {
            Console.Write("Please enter username: ");
            string username = Console.ReadLine();
            Console.Write("Please enter password: ");
            string password = Console.ReadLine();
            try
            {
                var login = apiService.Login(username, password);
                if (login)
                {
                    Console.WriteLine("You are now logged in");
                }
            }
            catch (HotelException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static void LogOut()
        {
            apiService.Logout();
            Console.WriteLine("You are now logged out");
        }

        private static int GetMainMenuChoice()
        {
            int menuSelection;
            bool parsedInput;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("Menu:");
                Console.WriteLine("1: List Hotels");
                Console.WriteLine("2: List Reservations for Hotel");
                Console.WriteLine("3: Create new Reservation for Hotel");
                Console.WriteLine("4: Update existing Reservation for Hotel");
                Console.WriteLine("5: Delete Reservation");
                Console.WriteLine("6: " + (apiService.LoggedIn ? "Log out" : "Log in"));
                Console.WriteLine("0: Exit");
                Console.WriteLine("---------");
                Console.Write("Please choose an option: ");

                parsedInput = int.TryParse(Console.ReadLine(), out menuSelection);
                if (!parsedInput)
                {
                    Console.WriteLine("Invalid input. Only input a number. Please try again.");
                }
            } while (!parsedInput);
            return menuSelection;
        }
    }
}
