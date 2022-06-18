using System;
using System.ComponentModel.DataAnnotations;

namespace HotelProject.Models
{
    public class LoginPicker
    {
        public Guid Id { get; set; } //Guidler unique değerler oluştururlar, bu sebeple Id için kullanılırlar.

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public string roomSelect { get; set; } // dropdown
        public string adultCount { get; set; } // dropdown
        public string childCount { get; set; } // dropdown

        //public DateTime gunFark { get; set => endDate - startDate; }
    }
}
