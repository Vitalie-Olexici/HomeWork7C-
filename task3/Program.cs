// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };
        ReverseArrayPrint(array, array.Length - 1);
    }
Main();

void ReverseArrayPrint(int[] array, int index)
    {
        if (index >= 0)
        {
            Console.Write(array[index] + " ");
            ReverseArrayPrint(array, index - 1);
        }
    }