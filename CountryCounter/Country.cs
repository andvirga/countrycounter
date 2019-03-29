using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesCount
{
    public class Country
    {
        public string name { get; set; }
        public string nativeName { get; set; }
        public string[] topLevelDomain { get; set; }
        public string alpha2Code { get; set; }
        public string alpha3Code { get; set; }
        public int numericCode { get; set; }
        public string[] currencies { get; set; }
        public string[] callingCodes { get; set; }
        public string capital { get; set; }
        public string[] altSpellings { get; set; }
        public string relevance { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }
       // public Translation[] translations { get; set; }
        public int population { get; set; }
        public string[] latlng { get; set; }
        public string denonym { get; set; }
        public string area { get; set; }
        public string gini { get; set; }
        public string[] timezones { get; set; }
        public string[] borders { get; set; }
        public string[] languages { get; set; }
    }
}

