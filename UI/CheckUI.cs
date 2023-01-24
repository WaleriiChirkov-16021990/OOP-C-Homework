using System.Text.RegularExpressions;
class CheckUI
{
    private string? input;

    private double inp;

    public CheckUI(string? input)
    {
        this.Input = input;
    }

    public CheckUI()
    {
    }

    public string? Input { get => input; set => input = value; }
    public double Inp { get => inp; set => inp = value; }

    public bool is_numeric()
    {
        if (Input == null)
        {
            return false;
        }
        string pattern = @"^\d$";
        return Regex.IsMatch(Input, pattern, RegexOptions.IgnoreCase);
    }

    public bool is_int_num()
    {
        if (Input == null)
        {
            return false;
        }
        string pattern = @"^-?\d$";
        return Regex.IsMatch(Input, pattern, RegexOptions.IgnoreCase);
    }

    public bool this_is_a_number()
    {
        if (Input == null)
        {
            return false;
        }
        string pattern = @"^-?\d+(\,?\d+)?$";
        return Regex.IsMatch(Input, pattern, RegexOptions.IgnoreCase);
    }

    public bool is_zero()
    {
        if (this.Inp == 0)
        {
            return true;
        }
        else return false;
    }
}