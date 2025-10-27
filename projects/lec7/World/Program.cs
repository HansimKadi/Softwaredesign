using World.Interfaces;
using World.Repositories;
using World.Services;
using World.Models;
using World.Mappers;
using System;

namespace World
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=worldSqlite.db";
            ICountryMapper countryMapper = new CountryMapper();
            ICountryRepository countryRepository = new SqliteCountryRepository(connectionString, countryMapper);
            ICountryService countryService = new CountryService(countryRepository);
            var countries = countryService.LoadCountries();
            countries[0].info();
        }
    }
}
