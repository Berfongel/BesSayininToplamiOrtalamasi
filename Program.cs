// See https://aka.ms/new-console-template for more information
double sayi1,sayi2,sayi3,sayi4,sayi5,toplam,ortalama;
Console.WriteLine("Ekrana Beş adet sayı giriniz :");
//girilecek olan sayılar
sayi1 = Convert.ToDouble(Console.ReadLine());
sayi2 = Convert.ToDouble(Console.ReadLine());
sayi3 = Convert.ToDouble(Console.ReadLine());
sayi4 = Convert.ToDouble(Console.ReadLine());
sayi5 = Convert.ToDouble(Console.ReadLine());
//sayıların toplamı
toplam = (sayi1+sayi2+sayi3+sayi4+sayi5);
//sayıların ortalaması
ortalama=((toplam)/5);
Console.WriteLine("Girdiğiniz sayıların toplamı :" +toplam);
Console.WriteLine("Girdiğiniz sayıların ortalaması :" + ortalama);


