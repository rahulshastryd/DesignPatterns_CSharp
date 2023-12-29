using FactoryMethods1.Interfaces;
using FactoryMethods1.Products.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods1.Factories
{
    public class WindowsUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton(); 
        }

        public ICheckBox CreateCheckBox()
        {
            return new WindowsCheckBox();
        }
    }
}
