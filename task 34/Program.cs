int[] number = { 345, 897, 568, 234 };
int i = 0;
int Even = 0;
double num = 10;
do
{
    num = number[i];
    num = num / 2;
    if (num == (int)num)
    {
        Even++;
    }
    i++;
} while (i <= number.Length - 1);
Console.WriteLine(Even);
