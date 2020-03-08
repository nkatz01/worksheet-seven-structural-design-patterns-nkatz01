using System;

namespace Flyweight
{
    public class JavaPlatform : IPlatform
    {
        public JavaPlatform()
        {
            Console.WriteLine("Java Platform object created");
        }

        public void Execute(Code code)
        {
            Console.WriteLine($"Compiling and executing {code} code.");
        }
    }
}