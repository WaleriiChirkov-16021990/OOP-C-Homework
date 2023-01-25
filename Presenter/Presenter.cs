class Presenter
{
    private string? view;

    public Presenter(string view)
    {
        this.View = view;
    }
    public Presenter()
    {

    }

    public string? View { get => view; set => view = value; }

    public void print()
    {
        System.Console.WriteLine(this.View);
        System.Console.WriteLine();
    }
}