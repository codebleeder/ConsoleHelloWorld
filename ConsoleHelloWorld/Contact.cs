using System;
namespace ConsoleHelloWorld
{
    public class Contact
    {
        private string phoneNumber;

        public string Firstname
        {
            set;
            get;
        }

        public bool checkPhoneNumber()
        {
            if (this.phoneNumber.Length == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Contact()
        {
            this.Firstname = "Phil";
            this.phoneNumber = "1234567891";
        }

        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
    }

}
