using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controls
{
    class MyObject
    {

        public string Category { get; set; }
        public string Data { get; set; }
        public override string ToString()
        {
            return Data;
        }

    }
}
