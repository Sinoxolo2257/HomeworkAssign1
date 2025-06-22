using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssign1.Models
{
	public class Driver
	{
		public string DriverID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string ServiceType { get; set; }
        public string ImageUrl { get; set; } // URL to the driver's image
        public bool IsAvailable { get; set; } // Indicates if the driver is currently available for bookings
    }
}