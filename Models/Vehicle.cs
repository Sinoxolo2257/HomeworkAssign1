using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssign1.Models
{
	public class Vehicle
	{
		public string VehicleID { get; set; }
        public string ServiceType { get; set; } 
        public string LicensePlate { get; set; }
        public string ImageUrl { get; set; } // URL to the vehicle's image
    }
}