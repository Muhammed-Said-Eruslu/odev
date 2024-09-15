#region IkıSayınınToplamı


/*Console.WriteLine("Birinci Sayıyı Giriniz");
int sayı = int.Parse(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz");
int sayı2 = int.Parse(Console.ReadLine());

int result = sayı + sayı2;

Console.WriteLine($"İkı sayının toplamı {result}");*/

#endregion

#region   IkıSayınınKaresi

/*Console.WriteLine("İlk Sayıyı Giriniz");
int sayı = int.Parse(Console.ReadLine());
Console.WriteLine("İkinci Sayıyı Giriniz");
int sayı2 = int.Parse(Console.ReadLine());

int result = sayı * sayı2;

Console.WriteLine($"iki Sayının Karesi  {result}");

*/
#endregion

#region 1den100e

/*int toplam = 0;
for(int i = 0; i <= 100; i++)
{
    toplam += i;
}
toplam =  toplam * toplam;
Console.WriteLine(toplam);*/

#endregion

#region DogumTarihiniGirenKişininYaşı
/*DateTime dt;
Console.WriteLine("Yaşınızı Giriniz");

dt = DateTime.TryParse(Console.ReadLine(),out ,dt);
*/
#endregion

#region 
/*int hız = 1;
Console.WriteLine("Her Hangi Bir (t) zamanı giriniz");
int dakika = int.Parse(Console.ReadLine());

if(dakika > 0 && dakika  <= 15)
{
    dakika *= hız*32;
    Console.WriteLine($"Şuanki Hızınız {dakika}");
}
else if(dakika > 15 && dakika <= 35)
{
    Console.WriteLine("Hızınız Sabit");
}
else if(dakika > 35 && dakika <= 50)
{
    
    dakika = hız*-32;
    Console.WriteLine($"Hızınız Azalıyor {dakika}");
}*/

/*double hız = 1;
Console.WriteLine("Her Hangi Bir (t) zamanı giriniz");
double dakika = double.Parse(Console.ReadLine());

if(dakika > 0 && dakika  <= 900)
{
    dakika *= hız*0.5333333333333333;
    Console.WriteLine($"Şuanki Hızınız {dakika}");
}
else if(dakika > 900 && dakika <= 2100)
{
    Console.WriteLine("Hızınız Sabit");
}
else if(dakika > 2100 && dakika <= 3000)
{

    dakika -= hız * 0.5333333333333333;
    Console.WriteLine($"Hızınız Azalıyor {dakika}");
}*/
#endregion

#region Binary
//Binary olarak girilen sayıyı decimal sayıya çeviren 
//programın algoritma ve akış diyagramını çiziniz
/*
Console.WriteLine("Bir Binary sayı giriniz");
string binary = Console.ReadLine();

bool geçerliMi = true;

foreach (var karakter in binary)
{
    if (karakter != 0 && karakter != 1) // Girilen sayı 0 ve 1 değilse bu bloga gir cunku binary sadece 0 ve 1 den olusur // 0 a ve 1 e eşit değilse
    {
        geçerliMi = false;
        break;
    }
}
if (!geçerliMi)
{

}*/
/*Console.WriteLine("Bir Binary sayı giriniz:");
string binary = Console.ReadLine();

bool geçerliMi = true;

// Binary sayının geçerliliğini kontrol et
foreach (var karakter in binary)
{
    if (karakter != '0' && karakter != '1') // Girilen sayı 0 ve 1 değilse
    {
        geçerliMi = false; // Geçerli değil olarak işaretle
        break; // Döngüyü sonlandır
    }
}

if (!geçerliMi)
{
    Console.WriteLine("Geçersiz binary sayı.");
}
else
{
    // Binary sayıyı decimal sayıya çevir
    int decimalSayi = 0;
    int uzunluk = binary.Length;

    for (int i = 0; i < uzunluk; i++)
    {
        // Binary sayının her basamağını ve 2'nin kuvvetlerini kullanarak decimal değeri hesapla
        if (binary[uzunluk - 1 - i] == '1')
        {
            decimalSayi += (int)Math.Pow(2, i);
        }
    }

    Console.WriteLine($"Binary sayının decimal karşılığı: {decimalSayi}");
}*/


#endregion

#region ArtıkYılMı
using System.Data;
using System.Diagnostics;

/*Console.WriteLine($" Artık Yıl Mı{DateTime.IsLeapYear(DateTime.Now.Year)}");*/

#endregion

#region Fibonaccı


/*int ilkSayı = 0;
int ıkıncısayı = 1;
int sonraKısayı;

for(int i = 3; i <= 10; i++) // ilk ıkı sayıyı bıldıgımız ıcın 3 den basladık ve bizden ılk 10 terimi istendi
{
   sonraKısayı =  ilkSayı+ıkıncısayı; // mantık su sonrakı sayı oncekı ıkı sayının toplamı olur fıbonacı budur
   Console.WriteLine(sonraKısayı); // sonrakı sayıyı yazdırırız
   ilkSayı = ıkıncısayı; // ilk sayı ıkıncı sayıya eşit olur boylelıkle ıkıncı sayının yerini alır
   ıkıncısayı = sonraKısayı; // ıkıncı sayıda sayı 1 ve sayı 2 nın toplamını alır
}*/


#endregion

#region MükemmelSayıMı

/*int toplam = 0;
int bolentoplamı = 0;
for(int i = 0; i <= 100; i++)
{
    toplam += i; // 0 dan 100 e kadar olan sayıların toplamını bulduk
}
int sayı = toplam; // sayıyı toplama eşitledik

for(int i = 1; i < sayı /2; i++) // i sayının ikiye bolumunden kucuk olana kadar devam edıcek
{
    if(sayı % 2 == 0) // eğer kalansız bolnuyosa o sayının bolenıdır
    {
        bolentoplamı += i;
    }
    if(bolentoplamı == sayı) // bolen toplamı sayıya esitse mukmmel olur
    {
        Console.WriteLine("Mükemmel Sayıdır");
    }
    else
    {
        Console.WriteLine("Mükemmel Sayı Değildir");
    }
}*/

