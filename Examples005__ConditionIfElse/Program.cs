Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "elvira")
{
    Console.WriteLine("Ура, это же ELVIRA!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
