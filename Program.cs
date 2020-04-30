using System;
using System.Threading;

namespace HW30._04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            WaterFall.row = Console.CursorTop;
            WaterFall.column = Console.CursorLeft;
            TimerCallback tm = new TimerCallback((i)=>WaterFall.WriteAt("h",(int)i,(int)i));
            for (var i = 0; i <= 10; i++)
            {
                Timer timer = new Timer(tm,i,0,2000);

            }
        }
    }
}
