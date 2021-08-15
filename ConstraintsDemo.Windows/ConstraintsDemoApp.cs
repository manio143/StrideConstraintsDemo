using Stride.Engine;

namespace ConstraintsDemo
{
    class ConstraintsDemoApp
    {
        static void Main(string[] args)
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}
