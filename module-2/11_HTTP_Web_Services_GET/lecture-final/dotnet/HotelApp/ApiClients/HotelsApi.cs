using RestSharp;
using System;
using System.Collections.Generic;

namespace HTTP_Web_Services_GET_lecture.ApiClients
{
    public class HotelsApi
    {
        private readonly RestClient client;
        private readonly string BASE_URL;

        public HotelsApi(string laptopNumber)
        {

            // See https://te-mockauction-server.azurewebsites.net/swagger/index.html for API Documentation

            this.BASE_URL = "https://te-mockauction-server.azurewebsites.net/students/" + laptopNumber + "/";
            this.client = new RestClient();
        }

        public List<Hotel> GetAllHotels()
        {
            RestRequest request = new RestRequest(BASE_URL + "hotels");

            IRestResponse<List<Hotel>> response;
            response = client.Get<List<Hotel>>(request);

            List<Hotel> results = response.Data;
            return results;
        }

        public List<Reservation> GetAllReservations()
        {
            RestRequest request = new RestRequest(BASE_URL + "reservations");

            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public Hotel GetHotel(int hotelId)
        {
            // First, we need a RestClient (we already have one)
            // If applicable, we need to set authentication information (next Monday's problem)

            // Create a request to send over
            // URL should look something like https://te-mockauction-server.azurewebsites.net/students/12345/hotels/5
            RestRequest request = new RestRequest(BASE_URL + "hotels/" + hotelId);

            //IRestResponse<Reservation> response = client.Get<Reservation>(request);

            // Send the request and get a response
            IRestResponse<Hotel> response;
            response = client.Get<Hotel>(request); // Actually makes the GET request to the server and waits for a response

            // Get the Hotel from the response
            Hotel hotel = response.Data;

            return hotel;

            //return null;
        }

        public List<Reservation> GetReservationsForHotel(int hotelId)
        {
            RestRequest request = new RestRequest($"{BASE_URL}hotels/{hotelId}/reservations");
            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            return response.Data;
        }

        public List<Hotel> GetAllHotelsInState(string state)
        {
            RestRequest request = new RestRequest($"{BASE_URL}hotels/filter?state={state}&isAwesome=1");
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            return response.Data;
        }

    }
}
