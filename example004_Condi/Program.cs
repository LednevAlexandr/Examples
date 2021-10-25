Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Маша")
{
    Console.WriteLine("Урв, это же Маша");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}