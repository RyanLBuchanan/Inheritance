namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot();
            HoverBot hoverBot = new HoverBot(10);

            robot.Travel();
            hoverBot.Travel();
        }
    }
}