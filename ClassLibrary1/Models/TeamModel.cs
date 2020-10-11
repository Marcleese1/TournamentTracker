using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class TeamModel
    {
        /// <summary>
        /// represents a list of people in 1 team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
       
        /// <summary>
        /// represents the team name 
        /// </summary>
        public string TeamName { get; set; }
    }
}
