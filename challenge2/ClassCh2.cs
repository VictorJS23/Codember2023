public class Compiler
{
    int count = 0;

    public void Hacking(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == "#")
            {
                count++;
            }
            else if (array[i] == "@")
            {
                count--;
            }
            else if (array[i] == "*")
            {
                count *= count;
            }
            else if (array[i] == "&")
            {
                Console.Write(count);
            }
        }
    }
}