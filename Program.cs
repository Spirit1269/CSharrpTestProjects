string pangram = "The quick brown fox jumps over the lazy dog";
Console.WriteLine("");

string[] words = pangram.Split(" ");

string[] reversedWords = new string[words.Length];
int index = 0;

foreach(string word in words)
{
    char[] charArray = word.ToCharArray();
    Array.Reverse(charArray);
    reversedWords[index] = new string(charArray);
    index++;
}
string result = String.Join(" ", reversedWords);
Console.WriteLine(result);
