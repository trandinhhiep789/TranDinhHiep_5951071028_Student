using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace TranDinhHiep_5951071028
{
    public class StudentInfo
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }
        [DataMember(Name = "PhoneNumber")]
        public float PhoneNumber { get; set; }
        [DataMember(Name = "DateTime")]
        public DateTime DateTime { get; set; }
    }
}