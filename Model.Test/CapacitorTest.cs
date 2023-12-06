namespace Model.Test
{
    public  class CapacitorTest
    {
        [Fact]
        public void SetActiveResistance_Int_Int()
        {
            var capacitor = new Capacitor();
            capacitor.ActiveResistance = 1;
            Assert.True(1 == capacitor.ActiveResistance);
        }
        [Fact]
        public void SetActiveResistance_Int_ArgumentOutOfRangeException()
        {
            var capacitor = new Capacitor();
            Assert.Throws<ArgumentOutOfRangeException>(() => capacitor.ActiveResistance = -1);
        }
        [Fact]
        public void SetFrequency_Int_Int()
        {
            var capacitor = new Capacitor();
            capacitor.Frequency = 1;
            Assert.True(1 == capacitor.Frequency);
        }
        [Fact]
        public void SetFrequency_Int_ArgumentOutOfRangeException()
        {
            var capacitor = new Capacitor();
            Assert.Throws<ArgumentOutOfRangeException>(() => capacitor.Frequency = -1);
        }
        [Fact]
        public void SetCopacity_Int_Int()
        {
            var capacitor = new Capacitor();
            capacitor.Copacity = 1;
            Assert.True(1 == capacitor.Copacity);
        }
        [Fact]
        public void SetCopacity_Int_ArgumentOutOfRangeException()
        {
            var capacitor = new Capacitor();
            Assert.Throws<ArgumentOutOfRangeException>(() => capacitor.Copacity = -1);
        }
        [Fact]
        public void SetName_String_String()
        {
            var capacitor = new Capacitor();
            capacitor.Name = "R1";
            Assert.True("R1" == capacitor.Name);
        }
        [Fact]
        public void SetName_String_ArgumentNullException()
        {
            var capacitor = new Capacitor();
            Assert.Throws<ArgumentNullException>(() => capacitor.Name = "");
        }
    }
}
