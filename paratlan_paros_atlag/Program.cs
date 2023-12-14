int db;
double szám, párosdb = 0;
double páratlandb = 0;
double párosösszeg = 0, páratlanösszeg = 0;
do
{
    Console.Write("darabszám: ");
    db = int.Parse(Console.ReadLine());
}
while (db <= 0 || db >= 100);
for (int i = 1; i <= db; i++)
{
    Console.Write(i + ".szám: ");
    szám = int.Parse(Console.ReadLine());
    if (szám % 2 == 0)
    {
        párosösszeg += (double)szám;
        párosdb ++;
    }
        
    else
    {
        páratlanösszeg += (double)szám;
        páratlandb ++;
    }
}
Console.WriteLine("párosösszeg: " + párosösszeg / párosdb);
Console.Write("páratlanösszeg: " + páratlanösszeg / páratlandb);
Console.ReadKey();
