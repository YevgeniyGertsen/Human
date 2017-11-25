using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Education
{
    public abstract class Education
    {
        public string Name { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime? End_date { get; set; } = null;
    }
}