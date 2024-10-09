using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ktanas_CSharp_tutorial
{
    class Car
    {
        public string producer { get; set; }
        public string model { get; set; }
        public int topSpeed { get; set; }

        public Car(string producer, string model, int topSpeed)
        {
            this.producer = producer;
            this.model = model;
            this.topSpeed = topSpeed;
        }
    }
}
