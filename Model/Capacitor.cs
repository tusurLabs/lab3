namespace Model
{
    public class Capacitor : PassiveElement
    {
        double _copacity;
        public double Copacity 
        {
            get
            {
                return _copacity;
            }
            set
            {
                if (value > 0)
                {
                    _copacity  = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Copacity));
                }
            }
        }

        public override double ReactiveResistance => 1 / (2 * Math.PI * Frequency * _copacity);

        public override string Impedance => $"{ActiveResistance} - j{ReactiveResistance}";
    }
}
