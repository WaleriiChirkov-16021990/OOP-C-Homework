public class UInput
{
    private string input;
    private List<string>? h_input;


    public UInput(string input, List<string> h_input)
    {
        this.input = input;
        this.h_input = h_input;
    }

    public UInput()
    {
        this.h_input = new List<string>();
    }

    public string Input { get => input; set => input = value; }
    public List<string>? H_input { get => h_input; set => h_input = value; }
    public void user_input()
    {
        while (true)
        {
            string? temp = Console.ReadLine();
            if (temp != null)
            {
                this.input = temp;
                this.h_input.Add(this.input);
            }
            break;
        }
    }

}