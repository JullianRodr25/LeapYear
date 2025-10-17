using FluentAssertions;

namespace AñoBisiesto;

public class UnitTest1
{
    [Fact]
    public void Si_ElAñoNoEsDivisiblePorCuatro_Deberia_SerFalso()
    {
        var divisionEntreCuatro = DivisionEntreCuatro(1569);
        divisionEntreCuatro.Should().Be(false);
    }

    private bool DivisionEntreCuatro(int año)
    {
        if (año % 4 == 0)
             return true;
        return false;
    }
}