class User_Interface
{
    private const string cURENT_VALUE = "текущее значение : ";
    private const string sTART_INFO = "калькулятор запущен.";
    private const string sTART_GREETING = "Перед вами калькулятор.";
    private const string sTART_INSTRUCTION_1 = "Для работы со мной выберите операцию.";
    private const string sTART_MENU_1 = "\n1.Сложение \n2.Вычитание \n3.Умножение \n4.Деление\n5.Выход\n8.log_view";
    private const string sTART_MENU_2 = "6.Отменить действие \n7.Очистить историю результатов";
    private const string sTART_LAST_VALUE = "\nПоследний результат = ";
    private const string sTART_INSTRUCTION_2 = "\nВыберите действие: ";
    private const string iNPUT_INFO = "пользователь ввел ";
    private const string eXIT_INFO = "программа завершена.";
    private const string cANCELLATION_OF_THE_ACTION = "пользователь отменил последний результат ";
    private const string nOW_HISTORY_RESULT = "текущая история результатов ";
    private const string uSER_CLEAR_HISTORY = "пользователь очистил историю результатов.";
    private const string wARNING_INSTRUCTION_1 = "Такого пункта нет!";
    private const string wARNING_INSTRUCTION_2 = "Вы ввели не число";
    private const string wARNING_INFO_INSTRUCTION_2 = "Пользователь ввел неизвестный пункт.";
    private const string wARNING_INFO_INSTRUCTION_3 = "Пользователь ввел неизвестное число.";
    private const string eNTER_FIRST_NUMBER = "Введите 1 число: ";
    private const string vIEW_FIRST_NUMBER = "первое число: ";
    private const string eNTER_SECOND_NUMBER = "Введите второе число: ";
    private const string vIEW_SECOND_NUMBER = "Введите второе число: ";
    private const string eNTER_FIRST_NUM_INFO = "пользователь ввел первое число %s";
    private const string eNTER_SECOND_NUM_INFO = "пользователь ввел второе число";
    private const string zERO_DIVIZION_ERR_INFO = "пользователь пытается делить на 0";
    private const string wARNING_ZERO_DIVISION = "На 0 делить нельзя!";

    private const string rESULT_INFO = "пользователь получил результат ";

    private const string rESULT_HISTORY_INFO = "текущая история результатов ";
    private const string rESULT = "ответ =  ";

    private const string uSER_LOG_VIEWED = "Пользователь просмотрел лог.";
    private const string dATA_WRITE = "Сектерная дата успешно записан !=) ";



    public static string START_INFO => sTART_INFO;

    public static string START_GREETING => sTART_GREETING;

    public static string START_INSTRUCTION_1 => sTART_INSTRUCTION_1;

    public static string START_MENU_1 => sTART_MENU_1;

    public static string START_MENU_2 => sTART_MENU_2;

    public static string START_LAST_VALUE => sTART_LAST_VALUE;

    public static string START_INSTRUCTION_2 => sTART_INSTRUCTION_2;

    public static string INPUT_INFO => iNPUT_INFO;

    public static string EXIT_INFO => eXIT_INFO;

    public static string CANCELLATION_OF_THE_ACTION => cANCELLATION_OF_THE_ACTION;

    public static string NOW_HISTORY_RESULT => nOW_HISTORY_RESULT;

    public static string USER_CLEAR_HISTORY => uSER_CLEAR_HISTORY;

    public static string WARNING_INSTRUCTION_1 => wARNING_INSTRUCTION_1;

    public static string WARNING_INSTRUCTION_2 => wARNING_INSTRUCTION_2;

    public static string WARNING_INFO_INSTRUCTION_2 => wARNING_INFO_INSTRUCTION_2;

    public static string WARNING_INFO_INSTRUCTION_3 => wARNING_INFO_INSTRUCTION_3;

    public static string ENTER_FIRST_NUMBER => eNTER_FIRST_NUMBER;

    public static string VIEW_FIRST_NUMBER => vIEW_FIRST_NUMBER;

    public static string ENTER_SECOND_NUMBER => eNTER_SECOND_NUMBER;

    public static string VIEW_SECOND_NUMBER => vIEW_SECOND_NUMBER;

    public static string ENTER_FIRST_NUM_INFO => eNTER_FIRST_NUM_INFO;

    public static string ENTER_SECOND_NUM_INFO => eNTER_SECOND_NUM_INFO;

    public static string ZERO_DIVIZION_ERR_INFO => zERO_DIVIZION_ERR_INFO;

    public static string WARNING_ZERO_DIVISION => wARNING_ZERO_DIVISION;

    public static string RESULT_INFO => rESULT_INFO;

    public static string RESULT_HISTORY_INFO => rESULT_HISTORY_INFO;

    public static string RESULT => rESULT;

    public static string CURENT_VALUE => cURENT_VALUE;

    public static string USER_LOG_VIEWED => uSER_LOG_VIEWED;

    public static string DATA_WRITE => dATA_WRITE;
}