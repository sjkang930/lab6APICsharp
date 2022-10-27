using System;
using System.Numerics;
using Microsoft.EntityFrameworkCore;
using provinceCity.Models;
public static class SeedData
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Province>().HasData(
            GetProvinces()
            );
        modelBuilder.Entity<City>().HasData(
           GetCities()
           );
    }

    public static List<Province> GetProvinces()
    {
        List<Province> Provinces = new List<Province>() {
            new Province() {
                ProvinceName="BritishColumbia",
                ProvinceCode="BC",
            },
            new Province() {
               ProvinceName="Manitoba",
                ProvinceCode="MB",
            },
            new Province() {
             ProvinceName="Ontario",
                ProvinceCode="ON",
            },
        };
        return Provinces;
    }
    public static List<City> GetCities()
    {
        List<City> Cities = new List<City>() {
            new City {
                CityId = 1,
                CityName = "Vancouver",
                ProvinceCode = "BC",
                Population = 100000
            },
            new City {
                CityId = 2,
                CityName = "Surrey",
                ProvinceCode = "BC",
                Population = 200000
            },
             new City {
                CityId = 3,
                CityName = "Langley",
                ProvinceCode = "BC",
                Population = 200000
            },
            new City {
                CityId = 4,
                CityName = "Burnaby",
                ProvinceCode = "BC",
                Population = 200000
            },
               new City {
                CityId = 5,
                CityName = "Winnipeg",
                ProvinceCode = "MB",
                Population = 100000
            },
            new City {
                CityId = 6,
                CityName = "brandon",
                ProvinceCode = "MB",
                Population = 200000
            },
             new City {
                CityId = 7,
                CityName = "churchill",
                ProvinceCode = "MB",
                Population = 200000
            },
            new City {
                CityId = 8,
                CityName = "Toronto",
                ProvinceCode = "ON",
                Population = 200000
            },
              new City {
                CityId = 9,
                CityName = "Ottawa",
                ProvinceCode = "ON",
                Population = 200000
            },
        };

        return Cities;
    }
}
