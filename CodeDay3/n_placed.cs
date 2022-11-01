using System;
class HelloWorld {
    static void Main() {
        long n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        if (n == 0)
        {
            Console.WriteLine(1);
        }
        else {
            while (n > 0) {
                n = n / 10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}
