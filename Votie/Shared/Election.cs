using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votie.Shared
{
    public class Election
    {
        public int Id { get; set; }
        public DateTime Date  { get; set; }
        public int Type { get; set; }
        public int District { get; set; }
        public int Fk_results { get; set; }
    }
}
