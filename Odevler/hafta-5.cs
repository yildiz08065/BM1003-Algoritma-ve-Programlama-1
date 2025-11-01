namespace Hafta_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] dizi = new int[5,3];
            Random random = new Random();
            Console.WriteLine("Matris: ");

            for(int i =0; i < 5; i++)
            {
                Console.Write("[");
                for (int j = 0; j < 3; j++)
                {
                    dizi[i, j] = random.Next(0, 10);
                    Console.Write(dizi[i, j] );
                    if(j < 2)
                        Console.Write(", ");
                }
                Console.WriteLine("]");
            }
            Console.WriteLine("");
            Console.WriteLine("Sütun Toplamları: ");
            Console.Write("Sütun 1 : ");
            int st1 = 0;
            for (int i = 0; i < 5; i++)
            {
                st1 = st1 + dizi[i, 0];
            }
            Console.Write(st1);
            Console.WriteLine("");
            Console.Write("Sütun 2 : ");
            int st2 = 0;
            for (int i = 0; i < 5; i++)
            {
                st2 = st2 + dizi[i, 1];
            }
            Console.Write(st2);
            Console.WriteLine("");
            Console.Write("Sütun 3 : ");
            int st3 = 0;
            for (int i = 0; i < 5; i++)
            {
                st3 = st3 + dizi[i, 2];
            }
            Console.Write(st3);
        }
    }
}
