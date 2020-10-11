using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TournamentModel
    {
        /// <summary>
        /// represents the name of the tournament
        /// </summary>
        public string TournamentName { get; set; }

        /// <summary>
        /// represents how much will be required in order to enter the tournament
        /// </summary>
        public decimal EntryFee { get; set; }

        /// <summary>
        /// represents a list of the teams entered
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// represents a list of the prizes that will be up for grabs
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        //represents a list of a list of the matchups and rounds
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();

    }
}
