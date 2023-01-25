class Division_1
{
    private Number number1;
    private Number number2;
    private Number reault_divis;
    private bool ZERO_DIVIZION_ERR_INFO;

    public Division_1(Number number1, Number number2)
    {
        this.number1 = number1;
        this.number2 = number2;
        this.Division();
    }

    public Division_1()
    {
        this.Number1 = new Number(User_Interface.ENTER_FIRST_NUMBER);
        this.Number2 = new Number(User_Interface.ENTER_SECOND_NUMBER);
        this.Division();
    }

    public Division_1(Number number1)
    {
        this.number1 = number1;
        this.Number2 = new Number(User_Interface.ENTER_SECOND_NUMBER);
        this.Division();
    }

    public Number Number1 { get => number1; set => number1 = value; }
    public Number Number2 { get => number2; set => number2 = value; }
    public Number Reault_divis { get => reault_divis; set => reault_divis = value; }
    public bool ZERO_DIVIZION_ERR_INFO1 { get => ZERO_DIVIZION_ERR_INFO; set => ZERO_DIVIZION_ERR_INFO = value; }

    public void Division()
    {
        if (Number2.Num != 0)
        {
            this.Reault_divis = new Number(Number1.Num / Number2.Num);
            new Logger(User_Interface.RESULT_INFO + $" {Number1.Num} / {Number2.Num} = {this.Reault_divis.Num}");
            this.ZERO_DIVIZION_ERR_INFO1 = false;
        }
        else
        {
            new Presenter(User_Interface.WARNING_ZERO_DIVISION).print();
            new Logger(User_Interface.ZERO_DIVIZION_ERR_INFO);
            new Logger(User_Interface.RESULT_INFO + $" {Number1.Num} / {Number2.Num} = ERROR ");
            this.Reault_divis = new Number(0);
            this.ZERO_DIVIZION_ERR_INFO = true;
        }
    }
}