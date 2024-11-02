var res = "";
var i = 1;
var j = 1;

while (i <= 5)
{
    Console.WriteLine("Question " + j + " (y or n) :");
    var key = Console.ReadKey().KeyChar;
    Console.WriteLine();

    if (key == 'n' || key == 'N')
    {
        j = j * 2;
        res = res + key;
    }
    else if (key == 'y' || key == 'Y')
    {
        j = (j * 2) + 1;
        res = res + key;
    }
    else
    {
        res = "Error";
        break;
    }

    i++;
}

res = res.ToLower();
Console.WriteLine(res);
if (res == "ynyny")
{
    Console.WriteLine("Your answer is correct");
}
else
{
    Console.WriteLine("Your answer is wrong");
}

/*
       (1)
    n /    \ y
   (2)     (3)
  /   \   /   \
(4)  (5) (6)  (7)

 */

