using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefentoets_Herkansing_OP2.Classes
{
    public class Json
    {

    }

    public class Toevoegen
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
    }

    public class Club
    {

        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Description")]
        public string Description { get; set; }
    }

    public class Resultaat
    {

        [JsonProperty("clubs")]
        public List<Club> Clubs { get; set; }
    }
}