#endregion

#region 4Basamaklı
// Girilen dört basamaklı sayılardan ilk iki basamağı ile son iki basamağının toplamının karesi, sayının 
// kendine eşit olan sayılara orijinal sayı denir. Girilen sayının orijinal olup olmadığını bulan 
// orjınal sayı nedir ?
// ilk ıkı basamağın son 2 basamagının toplamının karesidir
// ilk basta kullanıcıdan 4 basamaklı sayı isteriz
// ılk ıkı basamağı bulmak ıcın sayıyı 100 boleriz
// son ıkı basamagı bulmak ıcın sayıyın modunu alırız
// sonra bunların toplamını alırız
// sonra toplamın karesını alırız eğer toplamın karesi
// sayıya eşitse orjınal sayıdır
/*Console.WriteLine("4 Basamaklı Sayı Giriniz");

int sayı = int.Parse(Console.ReadLine());

int ıkıBasamak = sayı / 100;
int dortbasamak = sayı % 100;

int toplam = ıkıBasamak+dortbasamak;
int toplamKaresi = toplam * toplam;

if(toplamKaresi == sayı)
{
    Console.WriteLine("Orjınal Sayıdır");
}
else
{
    Console.WriteLine("Orjınal Sayı Değildir");
}*/
#endregion

#region fark
// 1 ile 500 arasındaki tam sayılardan tek sayıların toplamı ile çift sayıların 
//toplamının farkı negatif mi, pozitif mi olduğunu bulan programın algoritma ve akış diyagramını çiziniz.
/*int Cıfttoplam = 0;
int tekToplam = 0;
int fark = 0;
for(int i = 1; i<= 500; i++)
{
    if(i % 2 == 0) // eğer sayı cıftse
    {
        Cıfttoplam += i; // cıft toplama ekle
    }
    else
    {
        tekToplam += i; // değilse tek toplama ekle
    }
}
fark = Cıfttoplam - tekToplam; // farkı aldık 

if(fark < 0) // eğer farkı 0 dan kucukse
{
    Console.WriteLine("Farkı Negatif");
}
else if(fark > 0) // 0 dan buyukse
{
    Console.WriteLine("Farkı Pozitif");
}*/
#endregion

#region 4Hane
//4 haneli bir sayının birler, onlar, yüzler ve binler hanesini bulan programın algoritma ve akış diyagramını çiziniz.
/*
int sayı = 4000;
int basamak = 0;
while(sayı != 0)
{
    sayı /= 10;
    basamak++;
    if(basamak == 1)
    {
        Console.WriteLine($"Binler Basamagı {sayı}");
    }
    if(basamak == 2)
    {
        Console.WriteLine($"Yüzler Basamagı {sayı}");
    }
      if(basamak == 3)
    {
        Console.WriteLine($"Onlar Basamagı {sayı}");
    }
      if(basamak == 4)
    {
        Console.WriteLine($"Birler Basamagı {sayı}");
    }

   
}
 
*/

#endregion

#region RustGele
//Rastgele girilen 50 sayıdan negatif olanların ve pozitif olanların sayısını bulan programın algoritma ve akış şemasını çiziniz

/*
int negatifBul = 0;
int pozitifBul = 0;
for(int i = 0; i <=4; i++)
{
    Console.WriteLine("Sayı Giriniz");
int sayı = int.Parse(Console.ReadLine());

if(sayı < 0)
{
    negatifBul++;
    
}
if(sayı > 0)
{
pozitifBul++;
}

}
Console.WriteLine($"Toplam Girilen Pozitif Sayısı {pozitifBul}");
Console.WriteLine($"Toplam Girilen Negatif Sayısı {negatifBul}");
*/
#endregion

#region 10
//10 ile 200 arasındaki tam sayılardan 3 katının 2 fazlası 5 ile
// tam bölünebilen sayıları gösteren programın algoritma ve akış diyagramını çiziniz.
/*int tamBolum = 0;
int toplam = 0;
for(int i = 10; i < 200; i++)
{
    toplam += i;
    toplam *= 3+2;
    if(i % 5 == 0)
    {
        tamBolum++;
    }

}

Console.WriteLine($"Tam Bölünen Sayılar {tamBolum}");*/
#endregion

#region SayıBulmacı
//Sayı bulmaca oyunu programının algoritma ve akış diyagramı çiziniz.
//Kural: 10 sefer hakkınız var Kullanıcının tahminine göre tahmini yükselt yada tahmini azalt diyerek yönlendirme yapacak.
// Bulduğu sefer sayısını ekrana basacak veya üzgünüz bir daha ki sefere diyecek.

    int kalanHak = 10;
    int sayı = 31;
    int sayac = 0;
    Console.WriteLine("Sayı Bulmaca Bir Sayı Giriniz");
    int girilenSayı = int.Parse(Console.ReadLine());

    
    
  while(kalanHak != 0)
  {
          if (girilenSayı == sayı)
        {
            Console.WriteLine("Doğru tahmin ettiniz");
            Console.WriteLine($"Hangi Seferde Bulduğunuz {sayac}");
            break;
        }
        else if( kalanHak != 0)
        {
          
              Console.WriteLine("Yanlış Tahmin Ettiniz");
            girilenSayı = int.Parse(Console.ReadLine());
            kalanHak--;
            sayac++;
           
        }
  }
    


#endregion
