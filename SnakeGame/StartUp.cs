namespace SnakeGame
{
    using SnakeGame.GameObjects;
    using SnakeGame.Utilities;

    public class StartUp
    {
        public static void Main()
        {
            ConsoleSettings.CustomizeConsole();

            Wall wall = new Wall(60, 20);
            Snake snake = new Snake(wall);

            Engine engine = new Engine(wall, snake);
            engine.Run();
        }
    }
}
