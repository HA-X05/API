﻿using Web_API_Versioning.API.Models.Domain;

namespace Web_API_Versioning
{
    public static class CountriesData
    {
        public static List<Country> Get()
        {
            var countries = new[]
            {
                new { Id = 1, Name = "United States" },
                new { Id = 2, Name = "Germany" },
                new { Id = 3, Name = "Brazil" },
                new { Id = 4, Name = "China" },
                new { Id = 5, Name = "Italy" },
                new { Id = 6, Name = "South Africa" },
                new { Id = 7, Name = "Mexico" },
                new { Id = 8, Name = "Japan" },
                new { Id = 9, Name = "Russia" },
                new { Id = 10, Name = "Australia" }
            };

            return countries.Select(c => new Country { Id = c.Id, Name = c.Name }).ToList();
        }
    }
}
