Console.Write ("ВВедите имя пользователя:");
string username = Console.ReadLine();
if (username.ToLower () == "дима")
{
    Console.WriteLine ("Ура, это же Дима");
}
else
{
    Console.Write ("Привет,");
    Console.WriteLine (username);
}
