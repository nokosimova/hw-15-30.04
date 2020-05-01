using System;
using System.Threading;
using System.Threading.Tasks;
namespace HW30
{
    public  class Point
    {
        public  int col{get; set;}
        public  int row{get; set;}
    }
    public static class WaterFall
    {
        public static int row;
        public static int column;
        public static int height;

        public static void WriteAt(object p)
        {
            
            string s = "h";           
            Point point = p as Point;
            Console.SetCursorPosition(column + point.col, row + point.row);
            Console.Write(s);
        }
        public static void Stream(int column)
        {
           // WaterFall.row = Console.CursorTop;
           // WaterFall.column = Console.CursorLeft;
            //Parallel.For(1,column, (j)=>{
                Point point = new Point();
                point.col = column;
                for (int i = 0; i <= height; i++)
                {
                    point.row = i;
                    WaterFall.WriteAt(point);
                }
          //  Console.ReadLine();
            Console.Clear();
        }
        
    }
}