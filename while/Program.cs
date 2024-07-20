// 

int i = 0;
while (i < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    i++;
}
Console.WriteLine();

Console.WriteLine("1 ile 20 arasındaki sayılar :");
 i = 1;
while (i <= 20)
{
    Console.WriteLine(i);
    i++;
}
Console.WriteLine();



Console.WriteLine("1 ile 20 arasındaki çift sayılar :");
i = 1;
while (i <= 20)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
    
    i++;
}
Console.WriteLine();






Console.WriteLine("50 ile 150 arasındaki sayıların toplamı :");
int sum = 0;
i = 50;
while (i <= 150)
{
    sum += i;
    i++;
}

Console.WriteLine(sum);
Console.WriteLine();




int sum_cift = 0;
int sum_tek = 0;
i = 1;
while (i <= 120)
{
    if (i % 2 == 0)
        sum_cift += i;
    else
        sum_tek += i;
    i++;
}

Console.WriteLine();
Console.WriteLine("1 ile 120 arasındaki çift sayıların toplamı :");
Console.WriteLine(sum_cift);

Console.WriteLine("1 ile 120 arasındaki tek sayıların toplamı :");
Console.WriteLine(sum_tek);
