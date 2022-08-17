namespace NewDay.CodeDojo.Diamond;

public class Diamond
{
    private readonly int _limit;
    private readonly bool _lowercase;
    private readonly List<string> _rows = new();
    
    public Diamond(char limitChar)
    {
        _lowercase = limitChar switch
        {
            < 'A' or > 'Z' and < 'a' or > 'z' => throw new ArgumentOutOfRangeException(nameof(limitChar)),
            >= 'a' and <= 'z' => true,
            _ => _lowercase
        };

        _limit = GetValue(limitChar);
        
        for (var i = 0; i <= _limit; i++)
        {
            _rows.Add(PrintRow(i));
        }
        
        for (var i = _rows.Count - 2; i >= 0; i--)
        {
            _rows.Add(_rows[i]);
        }
    }
    
    public string Print()
    {
        return string.Join('\n', _rows);
    }

    private string PrintRow(int input)
    {
        var outerLength = _limit - input;
        var outerPadding = new string(' ', outerLength);

        var inputChar = GetChar(input);
        
        if (outerLength == _limit)
        {
            return outerPadding + inputChar + outerPadding;
        }

        var innerLength = (_limit - (outerLength + 1)) * 2 + 1;
        var innerPadding = new string(' ', innerLength);
        
        return outerPadding + inputChar + innerPadding + inputChar + outerPadding;
    }

    private char GetChar(int input)
    {
        return (char)(input + (_lowercase ? 'a' : 'A'));
    }

    private int GetValue(char input)
    {
        return input - (_lowercase ? 'a' : 'A');
    }
}