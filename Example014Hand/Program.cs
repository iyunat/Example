﻿
//int Factorial (int n)
//{
    //1!=1
    //0!=1
 //   if (n==1) return 1;
 //   else return n * Factorial (n-1);
//}

//Console.WriteLine(Factorial(3));//1*2*3=6

//double Factorial (int n)
//{
    //1!=1
    //0!=1
  //  if (n==1) return 1;
    //else return n * Factorial (n-1);
//}
//for (int i=1; i<40; i++)
//{
  //  Console.WriteLine($"{i}! = {Factorial(i)}");//  тип данных int не вмещает все числа, поэтому числа выводятся с -. 
//} // в этом случае можно использовать тип данных double


//Фибоначчи

int Fibonacci(int n)
{
    if(n==1 || n==2) return 1;
    else return Fibonacci(n-1) + Fibonacci (n-2);
}

for (int i=1; i<10; i++)
{
    Console.WriteLine(Fibonacci(i));

}