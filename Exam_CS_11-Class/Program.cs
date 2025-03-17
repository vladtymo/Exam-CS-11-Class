/*8. ------------------- Змагання 
Створити програму для обліку результатів змагань з легкої атлетики(чи ін.)
    Вивід учасників змагань(спортсмен, тренер, країна)
    Додавання(вилучення, редагування) спортсмена у(з) базу
    Вивід видів змагань(100м, 3км, стрибки та ін.)
    Додавання(вилучення, редагування) виду змагань
    Облік результатів змагань у певному виді
    Збереження у файлі(завантаження з файлу) переліку спортсменів
    Збереження у файлі(завантаження з файлу) переліку видів змагань	
    Збереження у файлі(завантаження з файлу) результатів змагань по датах
    Підведення підсумків (визначення переможців у певному виді змагання)*/

Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр. тексту

Console.WriteLine("------------ Welcome to Competition App (8) ------------");

Console.WriteLine("----- MENU -----");
Console.WriteLine("1. Show all competition members");
Console.WriteLine("2. Add new member");
Console.WriteLine("3. Delete member");
Console.WriteLine("4. Add new member");
Console.WriteLine("5. Save data to file");
Console.WriteLine("6. Show all competition types");
Console.WriteLine("7. Add new competition type");
Console.WriteLine("8. Облік результатів змагань у певному виді");
Console.WriteLine("9. Підведення підсумків");

public class Member
{
    public string Name { get; set; }
    public string Country { get; set; }
    public string Coach { get; set; }
    public int Medals { get; set; }
}

public class Competition
{
    public string Name { get; set; }
    public double Distance { get; set; }
}

public class Result
{
    public string Competition { get; set; }
    public string Medal { get; set; }
    public string Member { get; set; }
}