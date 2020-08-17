using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Week03.Exercise
{
    public class Student
    {
        public string Name { get; set; }
        public string PhoneNumber {get;set;}
        public Student(String name, String phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
             
        }
    }
}