﻿Console.Clear();

int xa = 30, ya = 1, 
    xb = 1, yb = 25,
    xc = 61, yc = 25;

//Console.SetCursorPosition(xa, ya);
//Console.Write("*");
//
//Console.SetCursorPosition(xb, yb);
//Console.Write("*");
//
//Console.SetCursorPosition(xc, yc);
//Console.Write("*");

int x = xa, y = ya;

int count = 0;

while(count < 1000)
{
    int what = new Random().Next(0, 3);   //[0, 1, 2)

    if(what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }

    if(what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }

    if(what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.Write("*");
    count++;
}