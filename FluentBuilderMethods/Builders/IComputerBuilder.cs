using FluentBuilderMethods.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderMethods.Builders
{
    public interface IComputerBuilder
    {
        IComputerBuilder BuildCPU();
        IComputerBuilder BuildRAM();
        IComputerBuilder BuildStorage();
        IComputerBuilder BuildGPU();
        Computer GetComputer();
    }
}
