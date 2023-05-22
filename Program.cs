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