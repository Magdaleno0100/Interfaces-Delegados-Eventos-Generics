using System;
using System.Collections.Generic;
using System.Text;

namespace ExplicitImplementation
{
    public class Person : IPlayer, IMusician
    {
      void IPlayer.Play()
        {
            Console.WriteLine("Play video game");
        }

        void IMusician.Play()
        {
            Console.WriteLine("Play guitar");
        }
        public void Play()
        {
            Console.WriteLine("Método de clase");
        }

    }
}
