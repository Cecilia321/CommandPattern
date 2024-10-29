using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    internal class UpCommand : ICommand
    {
        IElectronicDevice television;

        //commandObjekt. 
        public UpCommand(IElectronicDevice newDevice)
        {
            this.television = newDevice;
        }
        public void Execute()
        {
            television.VolumeUp();
        }
    }
}
