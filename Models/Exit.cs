using System;
class Exit
{
    private const string path = "Data/Data_file/data.txt";

    private Data? data;
    private Writer_file1<double>? WriFil1;


    public Exit(Data data)
    {
        if (data is not null)
        {
            this.Data = data;
            if (this.Data.Numbers is not null)
            {
                if (this.Data.Numbers.Result is not null)
                {
                    WriFil11 = new Writer_file1<double>(Exit.Path, this.Data.Numbers.Result);
                }
            }
        }
        new Logger(User_Interface.DATA_WRITE);
    }

    public Exit()
    {
        this.Data = new Data();
    }

    internal Data? Data { get => data; set => data = value; }
    internal Writer_file1<double>? WriFil11 { get => WriFil12; set => WriFil12 = value; }
    public Writer_file1<double>? WriFil12 { get => WriFil1; set => WriFil1 = value; }

    public static string Path => path;
    public bool exit_app()
    {
        if (this.WriFil1 is not null)
        {
            this.WriFil1.writeFileAdd();
        }
        new Logger(User_Interface.EXIT_INFO);
        new Presenter(User_Interface.EXIT_INFO).print();
        return false;
    }
}