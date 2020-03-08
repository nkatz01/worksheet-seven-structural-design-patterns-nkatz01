using System;

namespace Flyweight
{
    public class ScalaPlatform : IPlatform//, IEquatable<IPlatform>
    {
        public ScalaPlatform()
        {
            Console.WriteLine("Scala Platform object created");
        }

        //public override bool Equals(object other)
        //{
        //    IPlatform platform = other as ScalaPlatform;

        //    return !ReferenceEquals(null, platform) ;
        //}

        public void Execute(Code code)
        {
            Console.WriteLine($"Compiling and executing {code} code.");
        }

        //public  override    int GetHashCode()
        //{
        //    return this.GetHashCode();
        //}
    }
}