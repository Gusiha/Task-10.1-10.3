using Task_10._3;

NumberArray numberArray = new(10);

// Добавление в делегат функции BubbleSort
SortDelegate delegates = BubbleSort;

#region Демонстрация функционала

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

// Сортировка пузырьком, которая идентична сигнатуре делегата - 1ое задание
void BubbleSort(NumberArray numbers)
{
    for (int i = 0, temp = 0; i < numbers.Amount - 1; i++)
    {
        for (int j = 0; j < numbers.Amount - i - 1; j++)
        {
            if (numbers[j] > numbers[j + 1])
            {
                temp = numbers[j + 1];
                numbers[j + 1] = numbers[j];
                numbers[j] = temp;
            }
        }

    }
}




