using System;
using System.Collections.Generic;

namespace Cricket.Models
{
    public partial class Country
    {
        public Country()
        {
            MatchesTeamANavigation = new HashSet<Matches>();
            MatchesTeamBNavigation = new HashSet<Matches>();
            Players = new HashSet<Players>();
        }

        public int CountyId { get; set; }
        public string CountryName { get; set; }
        public string Continent { get; set; }
        public string CountryCode { get; set; }

        public Stadium Stadium { get; set; }
        public ICollection<Matches> MatchesTeamANavigation { get; set; }
        public ICollection<Matches> MatchesTeamBNavigation { get; set; }
        public ICollection<Players> Players { get; set; }
    }
}
