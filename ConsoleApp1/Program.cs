
//while (true)
//{
//    int card = Random.Shared.Next(-5, 5);
//    Console.WriteLine(card);
//    Console.ReadLine();
//}

int doghp = 120;
int cathp = 100;

string dogName = "dog";
string catName = "cat";

while (doghp > 0 && cathp > 0)
{
    Console.WriteLine();
    int dmg = Random.Shared.Next(0, 10);
    doghp -= dmg;

    Console.WriteLine();
    int dmg2 = Random.Shared.Next(0, 8);
    cathp -= dmg2;
}

if (doghp <= 0 && cathp <= 0)
{
    Console.WriteLine("GG");
}
else if (doghp <= 0)
{
    Console.WriteLine("dog lose");
}
else if (cathp <= 0)
{
    Console.WriteLine("cat lose");
}


Console.ReadLine();