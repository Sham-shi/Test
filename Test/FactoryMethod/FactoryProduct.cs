using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.FactoryMethod
{
    public abstract class FactoryProduct
    {
        public abstract Product CreateProduct();
    }
}
