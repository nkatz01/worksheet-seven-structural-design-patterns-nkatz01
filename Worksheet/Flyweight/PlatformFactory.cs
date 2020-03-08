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
        //private static List<(IPlatform, string)>flyweights = new List<(IPlatform, string)> {  (new ScalaPlatform(),  typeof(ScalaPlatform).ToString() ) ,
        //    (new JavaPlatform(),  typeof(JavaPlatform).ToString() )
        //};
        private static List<(IPlatform, string)> flyweights = new List<(IPlatform, string)> {   
        };

        public static IPlatform PlatformInstance(string name)
        {
         // var el =  flyweights.ElementAt(1);
          //  Console.WriteLine(el.Item2.Substring(10));
           var flyweight = getFlywight(name);

          return flyweight;
        }

        

        private static IPlatform getFlywight(string name)
        {


           

            if (flyweights.Where(t => t.Item2.Substring(10).StartsWith(name, StringComparison.InvariantCultureIgnoreCase)).Count() == 0)
            {
           //     Console.WriteLine("FlyweightFactory: Can't find a flyweight, creating new one.");

                var dataAccess = Assembly.GetExecutingAssembly();
                var builder = new ContainerBuilder();

                builder.RegisterAssemblyTypes(dataAccess)
                    .Where(t => t.Name.StartsWith(name, StringComparison.InvariantCultureIgnoreCase))
                    .AsImplementedInterfaces();

                var Container = builder.Build();

                using (var scope = Container.BeginLifetimeScope())
                {
                    var pltfrm = scope.Resolve<IPlatform>();

                    flyweights.Add((pltfrm, pltfrm.GetType().ToString()));
                        
                      

                }
            }
            else
            {
             //   Console.WriteLine("FlyweightFactory: Reusing existing flyweight.");
            }
            return flyweights.Where(t => t.Item2.Substring(10).StartsWith(name, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault().Item1;
        }


    }
}