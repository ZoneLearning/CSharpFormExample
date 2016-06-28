using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation
{
  public  class Product
    {
        public Product()
        {
        }
        public Product(string name,decimal price)
        {
            Name = name;
            Price = price;
            //list.Add(this);
        }

        public string Name { get; set; }
        public decimal Price { get; set; }

        public static List<Product> list = new List<Product>();

        public ListViewItem getProductList()
        {
            ListViewItem li = new ListViewItem();
            li.Text = Name;
            li.SubItems.Add(Price.ToString("C2"));
            return li;
        }
             
    }
}
