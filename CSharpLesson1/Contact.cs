using System;
using System.Collections.Generic;
using System.Text;


namespace CSharpLesson1
{
    class Contact
    {
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("Name: {0} \r\n", this.GetFullName());
            stringBuilder.AppendFormat("Date Of Birth: {0} \r\n", this.dateOfBirth);
            return stringBuilder.ToString();
        }
        public string emailAddress;
        private DateTime dateOfBirth;

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            { 
                this.dateOfBirth = value;
            }

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public string FullName
        //{
        //    get
        //    {
        //        return FirstName + " " + LastName;
        //    }
        //}
        public bool VerifyEmailAddress(string emailAddress)
        {
            return true;
        }

        public void Search(float latitude, float longitude, int distance = 10, string culcture ="en-US")
        {
            Console.WriteLine("latitude: {0}, longitude: {1}, distance: {2}, culcture: {3}", latitude,longitude,distance,culcture);
        }

        



    }

}
