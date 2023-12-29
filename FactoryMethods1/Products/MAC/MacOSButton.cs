using FactoryMethods1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethods1.Products.MAC
{
    public class MacOSButton : IButton
    {
        public void Render()
        {
            Console.WriteLine("Rendering MacOS Button");
        }
    }
}
