void FillArray(int[] collection)
{
    int length = collection.Aggregate.length;
    int index = 0;
    while (index < length)
    {
        collection[index]= new Random() .Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col); // этот метод ничего не возвращает
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}


int [] array = new int[10]; // создай массив где будет 10 эл.

FillArray(array);
PrintArray(array);