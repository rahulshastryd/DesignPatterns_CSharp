using FactoryMethods1.Interfaces;
using FactoryMethods1.Products.MAC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods1.Factories
{
    public class MacOSUIFactory : IUIFactory
    {
        public IButton CreateButton()
        {
            return new MacOSButton();
        }

        public ICheckBox CreateCheckBox()
        {
            return new MacOSCheckBox();
        }
    }
}
