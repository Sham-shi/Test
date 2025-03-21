using Lessons.AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons.AbstractFactory
{
    public class PageWindowsCreator
    {
        private IGUIFactory _guiFactory;
        public PageWindowsCreator(IGUIFactory guiFactory)
        {
            _guiFactory = guiFactory;
        }

        public void DragAndDropButton()
        {
            var button = _guiFactory.CreateButton();
            button.Render();
        }

        public void DragAndDropTextField()
        {
            var textField = _guiFactory.CreateTextField();
            textField.Render();
        }
    }
}
