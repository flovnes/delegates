namespace FilterArrayLab {
    public class Client {
        public delegate double Function(int x);
        public static void Main() {
            Function[] functions = new Function[3];

            Function sqrtabs = x => Math.Sqrt(Math.Abs(x));
            Function cube = x => x*x*x;
            Function add = x => x + 3.5;

            functions[0] = sqrtabs;
            functions[1] = cube;
            functions[2] = add; 
            
            Console.WriteLine("0 -- sqrt(abs(x))\n1 -- x^3\n2 -- x + 3.5\n");

            while(true) {
                try {
                    string[] data = Console.ReadLine().Trim().Split();
                    int choise = int.Parse(data[0]);
                    int value = int.Parse(data[1]);
                    
                    Function chosenFunction = functions[choise];

                    Console.WriteLine(chosenFunction(value));
                } catch {
                    Console.WriteLine("goodbye cruel world");
                    break;
                }
            }
        }
    }
}