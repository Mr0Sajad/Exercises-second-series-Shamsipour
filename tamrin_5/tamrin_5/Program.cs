
char key;
var text = "";

do
{

    do
    {
        key = Console.ReadKey(true).KeyChar;

    } while (char.IsDigit(key) && key != '\r');

    if (key != '\r')
    {
        Console.Write(key);
        text = text + key;
    }


} while (key != '\r');

Console.WriteLine();
Console.WriteLine();
Console.WriteLine(text);



