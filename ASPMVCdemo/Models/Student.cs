using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVCdemo.Models
{
    public class Student
    {
        string stid;
        string name;
        string sem;

        public string Stid
        {
            get
            {
                return stid;
            }

            set
            {
                stid = value;
            }
        }

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

        public string Sem
        {
            get
            {
                return sem;
            }

            set
            {
                sem = value;
            }
        }
    }
}