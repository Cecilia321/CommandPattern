﻿using System.Reflection.Metadata.Ecma335;

namespace CommandPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IElectronicDevice television = new Television();
            IElectronicDevice radio = new Radio();
            RemoteControl control = new RemoteControl(radio);

            control.Up.Press();
            control.Up.Press();
            
        }
    }
}