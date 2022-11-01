using System;
class Task {
  static void Main() 
  {
    int n = Convert.ToInt32(Console.ReadLine());
    int product=1;
    for(int i=1;i<=n;i++){
        product*=i;
    }
    Console.Write("product="+product);
  }
}