using FluentAssertions;

namespace AñoBisiesto;

public class AñoBisiesto
{
    [Fact]
    public void Si_ElAñoNoEsDivisiblePorCuatro_Deberia_SerFalso()
    {
        var divisionEntreCuatro = DivisionEntreCuatro(1569);
        divisionEntreCuatro.Should().Be(false);
    }
    
    [Fact]
    public void Si_ElAñoEsDivisiblePorCuatro_Deberia_SerVerdadero()
    {
        var divisionEntreCuatro = DivisionEntreCuatro(2008);
        divisionEntreCuatro.Should().Be(true);
    }
    private bool DivisionEntreCuatro(int año)
    {
        return false;
        
    }
}