Console.Clear();
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1, 
    xb = 1, yb = 30,
    xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");


int x = xa, y = xb; // Определяем случайную точку x и для определенности ставим первую точку.

int count = 0;  // Определяем какое именно количество раз нужно будет проделывать нахождение отрезков и делить пополам. 

while(count < 10000) // Оператор while (пока count меньше 10)
{
int what = new Random().Next(0, 3); // [0;3) 0 1 2 Наша задача тут сгенерировать псевдослучайное число
if(what == 0)                                  // Проверка
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

// после того как мы определили середину мы должны будем нарисовать ее при помощи данных операторов


Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count = count++;
}


