using System;

namespace CSharpLesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Contact c = new Contact();
            c.FirstName = "Hannah";
            c.LastName = "Crossland";
            c.DateOfBirth = new DateTime(1996, 04, 03);
            Console.WriteLine(c.ToString());

            c.Search(37.479444f, -122.450278f);
            c.Search(37.479444f, -122.450278f, 50);
            c.Search(37.479444f, -122.450278f, 50, "en");


            Console.WriteLine(c.VerifyEmailAddress("joe@example.com"));
            c.Search(27.966667f, 83.564445f);
            c.Search(27.966667f, 82.533333f);
            c.Search(29.434592f, 90.453434f, culcture: "en-GB");
            c.Search(32.432423f, 89.432432f, distance: 100);

            Contact c2 = new Contact
            {
                FirstName = "Joe",
                LastName = "Freeman",
                DateOfBirth = new DateTime(1995, 03, 15)
            };

            Console.WriteLine(c2.ToString());
            Console.Read();
        }
    }
}
