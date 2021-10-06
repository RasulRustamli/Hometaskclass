using System;

namespace Home_task_clas
{
    class Program
    {
        static void Main(string[] args)
        {
            Bmw car = new Bmw(4, "universal",3.2,"sport");
            Console.WriteLine(car.Bmwdetail()); 
        }
    }
}
