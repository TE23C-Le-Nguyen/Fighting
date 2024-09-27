
//while (true)
//{
//    int card = Random.Shared.Next(-5, 5);
//    Console.WriteLine(card);
//    Console.ReadLine();
//}

int pikachuhp = 100;
int scissorhp = 150;
int charizardhp = 200;
int victinyhp = 500;
int mewhp = 1000;
int giratinahp = 5000;
int diddyhp = 100;

int caterpiehp = 80;
int beedrillhp = 100;
int pinsirhp = 140;
int sneaselhp = 160;
int sceptilehp = 200;


string pikachu = "Pikachu";
string scissor = "Scissor";
string charizard = "Charizard";
string victiny = "Victiny";
string mew = "Mew";
string giratina = "Giratina";



string name;
int damageMax1 = 0;
int damageMax2 = 0;
int damageMax3 = 0;
int damageMax4 = 0;
int damageMax5 = 0;
int damageMax6 = 0;
int damageMax7 = 0;
int damageMax8 = 0;
int damageMax9 = 0;
int damageMax10 = 0;
int damageMax11 = 0;


Console.WriteLine("Skriv in ditt namn");
name = Console.ReadLine();
Console.WriteLine($" {name} is wandering in the forest with their pokemon until they encouter a wild pokemon");

string enemyName = "";

int enemyHp;


int randompokemon = Random.Shared.Next(1, 5);
if (randompokemon == 1)
{

    Console.ReadLine();
    enemyHp = caterpiehp;
    enemyName = "Caterpie";
}
else if (randompokemon == 2)
{
    
    Console.ReadLine();
    enemyHp = beedrillhp;
    enemyName = "Beedrill";
}
else if (randompokemon == 3)
{
    
    Console.ReadLine();
    enemyHp = pinsirhp;
    enemyName = "Pinsir";
}
else if (randompokemon == 4)
{
    
    Console.ReadLine();
    enemyHp = sneaselhp;
    enemyName = "Sneasel";
}
else
{
    Console.WriteLine();
    Console.ReadLine();
    enemyHp = sceptilehp;
    enemyName = "Sceptile";
}

Console.WriteLine($"Du möter {enemyName}!");


Console.WriteLine("Choose your pokemon to fight as");
Console.WriteLine("a) Pikachu, b) Scissor, c) Charizard , d) Victiny , e) Mew , f) Giratina");
string answer1 = Console.ReadLine();
string allianceName = "";
int allianceHp = 0;
while (answer1 != "a" && answer1 != "b" && answer1 != "c" && answer1 != "d" && answer1 != "e" && answer1 != "f")
{
    answer1 = Console.ReadLine();
}

if (answer1 == "a")
{
    Console.WriteLine("You choose Pikachu");
    allianceName = pikachu;
    allianceHp = pikachuhp;
    damageMax1 = 20;
}
else if (answer1 == "b")
{
    Console.WriteLine("You choose Scissor");
    allianceName = scissor;
    allianceHp = scissorhp;
    damageMax2 = 30;
}
else if (answer1 == "c")
{
    Console.WriteLine("You choose Charizard");
    allianceName = charizard;
    allianceHp = charizardhp;
    damageMax3 = 50;
}
else if (answer1 == "d")
{
    Console.WriteLine("You choose Victiny");
    allianceName = victiny;
    allianceHp = victinyhp;
    damageMax4 = 100;
}
else if (answer1 == "e")
{
    Console.WriteLine("You choose Mew");
    allianceName = mew;
    allianceHp = mewhp;
    damageMax5 = 300;
}
else if (answer1 == "f")
{
    Console.WriteLine("You choose Giratina");
    allianceName = giratina;
    allianceHp = giratinahp;
    damageMax6 = 1000;
}
Console.ReadLine();


while (allianceHp > 0 && enemyHp > 0)
{
    Console.WriteLine();
    int dmg = Random.Shared.Next(0, 10);
    allianceHp -= dmg;

    Console.WriteLine();
    int dmg2 = Random.Shared.Next(0, 8);
    enemyHp -= dmg2;
}

if (allianceHp <= 0 && enemyHp <= 0)
{
    Console.WriteLine("GG");
}
else if (allianceHp <= 0)
{
    Console.WriteLine($"{allianceName} lose");
}
else if (enemyHp <= 0)
{
    Console.WriteLine($"{enemyName} lose");
}
Console.ReadLine();