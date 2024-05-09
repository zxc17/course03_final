using System.ComponentModel.Design;

class Final
{
    public static void Main()
    {
        int size = 5;
        string[] array = new string[size];
        InputArray(array);
        PrintArray(array);
        string[] result = Select(array);
        PrintArray(result);
    }

    private static string[] Select(string[] array)
    {
        int n = 0;
        string[] temp = new string[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3) temp[n++] = array[i];
        }
        string[] result = new string[n];
        Array.Copy(temp, result, n);
        return result;
    }

    private static void InputArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine("Введите стороку № " + i);
            array[i] = Console.ReadLine();
        }
    }

    private static void PrintArray(string[] array)
    {
        Console.WriteLine("--------------");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("\"" + array[i] + "\" ");
        }
        Console.WriteLine();
    }
}