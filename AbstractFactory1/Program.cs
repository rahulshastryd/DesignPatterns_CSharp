using FactoryMethods1.Factories;

namespace AbstractFactory1
{
    public class Program
    {
        static void Main(string[] args)
        {
            IUIFactory windowsFactory = new WindowsUIFactory();
            ClientCode(windowsFactory);

            IUIFactory macOSFactory = new MacOSUIFactory();
            ClientCode(macOSFactory);
        }

        public static void ClientCode(IUIFactory factory)
        {
            var button = factory.CreateButton();
            var checkbox = factory.CreateCheckBox();

            button.Render();
            checkbox.Render();
        }
    }
}