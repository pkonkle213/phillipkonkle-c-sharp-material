using System;
using System.Collections.Generic;
using System.Text;
using HTTP_Web_Services_GET_lecture.Data;
using RestSharp;

namespace HTTP_Web_Services_GET_lecture.ApiClients
{
    public class TravelApi
    {
        public string GetRecommendedDestination()
        {
            // TODO: Call out to http://swapi.dev/api/planets/11/
            RestClient client = new RestClient();

            RestRequest request = new RestRequest("http://swapi.dev/api/planets/11/");

            IRestResponse<Planet> response = client.Get<Planet>(request);

            Planet planet = response.Data;

            string ad = $"{planet.Name}. I hear it is " +
                $"{planet.Climate} this time of year in its {planet.Terrain} lands";

            return ad;
        }
    }
}
