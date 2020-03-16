using System;

namespace _04ClassesHW
{
    class Program
    {
        static void Main(string[] args)
        {
            TXTHandler ex = new TXTHandler();
            ex.Change();
            XMLHandler el = new XMLHandler();
            el.Change();

        }
    }

    abstract class AbstractHandler
    {
        public abstract void Open();
        public abstract void Craete();
        public abstract void Change();
        public abstract void Save();
    }
        class XMLHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("XML документ открывается.");
        }
        public override void Craete()
        {
            Console.WriteLine("XML документ создаётся.");
        }
        public override void Change()
        {
            Console.WriteLine("XML документ изменяется.");
        }
        public override void Save()
        {
            Console.WriteLine("XML документ сохраняется.");
        }
    }
        class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("TXT документ открывается.");
        }
        public override void Craete()
        {
            Console.WriteLine("TXT документ создаётся.");
        }
        public override void Change()
        {
            Console.WriteLine("TXT документ изменяется.");
        }
        public override void Save()
        {
            Console.WriteLine("TXT документ сохраняется.");
        }
    }
        class DOCHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("DOC документ открывается.");
        }
        public override void Craete()
        {
            Console.WriteLine("DOC документ создаётся.");
        }
        public override void Change()
        {
            Console.WriteLine("DOC документ изменяется.");
        }
        public override void Save()
        {
            Console.WriteLine("DOC документ сохраняется.");
        }
    }
}
