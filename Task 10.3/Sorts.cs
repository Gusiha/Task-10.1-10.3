namespace Task_10._3
{
    
    static class QuickSortClass
    {
        public static void QuickSort(NumberArray number)
        {
            int[] array = number.Copy();

            array = QSort(array, 0, array.Length - 1);

            for (int i = 0; i < number.Amount; i++)
            {
                number[i] = array[i];
            }
        }

        static int[] QSort(int[] array, int startIndex, int finishIndex)
        {
            if (startIndex >= finishIndex)
            {
                return array;
            }

            int pivotIndex = GetPivotIndex(array, startIndex, finishIndex);

            // рекурсия с левым и правым подмассивами
            QSort(array, startIndex, pivotIndex - 1);
            QSort(array, pivotIndex + 1, finishIndex);

            return array;
        }

        static int GetPivotIndex(int[] array, int startIndex, int finishIndex)
        {
            int pivot = startIndex - 1;

            for (int i = startIndex; i <= finishIndex; i++)
            {
                if (array[i] < array[finishIndex])
                {
                    pivot++;
                    Swap(ref array[pivot], ref array[i]);
                }
            }

            // перестановка опорного элемента(pivot)
            pivot++;
            Swap(ref array[pivot], ref array[finishIndex]);

            return pivot;
        }

        static void Swap(ref int left, ref int right)
        {
            int temp = left;
            left = right;
            right = temp;
        }
    }

    static class BubbleSortClass
    {
        public static void BubbleSort(NumberArray numbers)
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

    }


}

