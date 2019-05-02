using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVCdemo.Models
{
    public class User
    {
        private string name;
        private string city;
        private int age;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

    }
}