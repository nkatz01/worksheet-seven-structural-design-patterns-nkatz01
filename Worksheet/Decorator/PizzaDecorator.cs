using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
   public abstract class PizzaDecorator : IPizza
    {

         
        public PizzaDecorator(IPizza pizza)
        {
            this.pizza = pizza;
           
        }


      
        public IPizza pizza { get; set; }
        public   string Description { get; set; }
        public   decimal Price { get; set; }
        public override string ToString()
        {

            return pizza.ToString();
               
        }
    }
}
