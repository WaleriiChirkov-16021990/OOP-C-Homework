using System.Text;
class Logger
{
    public const string filepath = "Logger/Log_file/log.log";
    private string message;


    public Logger(string message)
    {
        this.message = message;
        this.writeLogINFO();
    }

    public string Filepath { get => filepath; }
    public string Message { get => message; set => message = value; }

    public void writeLogINFO()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("INFO ~ ");
        stringBuilder.Append(System.DateTime.Now + " ");
        stringBuilder.Append(Message + "\n");
        File.AppendAllTextAsync(Filepath, stringBuilder.ToString());
        stringBuilder.Clear();
    }
}