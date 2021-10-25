using HTTP_Web_Services_GET_lecture.ApiClients;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_GET_lecture
{
    public class UserInterface
    {
        private readonly HotelsApi hotelsApi = new HotelsApi("REPLACE WITH YOUR LAPTOP #");
        private readonly TravelApi travelApi = new TravelApi();

        public void DisplayMainMenu()
        {
            Console.WriteLine("Welcome to Online Hotels! Please make a selection:");

            int menuSelection = -1;
            while (menuSelection != 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Menu:");
                Console.WriteLine("1: List Hotels");
                Console.WriteLine("2: List Reservations");
                Console.WriteLine("3: Show Details for Hotel ID 1");
                Console.WriteLine("4: List Reservations for Hotel ID 1");
                Console.WriteLine("5: List Hotels in Ohio");
                Console.WriteLine("6: Get a recommended travel destination");
                Console.WriteLine("0: Exit");
                Console.WriteLine("---------");
                Console.Write("Please choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    Console.WriteLine("Invalid input. Only input a number.");
                }
                else
                {
                    switch (menuSelection)
                    {
                        case 1:
                            PrintHotels(hotelsApi.GetAllHotels());
                            break;
                        case 2:
                            PrintReservations(hotelsApi.GetAllReservations());
                            break;
                        case 3:
                            PrintHotel(hotelsApi.GetHotel(1));
                            break;
                        case 4:
                            PrintReservations(hotelsApi.GetReservationsForHotel(1));
                            break;
                        case 5:
                            PrintHotels(hotelsApi.GetAllHotelsInState("OH"));
                            break;
                        case 6:
                            string destination = travelApi.GetRecommendedDestination();
                            Console.WriteLine("Need a travel idea? Try " + destination);
                            break;
                        default:
                            Console.WriteLine("Goodbye!");
                            break;
                    }
                }
            }
        }

        //Print methods:

        private void PrintHotels(List<Hotel> hotels)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hotels");
            Console.WriteLine("--------------------------------------------");
            foreach (Hotel hotel in hotels)
            {
                Console.WriteLine(hotel.Id + ": " + hotel.Name);
            }
        }

        private void PrintHotel(Hotel hotel)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Hotel Details");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine(" Id: " + hotel.Id);
            Console.WriteLine(" Name: " + hotel.Name);
            Console.WriteLine(" Stars: " + hotel.Stars);
            Console.WriteLine(" Rooms Available: " + hotel.RoomsAvailable);
            Console.WriteLine(" Cost / Night: " + hotel.CostPerNight.ToString("C"));
        }

        private void PrintReservations(List<Reservation> reservations)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Reservation Details");
            Console.WriteLine("--------------------------------------------");
            foreach (Reservation reserve in reservations)
            {
                Console.WriteLine(" Id: " + reserve.Id);
                Console.WriteLine(" Hotel Id: " + reserve.HotelID);
                Console.WriteLine(" Check In: " + reserve.CheckinDate);
                Console.WriteLine(" Check Out: " + reserve.CheckoutDate);
                Console.WriteLine(" Full Name: " + reserve.Fullname);
                Console.WriteLine(" # Guests: " + reserve.Guests);
                Console.WriteLine("---");
            }
        }
    }
}
