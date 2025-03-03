namespace TimerLab {
    public class Timer {
        private int t;
        public delegate void targetFunction();
        private bool active;
        private Thread timerThread;
        
        public Timer(targetFunction func, int time) {
            t = time;
            active = true;
            timerThread = new Thread(() => Start(func));
            timerThread.IsBackground = true;
            timerThread.Start();
        }
       
        private void Start(targetFunction func) {
            while (active) {
                func();
                Thread.Sleep(t);
            }
        }
        
        public void Stop() {
            active = false;
            if (timerThread.IsAlive) timerThread.Join();
        }
    }
    
    public class Client {
        public static void MyFunc() {
            Console.WriteLine("timer tick .");
        }
        
        public static void Main() {
            Timer timer = new(MyFunc, 1000);
            Timer other_timer = new(MyFunc, 1000);
                Console.WriteLine("something from the main");
            Console.ReadLine();
            timer.Stop();
        }
    }
}