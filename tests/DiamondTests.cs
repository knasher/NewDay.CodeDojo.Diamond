namespace NewDay.CodeDojo.Diamond.Tests.Unit;

public class DiamondTests
{
    [Fact]
    public void Construct_WithLimitCharAs1_ShouldThrowArgumentOutOfRangeException()
    {
        const char limitChar = '1';
        
        Action act = () => _ = new Diamond(limitChar);

        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage($"Specified argument was out of the range of valid values. (Parameter '{nameof(limitChar)}')");
    }
    
    [Fact]
    public void Construct_WithLimitCharAs__ShouldThrowArgumentOutOfRangeException()
    {
        const char limitChar = '_';
        
        Action act = () => _ = new Diamond(limitChar);

        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage($"Specified argument was out of the range of valid values. (Parameter '{nameof(limitChar)}')");
    }

    [Fact]
    public void Construct_WithLimitCharAsÇ_ShouldThrowArgumentOutOfRangeException()
    {
        const char limitChar = 'Ç';

        Action act = () => _ = new Diamond(limitChar);

        act.Should().Throw<ArgumentOutOfRangeException>()
            .WithMessage($"Specified argument was out of the range of valid values. (Parameter '{nameof(limitChar)}')");
    }

    [Fact]
    public void Print_WithConstructLimitCharAsA_ShouldReturnA()
    {
        new Diamond('A').Print().Should().Be("A");
    }

    [Fact]
    public void Print_WithConstructLimitCharAsB_ShouldReturnDiamondWith3Rows()
    {
        new Diamond('B').Print().Should().Be(" A \nB B\n A ");
    }

    [Fact]
    public void Print_WithConstructLimitCharAsD_ShouldReturnDiamondWith7Rows()
    {
        new Diamond('D').Print().Should().Be("   A   \n  B B  \n C   C \nD     D\n C   C \n  B B  \n   A   ");
    }

    [Fact]
    public void Print_WithConstructLimitCharAsLowercaseA_ShouldReturnLowercaseA()
    {
        new Diamond('a').Print().Should().Be("a");
    }

    [Fact]
    public void Print_WithConstructLimitCharAsLowercaseB_ShouldReturnLowercaseDiamondWith3Rows()
    {
        new Diamond('b').Print().Should().Be(" a \nb b\n a ");
    }

    [Fact]
    public void Print_WithConstructLimitCharAsLowercaseD_ShouldReturnLowercaseDiamondWith7Rows()
    {
        new Diamond('d').Print().Should().Be("   a   \n  b b  \n c   c \nd     d\n c   c \n  b b  \n   a   ");
    }
}