//Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
//лучше обойтись исключительно массивами.

// 1. Создать массив [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// 2. Пройтись по каждому слову массива
// 3. Сравнить длину слова с 3
// 4. Создать новый массив


// void FillArray()
// {
//     Console.WriteLine("Enter an array size: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     for (int i = 0; i<size; i++)
//     {
//         array [i] = Console.ReadLine();
//     }
// }

//Метод печать массива
void PrintArray(string[] array)
{
    System.Console.WriteLine();
    for (int i = 0; i<array.Length; i++)
    {
        System.Console.Write(array [i] +" ");
    }
}

//Проверяем
string[] a = new string[] {"Hello","2", "world", ":-)"};
PrintArray(a);

//Узнать размер массива
int GetSize(string[] array)
{
    int size = 0;
        for (int i = 0; i<array.Length; i++)
    {
        if (array [i].Length <=3)
        {
            size = size + 1;
        }
    }
    return size;
}

//Проверяем
//System.Console.WriteLine(GetSize(a));

//Создаем новый массив с нужной размерностью
string[] b = new string[GetSize(a)];

//Заполняем массив Б элементами массива А меньше или равно трем символам
void FillArray(string[] ArrayA, string[] ArrayB)
{
    int j = 0;
     for (int i = 0; i<ArrayA.Length; i++)
    {
        if (ArrayA [i].Length <=3)
        {
            ArrayB[j] = ArrayA [i];
            j = j+1;
        }
    }
}
FillArray(a,b);
PrintArray(b);