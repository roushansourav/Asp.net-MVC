using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVCdemo.Models
{
    public class Product
    {
        string _pid;
        string _name;
        double _price;
        string _description;
        public Product()
        { }

        public string Pid
        {
            get
            {
                return _pid;
            }

            set
            {
                _pid = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }

            set
            {
                _price = value;
            }
        }

        public string Description
        {
            get
            {
                return _description;
            }

            set
            {
                _description = value;
            }
        }

        public Product(string _pid, string _name, double _price, string _description)
        {
            this.Pid = _pid;
            this.Name = _name;
            this.Price = _price;
            this.Description = _description;
        }
    }
}