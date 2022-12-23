Console.Clear();
string[] s = { "с", "и", "к", "о" };

int count = s.Length;
/*
int n = 1;

for (int i = 0; i < count; i++)
{   
    for (int j = 0; j < count; j++)
    {
    Console.WriteLine($"{n++,-5}{s[i]}{s[j]}");
    }
}

*/
int n = 1;
void FindWord(string alphabet, char[] word, int length = 0)
{
    
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); return;
    }
    for (int i = 0; i< alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWord(alphabet, word, length + 1);
    }
}

FindWord("сока", new char[3]);