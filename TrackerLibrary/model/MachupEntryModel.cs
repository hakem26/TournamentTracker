using System.Collections.Generic;

namespace TrackerLibrary.model
{
    public class MachupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Represents the score for this particular team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the matchup that this team came
        /// </summary>
        /// <param name="initialScore">
        /// test param :)
        /// </param>
        public MachupModel ParentMatchup { get; set; }
    }
}