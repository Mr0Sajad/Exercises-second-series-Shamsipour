Console.WriteLine("Enter n :");
var n = Convert.ToInt32(Console.ReadLine());

var t = 1;
var a1 = 0;
var a2 = 1;

while (true)
{
    a1 = a2;
    a2 = t;
    t = a1 + a2;

    if (t <= n)
    {
        if (t == n)
        {
            System.Console.Write("is located");
            break;
        }
        else
        {
            continue;
        }
    }
    else
    {
        System.Console.Write("not located");
        break;

    }
}