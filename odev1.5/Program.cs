//Tek Cift sayi toplama
//
int even_sum = 0;
int odd_sum = 0;
Console.WriteLine("Sayi gir: ");
int input = int.Parse(Console.ReadLine());


for (int i = 0; i < input; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine("Sayi: " + i + " Cift");
        even_sum += i;
    }
    else
    {
        Console.WriteLine("Sayi: " + i + " Tek");
        odd_sum += i;

    }

}
Console.WriteLine("Tek sayilarin toplami: " + odd_sum);
Console.WriteLine("Cift sayilarin toplami: " + even_sum);