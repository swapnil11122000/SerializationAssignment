using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializationAssignment
{
    [Serializable] //this is attribute this informs to clr that this class needs to serialize
    public class Student
    {
        public int rollno { get; set; }
        public string name { get; set; }
        public int percentage { get; set; }
    }
}
