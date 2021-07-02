using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_MyCodeSnippet.Models.Exercise
{
    public class Student
    {
        public string Name { get; set; }
        public String PhoneNumber { get; set; }

        public Student(String name, String phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}