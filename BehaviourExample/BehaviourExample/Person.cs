using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourExample
{
    public class Person : IPlayer, IDriver
    {
        public void Drive()
        {
            Console.WriteLine("Driving");
        }

        public void Play()
        {
            Console.WriteLine("Playing");
        }
    }
}
