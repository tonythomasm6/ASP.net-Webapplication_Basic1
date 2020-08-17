using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FIT5032_Week03.Exercise
{
    public class ExampleDictionary
    {
        public void Example()
        {
            Dictionary<int, Student> studentDictionary = new Dictionary<int, Student>();
            Student s1 = new Student("Mathew", "0460318009");
            Student s2 = new Student("Kim", "0460318010");

            studentDictionary.Add(1, s1);
            studentDictionary.Add(2, s2);

            Student result = new Student("", "");

            studentDictionary.TryGetValue(1,out result);

            String n = result.Name;
            String p = result.PhoneNumber;
        }
      
        
    }
}