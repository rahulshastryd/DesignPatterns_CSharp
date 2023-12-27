using FluentBuilderMethods.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderMethods.Builders
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer computer;
        public GamingComputerBuilder()
        {
            this.computer = new Computer();
        }
        public IComputerBuilder BuildCPU()
        {
            computer.CPU = "Intel Core i7";
            return this;
        }

        public IComputerBuilder BuildGPU()
        {
            computer.GPU = "NVIDIA GeForce RTX 3080";
            return this;
        }

        public IComputerBuilder BuildRAM()
        {
            computer.RAM = "16GB DDR4";
            return this;
        }

        public IComputerBuilder BuildStorage()
        {
            computer.Storage = "1TB HDD + 512GB SSD";
            return this;
        }

        public Computer GetComputer()
        {
            return computer;
        }
    }
}
