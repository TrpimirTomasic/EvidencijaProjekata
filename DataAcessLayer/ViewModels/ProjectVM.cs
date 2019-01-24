using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;

namespace DataAcessLayer.ViewModels
{
   public class ProjectVM
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime deadline { get; set; }
        public string managerFullName { get; set; }
        public string category { get; set; }
    }
}
