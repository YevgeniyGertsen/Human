using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Human.Education;


namespace Human.ModelHuman
{
    
    public class Adult: Human
    {
        public Adult():this(new List<School>()){}
         public Adult(List<School> schools)
            :this(schools, new List<College>()){}
        public Adult(List<School> schools, List<College> colleges)
            :this(schools, colleges, new List<University>()){}
        public Adult(List<School> schools, List<College> colleges, List<University> universities)
        {
            Kids = new List<Kids>();
            Schools = schools;
            Colleges = colleges;
            Universities = universities;
        }

        public List<Kids> Kids;
        public List<School> Schools;
        public List<College> Colleges;
        public List<University> Universities;
        
        public bool IsMarried { get; set; } = false;
        public bool IsWorked { get; set; } = false;
        
        public static bool operator ==(Adult a, Adult b)
        {
          return (a.age > b.age && a.IsWorked);
        }

        public static bool operator !=(Adult a, Adult b)
        {
            if (a.age < b.age && a.IsWorked)
                return true;

            return false;
        }


        public static Adult operator > (Adult a, Adult b)
        {
            if (a.age > b.age)
            {
                return a;
            }
            else
                return b;
        }

        public static Adult operator < (Adult a, Adult b)
        {
            if (a.age < b.age)
            {
                return b;
            }
            else
                return a;
        }

        public static Adult operator ++(Adult a)
        {
            a.age = a.age++;
            return a;
        }

        public static Adult operator --(Adult a)
        {
            a.age = a.age--;
            return a;
        }

        //public static Adult operator ToString(Adult a)
        //{
        //    return a;
        //}
    }
}
