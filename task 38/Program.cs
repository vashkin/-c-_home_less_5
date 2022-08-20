int[] num = { 3, 7, 22, 2, 78 };
Array.Sort(num);
int minValue = num[0];
int maxValue = num[num.Length - 1];
int diffValue = maxValue - minValue;
Console.WriteLine(diffValue);