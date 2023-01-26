class Multiplication_1
{
    private Number? number1;
    private Number? number2;
    private Number? reault_multi;

    public Multiplication_1(Number number1, Number number2)
    {
        this.Number1 = number1;
        this.Number2 = number2;
        this.Multiplication();
    }

    public Multiplication_1()
    {
    }

    public Multiplication_1(Number number1)
    {
        this.number1 = number1;
    }

    public void enterTwoNumber()
    {
        this.Number1 = new Number(User_Interface.ENTER_FIRST_NUMBER);
        this.Number2 = new Number(User_Interface.ENTER_SECOND_NUMBER);
    }

    public void enterOneNumber()
    {
        this.Number2 = new Number(User_Interface.ENTER_SECOND_NUMBER);
    }

    public Number? Number1 { get => number1; set => number1 = value; }
    public Number? Number2 { get => number2; set => number2 = value; }
    public Number? Reault_multi { get => reault_multi; set => reault_multi = value; }


    public void Multiplication()
    {
        if (Number1 is not null && Number2 is not null)
        {
            this.Reault_multi = new Number(Number1.Num * Number2.Num);
            new Logger(User_Interface.RESULT_INFO + $" {Number1.Num} * {Number2.Num} = {this.Reault_multi.Num}");
        }
    }
}