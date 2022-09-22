void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        Console.WriteLine(collection[index]);
        index = index + 1;

    }
}

void PrintArray(int[] mass)

{
    int count = mass.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(mass[position]);
        position++;
    }

}

int indexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0; 
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
        }

            index++;

    }
    return position; 
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int rus = indexOf(array, 4);
