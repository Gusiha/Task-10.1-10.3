using System.Diagnostics;
using Task_10._3;
using static Task_10._3.BubbleSortClass;
using static Task_10._3.QuickSortClass;



NumberArray numberArray = new(10);
NumberArray numberArray1 = new(10);
// Добавление в делегат функции BubbleSort
SortDelegate delegates = BubbleSort;

#region Демонстрация функционала (Bubble Sort + копирование)

// Копирование массива
int[] newArr = numberArray.Copy();

// Вывод изначального состояния
Console.Write("Изначальный массив: ");
for (int i = 0; i < numberArray.Amount; i++)
{
    Console.Write($"{numberArray[i]} ");
}
Console.WriteLine();

// Сортировка через делегат 
numberArray.Sort(delegates);

Console.Write("Отсортированный массив: ");

// Вывод после сортировки
for (int i = 0; i < numberArray.Amount; i++)
{
    Console.Write($"{numberArray[i]} ");
}
Console.WriteLine();

for (int i = 0; i < newArr.Length; i++)
{
    Console.Write($"{newArr[i]} ");
}
#endregion

// Очищаем делегат от BubbleSort
delegates -= BubbleSort;


#region Демонстрация функционала (Quick Sort c копированием)

delegates += QuickSort;

Console.WriteLine();
Console.Write("Изначальный массив: ");
for (int i = 0; i < numberArray1.Amount; i++)
{
    Console.Write($"{numberArray1[i]} ");
}
Console.WriteLine();

// Сортировка через делегат 
numberArray1.Sort(delegates);

Console.Write("Отсортированный массив: ");

// Вывод после сортировки
for (int i = 0; i < numberArray1.Amount; i++)
{
    Console.Write($"{numberArray1[i]} ");
}
Console.WriteLine();
delegates -= QuickSort;
#endregion




#region Несколько экземпляров делегатов
Console.WriteLine("Choose sorting variant: \n1. QuickSort;\n2. Bubble Sort.");
string choice = Console.ReadLine();
if (choice == "1")
    delegates += QuickSort;
else
    delegates += BubbleSort;

NumberArray numArr = new(30000);

Stopwatch timer = new();
timer.Start();
numArr.Sort(delegates);
timer.Stop();
TimeSpan huh = timer.Elapsed;
Console.WriteLine(String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            huh.Hours, huh.Minutes, huh.Seconds,
            huh.Milliseconds / 10));
#endregion
