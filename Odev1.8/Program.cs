//Kullanıcıdan kaç tane sayıyı toplamak istediğini alan sonrasında toplanacak sayı adedi kadar sayıyı kullanıcıdan tek tek alıp bu sayıların toplamını ekrana yazan programı geliştirin
int sum = 0;
Console.WriteLine("Kac tane sayiyi toplamak istiyorsunuz: ");
int size = int.Parse(Console.ReadLine());

for(int i=0;i<size;i++)
{
    Console.Write((i+1)+". sayiyi giriniz:");
    int input=int.Parse(Console.ReadLine());
    sum += input;
}
Console.WriteLine("Sayilarin toplami: " + sum);