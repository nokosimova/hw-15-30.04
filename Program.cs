using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic; 

namespace HW30
{
    class Program
    {
        static int height = 10;
        static char[] SingleColumn = new char[height];
        static int InitRow;
        static int InitColumn;
        
        static void Main(string[] args)
        {
            CleanColumn();
            InitColumn = Console.CursorLeft;
            InitRow = Console.CursorTop;
            WriteStream(2);

        }
        public static void CleanColumn()
        {
            for (int i = 0; i < SingleColumn.Length; i++)
                SingleColumn[i] = '.';
        }

        //вывод символа:
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
        //вывод столбца
        public static void WriteList(int column)
        {
            for (int i = 0; i < SingleColumn.Length; i++)
            {
                Point point = new Point(column,i);
                WriteAt(SingleColumn[i], point);
            }
        }
        //вывод цепочки({переписывать лист + показывать лист} - н раз)
        public static void WriteStream(object column)
        {
            Random randomletter = new Random();
            Random randomheight = new Random();
            Point point = new Point(0,0);
            int i, beginpos, endpos;
            point.col = (int)column;
            int letterstreamheight = randomheight.Next(2,5); //длина потока букв
            
            for (i = 0; i < height + letterstreamheight; i++)
            {
                CleanColumn();
                beginpos = (i <= letterstreamheight) ? 0 : i - letterstreamheight;
                endpos = (i <= height)? i : height;
                    for (int letterpos = beginpos; letterpos < endpos; letterpos++)
                    {                                                  
                            char letter = Convert.ToChar(randomletter.Next(65,90));
                            SingleColumn[point.row + letterpos] = letter; 
                           // Console.SetCursorPosition(InitColumn + point.col, InitRow + point.row + letterpos);
                           // Console.Write(letter);
                            
                    }
                WriteList((int) column);
                Thread.Sleep(500);
                Console.Clear();
                                
            }













                /*    {
                        point.row = (i <= letterstreamheight)?1:i;
                        int count = (i <= letterstreamheight)? i:letterstreamheight;

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
                    Console.Clear();    */
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
                    int letterstreamheight = randomheight.Next(2,5); 
                    for (int i = 0; i < height; i++)
                    {
                        point.row = (i <= letterstreamheight)?1:i;
                        int count = (i <= letterstreamheight)? i:letterstreamheight;

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
