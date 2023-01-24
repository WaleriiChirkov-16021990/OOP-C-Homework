class Sum_1
{
    private Number number1;
    private Number number2;
    private Number result_sum;

    public Sum_1(Number number1, Number number2)
    {
        this.Number1 = number1;
        this.Number2 = number2;
        this.sum_Numbers();
    }

    public Sum_1()
    {
        this.Number1 = new Number(User_Interface.ENTER_FIRST_NUMBER);
        this.Number2 = new Number(User_Interface.ENTER_SECOND_NUMBER);
        this.sum_Numbers();
    }

    public Sum_1(Number number1)
    {
        this.number1 = number1;
        this.Number2 = new Number(User_Interface.ENTER_SECOND_NUMBER);
        this.sum_Numbers();

    }

    internal Number Number1 { get => number1; set => number1 = value; }
    internal Number Number2 { get => number2; set => number2 = value; }
    internal Number Result_sum { get => result_sum; set => result_sum = value; }

    public void sum_Numbers()
    {
        this.Result_sum = new Number(Number1.Num + Number2.Num);
        new Logger(User_Interface.RESULT_INFO + $" {Number1.Num} + {Number2.Num} = {this.Result_sum.Num}");
    }
}