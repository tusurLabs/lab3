namespace Model.Test
{
    public  class ResistorTest
    {
        [Fact]
        public void SetActiveResistance_Int_Int() 
        {
            var resistor = new Resistor();
            resistor.ActiveResistance = 1;
            Assert.True(1 == resistor.ActiveResistance);
        }
        [Fact]
        public void SetActiveResistance_Int_ArgumentOutOfRangeException()
        {
            var resistor = new Resistor();
            Assert.Throws<ArgumentOutOfRangeException>(() => resistor.ActiveResistance = -1);
        }
        [Fact]
        public void SetFrequency_Int_Int()
        {
            var resistor = new Resistor();
            resistor.Frequency = 1;
            Assert.True(1 == resistor.Frequency);
        }
        [Fact]
        public void SetFrequency_Int_ArgumentOutOfRangeException()
        {
            var resistor = new Resistor();
            Assert.Throws<ArgumentOutOfRangeException>(() => resistor.Frequency = -1);
        }
        [Fact]
        public void SetName_String_String()
        {
            var resistor = new Resistor();
            resistor.Name = "R1";
            Assert.True("R1" == resistor.Name);
        }
        [Fact]
        public void SetName_String_ArgumentNullException()
        {
            var resistor = new Resistor();
            Assert.Throws<ArgumentNullException>(() => resistor.Name = "");
        }
    }
}
