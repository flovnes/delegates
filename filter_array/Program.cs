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
            return [.. arr.Where((x) => check(x))];
        }

        
    }
}