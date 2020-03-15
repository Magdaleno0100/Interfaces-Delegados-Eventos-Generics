using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourExample
{
    public class Car
    {
        public IDriver Driver { set; get; }

        public void Start()
        {
            this.Driver.Drive();
        }
    }
}
