using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task_clas
{
    class Car
    {
        public string brand;
        public int door;
        public string type;
        public double engine;

        public Car()
        {
        }

        public string CarDetail()
        {
            return $"brand:{brand} \ndoor:{door} \ntype:{type} \nengine:{engine}";
        }
    }
  
    
    
}
