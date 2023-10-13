using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votie.Shared
{
    public class Vote
    {
        public int Id { get; set; }
        public int Fk_voter { get; set; }
        public int Fk_candidate { get; set; }
        public TimeSpan Time { get; set;}
        public string? Encryption { get; set; }
        
    }
}
