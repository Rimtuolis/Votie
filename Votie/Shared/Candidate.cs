using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Votie.Shared
{
    public class Candidate
    {
        public int Id { get; set; }
        public string? Name { get; set; }    
        public string? LastName { get; set; }
        public string? Photo { get; set;}
        public int District { get; set; }   
    }
}
