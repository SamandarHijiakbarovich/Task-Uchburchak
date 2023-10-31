/*int qavati = int.Parse(Console.ReadLine());
int count=0;
int uchburchak1 = 1;
List<int> ints = new List<int>();

if(qavati==1)
{
    Console.WriteLine(uchburchak1);
}
else
{
    for (int i = 0; i <qavati; i++)
    {
        uchburchak1 += 2;
        count = uchburchak1;
    }
    Console.WriteLine(count);
}*/


/*Console.WriteLine("Qavatni kiritng:");
int qavat = Convert.ToInt32(Console.ReadLine());

int uchburchak = 1;
for (int i = 1; i <= qavat; i++)
{
    uchburchak = 3 * uchburchak - 2;
    Console.WriteLine($"{i} qavatda {uchburchak} ta uchburcha bor.");
}
*/
/*
Console.Write("Qavat sonini kiriting: ");
int qavatSon = int.Parse(Console.ReadLine());

int uchburcha = 1;
int umumiyUchburchalar = 0;

for (int i = 1; i <= qavatSon; i++)
{
    umumiyUchburchalar += uchburcha;
    Console.WriteLine($"{i} qavatli uchburchakda {uchburcha} ta uchburcha bor.");
    uchburcha *= 2;
}

Console.WriteLine($"Jami {umumiyUchburchalar} ta uchburcha bor.");
*/

/*Console.Write("Qavat sonini kiriting: ");
        int qavatSon = Convert.ToInt32(Console.ReadLine());

        int jamiUchburchaklar = 0;

        for (int i = 1; i <= qavatSon; i++)
        {
            int uchburchaklar = (int)Math.Pow(i, 3);
            jamiUchburchaklar += uchburchaklar;

            Console.WriteLine($"{i} qavatdagi uchburchaklar soni: {uchburchaklar}");
        }

        Console.WriteLine($"Jami uchburchaklar soni: {jamiUchburchaklar}");
 

*/

/*
Console.Write("Qavatdagi uchburchaklar sonini kiriting (n): ");
int n = Convert.ToInt32(Console.ReadLine());

int triangles = (n * (n + 2) * (2 * n + 1)) / 8;

Console.WriteLine($"qavat soni - {n}: Uchburchaklar soni = {triangles}");
*/



Console.Write("Qavatdagi uchburchaklar sonini kiriting (n): ");
int n = Convert.ToInt32(Console.ReadLine());

int triangles = CalculateTriangles(n);

Console.WriteLine($"qavatlar soni - {n}: Uchburchaklar soni = {triangles}");

static int CalculateTriangles(int n)
{
    int resul1 = n * (n + 2);
    int result2 = resul1 * (2 * n + 1);
    int triangles = result2 / 8;

    return triangles;
}
