using System;
class Task {
  static void Main() {
    int n = Convert.ToInt32(Console.ReadLine());
        bool isPrime=true;
        if (n==1){
            Console.WriteLine("not both");
        }
        else{
        for(int i=2;i<=(Convert.ToInt32(n^1)/2)+1;i++){
            if (n==2){
		countinue;
		}
	     if(n%i==0){
                isPrime=false;
                break;
            }
            }
            if(isPrime==true){
                Console.Write("number is prime");
            }
            else{
                Console.Write("number isn't prime");
        }
        }
  }
  
}
