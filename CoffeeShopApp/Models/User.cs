using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShopApp.Models
{
    public class User
    {
        
            private string firstName;
            private string lastName;
            private string email;
            private string phoneNumber;
            private string password;
       

        public User() : this("", "", "","","")
            {
               
            }

            public User(string firstName,string lastName,string email,string phoneNumber,string password)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.email = email;
                this.phoneNumber = phoneNumber;
                this.password = password;
            }

            public string FirstName
            {
                set { firstName = value; }
                get { return firstName; }
            }
            public string LastName
            {
                set { lastName = value; }
                get { return lastName; }
            }
            public string Email
            {
                set { email = value; }
                get { return email; }
            }

        public string Phonenumber
        {
            set { phoneNumber = value; }
            get { return phoneNumber; }
        }
        public string Password
        {
            set { password = value; }
            get { return password; }
        }

    }

    
}