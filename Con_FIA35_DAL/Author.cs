using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Con_FIA35_DAL
{
    internal class Author
    {
        public int AId { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public bool Active { get; set; }
        public DateTime ActiveSince { get; set; }
        public DateTime LastPost { get; set; }


    }
}
