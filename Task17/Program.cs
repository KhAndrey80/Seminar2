//Программа, которая задает массив из 8 элементов и выводит на экран.
int [] array = new int[8];

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] array)
{
    string arrayOutput = String.Join(", ", array);
    System.Console.WriteLine("[" + arrayOutput + "]");
}

FillArray(array);
PrintArray(array);

