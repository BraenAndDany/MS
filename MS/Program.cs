using System.Text;

public class MASS
{

    public static void sprL(int[,]mass)
    {
        int dlina = 0;
        int score = 0;
        int top = 0, right = 0, down = 0,left=0;
        while (true)
        {
          
            if (mass.GetLength(0)==mass.GetLength(1))
            {
                for (int i = 0; i < mass.GetLength(1) - score; i++)
                {
                    Console.Write(mass[top, i + top]+" ");
                    dlina++;
                }
                score++;
                top++;
                if (dlina >= mass.Length)
                {
                    break;
                }
                for (int i = 0; i < mass.GetLength(0) - score; i++)
                {
                    Console.Write(mass[i + 1 + right, mass.GetLength(0) - 1 - right] + " ");
                    dlina++;
                }
                right++;
                if (dlina >= mass.Length)
                {
                    break;
                }
                for (int i = 0; i < mass.GetLength(1) - score; i++)
                {
                    Console.Write(mass[mass.GetLength(1) - 1 - down, mass.GetLength(1) - 2 - i - down] + " ");
                    dlina++;
                }
                down++;
                score++;
                if (dlina >= mass.Length)
                {
                    break;
                }
                for (int i = 0; i < mass.GetLength(0) - score; i++)
                {
                    Console.Write(mass[mass.GetLength(0) - 2 - i, left] + " ");
                    dlina++;
                }
                left++;
            }
            //*************************************//
            else if (mass.GetLength(0) <= mass.GetLength(1))
            {
                for (int i = 0; i < mass.GetLength(1) - score; i++)
                {
                    Console.Write(mass[top, i + top] + " ");
                    dlina++;
                }
                score++;
                top++;
                if (dlina >= mass.Length)
                {
                    break;
                }
                for (int i = 0; i < mass.GetLength(1)-(mass.GetLength(1)- mass.GetLength(0)) - score; i++)
                {
                    Console.Write(mass[i + 1 + right, mass.GetLength(1) - 1 - right] + " ");
                    dlina++;
                }
                right++;
                if (dlina >= mass.Length)
                {
                    break;
                }
                for (int i = 0; i < mass.GetLength(1) - score; i++)
                {
                    Console.Write(mass[mass.GetLength(0) - 1 - down, mass.GetLength(1) - 2 - i - down] + " ");
                    dlina++;
                }
                down++;
                score++;
                if (dlina >= mass.Length)
                {
                    break;
                }
                for (int i = 0; i < mass.GetLength(1)- (mass.GetLength(1) - mass.GetLength(0)) - score; i++)
                {
                    Console.Write(mass[mass.GetLength(0) - 2 - i, left] + " ");
                    dlina++;
                }
                left++;
            }
            //**************************************//
            else if(mass.GetLength(0) >= mass.GetLength(1))
            {
                for (int i = 0; i < mass.GetLength(1)-score; i++)
                {
                    Console.Write(mass[top, i + top] + " ");
                    dlina++;
                }
                score++;
                top++;
                if (dlina >= mass.Length)
                {
                    break;
                }
                for (int i = 0; i < mass.GetLength(0)-score; i++)
                {
                    Console.Write(mass[i + 1 + right, mass.GetLength(1) - 1 - right] + " ");
                    dlina++;
                }
                right++;
                if (dlina >= mass.Length)
                {
                    break;
                }
                for (int i = 0; i < mass.GetLength(1)-score; i++)
                {
                    Console.Write(mass[mass.GetLength(0) - 1 - down, mass.GetLength(1) - 2 - i - down] + " ");
                    dlina++;
                }
                down++;
                score++;
                if (dlina >= mass.Length)
                {
                    break;
                }
                for (int i = 0; i < mass.GetLength(0)-score; i++)
                {
                    Console.Write(mass[mass.GetLength(0) - 2 - i, left] + " ");
                    dlina++;
                }
                left++;
            }
            
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
