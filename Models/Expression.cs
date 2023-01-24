
public class Expression
{
    private string fild = "0";
    private List<string>? history_result;
    private UInput uInput;



    public Expression(string fild, List<string>? history_result)
    {
        this.fild = fild;
        this.history_result = history_result;
        this.UInput = new UInput();
    }
    public Expression()
    {
        this.History_result = new List<string>();
        this.UInput = new UInput();
    }

    public string Fild { get => fild; set => fild = value; }
    public List<string>? History_result { get => history_result; set => history_result = value; }
    public UInput UInput { get => uInput; set => uInput = value; }

    public void addResult(string result)
    {
        this.History_result.Add(result);
        this.Fild = result;
    }

    public void del_last_result()
    {
        if (this.History_result.Count > 0)
        {
            this.History_result.RemoveAt(this.History_result.Count - 1);
            this.Fild = this.History_result.LastOrDefault<string>();
            new Presenter(User_Interface.CANCELLATION_OF_THE_ACTION).print();
            if (this.History_result.Count == 0)
            {
                this.Fild = "0";
            }
        }
        else
        {
            new Presenter(User_Interface.USER_CLEAR_HISTORY).print();
        }
    }

    public void clear_result_history()
    {
        this.History_result = new List<string>();
        this.Fild = "0";
        new Presenter(User_Interface.USER_CLEAR_HISTORY).print();
    }
}