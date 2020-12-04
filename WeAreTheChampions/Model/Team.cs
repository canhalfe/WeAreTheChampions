using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Model
{
    public class Team
    {
        public Team()
        {
            TeamColors = new HashSet<Color>();
        }
        public int Id { get; set; }
        [Required]
        public string TeamName { get; set; }
        public virtual ICollection<Player> Players { get; set; }
        public virtual ICollection<Color> TeamColors { get; set; }
        public virtual ICollection<Match> Team1Matches { get; set; }
        public virtual ICollection<Match> Team2Matches { get; set; }
    }
}
