string str = "The quick brown fox";
//convert message into a char array
char[] charMessage = str.ToCharArray();
//reverse the chars
Array.reverse(charMessage);
int x = 0;
//count the o's
foreach (char i in charMessage) {if (i == 'o') {x++; }}
//convert it back to a string
string new_message = new string(charMessage);
//print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");


class Program
{
    static void Main(string[] args)
    {
        int num1 = 5;
        int num2 = 3;
        int num3;

        //unary operators
        num3 = num1;
        Console.WriteLine("num3 is {0}", num3);
        
        bool isSunny  = true;
        Console.WriteLine("is it sunny? {0}", !isSunny);

        Console.ReadKey();
    }
}