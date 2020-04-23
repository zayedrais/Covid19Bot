using System;
using System.Globalization;
using Newtonsoft.Json;

namespace Microsoft.BotBuilderSamples
{
    public class RepoWorld
    {
        public int newConfirmed { get; set; }
        public int totalConfirmed { get; set; }
        public int newDeaths { get; set; }
        public int totalDeaths  {get; set; }
        public int newRecovered { get; set; }
        public int totalRecovered { get; set; }

        public string date { get; set; }

        public RepoWorld()
        { }

        [JsonConstructor]
        public RepoWorld(int NewConfirmed, int TotalConfirmed, int NewDeaths, int TotalDeaths, int NewRecovered, int TotalRecovered, string Date)
        {
            newConfirmed = NewConfirmed;
            totalConfirmed = TotalConfirmed;
            newDeaths = NewDeaths;
            totalDeaths = TotalDeaths;
            newRecovered = NewRecovered;
            totalRecovered = TotalRecovered;
            date =Date;
        }
    }
}
