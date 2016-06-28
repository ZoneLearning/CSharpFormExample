using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation
{
    class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public static List<Product> list = new List<Product>();

        public ListViewItem createList()
        {
            ListViewItem list = new ListViewItem();
            list.Text = Name;
            list.SubItems.Add(Price.ToString("C2"));
            return list;
        }
             
    }
}
