using Lessons.AbstractFactory.UIElements.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons.AbstractFactory.UIElements.WindowsUIElements;

namespace Lessons.AbstractFactory.Factories
{
    public class WindowsFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextField CreateTextField()
        {
            return new WindowsTextField();
        }
    }
}
