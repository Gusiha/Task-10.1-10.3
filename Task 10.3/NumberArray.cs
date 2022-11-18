namespace Task_10._3
{

    // делегат из задания 2
    delegate void SortDelegate(NumberArray numbers);

    internal class NumberArray
    {
        // Свойство для получения кол-ва элементов в массиве (для удобства)
        public int Amount { get; }

        private int[] _array;

        // Конструктор, в котором выделяется место под массив размера [amount] и заполняется рандомными числами от 0 до 100
        public NumberArray(int amount)
        {
            Amount = amount;
            Random rand = new();
            _array = new int[amount];

            for (int i = 0; i < _array.Length; i++)
            {
                _array[i] = rand.Next() % 100;
            }
        }

        public void Sort(SortDelegate sort)
        {
            // вызов делегата c проверкой на NULL (запускается функция сортировки)
            sort?.Invoke(this);
        }

        // Индексатор
        public int this[int i]
        {
            get
            {
                if (i < _array.Length)
                    return _array[i];
                else
                    throw new ArgumentOutOfRangeException();
            }
            set
            {
                if (i < _array.Length)
                    _array[i] = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }

        
        public int[] Copy()
        {
            int[] array = new int[_array.Length];
            for (int i = 0; i < _array.Length; i++)
            {
                array[i] = _array[i];
            }
            return array;
        }


    }
}
