using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesCount
{
    public class Countries
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public int total { get; set; }
        public Country[] data { get; set; }
    }
}