using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UwpMorePowerfulWithVS2017.PortableViewModels.DatabaseManager
{
    public class Loader
    {
        public string Connection { get; set; }
        public int Timeout { get; set; }
        public string Query { get; set; }
    }
}