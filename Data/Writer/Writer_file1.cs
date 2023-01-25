using System.IO;

class Writer_file1<T> : List<T>
{
    private string path;
    private List<T> file;

    public Writer_file1(string path)
    {
        this.Path = path;
        File = new List<T>();
    }

    public Writer_file1(string path, List<T> file) : this(path) => this.File = file;

    public Writer_file1(List<T> file)
    {
        this.File = file;
    }

    public string Path { get => path; set => path = value; }
    public List<T> File { get => file; set => file = value; }

    public async void writeFileAdd()
    {
        using (StreamWriter streamWriter = new StreamWriter(this.Path, true))
        {
            foreach (T item in this.File)
            {
                await streamWriter.WriteLineAsync(Convert.ToString(item));
            }
        }
    }
}