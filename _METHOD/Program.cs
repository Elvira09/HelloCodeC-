// МЕТОДЫ

// Method1 - метод, который выводит что-то на консоль
// Method2 - выводит на консоль принятый аргумент
// Method21 - выводит на консоль принятый аргумент несколько раз
// Method3 - выводит на консоль текущий год
// Method4 - выводит на консоль текст или символ несколько раз
// Replace - заменяет символы в строке
// PrintArray - вывод элементов массива на консоль
// SelectionSort - Метод алгоритма сортировки методом выбора (максимального/минимального)
// Max - метод по поиску максимального числа с заданными аргументами
// FillArray - метод заполняет массив случайными числами от 1-10, обращаясь к аргументу collection (массив с типом данных int)
// IndexOf - метод по поиску элемента массива и сравнение его с заданным для поиска

void Method1() 
{
    Console.WriteLine("Автор ..."); //тело метода, который выводит что то на консоль
}
// Вызов метода
Method1();

void Method2(string msg) 
{
    Console.WriteLine(msg); //выводим на консоль принятый аргумент
}
// Вызов
Method2(msg: "Текст сообщения");

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

int Method3() //обязательно указать тип данных 
{
    return DateTime.Now.Year; //возвращаем текущий год 
}
// Вызов
int year = Method3(); //Console.WriteLine(year);

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
//Вывод
string res = Method4(10, "z");// : 10 - количество раз, "" - текст

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
//Вывод
string newText = Replace(text, ' ', '|');

void PrintArray(int[] array)//в качестве аргумента приходит массив
{
    int count = array.Length; //получение количество элементов в массиве

    for (int i = 0; i < count; i++) //пробегаем по всем элементам массива
    {
        Console.Write($"{array[i]} "); //выводим на экран элементы массива
    }
    Console.WriteLine();//пустая строка
}
//Вывод
PrintArray(arr);

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
//Вывод
SelectionSort(arr);


int Max(int arg1, int arg2, int arg3) 
{
    int result = arg1; // присваиваем результату аргумент 1
    if (arg2 > result) result = arg2; //производим сравнительные действия над аргументами
    if (arg3 > result) result = arg3;
    return result; // возвращаем резутьтат
}
//Вывод
int max = Max(a, b, c); 

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
//ВЫВОД
FillArray(array);

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
            break; //останавливает цикл, применимо когда значение элементов повторяются
        }
        index++;
    }
    return position;
}
//Вывод
int pos = IndexOf(array, 444);//ищем значение 444 в массиве


