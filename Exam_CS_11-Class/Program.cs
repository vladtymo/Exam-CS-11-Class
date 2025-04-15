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

using System.Text.Json;

Console.OutputEncoding = System.Text.Encoding.UTF8; // для укр. тексту

Console.WriteLine("------------ Welcome to Competition App (8) ------------");

Console.WriteLine("----- MENU -----");
Console.WriteLine("1. Show all competitions");
Console.WriteLine("2. Add new competition");
Console.WriteLine("3. Delete competition");
Console.WriteLine("4. Load data from file");
Console.WriteLine("5. Save data to file");
Console.WriteLine("6. Show competition by name");
Console.WriteLine("7. Add new competition type");
Console.WriteLine("8. Облік результатів змагань у певному виді");
Console.WriteLine("9. Підведення підсумків");

List<Competition> competitionList = new();

while (true)
{
    Console.Write("Select menu option: ");
    int option = int.Parse(Console.ReadLine());

    switch (option)
    {
        case 1:
            foreach (var com in competitionList)
            {
                Console.WriteLine("-------------- Competition -------------");
                Console.WriteLine($"Name: {com.Name}");
                Console.WriteLine($"Distance: {com.Distance}m");
            }
            break;
        case 2:
            var newCompetition = new Competition();

            Console.Write("Enter Competition Name: ");
            newCompetition.Name = Console.ReadLine();
            Console.Write("Enter Competition Distance: ");
            newCompetition.Distance = double.Parse(Console.ReadLine());
            
            competitionList.Add(newCompetition);
            break;
        case 4:
            string competitionJsonRead = File.ReadAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/competition.json");
            competitionList = JsonSerializer.Deserialize<List<Competition>>(competitionJsonRead);
            break;
        case 5:
            string competitionJson = JsonSerializer.Serialize(competitionList);
            File.WriteAllText($"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}/competition.json", competitionJson);
            break;
        case 3:
            Console.WriteLine("Enter competition name to delete: ");
            string nameToDelete = Console.ReadLine();
            
            var itemToDelete = competitionList.Find(x => x.Name == nameToDelete);
            if (itemToDelete == null)
            {
                Console.WriteLine("Invalid competition name!");
                break;
            }
            
            competitionList.Remove(itemToDelete);
            Console.WriteLine($"Competition: {itemToDelete.Name} was deleted!");
            break;
        case 6:
            Console.WriteLine("Enter competition name to search: ");
            string nameToSearch = Console.ReadLine();
            
            var itemToShow = competitionList.Find(x => x.Name == nameToSearch);
            if (itemToShow == null)
            {
                Console.WriteLine("Invalid competition name!");
                break;
            }
            
            Console.WriteLine("-------------- Competition -------------");
            Console.WriteLine($"Name: {itemToShow.Name}");
            Console.WriteLine($"Distance: {itemToShow.Distance}m");
            break;
    }

    Console.WriteLine("Натисніть щось для продовження...");
    Console.ReadKey();
    Console.Clear();
}
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