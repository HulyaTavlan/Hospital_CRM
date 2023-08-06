using Core.Objects.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Objects.Concrates
{
    public class PatientEntity : BasePersonEntity
    {
        public bool Smoke { get; set; }
        public bool Alcohol { get; set; }
        public string EMailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string DetailedAddress { get; set; }
    }
}
