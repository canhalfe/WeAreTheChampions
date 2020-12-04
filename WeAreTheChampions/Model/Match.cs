using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Model
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime? MatchTime { get; set; }
   
        public int Team1Id { get; set; }
   
        public int Team2Id { get; set; }
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        //https://stackoverflow.com/questions/5559043/entity-framework-code-first-two-foreign-keys-from-same-table
        public virtual Team Team1 { get; set; }
        public virtual Team Team2 { get; set; }
        public Result? Result { get; set; }


    }
}
