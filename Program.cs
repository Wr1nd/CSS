public class Programa
{
    static bool isRunning = false;
    
    public static void  Main(string[] args)
    {
        isRunning = Input.Calculate();
        while (isRunning){
            isRunning = Input.Calculate();
        }
    }
    
    
    
}