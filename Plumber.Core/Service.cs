using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber.Core
{
    public class Service:BaseAuditable
    {
        public string Description { get; set; }
        public string ImgUrl { get; set; }
        public ICollection<Technician> Technicians { get; set; }
    }
}
