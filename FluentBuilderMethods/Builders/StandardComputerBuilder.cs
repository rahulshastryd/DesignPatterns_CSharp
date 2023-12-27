using FluentBuilderMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderMethods.Builders
{
    public class StandardComputerBuilder : IComputerBuilder
    {
        private Computer computer;
        public StandardComputerBuilder()
        {
            this.computer = new Computer();
        }
        public IComputerBuilder BuildCPU()
        {
            computer.CPU = "Intel Core i5";
            return this;
        }

        public IComputerBuilder BuildGPU()
        {
            computer.GPU = "Integrated Graphics";
            return this;
        }

        public IComputerBuilder BuildRAM()
        {
            computer.RAM = "8 GB DDR4";
            return this;
        }

        public IComputerBuilder BuildStorage()
        {
            computer.Storage = "256GB SSD";
            return this;
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
