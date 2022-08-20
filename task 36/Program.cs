int[] number = { -4, -6, 89, 6 };

int i = 0;
double num = 10;
int notEven = 0;
do
{
    num = i;
    num = num / 2;
    if (num != (int)num)
    {
        notEven = notEven + number[i];
    }
    i++;
} while (i <= number.Length - 1);
Console.WriteLine(notEven);