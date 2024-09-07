// See https://aka.ms/new-console-template for more information

using System.ComponentModel;
using System.Linq.Expressions;

#region GünAdıBulma

/*Console.WriteLine("Gün Numarası Giriniz:\n(1/2/3/4/5/6/7)");
int girilengün = int.Parse(Console.ReadLine());

switch(girilengün)
{
    case 1:
    Console.WriteLine("Pazartesi");
    break;
    
    case 2:
    Console.WriteLine("Salı");
    break;
    
    case 3:
    Console.WriteLine("Çarşamba");
    break;

    case 4:
    Console.WriteLine("Perşembe");
    break;

    case 5:
    Console.WriteLine("Cuma");
    break;

    case 6:
    Console.WriteLine("Cumartesi");
    break;

    case 7:
    Console.WriteLine("Pazar");
    break;

    default:
    Console.WriteLine("Geçerli Numara Giriniz");
    break;

}*/

#endregion

#region RenkSeçimi
/*Console.WriteLine("Renk Seçiniz\n(Mavi için 1)\n(Siyah için 2)\n(Yeşil için 3)\n(Sarı için 4)\n(Turkuaz için 5)");
int renkSecimi = int.Parse(Console.ReadLine());

switch(renkSecimi)
{
    case 1:
    Console.WriteLine($"Seçtiğiniz Renk Mavi");
    break;
    case 2:
    Console.WriteLine($"Seçtiğiniz Renk Şudur: Siyah");
    break;
    case 3:
    Console.WriteLine($"Seçtiğiniz Renk Şudur: Yeşil");
    break;
    case 4:
    Console.WriteLine($"Seçtiğiniz Renk Şudur: Sarı");
    break;
    case 5:
    Console.WriteLine($"Seçtiğiniz Renk Şudur: Turkuaz");
    break;
    
    default:
    Console.WriteLine("Lütfen Geçerli Sayı Giriniz");
    break;
}*/
#endregion

#region null-coalescing 

/*Console.WriteLine("Bir Değer Giriniz :");
string ın   = Console.ReadLine();

string result = ın == null ? "Değer null" : ın ?? "Değer Default"; // eğer değer nullsa birinci kısın çalısır değilse ikinci kısım çalısır
Console.WriteLine(result);
*/
#endregion

#region YetişkinÇocuk
/*Console.WriteLine("Yaşınızı giriniz");
int yaş = int.Parse(Console.ReadLine());

string result1 = yaş >= 19 ? "Yetişkin" : (yaş < 18 ? "Çocuk" : "Genç");
Console.WriteLine(result1);*/

#endregion

#region ÜrünPahalıUcuz

/*Console.WriteLine("Ürün Fiyati Griiniz");
int fiyat = int.Parse(Console.ReadLine());

string result = fiyat >= 200 ? "Pahalı" : (fiyat < 200 ? "Ucuz" : "");
Console.WriteLine(result);*/

#endregion

#region HesapMakınesi

Basla:
    string islem = null; // kullanıcıdan daha sonra işlem alınacagı ıcın null
    int sayı1 = 0;
    int sayı2 = 0;

    try // kullanıcı sayıları girinci try blogu çalısır
    {
        Console.WriteLine("Birinci Sayıyı Giriniz:");
        sayı1 = int.Parse(Console.ReadLine()); // sayı int e cevrilir nedeni consoldaki girilen işlemin string olarak tutuldugu ıcın

        Console.WriteLine("İkinci Sayıyı Giriniz:");
        sayı2 = int.Parse(Console.ReadLine()); // sayı 2 inte cevrilir

        Console.WriteLine("Yapmak İstediğiniz işlemi Seçiniz\n(+)Toplama\t(-)Çıkarma\t(/)Bölme\t(*)Çarpma\t(%)Modüls");
        islem = Console.ReadLine(); // işlemin cevrilmemesinin sebebi char turunde işlem yapıcaz eğer 1 2  4 gibi olsaydı cevirirdki
    }
    catch (Exception ex) // eğer kullanıcı işleme int turu haric bir şey girerse bu blok çalısır
    {
        Console.WriteLine($"Hata: {ex.Message}"); // ekrana hata mesajı verilir
        goto Basla; // Hata durumunda döngüyü tekrar başlat
    }

    if (!string.IsNullOrEmpty(islem)) // eğer islem bos veya null değilse islem switch bloguna geçer
    {
        switch (islem)
        {
            case "+":
                Console.WriteLine($"Toplamın sonucu: {sayı1 + sayı2}");
                break;
            case "-":
                Console.WriteLine($"Çıkarma sonucu: {sayı1 - sayı2}");
                break;
            case "/":
                if (sayı2 != 0) // 0 a bolunmiyeceği için 0 a eşit olmadıgı surece işlme gercekleşir 0 girerse hata alır
                {
                    Console.WriteLine($"Bölme sonucu: {sayı1 / sayı2}");
                }
                else
                {
                    Console.WriteLine("Bölme işlemi için ikinci sayı sıfır olamaz.");
                }
                break;
            case "*":
                Console.WriteLine($"Çarpma sonucu: {sayı1 * sayı2}");
                break;
            case "%":
                if (sayı2 != 0) // aynı sekilde modulun ikinci sayısı 0 olamaz
                {
                    Console.WriteLine($"Modülüs sonucu: {sayı1 % sayı2}");
                }
                else
                {
                    Console.WriteLine("Modülüs işlemi için ikinci sayı sıfır olamaz."); // 0 girerse bunu ekranda gorur
                }
                break;
            default:
                Console.WriteLine("Geçersiz işlem.");
                break;
        }
    }
    else
    {
        Console.WriteLine("İşlem Yapılmadı.");
    }

    Console.WriteLine("Tekrar denemek ister misiniz? (Evet/Hayır)");
    string devam = Console.ReadLine().Trim().ToLower(); // trim boslukları silmek icin to lower tum buyuk harflerı kucuk harfe cevirir
    if (devam == "evet") // evet derse // hayır derse sonlanır
    {
        goto Basla; // başa doner
    }
    
    
    

#endregion