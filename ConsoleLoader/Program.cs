// See https://aka.ms/new-console-template for more information
using Model;

Console.WriteLine("Hello, World!");

List<IPassiveElement> elements = new List<IPassiveElement>();
while (true)
{
    Console.WriteLine("Для добавления элемента выберите его тип:\n 1 - резистор;\n 2 - конденсатор;\n 3 - индуктивность;\n 0 - выход.");
    int type = 0;
    if (int.TryParse(Console.ReadLine(), out type))
    {
        if (type == 0)
            break;
        if (type == 1)
        {
            Resistor resistor = new Resistor();
            Console.WriteLine("Введите название элемента");
            resistor.Name = Console.ReadLine();
            Console.WriteLine("Введите значение сопротивления в Ом");
            string userValue = Console.ReadLine();
            double value = 0;
            if (double.TryParse(userValue, out value))
            {
                try
                {
                    resistor.ActiveResistance = value;
                    elements.Add(resistor);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Значение должно быть числовым");
            }

        }
        if (type == 2)
        {
            Capacitor capacitor = new Capacitor();
            string userValue = Console.ReadLine();
            try
            {
                Console.WriteLine("Введите название элемента");
                capacitor.Name = Console.ReadLine();
                Console.WriteLine("Введите значение активного сопротивления в Ом");
                capacitor.ActiveResistance = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите частоту в Герцах");
                capacitor.Frequency = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите емкость в нФ");
                capacitor.Copacity = double.Parse(Console.ReadLine());
                Console.WriteLine("Выберите количество повторений");
                elements.Add(capacitor);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        if (type == 3)
        {
            Inductance inductance = new Inductance();
            try
            {
                Console.WriteLine("Введите название элемента");
                inductance.Name = Console.ReadLine();
                Console.WriteLine("Введите значение активного сопротивления в Ом");
                inductance.ActiveResistance = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите частоту в Герцах");
                inductance.Frequency = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение инфдуктивности");
                inductance.InductanceValue = double.Parse(Console.ReadLine());
                elements.Add(inductance);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
    else
    {
        Console.WriteLine("введите число из предлагаемых вариантов");
    }


}
foreach (var item in elements)
{
    Console.WriteLine($"{item.Name} {item.Impedance}");
}