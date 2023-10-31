/*Console.WriteLine("Qavat sonini kiriting:");
int qavatSon = Convert.ToInt32(Console.ReadLine());

int totalUchburchak = CalculateUchburchak(qavatSon);

Console.WriteLine($"{qavatSon} qavatli uchburchakda {totalUchburchak} ta uchburchak bor.");
static int CalculateUchburchak(int qavatSon)
{
    if (qavatSon <= 0)
    {
        return 0;
    }

    int totalUchburchak = 1;
    int uchburchak = 1;

    for (int i = 2; i <= qavatSon; i++)
    {
        uchburchak *= 2;
        totalUchburchak += uchburchak;
    }

    return totalUchburchak;
}*/


