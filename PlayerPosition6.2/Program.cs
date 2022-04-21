using System;

namespace PlayerPosition6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Renderer render = new Renderer();
            Player player = new Player(5,7);
            render.DrawPlayer(player.PositionX, player.PositionY, '#');
        }
    }

    class Renderer
    {
        public void DrawPlayer(int PositionX, int PositionY ,char ch)
        {
            Console.SetCursorPosition(PositionX, PositionY);
            Console.Write(ch);
        }
    }

    class Player
    {
        public int PositionX { get; private set; }
        public int PositionY { get; private set; }

        public Player(int PositionX, int PositionY)
        {
            this.PositionX = PositionX;
            this.PositionY = PositionY;
        }
     }
}
