
Console.Write("Qavat sonini kiriting: ");
int qavatSoni = Convert.ToInt32(Console.ReadLine());

int uchburchaklar = QavatUchburchaklar(qavatSoni);

Console.WriteLine($"{qavatSoni} qavatli uchburchakda {uchburchaklar} ta uchburchak bor.");

static int QavatUchburchaklar(int qavatSoni)
{
    return qavatSoni <= 1 ? qavatSoni : (int)Math.Pow(2, qavatSoni - 1) + 1;
}
