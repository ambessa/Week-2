using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.SingleResponsility
{
    public class Student
    {
        //Data bout the student
        public string name { get; set; }
        public int studentID { get; set; }
        public int age { get; set; }
        
        //Data about the SU
        //public DateTime happyHour { get; set; }

        //Actions the student can take
        //Move this to a student controller class
        //public void GoToLecture()
        //{
        //    //some code goes here
        //}
    }
}
