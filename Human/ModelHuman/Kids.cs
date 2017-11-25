using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human.Education;

namespace Human.ModelHuman
{
   
    public class Kids: Human
    {
       public Kids() {
            schools = new List<School>();
            colleges = new List<College>();
        }
        public List<School> schools;
        public List<College> colleges;
    }
}
