using FluentAssertions;

namespace AñoBisiesto;

public class AñoBisiesto
{
    [Fact]
    public void Si_ElAñoNoEsDivisiblePorCuatro_Deberia_SerFalso()
    {
        var divisionEntreCuatro = añoBisiesto(1569);
        divisionEntreCuatro.Should().Be(false);
    }

    [Theory]
    [InlineData(2008)]
    [InlineData(2004)]
    [InlineData(2012)]
    public void Si_ElAñoEsDivisiblePorCuatro_Deberia_SerVerdadero(int año)
    {
        var divisionEntreCuatro = añoBisiesto(año);
        divisionEntreCuatro.Should().Be(true);
    }

    [Fact]
    public void Si_ElAñoEsDivisblePorCienYNoPorCuatrocientos_Deberia_RetornarFalso()
    {
        var divisionEntreCuatroCientos = añoBisiesto(600);
        divisionEntreCuatroCientos.Should().Be(false);
    }

    private static bool añoBisiesto(int año)
    {
        if (año % 4 != 0)
            return false;
        if (año % 100 == 0 && año % 400 != 0)
            return false;
        return true;
    }
}