using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantAutomation
{
   public class Saloon:Button
    {
        public Saloon()
        {

        }

        public Saloon(string name, int numberOfTable, string tablePrefix)
        {
            SaloonName = name;
            Prefix = tablePrefix;
            for (int i = 1; i <= numberOfTable; i++)
            {
                Table t = new Table();
                t.Code = string.Format("{0}{1}", tablePrefix, i);
                this.Tables.Add(t);
            }

            this.Text = name;
            this.Width = 100;
            this.Height = 100;
        }
        public string SaloonName { get; set; }
        public string Prefix { get; set; }

        private static List<Saloon> _Saloons = new List<Saloon>();
        public static List<Saloon> Saloons
        {
            get
            {
                return _Saloons;
            }

            set
            {
                _Saloons = value;
            }
        }

        private List<Table> tables = new List<Table>();

        public List<Table> Tables
        {
            get
            {
                return tables;
            }

            set
            {
                tables = value;
            }
        }

        public ListViewItem getSaloonList()
        {
            ListViewItem list = new ListViewItem();
            list.Text = SaloonName;
            list.SubItems.Add(tables.Count.ToString());
            list.SubItems.Add(Prefix);

            return list;
        }
    }
}
