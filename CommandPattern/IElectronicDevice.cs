using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//vi laver en interface som bliver brugt til at lave alle recievers 
namespace CommandPattern
{
    public interface IElectronicDevice
    {

        public void On();
        public void Off();
        public void VolumeUp();
        public void VolumeDown();


    }
}
