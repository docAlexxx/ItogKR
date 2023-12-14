//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 


string[] fillArray(int size)
{
    string[] array = new string[size];
    for (int index = 0; index < size; index++)
    {
        array[index] = fillElement(index);
    }
    return array;
}

string fillElement(int index)
{
    System.Console.Write($"Введите {index + 1}-й элемент: ");
    return Console.ReadLine();
}

void printArray(string[] array)
{
    System.Console.WriteLine($"[{string.Join(", ", array)}]");
}

int getEndSize(string[] array)
{
    int size = 0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index].Length < 4)
        {
            size++;
        }
    }
    return size;
}

string[] fillEndArray(string[] array, int size)
{
    string[] endArray = new string[size];
    int endIndex=0;
    for (int index = 0; index < array.Length; index++)
    {
        if (array[index].Length < 4)
        {
           endArray[endIndex]=array[index];
           endIndex++;
        }
    }
    return endArray;
}



System.Console.Write("Введите количество элементов массива: ");
int startSize = Convert.ToInt32(Console.ReadLine());
string[] startArray = fillArray(startSize);
printArray(startArray);
int endSize = getEndSize(startArray);
if (endSize == 0)
{
    System.Console.Write("Не найдено элементов c длиной меньше 4 символов");
}
else
{
    string[] endArray = fillEndArray(startArray,endSize);
    System.Console.WriteLine("Элементы с длиной меньше 4 символов:");
    printArray(endArray);
}
