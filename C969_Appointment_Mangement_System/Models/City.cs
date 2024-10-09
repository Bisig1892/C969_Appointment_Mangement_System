using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Appointment_Mangement_System.Models
{
    public class City : TimestampInfo
    {
        public int cityId { get; set; }
        public string cityName { get; set; }
        public int countryId { get; set; }
    }
}
