class Subtraction_1
{
    private Number number1;
    private Number number2;
    private Number result_sub;

    public Subtraction_1(Number number1, Number number2)
    {
        this.Number1 = number1;
        this.Number2 = number2;
        this.sub_Numbers();
    }

    public Subtraction_1()
    {
        this.Number1 = new Number(User_Interface.ENTER_FIRST_NUMBER);
        this.Number2 = new Number(User_Interface.ENTER_SECOND_NUMBER);
        this.sub_Numbers();
    }

    public Subtraction_1(Number number1)
    {
        this.number1 = number1;
        this.Number2 = new Number(User_Interface.ENTER_SECOND_NUMBER);
        this.sub_Numbers();
    }

    internal Number Number1 { get => number1; set => number1 = value; }
    internal Number Number2 { get => number2; set => number2 = value; }
    internal Number Result_sub { get => result_sub; set => result_sub = value; }

    public void sub_Numbers()
    {
        this.Result_sub = new Number(Number1.Num - Number2.Num);
        new Logger(User_Interface.RESULT_INFO + $" {Number1.Num} - {Number2.Num} = {this.Result_sub.Num}");
    }

}


