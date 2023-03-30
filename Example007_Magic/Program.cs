// See https://aka.ms/new-console-template for more information
Console.Clear();
// Console.SetCursorPosition(10,2);
// Console.WriteLine("+");

// Console.SetCursorPosition(20,15);
// Console.WriteLine("&");

// Console.SetCursorPosition(5,7);
// Console.WriteLine("$");

int xa = 50, ya = 1,
    xb = 1, yb = 30,
    xc = 100, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb;

int count = 0;

while (count < 10) ;
{
    int Pavel = new Random().Next(0, 3); //то есть интервал такой [0;3) 0 1 2
    if (Pavel == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if (Pavel == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if (Pavel == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count++; //count = count + 1
}