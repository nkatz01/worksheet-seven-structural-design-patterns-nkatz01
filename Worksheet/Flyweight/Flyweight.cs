using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Flyweight
    {

        public IPlatform _sharedStatev { set; get; }  

        public Flyweight(IPlatform platform)
        {

            _sharedStatev = platform; 
        }

        //public IPlatform getPlatform(IPlatform uniqeState)
        //{
        //    get{ 
        //        return _sharedStatev;
            
        //    }
        //}

    }
}
