using System;
using System.Collections.Generic;

namespace Cricket.Models
{
    public partial class Matches
    {
        public int MatchId { get; set; }
        public string StadiumName { get; set; }
        public int? TeamA { get; set; }
        public int? TeamB { get; set; }
        public string Result { get; set; }
        public DateTime? DateTime { get; set; }
        public string WasMatchPlayed { get; set; }

        public Country TeamANavigation { get; set; }
        public Country TeamBNavigation { get; set; }
    }
}
