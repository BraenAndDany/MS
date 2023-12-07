using System.Text;

public class MASS
{

    public static void sprL(int[,]mass)
    {
        int dlina = 0;
        int shirina = 1;
        int k = 2,h=0;
        while (true)
        {
            shirina--;
            for (int i = 0+dlina; i < mass.GetLength(1); i++)
            {
                Console.WriteLine(mass[shirina, i-shirina]);
            }
            shirina++;
            if (shirina >= mass.GetLength(0)-1)
            {
                break;
            }
            for (int i = 0+shirina; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[i, mass.GetLength(1) - shirina]);
            }
            dlina++;
            for(int i = 0+dlina;i < mass.GetLength(1); i++)
            {
                Console.WriteLine(mass[mass.GetLength(0)-shirina,mass.GetLength(1)-dlina-i]);
            }
            shirina++;
            for (int i = 0+shirina; i < mass.GetLength(0); i++)
            {
                Console.WriteLine(mass[mass.GetLength(0)-k, h]);
                k++;
            }
            k = 2;
            h++;
            dlina++;
            
        }
    }
    static void Main(string[] args)
    {
        int n=Convert.ToInt32(Console.ReadLine());
        int m=Convert.ToInt32(Console.ReadLine());
        int[,]mass = new int[n, m];
        Random rnd = new Random();
        for (int i = 0; i<n ; i++)
        {
            for (int j = 0;j<m;j++)
            {
                mass[i,j] = rnd.Next(1, 10);
                Console.Write(mass[i,j]+" ");
            }
            Console.WriteLine();
        }
        sprL(mass);
    }
}
