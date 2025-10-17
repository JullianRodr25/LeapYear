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
    
    [Theory]
    [InlineData(2008)]
    [InlineData(2004)]
    [InlineData(2012)]
    public void Si_ElAñoEsDivisiblePorCuatro_Deberia_SerVerdadero(int año)
    {
        var divisionEntreCuatro = DivisionEntreCuatro(año);
        divisionEntreCuatro.Should().Be(true);
    }

    [Fact]

    public void Si_ElAñoEsDivisblePorCienYNoPorCuatrocientos_Deberia_RetornarFalso()
    {
        var divisionEntreCuatroCientos = DivisionEntreCuatro(600);
        divisionEntreCuatroCientos.Should().Be(false);
    }
    
    private static bool DivisionEntreCuatro(int año)
    {
        return año % 4 == 0;
    }
}