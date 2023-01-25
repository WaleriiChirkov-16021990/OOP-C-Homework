using System.Linq.Expressions;
// See https://aka.ms/new-console-template for more information
//
public class Application
{
    private Sum_1 sum_1;
    private Data data;
    private Expression expression;
    private Multiplication_1 multiplication_1;
    private Division_1 division_1;
    private Subtraction_1 subtraction_1;
    private Exit exit;

    private Presenter_log presenter_Log;

    public Application()
    {
        this.Data = new Data();
        this.Expression = new Expression();
    }

    public Expression Expression { get => expression; set => expression = value; }
    internal Sum_1 Sum_1 { get => sum_1; set => sum_1 = value; }
    internal Data Data { get => data; set => data = value; }
    internal Multiplication_1 Multiplication_1 { get => multiplication_1; set => multiplication_1 = value; }
    internal Division_1 Division_1 { get => division_1; set => division_1 = value; }
    internal Subtraction_1 Subtraction_1 { get => subtraction_1; set => subtraction_1 = value; }
    internal Exit Exit { get => exit; set => exit = value; }

    public void run_app()
    {
        bool flag = true;
        new Logger(User_Interface.START_INFO);
        new Presenter(User_Interface.START_GREETING);
        new Presenter(User_Interface.START_INSTRUCTION_1);
        while (flag)
        {
            new Presenter(User_Interface.CURENT_VALUE).print();
            new Logger(User_Interface.CURENT_VALUE + $" {Expression.Fild} ");
            new Presenter(Expression.Fild).print();
            new Presenter(User_Interface.START_MENU_1).print();
            new Presenter(User_Interface.START_MENU_2).print();
            new Presenter(User_Interface.START_INSTRUCTION_2).print();
            Expression.UInput.user_input();
            if (new CheckUI(Expression.UInput.Input).is_numeric())
            {

                switch (Expression.UInput.Input.Replace(" ", ""))
                {
                    case "1":  //СУММА
                        if (Expression.History_result.Count > 0)
                        {
                            this.Sum_1 = new Sum_1(new Number(double.Parse(Expression.Fild)));
                        }
                        else
                        {
                            this.Sum_1 = new Sum_1();
                        }
                        this.Data.Numbers.addResult(this.Sum_1.Result_sum.Num);
                        this.Expression.addResult(Convert.ToString(this.Sum_1.Result_sum.Num));
                        break;
                    case "2":  //РАЗНОСТЬ
                        if (Expression.History_result.Count > 0)
                        {
                            this.Subtraction_1 = new Subtraction_1(new Number(double.Parse(Expression.Fild)));
                        }
                        else
                        {
                            this.Subtraction_1 = new Subtraction_1();
                        }
                        this.Data.Numbers.addResult(this.Subtraction_1.Result_sub.Num);
                        this.Expression.addResult(Convert.ToString(this.Subtraction_1.Result_sub.Num));
                        break;
                    case "3":  //УМНОЖЕНИЕ
                        if (Expression.History_result.Count > 0)
                        {
                            this.Multiplication_1 = new Multiplication_1(new Number(double.Parse(Expression.Fild)));
                        }
                        else
                        {
                            this.Multiplication_1 = new Multiplication_1();
                        }
                        this.Data.Numbers.addResult(this.Multiplication_1.Reault_multi.Num);
                        this.Expression.addResult(Convert.ToString(this.Multiplication_1.Reault_multi.Num));
                        break;
                    case "4":  //ДЕЛЕНИЕ
                        if (Expression.History_result.Count > 0)
                        {
                            this.Division_1 = new Division_1(new Number(double.Parse(Expression.Fild)));
                        }
                        else
                        {
                            this.Division_1 = new Division_1();
                        }
                        if (!this.Division_1.ZERO_DIVIZION_ERR_INFO1)
                        {
                            this.Data.Numbers.addResult(this.Division_1.Reault_divis.Num);
                            this.Expression.addResult(Convert.ToString(this.Division_1.Reault_divis.Num));
                        }
                        break;
                    case "5":  //ВЫХОД
                        this.Exit = new Exit(this.Data);
                        flag = this.Exit.exit_app();
                        break;
                    case "6":  //ОТМЕНИТЬ ДЕЙСТВИЕ
                        this.Expression.del_last_result();
                        new Logger(User_Interface.CANCELLATION_OF_THE_ACTION);
                        break;
                    case "7":  //ОЧИСТИТЬ ИСТОРИЮ РЕЗУЛЬТАТОВ
                        this.Expression.clear_result_history();
                        new Logger(User_Interface.USER_CLEAR_HISTORY);
                        break;
                    case "8":  //ЛОГ
                        presenter_Log = new Presenter_log();
                        presenter_Log.show_log();
                        break;
                    default:
                        new Presenter(User_Interface.WARNING_INSTRUCTION_1).print();
                        break;
                }
            }
        }
    }
}