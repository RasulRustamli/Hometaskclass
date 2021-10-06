using System;
using System.Collections.Generic;
using System.Text;

namespace Home_task_clas
{
    class Bmw:Car
    {
        public string mode;

        public Bmw(int door, string type, double engine,string mode)
        {
            this.brand = "BMW";
            this.door = door;
            this.mode = mode;
            this.type = type;
            this.engine = engine;
        }

        public string Bmwdetail()
        {
            return $"{CarDetail()} {mode}";
        }
    }
}
