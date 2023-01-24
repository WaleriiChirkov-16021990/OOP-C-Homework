public class Numbers
{
    private List<double>? result;

    public Numbers()
    {
        this.Result = new List<double>();
    }
    public Numbers(List<double>? result)
    {
        this.Result = result;
    }

    public List<double>? Result { get => result; set => result = value; }

    public void addResult(double result)
    {
        this.Result.Add(result);
    }
}