using Flyet.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flyet.Models
{
    public class Pilot : User
    {
        public int Rate { get; set; }
        public Boolean ActiveLicense { get; set; }
        public string LicenseSerial { get; set; }
        public int AuthorId { get; set; }
    }
}
