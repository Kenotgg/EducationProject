using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheEduSystem
{
    public class Exam : Lection
    {
        public int rate = 0;
        public Exam(int rate,string subjectName) : base(subjectName)
        {
            this.rate = rate;
        }
      
    }
}
