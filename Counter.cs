using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace water_counter
{
    internal class Counter
    {
        // public DateTime date = new DateTime();
        public string Maker { get; set; }
        public string Model { get; set; }
        public int SerialID { get; set; }
        public string lastCheck { /*get { return date.ToShortDateString(); } set { }*/ get; set; }
        public bool hotWater { get; set; }
    }
}
