using System.ComponentModel;
using System.Text.Json;

namespace csharpodev
{
    public class Odev
    {
        public static void Main()
        {
            string devamMi = "";
            Boolean hataliMi;
            do
            {
                Console.Clear();
                Console.Write("Boyunuzu m cinsinden Giriniz : ");
                double boy = Convert.ToDouble(Console.ReadLine());
                Console.Write("Kilonuzu Giriniz : ");
                double kilo = Convert.ToDouble(Console.ReadLine());
                double sonuc = kilo / Math.Pow(boy, 2);

                if (sonuc < 18.49)
                {
                    Console.WriteLine("Hastanın; boyu: {0}, kilosu {1}, VKI indeksi: {2}, Teşhis: Zayıf", boy, kilo, sonuc);
                }
                else if (sonuc > 18.5 && sonuc < 24.99)
                {
                    Console.WriteLine("Hastanın; boyu: {0}, kilosu {1}, VKI indeksi: {2}, Teşhis: İDEAL", boy, kilo, sonuc);
                }
                else if (sonuc > 25 && sonuc < 29.99)
                {
                    Console.WriteLine("Hastanın; boyu: {0}, kilosu {1}, VKI indeksi: {2}, Teşhis: HAFİF KİLOLU", boy, kilo, sonuc);
                }
                else
                {
                    Console.WriteLine("Hastanın; boyu: {0}, kilosu {1}, VKI indeksi: {2}, Teşhis: OBEZ", boy, kilo, sonuc);
                }
                do
                {
                    Console.Write("Yeni bir hesaplama yapmak istiyor musunuz? (E/H)");

                    devamMi = Console.ReadLine();
                    if (devamMi == "E" || devamMi == "e" || devamMi == "H" || devamMi == "h")
                    {

                        hataliMi = false;
                    }
                    else
                    {
                        hataliMi = true;
                        Console.WriteLine("Hatalı giriş yaptınız");
                    }
                } while (hataliMi == true);
            } while (devamMi == "E" || devamMi == "e");
        }
    }
}


