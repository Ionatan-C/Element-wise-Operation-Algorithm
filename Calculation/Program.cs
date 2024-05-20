internal class Program
{
    static void Main(string[] args)
    {
        new Calculation();
    }
}

public class Calculation
{
    public Calculation()
    {
        List<int> data1 = new List<int> { 6, 4, 8, 1, 9 };
        List<int> data2 = new List<int> { 7, 2, 5, 6, 3 };
        List<int> data3 = new List<int> { 3, 2, -1, 0, 1};

        for (int i = 0; i <= data1.Count - 1; i++)
        {
            int answer = data1[i] + data2[i];
            int finalAnswer = answer * data3[i];
            Console.WriteLine(finalAnswer);
        }

    }
}