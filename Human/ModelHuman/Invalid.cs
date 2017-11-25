using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.ModelHuman
{
    public class Invalid: Adult
    {
        public Invalid():this(inv.none) { }
        public Invalid(inv inv):this(inv, 0) { }
        public Invalid(inv inv, double allowance):base()
        {
            base.inv = inv;
            this.allowance = allowance;
        }
        public double allowance { get; set; }  
    }
}
