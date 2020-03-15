using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourExample
{
    public class Dog : IPlayer
    {
        public void Play()
        {
            Console.WriteLine("Dog is playing");
        }
    }
}
