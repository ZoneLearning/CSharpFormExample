using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation
{
    public class Table:Button
    {
        public Table()
        {
            this.Width = 70;
            this.Height = 70;
        }

        private string code;
        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = this.Text = value;
            }
        }

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

        List<Product> _Products = new List<Product>();

        public List<Product> Products
        {
            get
            {
                return _Products;
            }

            set
            {
                _Products = value;
            }
        }

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
