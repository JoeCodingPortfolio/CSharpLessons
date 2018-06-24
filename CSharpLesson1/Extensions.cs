using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpLesson1
{
     static class Extensions {

        public static string GetFullName(this Contact FullName)
        {
            return FullName.FirstName + " " + FullName.LastName;
        }




    }
  
}
