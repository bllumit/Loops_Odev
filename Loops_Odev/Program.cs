// 2)
// Kullanıcı ve şifre istenecek, kullanıcı adı admin ve şifre 123 ise hoş geldin admin mesajı verilip döngü bir daha dönemeyecek şekilde sonlandırılacak. Not : öğrettiklerim dışında birşey kullanmayın...
// Eğer kullanıcıadı veya şifre yanlış ise kullanıcıya bilgileriniz yanlış mesajı verilecek. Kullanıcı bilgileri en fazla 3 kez hatalı girebilecek. Eğer 3'kezde hatalı girerse hesabınız bloke oldu mesajı verilip yine döngü sonlandırılacak..


string kullaniciAdi = "";
string kullaniciSifre = "";

int girisHakki = 3;

while (girisHakki > 0)
{
    Console.WriteLine("Kullanıcı Adınızı Yazınız");
    kullaniciAdi = Console.ReadLine();

    Console.WriteLine("Kullanıcı Şifrenizi Yazınız");
    kullaniciSifre = Console.ReadLine();
    girisHakki--;

    if (kullaniciAdi == "admin" || kullaniciAdi == "ADMIN" && kullaniciSifre == "123")
    {
        Console.WriteLine("Hoşgeldin Admin");
        break;
    }
    else
    {
        Console.WriteLine("Hatalı Kullanıcı Adı veya Şifre Girdiniz");
        Console.WriteLine(" ");
    }
    if (girisHakki == 0)
    {
        Console.WriteLine("Hesabının Bloke Olmuştur!!!");
    }
}

Console.ReadLine();

//------------------------------------------------------------------------------------------------------------------------------------------

// 1) 
// N adet öğrencinin vize final notu istenecek..
// vize ve finalden n öğrencinin ortalama hesaplanacak
// n adet öğrenciden En büyük ve En düşük ortalamıy notu ekrana yazdırınız..
// Sınıf ortalamasını ekrana yazdırınız...

//BU SORUNUN İÇİNDEN ÇIKAMADIM.....

//float vize, final, ortalama;
//int ogrenci = 5;

//while (ogrenci > 0)
//{
//    Console.WriteLine("Vize Notunuz: 0 - 100 arası bir değer giriniz");
//    vize = Convert.ToSingle(Console.ReadLine());

//    Console.WriteLine("Final: 0 - 100 arası bir değer giriniz");
//    final = Convert.ToSingle(Console.ReadLine());

//    ortalama = vize * 0.5f + final * 0.4f;
//    Console.WriteLine("Ortalamanız:" + " " + ortalama);
//    Console.WriteLine(" ");

//    ogrenci--;

//    if (ortalama >= 75)
//    {
//        Console.WriteLine("En Yüksek Ortalama" + ortalama);
//    }
//    else if (ortalama <= 25)

//        Console.WriteLine("En Düşük Ortalama" + ortalama);

//}


