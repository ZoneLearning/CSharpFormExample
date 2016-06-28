﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAutomation
{
    class Table
    {
        public string Code { get; set; }
        private string customerName;

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                if (value.Length < 2)
                    throw new Exception("İsim 2 harften küçük olamaz.");

                customerName = value;
            }
        }

        public string CustomerPhone { get; set; }
        public bool isReserved { get; set; }
        public bool isFull { get; set; }

        List<Product> Products = new List<Product>();

        public decimal TotalPrice
        {
            get
            {
                decimal sum = 0;

                foreach (Product item in Products)
                {
                    sum += item.Price;
                }
                return sum;
            }
        }

    }
}
