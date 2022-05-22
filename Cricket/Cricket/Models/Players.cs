using System;
using System.Collections.Generic;

namespace Cricket.Models
{
    public partial class Players
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int? PlayerAge { get; set; }
        public int? CountryId { get; set; }

        public Country Country { get; set; }
    }
}
