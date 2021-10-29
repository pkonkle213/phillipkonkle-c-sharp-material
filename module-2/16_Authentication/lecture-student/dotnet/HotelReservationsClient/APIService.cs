using HotelReservationsClient.Exceptions;
using RestSharp;
using RestSharp.Authenticators;
using System.Collections.Generic;

namespace HotelReservationsClient
{
    public class APIService
    {
        private readonly string API_URL = "https://localhost:44322/";
        private readonly RestClient client = new RestClient();
        private string apiToken = null;

        public List<Hotel> GetHotels()
        {
            RestRequest request = new RestRequest(API_URL + "hotels");
            IRestResponse<List<Hotel>> response = client.Get<List<Hotel>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed || !response.IsSuccessful)
            {
                ProcessErrorResponse(response);
            }
            else
            {
                return response.Data;
            }

            return null;
        }

        public List<Reservation> GetReservations(int hotelId = 0)
        {
            string url = API_URL;
            if (hotelId == 0)
            {
                url += "reservations";
            }
            else
            {
                url += $"hotels/{hotelId}/reservations";
            }

            RestRequest request = new RestRequest(url);
            IRestResponse<List<Reservation>> response = client.Get<List<Reservation>>(request);

            if (response.ResponseStatus != ResponseStatus.Completed || !response.IsSuccessful)
            {
                ProcessErrorResponse(response);
            }
            else
            {
                return response.Data;
            }
            return null;
        }

        public Reservation GetReservation(int reservationId)
        {
            RestRequest request = new RestRequest(API_URL + "reservations/" + reservationId);

            IRestResponse<Reservation> response = client.Get<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed || !response.IsSuccessful)
            {
                ProcessErrorResponse(response);
            }
            else
            {
                return response.Data;
            }
            return null;
        }

        public Reservation AddReservation(Reservation newReservation)
        {
            RestRequest request = new RestRequest(API_URL + "reservations");
            request.AddJsonBody(newReservation);

            IRestResponse<Reservation> response = client.Post<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed || !response.IsSuccessful)
            {
                ProcessErrorResponse(response);
            }
            else
            {
                return response.Data;
            }
            return null;
        }

        public Reservation UpdateReservation(Reservation reservationToUpdate)
        {
            RestRequest request = new RestRequest(API_URL + "reservations/" + reservationToUpdate.id);
            request.AddJsonBody(reservationToUpdate);
            IRestResponse<Reservation> response = client.Put<Reservation>(request);

            if (response.ResponseStatus != ResponseStatus.Completed || !response.IsSuccessful)
            {
                ProcessErrorResponse(response);
            }
            else
            {
                return response.Data;
            }
            return null;
        }

        public bool DeleteReservation(int reservationId)
        {
            RestRequest request = new RestRequest(API_URL + "reservations/" + reservationId);
            IRestResponse response = client.Delete(request);

            if (response.ResponseStatus != ResponseStatus.Completed || !response.IsSuccessful)
            {
                ProcessErrorResponse(response);
            }
            else
            {
                return true;
            }

            return false;
        }

        private void ProcessErrorResponse(IRestResponse response)
        {
            if (response.ResponseStatus != ResponseStatus.Completed)
            {
                throw new NoResponseException("Error occurred - unable to reach server.", response.ErrorException);
            }
            else if (!response.IsSuccessful)
            {
                throw new NonSuccessException((int)response.StatusCode);
            }
        }

        public bool Login(string submittedName, string submittedPass)
        {
            RestRequest request = new RestRequest(API_URL + "login");

            LoginUser loginUser = new LoginUser { Username = submittedName, Password = submittedPass };
            request.AddJsonBody(loginUser);

            IRestResponse<API_User> response = client.Post<API_User>(request);

            if (response.ResponseStatus != ResponseStatus.Completed || !response.IsSuccessful)
            {
                ProcessErrorResponse(response);
                return false;
            }

            apiToken = response.Data.Token;

            return true;
        }

        public bool LoggedIn
        {
            get
            {
                return !string.IsNullOrWhiteSpace(apiToken);
            }
        }

        public void Logout()
        {
            apiToken = null;
            client.Authenticator = null;
        }
    }
}
