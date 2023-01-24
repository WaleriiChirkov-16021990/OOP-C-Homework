class Presenter_log
{
    private const string path = "Logger/Log_file/log.log";

    private Reader_file1 ReadFil1;
    private string lo;

    internal Reader_file1 ReadFil11 { get => ReadFil1; set => ReadFil1 = value; }
    public string Lo { get => lo; set => lo = value; }

    public Presenter_log()
    {
        this.ReadFil1 = new Reader_file1(path);
    }

    public void show_log()
    {

    }
}