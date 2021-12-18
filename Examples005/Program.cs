Console.WriteLine("Введите имя пользователя: ");
String ueserName = Console.ReadLine();

if (ueserName.ToLower() == "маша") {
     Console.WriteLine("Ура, это Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(ueserName);
}
