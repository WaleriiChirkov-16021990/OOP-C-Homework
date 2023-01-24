class Reader_file1
{
    private string path;
    private string file;

    public Reader_file1(string path)
    {
        this.path = path;
    }
    public Reader_file1()
    {

    }

    public string Path { get => path; set => path = value; }
    public string File { get => file; set => file = value; }

    public async void readFile(List<double> list)
    {
        using (StreamReader streamReader = new StreamReader(this.Path))
        {
            this.File = await streamReader.ReadToEndAsync();
        }

    }
}