using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons.AbstractFactory.UIElements.Abstractions;

namespace Lessons.AbstractFactory.Factories
{
    public interface IGUIFactory
    {
        public IButton CreateButton();

        public ITextField CreateTextField();
    }
}
