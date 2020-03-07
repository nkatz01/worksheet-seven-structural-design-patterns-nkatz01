using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Diagnostics;

namespace Flyweight
{
    public static class PlatformFactory
    {
        private static List<(Flyweight, string)>flyweights = new List<(Flyweight, string)> {  (new Flyweight(new ScalaPlatform()),  typeof(ScalaPlatform).ToString() ) ,
            (new Flyweight(new ScalaPlatform()),  typeof(JavaPlatform).ToString() )
        };

        public static  IPlatform PlatformInstance(string name)
        {
         // var el =  flyweights.ElementAt(1);
          //  Console.WriteLine(el.Item2.Substring(10));
           var flyweight = getFlywight(name);
          return flyweight._sharedStatev;
        }

        

        private static Flyweight getFlywight(string name)
        {


            //  string key = this.getKey(name);

            if (flyweights.Where(t => t.Item2.Substring(10).StartsWith(name, StringComparison.InvariantCultureIgnoreCase)).Count() == 0)
            {
                Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");

                var dataAccess = Assembly.GetExecutingAssembly();
                var builder = new ContainerBuilder();

                builder.RegisterAssemblyTypes(dataAccess)
                    .Where(t => t.Name.StartsWith(name))
                    .AsImplementedInterfaces();

                var Container = builder.Build();

                using (var scope = Container.BeginLifetimeScope())
                {
                    var pltfrm = scope.Resolve<IPlatform>();

                    flyweights.Add((new Flyweight(pltfrm), pltfrm.GetType().ToString()));
                        
                      

                }
            }
            else
            {
                Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return flyweights.Where(t => t.Item2.Substring(10).StartsWith(name, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault().Item1;
        }


    }
}