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

            if(response.ResponseStatus!=ResponseStatus.Completed) // We weren't able to talk to the server
            {
                Console.WriteLine("Could not communicate with the server. Check your internet connection and try again later.");
                return null;
            }

            if(response.StatusCode!= System.Net.HttpStatusCode.OK)
            {
                Console.WriteLine("Well that's awkward, something went wrong: " + response.StatusDescription);
            }

            return response.Data;
        }

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest(BASE_URL + "hotels");

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            if (!response.IsSuccessful)
            {
                Console.WriteLine("Well, this sucks: " + response.StatusDescription);
            }
            return response.Data;
        }

        public List<Reservation> GetReservations(int hotelId)
        {
            RestRequest request = new RestRequest($"{BASE_URL}hotels/{hotelId}/reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public List<Reservation> GetReservations()
        {
            RestRequest request = new RestRequest($"{BASE_URL}reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public Reservation AddReservation(Reservation newReservation)
        {
            RestRequest request = new RestRequest(BASE_URL + "reservations");
            request.AddJsonBody(newReservation); // Serializes the reservation to JSON and use it as a body.

            IRestResponse<Reservation> response = client.Post<Reservation>(request);

            return response.Data;
        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            RestRequest request = new RestRequest(BASE_URL + "reservations/" + reservationToUpdate.Id);
            request.AddJsonBody(reservationToUpdate);

            IRestResponse<Reservation> response = client.Put<Reservation>(request);

            return response.Data;
        }

        public bool DeleteReservation(int reservationId) //Changed to bool due to possibly wanting to know if this succeeded or not
        {
            RestRequest request = new RestRequest(BASE_URL + "reservations/" + reservationId);

            IRestResponse response = client.Delete(request);
            
            if (response.ResponseStatus != ResponseStatus.Completed) // We weren't able to talk to the server
            {
                Console.WriteLine("Could not communicate with the server. Check your internet connection and try again later.");
                return false;
            }
            
            return true;
        }
    }
}
