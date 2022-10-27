using System;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace provinceCity.Models
{
    public class Province
    {
    
        
        [Key]
        [MaxLength(30)]

        public string ProvinceCode { get; set; }
        public string ProvinceName { get; set; }
        public ICollection<City> Cities

        {
            get; set;

        }
    
    }
}

