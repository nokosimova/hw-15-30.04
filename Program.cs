using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic; 

namespace HW30
{
    class Program
    {
        static List<char> StreamList = new List<char>();
        static int InitRow;
        static int InitColumn;
        
        static void Main(string[] args)
        {
            InitColumn = Console.CursorLeft;
            InitRow = Console.CursorTop;
            StreamList.Add('A');
            StreamList.Add('B');
            StreamList.Add('C');
            StreamList.Add('D');
            WriteList(2);

        }

        //вывод листа-столбца:
        public static void WriteAt(char letter, object p)
        {
            Point point = p as Point;
            try
            {
                Console.SetCursorPosition(InitColumn + point.col, InitRow + point.row);
                Console.Write(letter);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.Clear();
                Console.WriteLine(e.Message);
            }
        }
        public static void WriteList(int column)
        {
            for (int i = 0; i < StreamList.Count; i++)
            {
                Point point = new Point(column,i);
                WriteAt(StreamList[i], point);
            }
        }
    }
}


/*using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic; 

namespace HW30._04
{
    class Program
    {
        static object locker = new object();
        static int InitColumn = Console.CursorLeft;
        static int InitRow = Console.CursorTop;
        static int height = 10;
        static List<char> SingleStream = new List<char>();
        static void Main(string[] args)
        {
            for(int i = 0; i < height; i++)
                SingleStream.Add(' ');
            Console.Clear();
            WaterFall.height = 5;
            WaterFall.row = Console.CursorTop;
            WaterFall.column = Console.CursorLeft;

            Task[] tasks = new Task[2];
            for (int j = 0; j < tasks.Length; j++)
            {
                object k = j;
                tasks[j] = Task.Factory.StartNew(StreamMovie, k);
            }
            Console.ReadLine();
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
                    for (int i = 0; i < height; i++)
                    {
                        point.row = (i <= streamheight)?1:i;
                        int count = (i <= streamheight)? i:streamheight;

                        for (int letter = 0; letter < count; letter++)
                        {                          
                            if (point.row + letter <= 10)
                            {
                                Console.SetCursorPosition(InitColumn + point.col, InitRow + point.row + letter);
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
*/
