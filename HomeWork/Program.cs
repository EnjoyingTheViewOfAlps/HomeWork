using System.ComponentModel;
using System.Numerics;

Console.WriteLine("Выберите задание:\n 1) Opposite;\n 2) IsSymmetric;\n 3) Max/Min");
int task = Convert.ToInt32(Console.ReadLine());
switch(task)
{
    case 1:
        Console.Clear();
        Opposite();
        break;
    case 2:
        Console.Clear();
        Symmetric();
        break;
    case 3:
        Console.Clear();
        MaxMin();
        break;
}



void Opposite()
{
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] counts = new int[N];
    int Numbers;

    Console.WriteLine("Заполните ваш массивчик");
    for (int i = 0; i < N; i++)
    {
        Numbers = Convert.ToInt32(Console.ReadLine());
        counts[i] = Numbers;
    }

    if (N >= 1 && N <= 100)
    {
        isOpposite(counts);
    }

    void isOpposite(int[] m)
    {
        for (int i = 0; i < m.Length; i++)
        {
            for (int j = 0; j < m.Length; j++)
            {
                if (m[i] == m[j] * -1)
                {
                    Console.WriteLine("Индекс противоположных чисел:");
                    Console.Write(i + " ");
                    Console.Write(j);
                    return;
                }
            }
        }
    }
}


void Symmetric()
{
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[N, N];
    int z;
    if (N <= 100)
    {
        Create(matrix);
        isMatrixSymmetric(matrix);
    }
    else { return; }

    void Create(int[,] m)
    {
        Console.WriteLine("Заполните массивчик:");
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine($"Введите элементы строки {i + 1} через пробел:");
            string[] input = Console.ReadLine().Split(' ');

            for (int j = 0; j < N; j++)
            {
                if (int.TryParse(input[j], out z))
                {
                    m[i, j] = z;
                }
            }
        }
    }

    bool isMatrixSymmetric(int[,] m)
    {
        bool Sym = false;
        int count = 0; 
        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i != j)
                {
                    if (m[i, j] == m[j, i])
                    {
                        count++;
                    }
                }
            }
        }
        if (count == N)
        { 
            Sym = true; 
            Console.WriteLine("yes");
        }
        if (Sym == false) 
        { 
            Console.WriteLine("no"); 
        }
        return Sym;
    }
}

void MaxMin()
{
    Console.WriteLine("Введите число N");
    int N = Convert.ToInt32(Console.ReadLine());
    int[] days = new int[N];
    int C;
    Console.WriteLine("Введите градусы");
    for (int i = 0; i < N; i++)
    {
        C = Convert.ToInt32(Console.ReadLine());
        days[i] = C;
    }
    if (N >= 3)
    {
        maxMin(days);
    }
    void maxMin(int[] m)
    {
        for (int i = 1; i < N - 1; i++)
        {
            if (m[i - 1] > m[i] && m[i] < m[i + 1])
            {
                Console.WriteLine($"day {i + 1} : {m[i]} (min)");
            }
            else if (m[i - 1] < m[i] && m[i] > m[i + 1])
            {
                Console.WriteLine($"day {i + 1} : {m[i]} (max)");
            }
        }
    }
}