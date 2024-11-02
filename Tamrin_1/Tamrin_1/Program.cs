

// GEREFTAN ADAD N , M
Console.WriteLine("Enter n :");
var n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter m :");
var m = Convert.ToInt32(Console.ReadLine());

var c = 0;

// halghe harekat as n ta m 
while (true)
{
    // check n avale ya na
    var x = 2;
    bool n_aval;
    if (n <= 2)
    {
        if (n == 2)
        {
            n_aval = true;
        }
        else
        {
            n_aval = false;
        }
    }
    else
    {
        while (true)
        {
            var t = n % x;
            if (t == 0)
            {
                n_aval = false;
                break;
            }
            else
            {
                x = x + 1;
                if (x < n)
                {
                    continue;
                }
                else
                {
                    n_aval = true;
                    break;
                }

            }
        }

    }


    if (n_aval == true)
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
        Console.WriteLine("tedade adad aval : "+ c);
        break;
    }
}
