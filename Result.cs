public class Result
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
    
    public Result(int num1, int num2, string action, string result)
    {
        this.num1 = num1;
        this.num2 = num2;
        this.action = action;
        this.result1 = result;
    }
    
    public void PrintVars()
    {
        Console.WriteLine(
            $"Number 1: {num1}\n" +
            $"Number 2: {num2}\n" +
            $"Action: {action}\n" +
            $"Result: {result1}");
    }
    

    public static bool PrintResult(int num1, int num2, string action, int result)
    {
        Console.WriteLine(
            $"{num1} {action} {num2} = {result}");
        return false;
    }
}
