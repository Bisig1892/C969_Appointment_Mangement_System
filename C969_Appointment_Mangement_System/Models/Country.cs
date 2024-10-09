using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Appointment_Mangement_System.Models
{
    internal class Country : TimestampInfo
    {
        public int countryId { get; set; }
        public string country { get; set; }
    }
}
