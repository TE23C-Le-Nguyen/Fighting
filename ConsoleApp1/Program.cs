
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




int pikachudamageMax = 20;
int scissordamageMax = 30;
int charizarddamageMax = 50;
int victinydamageMax = 100;
int mewdamageMax = 300;
int giratinadamageMax = 1000;

int caterpiedamageMax = 10;
int beedrilldamageMax = 20;
int pinsirdamageMax = 40;
int sneaseldamageMax = 50;
int sceptiledamageMax = 80;


Console.WriteLine("Skriv in ditt namn");
name = Console.ReadLine();
Console.WriteLine($" {name} is wandering in the forest with their pokemon until they encouter a wild pokemon");

string enemyName = "";
int enemydamageMax;
int enemyHp;


int randompokemon = Random.Shared.Next(1, 5);
if (randompokemon == 1)
{

    Console.ReadLine();
    enemyHp = caterpiehp;
    enemyName = "Caterpie";
    enemydamageMax = caterpiedamageMax;
}
else if (randompokemon == 2)
{
    
    Console.ReadLine();
    enemyHp = beedrillhp;
    enemyName = "Beedrill";
    enemydamageMax = beedrilldamageMax;
}
else if (randompokemon == 3)
{
    
    Console.ReadLine();
    enemyHp = pinsirhp;
    enemyName = "Pinsir";
    enemydamageMax = pinsirdamageMax;
}

else if (randompokemon == 4)
{

    
    Console.ReadLine();
    enemyHp = sneaselhp;
    enemyName = "Sneasel";
    enemydamageMax = sneaseldamageMax;
}
else
{
    Console.WriteLine();
    Console.ReadLine();
    enemyHp = sceptilehp;
    enemyName = "Sceptile";
    enemydamageMax = sceptiledamageMax;
}

Console.WriteLine($"Du möter {enemyName}!");


Console.WriteLine("Choose your pokemon to fight as");
Console.WriteLine("a) Pikachu, b) Scissor, c) Charizard , d) Victiny , e) Mew , f) Giratina");
string answer1 = Console.ReadLine();
string allianceName = "";
int allianceHp = 0;
int damageMax = 0;
while (answer1 != "a" && answer1 != "b" && answer1 != "c" && answer1 != "d" && answer1 != "e" && answer1 != "f")
{
    answer1 = Console.ReadLine();
}

if (answer1 == "a")
{
    Console.WriteLine("You choose Pikachu");
    allianceName = pikachu;
    allianceHp = pikachuhp;
    damageMax = pikachudamageMax;
}
else if (answer1 == "b")
{
    Console.WriteLine("You choose Scissor");
    allianceName = scissor;
    allianceHp = scissorhp;
    damageMax = scissordamageMax;
}
else if (answer1 == "c")
{
    Console.WriteLine("You choose Charizard");
    allianceName = charizard;
    allianceHp = charizardhp;
    damageMax = charizarddamageMax;
}
else if (answer1 == "d")
{
    Console.WriteLine("You choose Victiny");
    allianceName = victiny;
    allianceHp = victinyhp;
    damageMax = victinydamageMax;
}
else if (answer1 == "e")
{
    Console.WriteLine("You choose Mew");
    allianceName = mew;
    allianceHp = mewhp;
    damageMax = mewdamageMax;
}
else if (answer1 == "f")
{
    Console.WriteLine("You choose Giratina");
    allianceName = giratina;
    allianceHp = giratinahp;
    damageMax = giratinadamageMax;
}
Console.ReadLine();


while (allianceHp > 0 && enemyHp > 0)
{
    Console.WriteLine();
    int dmg = Random.Shared.Next(1, enemydamageMax);
    allianceHp -= dmg;
    Console.WriteLine(allianceName + " has " + allianceHp + " hp left");


    Console.WriteLine();
    int dmg2 = Random.Shared.Next(1, damageMax);
    enemyHp -= dmg2;
    Console.WriteLine(enemyName + " has " + enemyHp + " hp left");
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