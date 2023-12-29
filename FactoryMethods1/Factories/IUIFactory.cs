using FactoryMethods1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods1.Factories
{
    public interface IUIFactory
    {
        IButton CreateButton();
        ICheckBox CreateCheckBox();
    }
}
