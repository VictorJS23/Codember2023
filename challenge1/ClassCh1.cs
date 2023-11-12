public class Fix
{
    public string word { get; set; }
    public int count { get; set; }

    public void FillterWords(List<Fix> lista, string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = array[i].ToLower();
        }

        for (int i = 0; i < array.Length; i++)
        {
            Fix existword = lista.FirstOrDefault(n => n.word == array[i]);

            if (existword == null)
            {
                Fix newWord = new Fix();
                newWord.word = array[i];
                newWord.count = 1;
                lista.Add(newWord);

            }
            else
            {
                existword.count++;
            }

        }

    }
    public void ReadWords(List<Fix> lista)
    {
        foreach (Fix item in lista)
        {
            Console.Write($"{item.word}{item.count}");
        }
    }
}