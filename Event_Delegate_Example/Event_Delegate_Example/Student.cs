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
        public string AdSoyad { get; set; }
        public double Ortalama { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public double Midterm { get; set; }
        public double Final { get; set; }
        public double Average { get { return Midterm * 0.4 + Final * 0.6; } }

        //Herhangi bir event olusturabiliyorum, olusturdugum event'e olay baglıyorum.

        //event'in tipi delagate olmak zorunda
        //bu event'lara metod baglayabiliyorum ama ne zaman calistiracagimi bilmem gerek
        //Ortalama hesaplandıgı, degistigi zaman. Midterm ve Final'a a deger atandıgı zaman.
        public event PassFailEventHandler Pass;
        public event PassFailEventHandler Fail;

    }
}
