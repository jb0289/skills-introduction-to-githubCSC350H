/*
   This code reverses a message, counts the number of times 
   a certain character appears in the code, then prints the results.
*/

string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();
Array.Reverse(charMessage);

int oCount = 0;
foreach (char character in charMessage)
{
    if (character == 'o')
    {
        oCount++;
    }
}

string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {oCount} times.");