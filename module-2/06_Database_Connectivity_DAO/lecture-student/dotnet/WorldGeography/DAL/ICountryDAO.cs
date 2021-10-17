using System.Collections.Generic;
using WorldGeography.Models;

namespace WorldGeography.DAL
{
    public interface ICountryDAO
    {
        /// <summary>
        /// Gets all countries.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Country> GetCountries();

        /// <summary>
        /// Gets all countries for a continent.
        /// </summary>
        /// <param name="continent">The continent to filter by.</param>
        /// <returns></returns>
        IEnumerable<Country> GetCountries(string continent);
    }
}
