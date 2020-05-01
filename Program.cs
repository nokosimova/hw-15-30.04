using System;
using System.Threading;
using System.Threading.Tasks;

namespace HW30._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            WaterFall.height = 5;
            WaterFall.row = Console.CursorTop;
            WaterFall.column = Console.CursorLeft;
            int num = 5;
            Point point = new Point();
                point.col = num;
                for (int i = 0; i <= 5; i++)
                {
                    point.row = i;
                    WaterFall.WriteAt(point);
                }
           // WaterFall.Stream(num);
          //  TimerCallback tm = new TimerCallback(WaterFall.Stream);
            
          /*  Task task1 = Task.Factory.StartNew((i) => {
                
                Timer timer = new Timer(tm, i, 0, 8000);
            },5);

            Task task2 = Task.Factory.StartNew((i) => {
             //   TimerCallback tm = new TimerCallback(WaterFall.Stream);
                Timer timer = new Timer(tm, i, 0, 8000);
            },2);*/
            //task1.Start();
          //  Console.ReadLine();
        }
    }
}
