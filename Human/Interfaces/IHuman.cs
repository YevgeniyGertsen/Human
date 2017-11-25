using Human.ModelHuman;
using Human.ModelIdentity;
using Human.ModelOther;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human.Interfaces
{
    public interface IHuman
    {
        string name { get; set; }
        int age { get; set; }
        sex sex { get; set; }
    }
}
