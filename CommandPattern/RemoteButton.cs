using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//press som kalder c.execute
namespace CommandPattern
{
    internal class RemoteButton
    {
        ICommand command;

        public RemoteButton(ICommand NewCommand)
        {
            this.command = NewCommand;
        }

        public void Press()
        {
            command.Execute();
        }
    }
}
