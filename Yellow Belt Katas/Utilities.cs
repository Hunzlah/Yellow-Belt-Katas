namespace Yellow_Belt_Katas;

public static class Utilities
{
    public static int GetRandomNumber(int min, int max)
    {
        return new Random().Next(min, max);
    }
    public static int GetInputInRange(int min, int max, string[] inputs)
    {
        for(int i = 0; i < inputs.Length; i++)   
        {
            Console.WriteLine($"{i+1}. {inputs[i]}");
        }
        
        int input;
        while (true)
        {
            int.TryParse(Console.ReadLine(), out int num);
            if (num >= min && num <= max)
            {
                input = num;
                break;
            }
            else
            {
                Console.WriteLine("Please enter a number between {0} and {1}", min, max);
            }
        }

        return input;
    }
}