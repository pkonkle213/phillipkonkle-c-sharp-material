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
            throw new NotImplementedException();
        }

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest(BASE_URL + "hotels");

            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

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
            throw new NotImplementedException();
        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            throw new NotImplementedException();
        }

        public void DeleteReservation(int reservationId)
        {
            throw new NotImplementedException();
        }
    }
}
