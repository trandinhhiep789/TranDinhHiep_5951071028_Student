using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace TranDinhHiep_5951071028
{
    [DataContract]
    public class WeatherInfo
    {
        [DataMember(Name = "Location")]
        public string Location { get; set; }
        [DataMember(Name = "degree")]
        public float Degree { get; set; }
        [DataMember(Name = "datetime")]
        public DateTime DateTime { get; set; }
    }
}