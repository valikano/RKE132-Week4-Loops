﻿int sum = 0;

for (int i = 1; i < 5; i++)
{

    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum += i;
}

//Console.WriteLine($"Final total {sum}");
