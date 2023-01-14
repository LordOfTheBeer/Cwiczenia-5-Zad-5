namespace Cwiczenia_5_Zad_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj iloś elementow");
            int ile;
            ile = Convert.ToInt16(Console.ReadLine());

            double[] t1 = new double[ile];
            for (int i = 0; i < t1.Length; i++)
            {
                Console.WriteLine("Podaj element " + i);
                t1[i] = Convert.ToDouble(Console.ReadLine());
            }
            double min, max;
            min = t1[0]; max = t1[0];
            for (int k = 1; k < t1.Length; k++)
            {
                if (t1[k] < min)
                    min = t1[k];
                if (t1[k] > max)
                    max = t1[k];

            }

                Console.WriteLine("min = " + min + "\tmax = " + max);
                
        }
    }
}