class Presenter_data : Presenter
{
    private Data? data;

    public Presenter_data(Data data,
        string view)
        : base(view)
    {
        this.Data = data;
    }

    public Presenter_data(Data data) : base()
    {
        this.Data = data;
    }

    public Presenter_data() : base()
    {

    }

    public Presenter_data(string? view) : base(view)
    {
    }

    internal Data? Data { get => data; set => data = value; }

    public void printData()
    {
        if (this.Data is not null &&
            this.Data.Numbers is not null &&
             this.Data.Numbers.Result is not null)
        {
            foreach (double item in this.Data.Numbers.Result)
            {
                new Presenter(Convert.ToString(item));
            }
        }
    }
}