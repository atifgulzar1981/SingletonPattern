using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static int _counter;
        private static Singleton _instance;

        private Singleton()
        {
            _counter++;
            Console.WriteLine($"Object Creation Counter: {_counter.ToString()}");
        }


        public static Singleton GetInstance()
        {
            return _instance ??= new Singleton();
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}