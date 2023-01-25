class Presenter_log
{
    private string path = @"Logger\Log_file\log.log";

    private Reader_file1 readFil1;
    internal Reader_file1 ReadFil1 { get => readFil1; set => readFil1 = value; }
    public string Path { get => path; set => path = value; }
    public Presenter_log()
    {
        this.ReadFil1 = new Reader_file1(Path);

    }
    public void show_log()
    {
        new Presenter(this.ReadFil1.File).print();
        new Logger(User_Interface.USER_LOG_VIEWED);
    }
}