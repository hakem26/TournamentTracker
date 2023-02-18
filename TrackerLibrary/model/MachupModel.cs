using System.Collections.Generic;

namespace TrackerLibrary.model
{
    public class MachupModel
    {
        public List<MachupEntryModel> Entries { get; set; } = new List<MachupEntryModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}