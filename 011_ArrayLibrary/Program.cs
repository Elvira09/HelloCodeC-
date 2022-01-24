﻿
//Поиск позиции нужного элемента массива с случайными элементами

// void - тип метода, который НЕ возвращает значение

//создаем метод FillArray, который заполняет массив случайными числами от 1-10, обращаясь к аргументу collection (массив с типом данных int)
void FillArray(int[] collection) //вместо array лучше назвать collection, иначе могут возникать ошиьки
{
    int length = collection.Length; //определяем длину массива
    int index = 0; //стартуем с индекса 0
    while (index < length) //пока индекс меньше длины массива
    {
        //кладем в аргумент новое случайное целое число из диапозона от 1 до 10
        collection[index] = new Random().Next(1, 10); 
        index++;         //index = index + 1;

    }
}

//Метод, который будет печатать массивю. Аргумент называем по другому, чтоб не было конфликтов с предыдущим методом
void PrintArray(int[] col) 
{
    int count = col.Length; //задаем длину массива
    int position = 0; //position - это инде //кс, стартуем с нуля
    while (position < count) //пока индекс меньше длины массива
    { 
        Console.WriteLine(col[position]); //выводим на экран значение текущего элемента
        position++; //index = index + 1;
    }
}

//создаем метод по поиску элемента массива и сравнение его с заданным для поиска
int IndexOf(int[] collection, int find)
{
    int count = collection.Length; //задаем длину массива
    int index = 0; //стартуем с индекса 0
    int position = -1; //задаем переменную, куда фиксируется значение индексаю Если элемента нет, то  -1 интерпритирует это
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            // break; //останавливает цикл, применимо когда значение элементов повторяются
        }
        index++;
    }
    return position;
}

//создаем новый массив array содержащий 10 элементов, по умолчанию он заполнен нулями
int[] array = new int[10]; 

FillArray(array); //с помощью метода заполняем массив случайными числами
array[4] = 4; //кладем в элемент под индексом 4 - число 4
array[6] = 4; //кладем в элемент под индексом 6 - число 4

PrintArray(array); //вывели на консоль массив
Console.WriteLine(); //отступ

int pos = IndexOf(array, 444);//ищем значение 444 в массиве
Console.WriteLine(pos); // выводим на консоль результат (в нашем случае это '-1', т.к массив заполняется числами от 1 до 10)


