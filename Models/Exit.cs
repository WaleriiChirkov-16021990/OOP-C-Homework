class Exit
{
    private Data data;
    private Writer_file1 WriFil1;


    public Exit(Data data)
    {
        this.Data = data;
        WriFil11 = new Writer_file1(this.Data.Numbers.Result);
    }

    public Exit()
    {
        this.Data = new Data();
    }

    internal Data Data { get => data; set => data = value; }
    internal Writer_file1 WriFil11 { get => WriFil1; set => WriFil1 = value; }

}