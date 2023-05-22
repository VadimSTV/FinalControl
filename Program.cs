/*Задача:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

Console.Write ("Задайте массив <= 3: ");
int n;
int.TryParse(Console.ReadLine()!, out n);
string[] Arr = new string[n];

void Array(string[] stringArr)      //create metod array
{
    for (int i = 0; i < stringArr.Length; i++)
    {
        Console.WriteLine("Введите {i + 1} элемент массива: ");
        stringArr[i] = Console.ReadLine()!;
    }
}
string[] newArr(string[] Arr)
{
    int n = 0;
    for (int i = 0; i < Arr.Length; i++)
    {
        if (Arr[i].Length <= 3)
            n++;
    }    
        string[] arrayRes = new string[n];
        int j = 0;
        for (int i = 0; i < Arr.Length; i++)
        {
            if (Arr[i].Length <= 3)
            {
                arrayRes[j] = Arr[i];
                j++;
            }
        }
        return arrayRes;
    }
    void printArr (string[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        Console.WriteLine(Arr[i] + " ");
    }
    Console.WriteLine();
}

Array(Arr);
printArr(newArr(Arr));