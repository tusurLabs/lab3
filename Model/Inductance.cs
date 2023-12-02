namespace Model
{
    public class Inductance : PassiveElement
    {
        double _inductance;       
        public double InductanceValue
        {
            get
            {
                return _inductance;
            }
            set
            {
                if (value >= 0)
                {
                    _inductance = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(InductanceValue));
                }
            }
        }
        public override double ReactiveResistance => Frequency * _inductance;
        public override string Impedance => $"{ActiveResistance} + j{ReactiveResistance}";
    }
}
