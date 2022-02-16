using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoCMS.Models
{
    public class NewsViewModel
    {
        public NewsViewModel()
        {
            
        }
        public int ID { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string NewsContent { get; set; }
    }
}
