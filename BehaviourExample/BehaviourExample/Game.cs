using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourExample
{
    public class Game
    {
        public IPlayer Player { get; set; }

        public void Play()
        {
            this.Player.Play();
        }

    }
}
