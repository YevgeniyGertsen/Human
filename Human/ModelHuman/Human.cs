using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human.ModelIdentity;
using Human.ModelOther;

namespace Human.ModelHuman
{
   public enum sex {
        man, woman
    }

    public enum inv {
        first, second, third, none
    }


    public abstract class Human 
    {
        public string name { get; set; }
        public int age { get; set; }
        public string city { get ; set; }
        public DateTime birth { get; set; }
        public  sex sex { get; set; }
        protected inv inv { get; set; } = inv.none;
        public List<Identity> Identites { get; set; }
        public List<Sudimost> Sudimosti { get; set; }
        public List<Adult> Partner;




    }
}
