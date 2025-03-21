using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.FactoryMethod
{
    public class FactoryApple : FactoryProduct
    {
        public override Product CreateProduct()
        {
            Apple apple = new Apple();
            return apple;
        }
    }
}
