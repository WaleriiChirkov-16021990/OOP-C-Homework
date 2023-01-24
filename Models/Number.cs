public class Number
{
    private double num;
    private UInput uInput;

    public double Num { get => num; set => num = value; }
    public UInput UInput { get => uInput; set => uInput = value; }

    public Number(double num)
    {
        Num = num;
        this.UInput = new UInput();
    }

    public Number()
    {
        this.UInput = new UInput();
        // this.addNum(User_Interface.ENTER_FIRST_NUMBER);
    }

    public Number(string msg)
    {
        this.UInput = new UInput();
        this.addNum(msg);
    }

    public void addNum(String msge)
    {
        this.UInput = new UInput();
        while (true)
        {
            new Presenter(msge).print();
            this.UInput.user_input();
            if (new CheckUI(this.UInput.Input).this_is_a_number())
            {
                this.Num = Convert.ToDouble(this.UInput.Input);
                break;
            }
            else
            {
                this.Num = 0;
                new Presenter(User_Interface.WARNING_INSTRUCTION_2).print();
            }
        }
    }
}