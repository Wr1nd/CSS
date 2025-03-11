public class Input
{
    public int num1;
    public int num2;
    public string action;
    public string result1;
    
    public int Num1
    {
        get { return num1; }
        set { num1 = value; }
    }
    public int Num2
    {
        get { return num2; }
        set { num2 = value; }
    }
    public string Action
    {
        get { return action; }
        set { action = value; }
    }
    public string Result1
    {
        get { return result1; }
        set { result1 = value; }
    }
    
    public Input(int num1, int num2, string action, string result)
    {
        this.num1 = num1;
        this.num2 = num2;
        this.action = action;
        this.result1 = result;
    }
    
    public static bool Calculate()
    {
        string input = Console.ReadLine();
        char action = findAction(input);
        try
        {
            int num1 = int.Parse(input.Split(action)[0]); // Ištrauktas iš "input" pirmas skaičius
            int num2 = int.Parse(input.Split(action)[1]);  // Ištrauktas iš "input" antras skaičius
            int result = 0;
            switch (action)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
            }
            string actionStr = Convert.ToString(action);
            Result.PrintResult(num1, num2, actionStr, result);
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine($"[Error]: Wrong input: {input} ");
            return true;
        }
    }
    
    private static char findAction(string input)
    {
        if (input.Contains("+"))
        {
            return '+';
        }
        else if (input.Contains("-"))
        {
            return '-';
        }
        else if (input.Contains("*"))
        {
            return '*';
        }
        else if (input.Contains("/"))
        {
            return '/';
        }
        else
        {
            return ' ';
        }
    }
    
    public void PrintVars()
    {
        Console.WriteLine(
            $"Number 1: {num1}\n" +
            $"Number 2: {num2}\n" +
            $"Action: {action}\n" +
            $"Result: {result1}");
    }
    
}