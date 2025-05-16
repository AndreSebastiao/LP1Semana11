using System;
using MathDuel;

namespace MathDuel
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize game components
            MathDuel game = new MathDuel();
            Controller controller = new Controller(game);
            IView view = new IView(controller, game);
            controller.Run(view);
        }
    }
}