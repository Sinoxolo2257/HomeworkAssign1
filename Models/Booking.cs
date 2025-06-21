using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeworkAssign1.Models
{
	public class Booking
	{
		public string BookingID { get; set; }
		public DateTime BookingDate { get; set; }
        public string FullName { get; set; }
        public string ServiceType { get; set; }
        public string VehicleID { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string DriverID { get; set; }
        public bool IsSOS { get; set; }

    }
}