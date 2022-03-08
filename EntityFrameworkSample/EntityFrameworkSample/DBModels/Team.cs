using System;
using System.Collections.Generic;

#nullable disable

namespace EntityFrameworkSample.DBModels
{
    public partial class Team
    {
        public Team()
        {
            MatchhTeam1Navigations = new HashSet<Matchh>();
            MatchhTeam2Navigations = new HashSet<Matchh>();
        }

        public int Id { get; set; }
        public string TeamName { get; set; }

        public virtual ICollection<Matchh> MatchhTeam1Navigations { get; set; }
        public virtual ICollection<Matchh> MatchhTeam2Navigations { get; set; }
    }
}
