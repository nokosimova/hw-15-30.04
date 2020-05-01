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
            
            Task[] tasks = new Task[1];
            for (int j = 0; j < tasks.Length; j++)
            {   
                object k = j;
                tasks[j] = Task.Factory.StartNew(StreamMovie, k);
            }
            Console.ReadLine();
           /* Parallel.For(0,20,(j)=>{
                point.col = j;
                for (int i = 0; i <= 5; i++)
                {
                    point.row = i;
                    WaterFall.WriteAt(point);
                }
            });
            */
       /*     Parallel.Invoke(()=>{
                point.col = 0;
                for (int i = 0; i <= 5; i++)
                {
                    point.row = i;
                    WaterFall.WriteAt(point);
                }
            }
            ,()=>{
                point.col = 1;
                for (int i = 0; i <= 5; i++)
                {
                    point.row = i;
                    WaterFall.WriteAt(point);
                }},
               ()=> {
                point.col = 2;
                for (int i = 0; i <= 5; i++)
                {
                    point.row = i;
                    WaterFall.WriteAt(point);
                }
                });*/
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
            
        }
        public static void StreamMovie(object column)
        {
            Random randomletter = new Random();
            Random randomheight = new Random();
            Point point = new Point();
                    TimerCallback tm = new TimerCallback(Stream);
                    Timer timer = new Timer(tm, column, 0, 12000);
        }

        public static void Stream(object column)
        {
            Random randomletter = new Random();
            Random randomheight = new Random();
            Point point = new Point();
            point.col = (int)column;
                    int streamheight = randomheight.Next(2,5); 
                    for (int i = 1; i <= 10; i++)
                    {
                        point.row = i;
                        int count = (i < streamheight)? i:streamheight;
                        for (int letter = 0; letter < count; letter++)
                        {
                            if (point.row + letter <= 10)
                            {
                                Console.SetCursorPosition(WaterFall.column + point.col, WaterFall.row + point.row + letter);
                                Console.Write(Convert.ToChar(randomletter.Next(65,90)));
                            }
                        }
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    Console.Clear();
                    


        }
        
    }
}
