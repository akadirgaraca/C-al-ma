// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string ogrenciAdı = "Abdül Kadir GARACA";
int ogrenciNO = 1074;
double ogrenciGno = 2.9;
Console.WriteLine("Öğrenci Bilgileri" + "\r\n" + "Öğrenci Adı:" + ogrenciAdı);


Console.WriteLine("Adınızı girniz");
string isim = Console.ReadLine();
Console.WriteLine("Soyadınızı giriniz:");
string soyisim = Console.ReadLine();
Console.WriteLine("İsim: " + isim + "\r\n" + "Soyisim: " + soyisim);

Console.WriteLine("Kenar değerini giriniz:");
int kenar = Convert.ToInt32(Console.ReadLine());
int cevre = kenar * 4;
Console.WriteLine("Çevre : " + cevre);

for (int i = 1; i < 4; i++)
{
    Console.WriteLine("Bakiyenizi Girin:");
    int bakiye = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Çekilecek tutar:");
    int cekilecek_para = Convert.ToInt32(Console.ReadLine());
    int kalan_bakiye = bakiye - cekilecek_para;
    Console.WriteLine("Kalan bakiyeniz:" + kalan_bakiye);


}
Console.ReadKey();