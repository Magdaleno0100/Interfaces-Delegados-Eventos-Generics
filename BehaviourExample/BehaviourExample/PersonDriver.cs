using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourExample
{
    public class PersonDriver 
    {
        public IDriver DriverAttribute { set; get; }
        public IPlayer PlayerAttribute { set; get; }
        public void StartPD()
        {
            this.DriverAttribute.Drive();
        }

        public void Driving()
        {
            this.PlayerAttribute.Play();
        }

    }
}
