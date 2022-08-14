void FillArray (int[] collection)
{
    int length = collection.Length;// обозначает длинну массива
    int index = 0;
    while (index < length) 
    {
       collection [index]= new Random().Next (1, 10);
        index++;
    }
}

void PrintArray (int [] col)
{
    int count = col.Length;//Кол-во элементов в массиве
    int position = 0;
    while (position < count)
    {
       Console.WriteLine (col [position]);
       position++; 
    }
}

int Indexof (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection [index] == find)
        {
            position = index;
        }
        index++;
    }

return position;
}


int [] array = new int [10];//по умолчанию массив будет заполнен нулями

FillArray(array);
PrintArray(array);
//что мы сделали:
//1. Определили массив из 10 элементов
//2.Сделали метод FillArray, который заполнил наш массив
//3/ Сделали метод PrintArray, который распечатал наш массив
Console.WriteLine();

int pos = Indexof (array, 8);
Console.WriteLine(pos);