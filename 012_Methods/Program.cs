﻿// МЕТОДЫ
Здесь написаны следующие методы:
Method1 - метод, который выводит что-то на консоль
Method2 - выводит на консоль принятый аргумент
Method21 - выводит на консоль принятый аргумент несколько раз
Method3 - выводит на консоль текущий год
Method4 - выводит на консоль текст или символ несколько раз
Replace - заменяет символы в строке
PrintArray - вывод элементов массива на консоль
SelectionSort - Метод алгоритма сортировки методом выбора (максимального/минимального)

// // // Вид 1. Методы, которые ничего не возвращают и ничего не принимают

//void - тип метода ,который ничего не возвращает и Method1() - нет переменной
void Method1() 
{
    Console.WriteLine("Автор ..."); //тело метода, который выводит что то на консоль
}
// Вызов метода
Method1();





// // // Вид2. Методы, которые ничего не возвращают, но могут принимать какие-то аргументы

//void - тип метода, Method2 - индентификатор, (string msg) - какое то количество аргументов
void Method2(string msg) 
{
    Console.WriteLine(msg); //выводим на консоль принятый аргумент
}
// Вызов
Method2(msg: "Текст сообщения");

// Описание варианта с двумя аргументами
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Вызов
Method21(msg: "Текст", count: 4); //выводим сообщение 4 раза, count - количество выводов даннаго сообщения
Method21(count: 4, msg: "новый текст");




// // // Вид 3. Методы, которые что то возвращают, но ничего не принимают
int Method3() //обязательно указать тип данных 
{
    return DateTime.Now.Year; //возвращаем текущий год 
}
// Вызов
int year = Method3(); //Console.WriteLine(year);





// // // Вид4. Методы, которые что то принимают и что то возвращает
//Метод 4 - 1 вариант с циклом while
// string Method4(int count, string text) //выводим  text  - count раз
// {
//    int i = 0;
//    string result = String.Empty; //изначально выводится пустой строкой функцией String.Empty

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

//Метод 4 - 2 вариант с циклом for - оптимальнее первого

string Method4(int count, string text)
{
    string result = String.Empty;//изначально выводится пустой строкой функцией String.Empty
    //цикл со счетчиком 
    //int i = 0  - инициализация счетчика; i < count  - проверка условия; i++ - увеличение счетчика
    for (int i = 0; i < count; i++) 
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");// : 10 - количество раз, "" - текст
Console.WriteLine(res); //вывод на экран результата


//for - цикл в цикле
//вывод таблицы умножения на консоль
for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++) // 
    {
        Console.WriteLine($"{i} x {j} = {i * j}");//в выводе на консоль сразу тело цикла
    }
    Console.WriteLine();//после внутреннего цикла сделали переход на новую строку - искуственный разрыв
}


// // // Работа с текстом

//Вывод на консоль элемент строки согласно индекса
string s = "qwerty"
 //         012
Console.WriteLine(s[3]); // на консоль выводится символ r под индексом 3



//Метод по замене символов в строке
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;//инициализация пустой строки

    int length = text.Length;//показывает количество символов в строке
    for (int i = 0; i < length; i++)//пробегаемся от нулевого символа до конца нашей строки
    {
        //если текущий символ совпал с тем символом, который хотим заменить, то в результат кладем новый символ
        if(text[i] == oldValue) result = result + $"{newValue}";
        //если совпадений не обнаружено, то в результат кладется текущий символ
        else result = result + $"{text[i]}";
    }

    return result;
}

//Пример
// Дан текст. В тексте нужно все пробелы заменить черточками, 
// маленькие буквы “к” заменить большими “К”,
// a большие “С” заменить маленькими “с”.
// Ясна ли задача?

string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);



// Сортировка одномерного массива
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

//Метод по выводу массива на экран
void PrintArray(int[] array)//в качестве аргумента приходит массив
{
    int count = array.Length; //получение количество элементов в массиве

    for (int i = 0; i < count; i++) //пробегаем по всем элементам массива
    {
        Console.Write($"{array[i]} "); //выводим на экран элементы массива
    }
    Console.WriteLine();//пустая строка
}

//Метод алгоритма сортировки методом выбора (максимального/минимального)
void SelectionSort(int[] array) //в качестве аргумента приходит массив
{
    //если внутренний цикл начинаем с i + 1, то в сравнении нужно отнять единицу array.Length - 1
    for (int i = 0; i < array.Length - 1 ; i++) //пробегаемся по всем элементам массива
    {
        //определяем позицию, на которую смотрим запоминаем позицию рабочего элемента, для которого дальше будем производить какие-либо действия
        int minPosition = i; 
        //этот цикл кода ищет максимальный элемент 
        for (int j = i + 1; j < array.Length; j++)//пробегаемся по элементам с позиции i + 1
        {
            if(array[j] < array[minPosition]) minPosition = j;//если текущий элемент меньше заданной minPosition, то сохраняем в минипозицию
        }
        
        int temporary = array[i]; //меняем значение minPosition на temporary
        array[i] = array[minPosition];// обмен двух переменных местами: в i-позицию кладем то что нашлось при выолнении цикла
        array[minPosition] = temporary;//в минимальную позицию кладем временную
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);

 