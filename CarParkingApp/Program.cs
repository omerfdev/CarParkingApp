using System.Threading.Channels;
namespace CarParkingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MainPage();
            Calculate(Choose(), GetTime());
        }
        private static void MainPage()
        {
            string[] tasitlar = { "=> Arabalar için 1 giriniz", "=> Motorsiklet için 2 giriniz", "=> Minibüs için 3 giriniz", "=> Kamyon (ve diğer ticari araçlar) için 4 giriniz" };
            foreach (string s in tasitlar)
            {
                Console.WriteLine(s);
            }
        }
        private static string Choose()
        {
            string choose = Console.ReadLine();
            for (int i = 0; i < choose.Length; i++)
            {
                if (!char.IsDigit(choose[i]))
                {
                    Console.WriteLine("Yanlış Seçim 1-2-3-4 rakamlarından birini giriniz");
                    return Choose();
                }

            }

            return choose;
        }
        private static double GetTime()
        {
            Console.WriteLine("Saat Bilgisini giriniz");
            if (double.TryParse(Console.ReadLine(), out double time))
            {
                return time;
            }
            else
            {
                Console.WriteLine("Yanlış saat bilgisi Örnek 2,5");
                return GetTime();

            }


        }
        private static void Calculate(string choose, double time)
        {
            switch (choose)
            {
                case "1":
                    if (time <= 2) { double hesap = 5; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else if (time <= 6 && time > 2) { double hesap = 10; Console.WriteLine(hesap + " TL"); Console.ReadLine(); ; }
                    else if (time <= 12 && time > 6) { double hesap = 20; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else if (time <= 24 && time > 12) { double hesap = 35; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else
                    {
                        int sayac = 0;
                        while (time >= 0)
                        {

                            time = time - 24;

                            if (time <= 0) { double hesap = 35 + (sayac * 20); Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                            sayac++;
                        }


                    }


                    break;

                case "2":
                    if (time <= 2) { double hesap = 0; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else if (time <= 6 && time > 2) { double hesap = 3; Console.WriteLine(hesap + " TL"); Console.ReadLine(); ; }
                    else if (time <= 12 && time > 6) { double hesap = 6; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else if (time <= 24 && time > 12) { double hesap = 12; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else
                    {
                        int sayac = 0;
                        while (time >= 0)
                        {

                            time = time - 24;
                            sayac++;
                            if (time <= 0) { double hesap = 12 + (sayac * 10); Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                        }
                    }

                    break;

                case "3":
                    if (time <= 2) { double hesap = 8; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else if (time <= 6 && time > 2) { double hesap = 16; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else if (time <= 12 && time > 6) { double hesap = 32; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else if (time <= 24 && time > 12) { double hesap = 45; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else
                    {
                        int sayac = 0;
                        while (time >= 0)
                        {

                            time = time - 24;
                            sayac++;
                            if (time <= 0) { double hesap = 45 + (sayac * 25); }
                        }
                    }

                    break;
                case "4":
                    if (time <= 2) { double hesap = 15; Console.WriteLine(hesap); }
                    else if (time <= 6 && time > 2) { double hesap = 30; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else if (time <= 12 && time > 6) { double hesap = 60; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else if (time <= 24 && time > 12) { double hesap = 100; Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                    else
                    {
                        int sayac = 0;
                        while (time >= 0)
                        {

                            time = time - 24;
                            sayac++;
                            if (time <= 0) { double hesap = 100 + (sayac * 55); Console.WriteLine(hesap + " TL"); Console.ReadLine(); }
                        }
                    }


                    break;
                default:
                    Console.WriteLine("Yanlış Giriş Yaptınız"); Calculate(choose, time);
                    break;
            }



        }

    }
}



      
       

