namespace Hafta_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N degerini giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int[,] matris = new int[sayi, sayi];
            Random rastgele = new Random();
            Console.WriteLine("Matris: ");
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    matris[i, j] = rastgele.Next(-9, 10);
                    Console.Write(" " + matris[i, j] + " ");
                }
                Console.WriteLine();
            }
            int tplm1 = 0;
            for (int i = 0; i < sayi; i++)
            {
                tplm1 = tplm1 + matris[i, i];
            }
            int carpim = 1;
            for (int i = 0; i < sayi; i++)
            {
                carpim = carpim * matris[i, sayi - 1 - i];
            }
            int negatif = 0;
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    if (matris[i, j] < 0)
                    {
                        negatif++;
                    }
                }
            }
            int encoksayi = matris[0, 0];
            int encoktekrar = 1;

            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    int sayi2 = matris[i, j];
                    int sayac = 0;
                    for (int x = 0; x < sayi; x++)
                    {
                        for (int y = 0; y < sayi; y++)
                        {
                            if (matris[x, y] == sayi2)
                                sayac++;
                        }
                    }
                    if (sayac > encoktekrar || (sayac == encoktekrar && sayi2 < encoksayi))
                    {
                        encoktekrar = sayac;
                        encoksayi = sayi2;
                    }
                }
            }
            int toplam2 = 0, asal2 = 0;
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    toplam2 = toplam2 + matris[i, j];
                    asal2++;
                }
            }
            Console.WriteLine("Asal köşegen toplamı: " + tplm1);
            Console.WriteLine("Yardımcı köşegen çarpımı: " + carpim);
            Console.WriteLine("Negatif sayı sayısı: " + negatif);
            Console.WriteLine("En çok tekrar eden sayı: " + encoksayi + " (Tekrar: " + encoktekrar + ")");
            int asaltoplam = 0;
            int asaladet = 0;
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    int sayi2 = matris[i, j];
                    bool asal = true;

                    if (sayi2 < 2)
                        asal = false;
                    else
                    {
                        for (int k = 2; k * k <= sayi2; k++)
                        {
                            if (sayi % k == 0)
                            {
                                asal = false;
                                break;
                            }
                        }
                    }
                    if (asal)
                    {
                        asaltoplam += sayi2;
                        asaladet++;
                    }
                }
            }
            if (asaladet == 0)
                Console.WriteLine("Asal sayı yok.");
            else
            {
                double ortalama = asaltoplam / (double)asaladet;
                Console.WriteLine("Asal sayıların ortalaması: " + ortalama);
            }
            int[,] yeni = new int[sayi, sayi];
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    yeni[j, sayi - 1 - i] = matris[i, j];
                }
            }
            Console.WriteLine("Matrisin 90 derece döndürülmüş hali:");
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < sayi; j++)
                {
                    Console.Write(yeni[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

