using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Project
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
       // public DateTime deadline { get; set; }
        public int manager { get; set; }
        public int category { get; set; }
    }
}
