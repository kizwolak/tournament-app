using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TournamentApp 
    {
        public class MatchupModel
        {
            public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
            public TeamModel Winnder { get; set; }
            public int MatchupRound { get; set; }
        }
    }