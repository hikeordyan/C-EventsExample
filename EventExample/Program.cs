using System;


namespace EventExample
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassCounter Counter = new ClassCounter();
            Handler_I Handler1 = new Handler_I();
            Handler_II Handler2 = new Handler_II();

            //Подписались на событие
            Counter.onCount15 += Handler1.Message;
            Counter.onCount71 += Handler2.Message;
            
            Counter.Count();
        }
    }
}
