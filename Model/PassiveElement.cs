namespace Model
{
    public class PassiveElement : IPassiveElement
    {
        double _activeResistance,  _frequncy;
        string _name;
        public string Name {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException(nameof(Name));
                else
                    _name = value;
            }
        }
        public virtual string Impedance =>  $"{_activeResistance} + j{ReactiveResistance}";
        public virtual double ReactiveResistance
        {
            get;
            set;

        }
        public double Frequency
        {
            get
            {
                return _frequncy;
            }
            set
            {
                if (value >= 0)
                {
                    _frequncy = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(Frequency));
                }
            }
        }
        public double ActiveResistance 
        {
            get
            {
                return _activeResistance;
            }
            set
            {
                if (value >= 0)
                {
                    _activeResistance = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(ActiveResistance));
                }
            }
        }
    }
}
