using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeneratorName;
using Human.ModelHuman;

namespace Human
{
    public class HumanGenerated
    {
        private Random rnd=new Random();
        
        public Adult adult_g()
        {
            Adult adult= new Adult();
            adult.age = rnd.Next(16,100);
            adult.birth = Generated_B(adult);
            adult.city = "Almaty";

            Generator g = new Generator();
            
            adult.name = g.GenerateDefault(Gender.man).Replace("\n","");
            adult.name = adult.name.Replace("<center><b><font size=7>","").Replace("</font></b></center>","");

            return adult;
        } 

        public void TestOperators ()
        {
            Adult a = adult_g();
            Adult b = adult_g();

            Adult c = a > b;

            Adult s = c++;
        }


        public DateTime Generated_B(Adult adult)
        {
            //DateTime date;
            //int month = rnd.Next(0, DateTime.Now.Month);
            //if (DateTime.IsLeapYear(DateTime.Now.AddYears(-adult.age).Year))
            //{
            //    if (month == 2)
            //        date = new DateTime(-adult.age, month, rnd.Next(0, 29));
            //    else
            //        date = new DateTime(-adult.age, month, rnd.Next(0, 28));
            //}
            //else
            //    date = new DateTime(-adult.age, month, rnd.Next(0, 28));

            return DateTime.Now.AddYears(-adult.age);
    }
    }
}
