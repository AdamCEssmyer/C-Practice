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