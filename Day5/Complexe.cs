namespace _30_day_c__chalenge.Day5
{
    internal class Complexe
    {
        private int id;
        private static int count = 1;
        private int[] a = new int[2];

        public Complexe(int R, int C)
        {
            a[0] = R;
            a[1] = C;
            Console.WriteLine($"Nombre Complexe {count} : {a[0]}{sign()}{a[1]}i");
            id = count;
            count++;
        }
        public override string ToString()
        {
            return $"Nombre Complexe {id}: {a[0]} {sign()}{a[1]}i";
        }
        private string sign()
        {
            return a[1] > 0 ? "+" : "";
        }
        private static string signt(int c)
        {
            return c > 0 ? "+" : "";
        }
        public static void Plus(Complexe c1, Complexe c2)
        {
            int r = c1.a[0] + c2.a[0];
            int c = c1.a[1] + c2.a[1];
            Console.WriteLine($"La Somme \n {r} {signt(c)}{c}i");
        }
        public static void Minus(Complexe c1, Complexe c2)
        {
            int r = c1.a[0] - c2.a[0];
            int c = c1.a[1] - c2.a[1];
            Console.WriteLine($"La Différénce \n {r} {signt(c)}{c}i");
        }
    }
}
