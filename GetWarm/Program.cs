Console.Clear();
Console.WriteLine("Enter your name:");
string name = Console.ReadLine();
int temperature = 0;
void GetWarm(int temper)
{ 
    temper = 0;
    while (temper < 100)
    {
        Console.WriteLine($"temperature = {temper}. It's so cold yet");
        Console.Write("Write 'getwarm' ");
        string i = Console.ReadLine();
        if (i.ToLower() == "getwarm")
        {
            temper += 25;
        }


    }
}
GetWarm(temperature);
Console.WriteLine($"Thx, {name}. It's finally warm");
