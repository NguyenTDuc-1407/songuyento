﻿Console.WriteLine("Danh sach so nguyen to :");
for (int i = 2; i <= 100; i++)
{
    int dem = 0;
    for (int j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            dem++;
        }
    }

    if (dem == 2)
    {
        Console.WriteLine(i);
    }
}