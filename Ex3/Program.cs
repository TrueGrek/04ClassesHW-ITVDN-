using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player pla = new Player();
            (pla as IPlayable).Stop();
            (pla as IRecordable).Stop();
        }
    }
    interface IPlayable
    {
        void Play();
        void Pause();
        void Stop();
    }
    interface IRecordable
    {
        void Record();
        void Pause();
        void Stop();
    }
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Play music");
        }
        void IPlayable.Pause()
        {
            Console.WriteLine("Pause music");
        }
        void IPlayable.Stop()
        {
            Console.WriteLine("Stop music");
        }
        public void Record()//неявно так как он у нас в конкретном интерфейсе, а не в двух.
        {
            Console.WriteLine("Record music");
        }
        void IRecordable.Pause()//явно так как одноименные методы.
        {
            Console.WriteLine("Pause record");
        }
        void IRecordable.Stop()
        {
            Console.WriteLine("Stop record");
        }
    }
}
