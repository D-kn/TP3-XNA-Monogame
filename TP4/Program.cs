using System;

namespace TP4
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new CasseBrique())
                game.Run();
        }
    }
}
