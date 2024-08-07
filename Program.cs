using System;
namespace SayHello{
    class Program{
        static void Main(string[] args){
            Console.WriteLine("Vui Lòng Cho Biết Tên:  ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Xin Chào: " + yourName);
        }
    }
}