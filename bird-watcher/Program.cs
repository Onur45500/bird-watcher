public class Program
{
    public class BirdCount(int[] array)
    {

        public void LastWeek()
        {
            int[] lastWeek = { 0, 2, 5, 3, 7, 8, 4 };

            foreach (int number in lastWeek)
            {
                Console.WriteLine($"{number}");
            }
        }

        public void Today()
        {
            int count = array.Last();

            Console.WriteLine($"{count}");
        }

        // We will use GetUpperBound(0) to take the index of the last element and increment it.
        public void IncrementTodaysCount()
        {
            Console.WriteLine($"Last element index {array.GetUpperBound(0)} incremented from {array[array.GetUpperBound(0)]} => {++array[array.GetUpperBound(0)]}");
        }

        // Made a test with GetUpperBound(1) to see how it works with multiple dimensions.
        //public void IncrementTodaysCount2(char[,] array)
        //{
        //    Console.WriteLine($"Last element index {array.GetUpperBound(1)} incremented from {array[array.GetUpperBound(1),0]} => {++array[array.GetUpperBound(1),0]}");
        //}

        public bool HasDayWithoutBird()
        {
            foreach (int number in array)
            {
                if (number == 0)
                {
                    Console.WriteLine("Yes");
                    return true;
                }

                //Console.WriteLine($"{number}");
            }

            Console.WriteLine("No");
            return false;
        }

        public void CountForFirstDays(int numberOfDays)
        {
            if (numberOfDays > array.Length)
            {
                numberOfDays = array.Length;
            }
            for (int i = 0; i <= numberOfDays - 1; i++)
            {
                Console.WriteLine($"{array[i]}");
            }
        }

        public void BusyDays()
        {
            int count = 0;
            foreach (int number in array)
            {
                if (number >= 5)
                {
                    count++;
                }
            }

            Console.WriteLine($"Number of busy days : {count}");
        }

    }

    //static void Main(string[] args)
    //{

    //    //int[] table1 = new int[] // First method to initialise an array
    //    //{
    //    //    1, 2, 3, 4, 5
    //    //};

    //    //int[] table2 = new[] { 1, 3, 4, 5 }; // Second method

    //    //int[] table3 = { 1, 2, 3, 4, 5 }; // Third method

    //    //char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

    //    //foreach(char vowel in vowels)
    //    //{
    //    //    Console.WriteLine($"{vowel}");
    //    //}

    //    char[,] value = { { 'a', 'b' }, { 'c', 'd' },
    //                       { 'e', 'f' }, { 'g', 'h' },
    //                                   { 'i', 'j' } };

    //    int[] birdsPerDay = { 1, 5, 3, 4, 0, 6 };

    //    BirdCount birdCount = new BirdCount(birdsPerDay);
    //    birdCount.Today();

    //    birdCount.IncrementTodaysCount();

    //    //birdCount.IncrementTodaysCount2(value);

    //    birdCount.HasDayWithoutBird();

    //    birdCount.CountForFirstDays(1000);

    //    birdCount.BusyDays();
    //}
}