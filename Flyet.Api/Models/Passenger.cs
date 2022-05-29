using Flyet.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flyet.Models
{
    public class Passenger : User
    {
        public int Id { get; set; }
        public int Rate { get; set; }
    }
}
