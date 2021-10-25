using HTTP_Web_Services_POST_PUT_DELETE_lecture.ApiClients;
using System;
using System.Collections.Generic;
using System.Text;

namespace HTTP_Web_Services_POST_PUT_DELETE_lecture
{
    public class UserInterface
    {
        private readonly ReservationsService apiService =
            new ReservationsService("https://te-mockauction-server.azurewebsites.net/students/REPLACEME/");

        private readonly ConsoleService console = new ConsoleService();

        public void ShowMainMenu()
        {
            Console.WriteLine("Welcome to Online Hotels! Please make a selection:");

            bool keepGoing;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("Menu:");
                Console.WriteLine("1: List Hotels");
                Console.WriteLine("2: List Reservations for Hotel");
                Console.WriteLine("3: Create new Reservation for Hotel");
                Console.WriteLine("4: Update existing Reservation for Hotel");
                Console.WriteLine("5: Delete Reservation");
                Console.WriteLine("0: Exit");
                Console.WriteLine("---------");

                keepGoing = HandleMenuSelection();
            }
            while (keepGoing);
        }

        /// <summary>
        /// Gets a main menu prompt and responds to the user's input
        /// </summary>
        /// <returns>A boolean value indicating whether or not we should keep going</returns>
        private bool HandleMenuSelection()
        {
            Console.Write("Please choose an option: ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out int menuSelection))
            {
                Console.WriteLine("Invalid input. Only input a number.");
                return true;
            }

            switch (menuSelection)
            {
                case 1:
                    ListHotels();
                    break;

                case 2: // List reservations by hotel
                    ListReservationsForHotel();
                    break;

                case 3: // Create new reservation
                    CreateReservation();
                    break;

                case 4: // Update an existing reservation
                    UpdateExistingReservation();
                    break;

                case 5: // Delete a reservation
                    DeleteReservation();
                    break;

                case 0:
                    Console.WriteLine("Goodbye!");
                    return false;
            }

            return true;
        }

        private void ListHotels()
        {
            List<Hotel> hotels = apiService.GetHotels();
            if (hotels != null && hotels.Count > 0)
            {
                console.PrintHotels(hotels);
            }
        }

        private void ListReservationsForHotel()
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

        private void UpdateExistingReservation()
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

        private void CreateReservation()
        {
            string newReservationString = console.PromptForReservationData();
            Reservation reservationToAdd = new Reservation(newReservationString);

            if (reservationToAdd.IsValid)
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
        }

        private void DeleteReservation()
        {
            // Delete reservation
            List<Reservation> reservations = apiService.GetReservations();
            if (reservations != null)
            {
                int reservationId = console.PromptForReservationID(reservations, "delete");
                apiService.DeleteReservation(reservationId);
            }
        }
    }
}
