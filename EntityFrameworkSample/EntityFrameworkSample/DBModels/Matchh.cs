using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkSample.DBModels
{
    public partial class Matchh
    {
        public int Cid { get; set; }
        public string Namee { get; set; }
        public int? Team1 { get; set; }
        public int? Team2 { get; set; }

        public virtual Team Team1Navigation { get; set; }
        public virtual Team Team2Navigation { get; set; }
    }
}
