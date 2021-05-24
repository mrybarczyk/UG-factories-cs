using System;
using System.Diagnostics;
namespace Fabryki
{ 
    class SF
    {
        private SF() { }
        private static SF _instance;
        public static SF GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SF();
            }
            return _instance;
        }
        public interface IRoslina
        {
            string Nazwa { get; }
        }
        public class Kwiat : IRoslina
        {
            public string Nazwa { get; }
            public Kwiat(string type)
            {
                Nazwa = type;
            }
        }
        public class Drzewo : IRoslina
        {
            public string Nazwa { get; }
            public Drzewo(string type)
            {
                Nazwa = type;
            }
        }
        public class Krzew : IRoslina
        {
            public string Nazwa { get; }
            public Krzew(string type)
            {
                Nazwa = type;
            }
        }

        public IRoslina plant(string type1, string type2)
        {
            IRoslina r = null;
            switch (type1)
            {
                case "Drzewo":
                    switch (type2)
                    {
                        case "Buk":
                            r = new Drzewo(type2);
                            return r;
                        case "Lipa":
                            r = new Drzewo(type2);
                            return r;
                        case "Brzoza":
                            r = new Drzewo(type2);
                            return r;
                        case "Sosna":
                            r = new Drzewo(type2);
                            return r;
                        case "Klon":
                            r = new Drzewo(type2);
                            return r;
                        default:
                            Console.WriteLine("Nie mamy takiego drzewka :C");
                            return r;
                    }
                case "Krzew":
                    switch (type2)
                    {
                        case "Jałowiec":
                            r = new Krzew(type2);
                            return r;
                        case "Cis":
                            r = new Krzew(type2);
                            return r;
                        case "Głóg":
                            r = new Krzew(type2);
                            return r;
                        case "Jarząb":
                            r = new Krzew(type2);
                            return r;
                        case "Róża":
                            r = new Krzew(type2);
                            return r;
                        default:
                            Console.WriteLine("Nie mamy takiego krzewu :C");
                            return r;
                    }
                case "Kwiat":
                    switch (type2)
                    {
                        case "Tulipan":
                            r = new Kwiat(type2);
                            return r;
                        case "Goździk":
                            r = new Kwiat(type2);
                            return r;
                        case "Hiacynt":
                            r = new Kwiat(type2);
                            return r;
                        case "Fiołek":
                            r = new Kwiat(type2);
                            return r;
                        case "Azalia":
                            r = new Kwiat(type2);
                            return r;
                        default:
                            Console.WriteLine("Nie mamy takiego kwiatka :C");
                            return r;
                    }
                default:
                    Console.WriteLine("Nie mamy takiej roslinki :C");
                    return r;
            }
        }
    }
    
    class SimpleFactory
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var f = SF.GetInstance();
            var p = f.plant("Drzewo", "Klon");
            var c = f.plant("Krzew", "Głóg");
            var k = f.plant("Kwiat", "Hiacynt");
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
            try
            {
                Console.WriteLine(p.Nazwa);
                Console.WriteLine(c.Nazwa);
                Console.WriteLine(k.Nazwa);
            } catch (NullReferenceException e)
            {
                
            }
        }
    }
}
