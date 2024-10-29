using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//invoker 
namespace CommandPattern
{
    internal class RemoteControl
    {
        //her laver vi remotens buttons 
        RemoteButton on;
        RemoteButton off;
        RemoteButton up;
        RemoteButton down;
        public RemoteControl(IElectronicDevice electronicDevice) 
        {
            on = new RemoteButton(new OnCommand(electronicDevice));
            Off = new RemoteButton(new OffCommand(electronicDevice));
            Up = new RemoteButton(new UpCommand(electronicDevice));
            
        }

        internal RemoteButton On { get => on; set => on = value; }
        internal RemoteButton Off { get => off; set => off = value; }
        internal RemoteButton Up { get => up; set => up = value; }
    }
}
