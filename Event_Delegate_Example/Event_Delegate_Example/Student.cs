using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Delegate_Example
{
    //Ogrencinin durumu kaldıgı ve gectigi anda olan EventHandler olusturuldu
    delegate void PassFailEventHandler(object sender, PassFailEventArgs e);

    //Event argumanı olusturuldu.
    class PassFailEventArgs : EventArgs
    {
        public string NameSurname { get; set; }
        public double Average { get; set; }
    }
    class Student
    {
        public static int PASS_POINT = 70;

        public string Name { get; set; }
        public string Surname { get; set; }
        private double midterm;
        private double final;

        public double Midterm
        {
            get { return midterm; }
            set { midterm = value; StateControl(); }
        }

        public double Final
        {
            get { return final; }
            set { final = value; StateControl(); }
        }

        void StateControl()
        {
            if (Average >= PASS_POINT)
            {
                if(Pass!=null)
                Pass(this, new PassFailEventArgs { NameSurname = Name + " " + Surname, Average = Average });
            }
            else
            {
                if (Fail != null)
                    Fail(this,new PassFailEventArgs { NameSurname = Name + " " + Surname, Average = Average });

            }
                
        }

        public double Average { get { return Midterm * 0.4 + Final * 0.6; } }

        //Herhangi bir event olusturabiliyorum, olusturdugum event'e olay baglıyorum.

        //event'in tipi delagate olmak zorunda
        //bu event'lara metod baglayabiliyorum ama ne zaman calistiracagimi bilmem gerek
        //Ortalama hesaplandıgı, degistigi zaman. Midterm ve Final'a a deger atandıgı zaman.
        public event PassFailEventHandler Pass;
        public event PassFailEventHandler Fail;

        public override string ToString()
        {
            return Name + " " + Surname + " " + Average;
        }

    }
}
