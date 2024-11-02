Console.WriteLine("Enter n :");
var n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter m :");
var m = Convert.ToInt32(Console.ReadLine());

var c = 0;

while (true)
{
    bool n_palindrome;

    var rev = 0;
    var rem = 0;
    var temp = 0;

    temp = n;
    while (true)
    {
        if (temp != 0)
        {
            rem = temp % 10;
            rev = rev * 10 + rem;
            temp = temp / 10;
            continue;
        }
        else
        {
            if (rev == n)
            {
                n_palindrome = true;
                break;
            }
            else
            {
                n_palindrome = false;
                break;
            }
        }
    }

    if (n_palindrome==true)
    {
        Console.WriteLine(n);
        c = c + 1;
        n = n + 1;
    }
    else
    {
        n = n + 1;
    }

    if (n <= m)
    {
        continue;
    }
    else
    {
        Console.WriteLine("tedade adad palindrome : " + c);
        break;
    }
}