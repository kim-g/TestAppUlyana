// See https://aka.ms/new-console-template for more information
Console.WriteLine("Как Вас зовут?");
string? UserName;

//UserName = Console.ReadLine();
//bool IsNameCorrect = UserName == "" && UserName == null;
bool IsNameCorrect = 2 != 2;
Console.WriteLine(IsNameCorrect);
if (IsNameCorrect)
{
    Console.WriteLine("Жалко, что Вы не представились. Будем хвать Вас \"Аноним\"");
    UserName = "Аноним";
}
else
{
    Console.WriteLine($"Приятно познакомиться, {UserName}!");
}

string Text = "Сердечно поздравляем {Name} с награждением государственной наградой - орденом Дружбы за заслуги в научной деятельности и многолетнюю добросовестную работу. Желаем {Name} новых творческих успехов! Коллектив ИОС УрО РАН поздравляет {Name}";
string TextWithName = Text.Replace("{Name}", UserName);

Console.WriteLine(TextWithName);
