using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavstaBLL
{
  public  class NewFile
    {
        public NewFile(dynamic point, dynamic time, dynamic mpTime)
        {
            Point = point;
            Time = time;
            MpTime = mpTime;
        }

        public dynamic Point { get; set; }
        public dynamic Time { get; set; }
        public dynamic MpTime { get; set; }


        public override string ToString()
        {
            return "Point:"+ Point+ " " + "Time:" + Time + " " +   "MpTime:" + MpTime;
        }

        
    }
}
