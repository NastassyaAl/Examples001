int[] array = { 1, 28, 3, 14, 5, 65, 7, 8 };

int n = array.Length;

int find = 28;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}