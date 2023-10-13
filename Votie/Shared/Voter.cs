using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votie.Shared
{
    public class Voter
    {
        public int Id { get; set; } 
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public DateTime Date { get; set; }    
        public int Document_id { get; set; } 
    }
}
