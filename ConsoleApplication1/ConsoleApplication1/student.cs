using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class student
    {
        public string name;
        public string hometown;
        public int age;
        public override bool Equals(object obj)
        {
            student other = obj as student;
            if(other != null)
            {
                if(other.name == name && other.age == age && other.hometown == hometown)
                { return true; }
            }
            return false;
        }
        public override string ToString()
        {
            string info = "";
            info += "Student Name: " + name;
            info += "\nAge: " + age;
            info += "\nHometown: " + hometown;
            return info;
        }
    }
}
