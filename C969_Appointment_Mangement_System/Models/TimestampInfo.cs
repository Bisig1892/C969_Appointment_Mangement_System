using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C969_Appointment_Mangement_System.Models
{
    public abstract class TimestampInfo
    {
        public Timestamp createdDate { get; set; }
        public string createdBy { get; set; }
        public Timestamp lastUpdate { get; set; }
        public string lastUpdatedBy { get; set; }
    }
}
