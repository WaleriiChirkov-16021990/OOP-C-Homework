class Data
{
    private Numbers? numbers;
    public Data()
    {
        this.Numbers = new Numbers();
    }
    public Data(Numbers numbers)
    {
        this.Numbers = numbers;
    }

    internal Numbers? Numbers { get => numbers; set => numbers = value; }
}