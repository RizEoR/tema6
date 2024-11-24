

using System;
using System.Globalization;
// Задаем строку с датой в формате "MM/dd/yyyy"

Console.WriteLine("введи дату в формате xx/xx/xxxx");
string dateI =  Console.ReadLine();
// метод ParseExact() для преобразования строки в дату с указанным форматом
DateTime date1 = DateTime.ParseExact(dateI, "MM/dd/yyyy", null);
Console.WriteLine("используя ParseExact(): " + date1);

//  метод Parse() для преобразования строки в дату
DateTime date2 = DateTime.Parse(dateI);
Console.WriteLine("используя Parse(): " + date2);

// Задаем строку с числом

  
// Используем метод TryParse() для попытки преобразования строки в число
Console.WriteLine("Введи число:");
string nI = Console.ReadLine();
bool result1 = int.TryParse(nI, out int n1);
if (result1)
{
    Console.WriteLine("Используя TryParse(): " + n1);
}
else
{
    Console.WriteLine("Используя TryParse(): Не удалось разобрать");
}

 
// Ниже демонстрируется корректное использование TryParseExact с датой:

Console.WriteLine("\nт Введи дату в формате dd/MM/yyyy:");
string da = Console.ReadLine();
DateTime date;

if (DateTime.TryParseExact(da, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))// это нейтральная, которая использует стандартные форматы без учета региональных настроек пользователя.
{//  DateTimeStyles.None Это флаг, указывающий дополнительные параметры преобразования.указывает что не никаких дополнительных стилей преобразования.

    Console.WriteLine($"Используя TryParseExact(): {date}");
}
else
{
    Console.WriteLine("Используя TryParseExact(): Не удалось разобрать дату");
}


