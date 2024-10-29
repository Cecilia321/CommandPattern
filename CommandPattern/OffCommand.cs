using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class OffCommand : ICommand
    {
        IElectronicDevice device;

        //commandObjekt. 
        public OffCommand(IElectronicDevice newDevice)
        {
            this.device = newDevice;
        }
        public void Execute()
        {
            device.Off();
        }
    }
}
