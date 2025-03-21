using Lessons.AbstractFactory.UIElements.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lessons.AbstractFactory.UIElements.WebUIElements;

namespace Lessons.AbstractFactory.Factories
{
    public class WebFactory : IGUIFactory
    {
        public IButton CreateButton()
        {
            return new WebButton();
        }

        public ITextField CreateTextField()
        {
            return new WebTextField();
        }
    }
}
