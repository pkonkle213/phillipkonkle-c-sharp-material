using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_POST_PUT_DELETE_lecture.ApiClients
{
    public class ReservationsService
    {
        private readonly string BASE_URL = "";
        private readonly RestClient client;

        public ReservationsService(string base_url)
        {
            this.BASE_URL = base_url;
            this.client = new RestClient();
        }

        public Reservation GetReservation(int reservationId)
        {
            RestRequest request = new RestRequest(BASE_URL + "reservations/" + reservationId);

            IRestResponse<Reservation> response = client.Get<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed) // We weren't able to talk to the server
            {
                Console.WriteLine("Could not communicate with the server. Check your internet connection and try again later.");
                return null;
            }

            if (response.StatusCode != System.Net.HttpStatusCode.OK) // Must be a 200 OK status
            {
                Console.WriteLine("Unexpected status code for Get Reservation: " + response.StatusDescription);
            }

            return response.Data;
        }

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest(BASE_URL + "hotels");

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed) // We weren't able to talk to the server
            {
                Console.WriteLine("Could not communicate with the server. Check your internet connection and try again later.");
                return new List<Hotel>();
            }

            if (!response.IsSuccessful) // IsSuccessful means Status >= 200 && Status <= 299
            {
                Console.WriteLine("Could not get list of hotels: " + response.StatusDescription);
                return new List<Hotel>();
            }

            return response.Data;
        }

        public List<Reservation> GetReservations(int hotelId)
        {
            RestRequest request = new RestRequest($"{BASE_URL}hotels/{hotelId}/reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed) // We weren't able to talk to the server
            {
                Console.WriteLine("Could not communicate with the server. Check your internet connection and try again later.");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not get the hotel: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public List<Reservation> GetReservations()
        {
            RestRequest request = new RestRequest($"{BASE_URL}reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed) // We weren't able to talk to the server
            {
                Console.WriteLine("Could not communicate with the server. Check your internet connection and try again later.");
                return new List<Reservation>();
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not get reservations: " + response.StatusDescription);
                return new List<Reservation>();
            }

            return response.Data;
        }

        public Reservation AddReservation(Reservation newReservation)
        {
            RestRequest request = new RestRequest(BASE_URL + "reservations");

            request.AddJsonBody(newReservation); // Serialize the reservation to JSON and use it as a body

            IRestResponse<Reservation> response = client.Post<Reservation>(request);

            CheckForErrors(newReservation, response);

            return response.Data;
        }

        private static void CheckForErrors(Reservation newReservation, IRestResponse<Reservation> response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed) // We weren't able to talk to the server
            {
                /*
                Console.WriteLine("Could not communicate with the server. Check your internet connection and try again later.");
                return null;
                */
                throw new ReservationException(newReservation, "Could not communicate with the server: " + response.ErrorMessage);
            }

            if (!response.IsSuccessful)
            {
                /*
                Console.WriteLine("Could not create reservation: " + response.Content);
                return null;
                */
                throw new ReservationException(newReservation, response.StatusDescription);
            }
        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            RestRequest request = new RestRequest(BASE_URL + "reservations/" + reservationToUpdate.Id);

            request.AddJsonBody(reservationToUpdate);

            IRestResponse<Reservation> response = client.Put<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed) // We weren't able to talk to the server
            {
                Console.WriteLine("Could not communicate with the server. Check your internet connection and try again later.");
                return null;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not update reservation: " + response.StatusDescription);
                return null;
            }

            return response.Data;
        }

        public bool DeleteReservation(int reservationId)
        {
            RestRequest request = new RestRequest(BASE_URL + "reservations/" + reservationId);

            IRestResponse response = client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed) // We weren't able to talk to the server
            {
                Console.WriteLine("Could not communicate with the server. Check your internet connection and try again later.");
                return false;
            }

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Could not delete reservation: " + response.StatusDescription);
                return false;
            }

            return true;
        }
    }
}
