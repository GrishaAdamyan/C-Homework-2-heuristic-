Console.WriteLine("enter the number of row:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of column:");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = { {2, 3, 4, 4, 4, 4, 3, 2 },
               {3, 4, 6, 6, 6, 6, 4, 3 },
               {4, 6, 8, 8, 8, 8, 6, 4 },
               {4, 6, 8, 8, 8, 8, 6, 4 },
               {4, 6, 8, 8, 8, 8, 6, 4 },
               {4, 6, 8, 8, 8, 8, 6, 4 },
               {3, 4, 6, 6, 6, 6, 4, 3 },
               {2, 3, 4, 4, 4, 4, 3, 2 }, };
int flag = 0;
int new_a = -1;
int new_b = -1;


do
{
    int count = movingKnight(a, b);
    a = new_a;
    b = new_b;
    Console.WriteLine("Continue? 1 or 0");
    int res = Convert.ToInt32(Console.ReadLine());
    if (res == 0 || count == 0){
        flag = 1;
        Console.WriteLine("You have stopped the code or there is no place for queen");
    }
}
while (flag == 0);


int movingKnight(int a, int b)
{
    int min = 9;
    int count = 0;
    matrix[a, b] = 9;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if ((a == i && b == j) || matrix[i, j] == 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("K ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if ((Math.Abs(a - i) == 2 && Math.Abs(b - j) == 1) || (Math.Abs(a - i) == 1 && Math.Abs(b - j) == 2))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(matrix[i, j] + " ");
                Console.ForegroundColor = ConsoleColor.White;
                count++;
                if (min > matrix[i, j])
                {
                    min = matrix[i, j];
                    new_a = i;
                    new_b = j;
                }
            }
            else
            {
                Console.Write("0 ");
            }
        }
        Console.WriteLine();
    }
    return count;
}