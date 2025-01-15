using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plumber.Core
{
    public class Technician:BaseAuditable
    {
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public string Profession { get; set; }
        public Service Service { get; set; }
        public int ServiceId { get; set; }
    }
}
