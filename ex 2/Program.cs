Console.Clear();

Console.WriteLine("Enter array size:");
int size = Convert.ToInt32(Console.ReadLine());
string[] MyArray = new string[size];

Console.WriteLine($"Enter your array:");


void PrintArray(string[] array)
{


    Console.Write($"[ {String.Join(", ", array)} ]");
}


void FillArrayPerson(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        Console.WriteLine($"Enter number fot this position: ({i + 1})");
        array[i] = Console.ReadLine();
    }
}

FillArrayPerson(MyArray);
PrintArray(MyArray);



for (int i = 0; i < size; i++)
{
    {


        if (MyArray[i].Length < 4)
        {
            MyArray[i] = MyArray[i];

        }
        else
        {
            MyArray[i] = "-";
        }


    }
}



PrintArray(MyArray);





