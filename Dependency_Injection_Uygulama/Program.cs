using Dependency_Injection_Uygulama.Entities;
using System;

namespace Dependency_Injection_Uygulama {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Biz burada bir sınıfın başka bir sınıfa bağımlılığını azaltmaya çalışıyoruz.
            //Vasita sınıfına ister araba ver ister kamyon ver ister otobüs ver, Vasita onların nasıl yaptığına bakmıyor
            // Yapması yeter
            Vasita vasita = new Vasita(new Araba());
            vasita.Kullan();

            Vasita vasita2 = new Vasita(new Kamyon());
            vasita2.Kullan();
            Vasita vasita3 = new Vasita(new Otobus());
            vasita3.Kullan();
        }
    }
}
