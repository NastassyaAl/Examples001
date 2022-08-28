Console.WriteLine ("Введите имя пользователя: ");
string username = Console.ReadLine();
if (username.ToLower() == "настя")
{
    Console.WriteLine("Ура!!! Это же Настя!!!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}
