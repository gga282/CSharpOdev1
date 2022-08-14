//Kullanıcıdan 10 adet sayı alan ve bu sayıların 50 den küçük olanlarının sayısını bulup ekrana yazan uygulamayı geliştirin

int[] arr = new int[10];
Console.WriteLine("10 tane sayi girin: ");
for(int i=0;i<arr.Length;i++)
{
    Console.Write((i+1)+". sayiyi giriniz: ");
    arr[i] = int.Parse(Console.ReadLine());

}
for(int i=0;i<arr.Length;i++)
{
    if (arr[i] < 50)
    {
        Console.WriteLine("Sayi["+(i+1)+"]"+arr[i] +"<50");
    }
}