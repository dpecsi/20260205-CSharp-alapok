namespace _20260205___CSharp_alapok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int szám;
            szám = 5;

            int szám2 = -18;

            const double PI = 3.14159;

            szám = szám2 + 10;
            szám = szám2 - 10;
            szám = szám2 * 10;
            szám = szám2 / 10;  // egész osztás
            double eredmény = PI / 18.0; // valós osztás
            // valami megjegyzés
            /*
             több soros megjegyzés
             több soros megjegyzés
             */
            szám = szám2 % 10; // maradákos osztás
            szám2 = 180;
            eredmény = szám2 / 18.0; // valós osztás
            szám = Convert.ToInt32(szám2 / 18.0); // valós osztás eeedményét egészre konvertáljuk
            eredmény = szám2 / 18; // valós osztás, mert a szám2 egy int, de a 18 egy int literal

            Console.Write(szám);
            Console.Write(eredmény);
            Console.WriteLine();
            Console.WriteLine("Hello, World!");
        }
    }
}
