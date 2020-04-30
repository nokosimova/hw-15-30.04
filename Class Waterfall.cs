using System;
namespace HW30
{
    public static class WaterFall
    {
        public static int row;
        public static int column;

        public static void WriteAt(string s, object obx, object  oby)
        {
            int x = (int)obx;
            int y = (int)oby;

            Console.SetCursorPosition(column + x, row + y);
            Console.Write(s);
        }
        
    }
}