using System;

namespace PlayerPosition6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer render = new Renderer();
            Player player = new Player(5,7);
            render.DrawPlayer(player.X, player.Y, '#');
        }
    }

    class Renderer
    {
        public void DrawPlayer(int x, int y ,char ch)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(ch);
        }
    }

    class Player
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Player(int x, int y)
        {
            X = x;
            Y = y;
        }
     }
}
