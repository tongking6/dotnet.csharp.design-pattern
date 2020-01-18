using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Application Started");
            
            var context = new Context(new Strategy1());
            context.Operation();
            context.setStrategy(new Strategy2());
            context.Operation();
        }
    }
}
