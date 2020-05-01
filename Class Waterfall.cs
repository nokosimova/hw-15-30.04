using System;
using System.Threading;
using System.Threading.Tasks;
namespace HW30
{
    public  class Point
    {
        public  int col{get; set;}
        public  int row{get; set;}
        public Point(int c, int r)
        {
            col = c;
            row = r; 
        }
    }
    public static class WaterFall
    {
        public static int row;
        public static int column;
        public static int height;
    }
}