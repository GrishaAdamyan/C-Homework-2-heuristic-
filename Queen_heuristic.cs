﻿Console.WriteLine("enter the number of row (0-7):");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter the number of column (0-7):");
int b = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[8, 8];
int flag = 0;

do
{
    int count = addingQueen(a, b);
    print_matrix();
    Console.WriteLine("Continue? 1 or 0");
    int res = Convert.ToInt32(Console.ReadLine());
    if (res == 1 && count != 0)
    {
        a = -1;
        b = -1;
        int max = 100;
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                if (matrix[i, j] != 1 && matrix[i, j] != 9)
                {
                    int min = checking_position(i, j);
                    if (min <= max)
                    {
                        max = min;
                        a = i;
                        b = j;
                    }
                }
            }
        }
    }
    else
    {
        Console.WriteLine("You have stopped the code or there is no place for queen");
        flag = 1;
        break;
    }
}
while (flag == 0);

void print_matrix(){
    for (int k = 0; k < 8; k++)
    {
        for (int l = 0; l < 8; l++)
        {
            if (matrix[k, l] == 9)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Q ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (matrix[k, l] == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("1 ");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write("0 ");
            }
        }
        Console.WriteLine();
    }
}

int addingQueen(int a, int b)
{
    int count = 0;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (a == i && b == j)
            {
                matrix[i, j] = 9;
            }
            else if (matrix[i, j] == 1 || matrix[i, j] == 9)
            {
                continue;
            }
            else if ((Math.Abs(a - i) == Math.Abs(b - j)) || a == i || b == j)
            {
                matrix[i, j] = 1;
            }
            else
            {
                count++;
            }
        }
    }
    return count;
}

int checking_position(int a, int b)
{
    int count1 = 0;
    for (int i = 0; i < 8; i++)
    {
        for (int j = 0; j < 8; j++)
        {
            if (a == i && b == j)
            {
                continue;
            }
            else if ((Math.Abs(a - i) == Math.Abs(b - j)) || a == i || b == j)
            {
                if (matrix[i, j] == 0)
                {
                    count1++;
                }
            }
        }
    }
    return count1;
}