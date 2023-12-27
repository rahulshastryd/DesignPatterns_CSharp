using FluentBuilderMethods.Builders;
using FluentBuilderMethods.Director;
using FluentBuilderMethods.Models;

namespace FluentBuilderPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComputerDirector director = new ComputerDirector();

            // Build Standard Computer
            IComputerBuilder standardBuilder = new StandardComputerBuilder();
            director.Construct(standardBuilder);
            Computer standardComputer = standardBuilder.GetComputer();
            Console.WriteLine("Standard Computer: " + standardComputer);

            //Build a gaming Computer
            IComputerBuilder gamingBuilder = new GamingComputerBuilder();
            director.Construct(gamingBuilder);
            Computer gamingComputer = gamingBuilder.GetComputer();
            Console.WriteLine("Gaming Computer: " + gamingComputer);
        }
    }
}