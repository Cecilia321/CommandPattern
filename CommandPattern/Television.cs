using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Vi laver en reciever klasse som hedder television, som benytter interfacet IElectronicDevice
namespace CommandPattern
{
    internal class Television : IElectronicDevice
    {
        //VI laver en private metode, med en value for volume 
        private int voulume = 0;

        //public int Voulume { get => voulume; set => voulume = value; }

        public void Off()
        {
            Console.WriteLine("TV is OFF");
        }

        public void On()
        {
            Console.WriteLine("TV is ON");
        }

        public void VolumeDown()
        {
            voulume--;
            Console.WriteLine("TV volume is at" + voulume);

        }

        public void VolumeUp()
        {
            voulume++;
            Console.WriteLine("TV volume is at" + voulume);
        }
    }
}
