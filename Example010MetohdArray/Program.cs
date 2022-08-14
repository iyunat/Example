int [] array ={15, 92, 34, 74, 45, 63, 74, 58};

int n = array.Length;
int find = 74;
int index = 0;

while (index < n)
{
    if (array [index] == find)
    {
        Console.WriteLine(index);
        break;
    }
   // index= index+1;
   index++;
}


