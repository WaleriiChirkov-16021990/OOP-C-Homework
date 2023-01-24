class Writer_file1<T> List<T>
{
    private string path;
private List file;

public Writer_file1(string path)
{
    this.Path = path;
}

public Writer_file1(string path, List file) : this(path)
    {
    this.File = file;
}

public Writer_file1(List file)
{
    this.Path = "Data/Data_file/data.txt";
    this.File = file;
}

public string Path { get => path; set => path = value; }
public T File { get => file; set => file = value; }

// public async Task writeFileFullAsync(List<double> f)
// {
// using (StreamWriter writer = new StreamWriter(this.Path, false))
// {
// await writer.WriteLineAsync(f);
// }

// }
public async void writeFileAdd()
{
    using (StreamWriter streamWriter = new StreamWriter(this.Path, true))
    {
        foreach (double item in this.File)
        {
            await streamWriter.WriteLineAsync(Convert.ToString(item));

        }
    }

}
}