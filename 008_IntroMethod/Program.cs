//Максимум из 9 чисел с помощью Метода


//создаем метод по поиску максимального числа с заданными аргументами
int Max(int arg1, int arg2, int arg3) 
{
    int result = arg1; // присваиваем результату аргумент 1
    if (arg2 > result) result = arg2; //производим сравнительные действия над аргументами
    if (arg3 > result) result = arg3;
    return result; // возвращаем резутьтат
}
int a1 = 112125;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2311;
int c2 = 33;
int a3 = 13;
int b3 = 23111;
int c3 = 313;

// int max1 = Max(a1, b1, c1); //ищем мксимум из первой тройки чисел
// int max2 = Max(a2, b2, c2);
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
//более сокращенно так:
int max = Max(
    Max(a1, b1, c1), 
    Max(a2, b2, c2),
    Max(a3, b3, c3));

Console.WriteLine(max);
