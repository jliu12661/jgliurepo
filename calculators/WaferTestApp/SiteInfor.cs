using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaferTestApp
{
    public enum STATE {UNTESTED, PASS, FAIL}

    public class SiteInfor
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public bool Selected { get; set; } = false;
        public STATE State { get; set; } = STATE.UNTESTED;

        public double X { get; set; }
        public double Y { get; set; }
    }
}
