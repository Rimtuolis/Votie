using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votie.Shared
{
    public class Result
    {
        public int Id { get; set; }
        public int Fk_election { get; set; }
        public int Fk_candidate { get; set; }
        public int Total { get; set; }
        public float Percent { get; set; }
        
    }
}
