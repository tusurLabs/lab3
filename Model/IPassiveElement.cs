namespace Model
{
    public interface IPassiveElement
    {
        public string Name { get; set; }
        public string Impedance { get; }
        public double ActiveResistance { get; set; }
        public double ReactiveResistance { get; }
    }
}