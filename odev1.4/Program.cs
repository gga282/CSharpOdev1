int sum = 0;
Console.Write("Bir sayi girin: ");
string input = Console.ReadLine();
int size = Convert.ToInt32(input);
for(int i=0;i<size;i++)
{
    sum += i;
}
Console.WriteLine(size+"'ya kadar olan sayilarin toplami: " + sum);