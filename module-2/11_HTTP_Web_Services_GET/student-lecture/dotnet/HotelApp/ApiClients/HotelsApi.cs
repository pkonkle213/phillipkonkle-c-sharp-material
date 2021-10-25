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
            this.client = new RestClient();

            // See https://te-mockauction-server.azurewebsites.net/swagger/index.html for API Documentation

            this.BASE_URL = "https://te-mockauction-server.azurewebsites.net/students/" + laptopNumber + "/";
        }

        public List<Hotel> GetAllHotels()
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetAllReservations()
        {
            throw new NotImplementedException();
        }

        public Hotel GetHotel(int hotelId)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetReservationsForHotel(int hotelId)
        {
            throw new NotImplementedException();
        }

        public List<Hotel> GetAllHotelsInState(string state)
        {
            throw new NotImplementedException();
        }

    }
}
