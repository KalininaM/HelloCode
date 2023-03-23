Console.Write("Введите ваше имя: ");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша")
{
    Console.WriteLine("УрА! Это Маша!");
}
else
{
    Console.WriteLine("Привет, " + userName);
}