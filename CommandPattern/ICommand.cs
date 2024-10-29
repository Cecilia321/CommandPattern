using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//vi laver her et command interface, som alle commands skal have implementeret. 
namespace CommandPattern
{
    public interface ICommand
    {
        public void Execute();

    }
}
