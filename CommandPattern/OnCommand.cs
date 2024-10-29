using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// her laver vi specifikke commands
namespace CommandPattern
{
    internal class OnCommand : ICommand
    {
        IElectronicDevice device;

        //commandObjekt. 
        public OnCommand(IElectronicDevice newDevice)
        {
            this.device = newDevice;
        }
        public void Execute()
        {
            device.On();
        }
    }
}
