// See https://aka.ms/new-console-template for more information
//


#region Fibonacci

/*using System.ComponentModel;

int n = 10; // ilk 10 terimi istendiği için
Fibonacci(n); // n sayıya kadar hesaplıcak

static void Fibonacci(int n)
{
    int a = 0;
    int b = 1;
    int temp;

    for(int i = 2; i < n; i++) //  i den başlamasının sebebi zaten 0 ve 1 i tanımladık
    //
    {
        temp = a + b; // son iki sayının toplamanı bul ve geçici değişkene ata
        Console.WriteLine(temp); // tempi ekrana yazdır
        a = b; // a b nin eski değerini alır
        b = temp; // b de bir sonrakı değere geçer
    }
}*/

#endregion

#region 1-100*MükemmelSayı
/*int bolenToplamı = 0; // bolen  toplamını bulmak ıcın
int toplamanı =  0;
// ilk basta 1 den 100 e kadar olan sayıların toplamını buluruz
// sonra sayı değiskenine toplamını atarız
// for ıle kaç tane boleni oldugunu bulur
// if ile bolumunden kalan 0 mı diye kontrol ederiz bunun sebebi tam bolunmustur ve bu sayının bolendir
// sonra kaö bolenı oldugunu hesaplamak ıcın bolentoplama atarız

for(int i = 1; i <=100; i = i+2) // cıft sayıların toplamını bulmak ıcın
{
    toplamanı += i;
  
}

int sayı2 = toplamanı; // sayıyı toplamına esitledik
for(int j = 1; j <= sayı2 / 2;  j++) // j sayı 2 ye bolundugu sürece j yi arttır
{
    if( sayı2 % 2 == 0) // sayının bolumunden kalan 0 a esitse demek ki pozitif tam bolenlerin ıcınde
    {
        bolenToplamı += j; // kaç kere bolundugu kontrol edilir vee bolenleri hesaplanır
    }
}
if(bolenToplamı == sayı2)
{
    Console.WriteLine($"Mukemmel Sayıdır: {sayı2}");
}

else
{
    Console.WriteLine($"Mükemmel Sayı Değildir");
}
*/

#endregion

#region GirilenSayıMukemmelMı
// once kullanıcıdan sayı alırız ve cevirirz
// sonra for döngüsü ıcınde sayının bolenlerini hesaplarız
// eger sayının bolenleri 0 a esitse mukennel sayıdır

/*Console.WriteLine("Bir Sayı Giriniz");
int sayı = int.Parse(Console.ReadLine());

for(int i = 1; i <= sayı / 2; i++);

if(sayı % 2 == 0)
{
    Console.WriteLine("Mükemmel Sayıdır");
}
else
{
    Console.WriteLine("Mükemmel Sayı Değildir");
}*/

#endregion

#region HerHgiBirSayınınHerhangBirDerecesi

/*//Herhangi bir sayının herhangi bir dereceden kuvvetini bulan programın algoritma ve akış diyagramını çiziniz
Console.WriteLine("Bir Sayı Giriniz");
int sayı = int.Parse(Console.ReadLine());
Console.WriteLine("Hangi Derecen Hesaplamak İstersin (Kök) (Kare) (Küp)");
string secım = Console.ReadLine().Trim().ToLower();

if(secım == "kare")
{
    int kareSonuc = sayı * sayı;
    Console.WriteLine($"Karesinin Sonucu: {kareSonuc}");
}
else if(secım == "küp")
{
    int kupSonuc = sayı * sayı * sayı;
    Console.WriteLine($"Küpünün Sonucu: {kupSonuc}");
}
else if(secım == "kök")
{
    double kokSonuc = Math.Sqrt(sayı);
    Console.WriteLine($"Kökünün Sonucu: {kokSonuc}");
}

/*switch(secım)
{
    case "kare":
    int kareSonuc = sayı * sayı;
    Console.WriteLine($"Karesinin Sonucu: {kareSonuc}");
    break;

    case "küp":
    int kupSonuc = sayı * sayı * sayı;
    Console.WriteLine($"Küpünün Sonucu: {kupSonuc}");
    break;

    case "kök":
    double kokSonuc = Math.Sqrt(sayı);
    Console.WriteLine($"Kökünün Sonucu: {kokSonuc}");
    break;

    
}*/

#endregion

#region GüçlüSayımı
// Girilen sayının abundant (güçlü) sayı mı ya da Deficient (güçsüz) sayı mı olduğunu bulan programın algoritma ve akış diyagramını çiziniz.*basadon:
basadon:
try
{
    Console.WriteLine("Bir Sayı Giriniz");
    int sayı = int.Parse(Console.ReadLine());
    int basamak = 0;

    if (sayı == 0)
    {
        basamak = 1;

    }
    else
    {
        while (sayı != 0)
        {
            sayı /= 10;
            basamak++; // basamak sayısını bulmak için

        }
    }
    
}
catch(FormatException)
{
    Console.WriteLine("Yanlış Sayı Girdiniz");
    goto basadon;

} 
#endregion

