using FluentBuilderMethods.Builders;
using FluentBuilderMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderMethods.Director
{
    public class ComputerDirector
    {
        public void Construct(IComputerBuilder builder)
        {
            builder.
                BuildCPU().
                BuildRAM().
                BuildStorage().
                BuildGPU();
        }
    }
}
