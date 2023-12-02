namespace Model
{
    public class Resistor : PassiveElement
    {
        public override string Impedance => $"{ActiveResistance}";
    }
}
