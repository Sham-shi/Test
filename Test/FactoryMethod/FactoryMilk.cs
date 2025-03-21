using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.FactoryMethod
{
    public class FactoryMilk : FactoryProduct
    {
        public override Product CreateProduct()
        {
            Milk milk = new Milk();
            return milk;
        }
    }
}
