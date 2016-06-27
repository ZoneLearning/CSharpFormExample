using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarParkAutomation
{
    class Vehicle
    {
        //Araç tanımlanır tanımlanmaz o anki saati giriş zamanı olarak alınır. Constructor sayesinde.
        public Vehicle()
        {
            Entry = DateTime.Now;
        }

        public string Plaque { get; set; }
        public VehicleType Type { get; set; }
        public bool Contact { get; set; }
        public bool Subscriber { get; set; }
        public DateTime Entry { get; set; }
        public DateTime Exit { get; set; }

        public int Duration
        {
            get
            {
                TimeSpan timeSpan = Exit - Entry;
                if (timeSpan - TimeSpan.FromHours((int)timeSpan.TotalHours) > TimeSpan.Zero)
                {
                   timeSpan= timeSpan.Add(TimeSpan.FromHours(1));
                }
                return (int)timeSpan.TotalHours;
            }
        }

        public decimal Fee //ücret
        {
            get
            {
                decimal total = Type.Price * (Duration - 1) + Type.Price * 2;
                if (Subscriber)
                {
                    total *= 0.80m; //decimal olması için sonuna m yazıyoruz.
                }
                return total;
            }

        }

        public override string ToString()
        {
            string subscriberText = Subscriber ? "Abone" : "Abone Değil";
            string contactText = Contact ? "Kontak Var" : "Kontak Yok";
            return string.Format("{0}--{1}--{2}--{3}", Plaque, Type.Name, subscriberText, contactText);
        }
    }
    class VehicleType
    {

        public string Name { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return Name;
        }

    }
}
