using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Microsoft.BotBuilderSamples
{
    public class Repo
    {
        public int confirmed { get; set; }
        public int deaths { get; set; }
        public int recovered { get; set; }
        public int active  {get; set; }

        public string date { get; set; }

        public Repo()
        { }

        [JsonConstructor]
        public Repo(int Confirmed, int Deaths, int Recovered, int Active, string Date)
        {
            confirmed = Confirmed;
            deaths = Deaths;
            recovered = Recovered;
            active = Active;
            date = Date;

        }
    }
}
