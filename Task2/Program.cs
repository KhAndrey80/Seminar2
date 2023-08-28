int [] array = {13, 452, 673, 47, 235, 676, 127, 348, 673};

int n = array.Length;

int find = 673;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        System.Console.WriteLine(index);
        break;
    }

 index++;   
}
