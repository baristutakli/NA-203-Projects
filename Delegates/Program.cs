using System;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();// void olan ve paramaetre almayan operasyonlara delegelik yapıyor
        public delegate void MyDelegate2(string str); //parametre alan metotlara delege eder
        public delegate int MyDelegate3(int myintger);// int dönden ve int parametre alan operasyonlara delege eder
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CustomerManager customer = new CustomerManager();
            MyDelegate myDelegate = customer.SendMessage;// ek bir işlem yapmasını da delege edebiliriz
            myDelegate += customer.ShowAlert;// ikinci bir işlemi delege ettik
            // -= kullanarak yapılan işlemi ger alabiliriz
            myDelegate();

            Func<int, int, int> add = Topla;// add operasyonu aslında bir delegeye karşılık geliyor
            Console.WriteLine(add(3,5));

            Func<int> getRandom = delegate ()
            {
                Random rdm = new Random();
                return rdm.Next(1, 100);
            };

            Func<int> getRandom2 = () => new Random().Next(1, 50);// parametresiz metoda delegasyon yaptık
        }
        static int Topla(int a,int b)
        {
            return a + b;
        }
    }
    public class CustomerManager {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }
        public void ShowAlert()
        {
            Console.WriteLine("Be careful");
        }
    }

}
