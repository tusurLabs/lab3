namespace Model.Test;

public class InductanceTest
{
    [Fact]
    public void SetActiveResistance_Int_Int()
    {
        var inductance = new Inductance();
        inductance.ActiveResistance = 1;
        Assert.True(1 == inductance.ActiveResistance);
    }
    [Fact]
    public void SetActiveResistance_Int_ArgumentOutOfRangeException()
    {
        var inductance = new Inductance();
        
        Assert.Throws<ArgumentOutOfRangeException>(() => inductance.ActiveResistance = -1);
    }
    [Fact]
    public void SetFrequency_Int_Int()
    {
        var inductance = new Inductance();
        inductance.Frequency = 1;
        Assert.True(1 == inductance.Frequency);
    }
    [Fact]
    public void SetFrequency_Int_ArgumentOutOfRangeException()
    {
        var inductance = new Inductance();
        Assert.Throws<ArgumentOutOfRangeException>(() => inductance.Frequency = -1);
    }
    [Fact]
    public void SetInductanceValue_Int_Int()
    {
        var inductance = new Inductance();
        inductance.InductanceValue = 1;
        Assert.True(1 == inductance.InductanceValue);
    }
    [Fact]
    public void SetInductanceValue_Int_ArgumentOutOfRangeException()
    {
        var inductance = new Inductance();
        Assert.Throws<ArgumentOutOfRangeException>(() => inductance.InductanceValue = -1);
    }
    [Fact]
    public void SetName_String_String()
    {
        var inductance = new Inductance();
        inductance.Name = "R1";
        Assert.True("R1" == inductance.Name);
    }
    [Fact]
    public void SetName_String_ArgumentNullException()
    {
        var inductance = new Inductance();
        Assert.Throws<ArgumentNullException>(() => inductance.Name = "");
    }
}
