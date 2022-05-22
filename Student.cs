using System;
using System.Collections.Generic;
using System.Text;

namespace CS_Practice
{
    internal class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string Amajor, double aGpa)
        {
            name = aName;
            major = Amajor;
            gpa = aGpa;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
}
