namespace FilterArrayLab {
    public class Client {
        public delegate bool Filter(int num);
        public static void Main() {
            int k = int.Parse(Console.ReadLine());
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Filter checkIsDivisible = x => x % k == 0; 

            FilterLinq(array, checkIsDivisible);           
            FilterManual(array, checkIsDivisible);   
        }
        public static int[] FilterLinq(int[] arr, Filter check) {
            return arr.Where((x) => check(x)).ToArray();
        }

        public static int[] FilterManual(int[] arr, Filter check) {
            int new_size = 0;
            for (int i = 0; i < arr.Length; ++i)
                if (check(arr[i]))
                    new_size++;
            
            int[] new_arr = new int[new_size];
            for (int i = 0, j = 0; i < new_size; ++i) {
                if (check(arr[i]))
                    new_arr[j++] = arr[i];
            }

            return new_arr;
        }
    }
}