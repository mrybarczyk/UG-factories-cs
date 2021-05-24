using System;
using System.Diagnostics;
namespace Fabryki
{

    public interface IFactory
    {
        IRoslina PlantOne();
    }
    public interface IRoslina
    {
        string Nazwa(string n);
    }

    class Drzewa : IFactory
    {
        private Drzewa() { }
        private static Drzewa _instance;
        public static Drzewa GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Drzewa();
            }
            return _instance;
        }
        public IRoslina PlantOne()
        {
            return new Drzewo();
        }
    }

    class Drzewo : IRoslina
    {
        string nazwa;
        public string Nazwa(string n)
        {
            nazwa = null;
            switch (n)
            {
                case "Buk":
                    nazwa = n;
                    return nazwa;
                case "Brzoza":
                    nazwa = n;
                    return nazwa;
                case "Lipa":
                    nazwa = n;
                    return nazwa;
                case "Sosna":
                    nazwa = n;
                    return nazwa;
                case "Klon":
                    nazwa = n;
                    return nazwa;
                default:
                    throw new NullReferenceException();
            }
        }
    }

    class Krzewy : IFactory
    {
        private Krzewy() { }
        private static Krzewy _instance;
        public static Krzewy GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Krzewy();
            }
            return _instance;
        }
        public IRoslina PlantOne()
        {
            return new Krzew();
        }
    }

    class Krzew : IRoslina
    {
        string nazwa;
        public string Nazwa(string n)
        {
            nazwa = null;
            switch (n)
            {
                case "Głóg":
                    nazwa = n;
                    return nazwa;
                case "Róża":
                    nazwa = n;
                    return nazwa;
                case "Jałowiec":
                    nazwa = n;
                    return nazwa;
                case "Cis":
                    nazwa = n;
                    return nazwa;
                case "Jarząb":
                    nazwa = n;
                    return nazwa;
                default:
                    throw new NullReferenceException();
            }
        }
    }

    class Kwiaty : IFactory
    {
        private Kwiaty() { }
        private static Kwiaty _instance;
        public static Kwiaty GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Kwiaty();
            }
            return _instance;
        }
        public IRoslina PlantOne()
        {
            return new Kwiat();
        }
    }

    class Kwiat : IRoslina
    {
        string nazwa;
        public string Nazwa(string n)
        {
            nazwa = null;
            switch (n)
            {
                case "Tulipan":
                    nazwa = n;
                    return nazwa;
                case "Hiacynt":
                    nazwa = n;
                    return nazwa;
                case "Azalia":
                    nazwa = n;
                    return nazwa;
                case "Fiołek":
                    nazwa = n;
                    return nazwa;
                case "Goździk":
                    nazwa = n;
                    return nazwa;
                default:
                    throw new NullReferenceException();
            }
        }
    }

    class Planter
    {
        private Planter() { }
        private static Planter _instance;
        public static Planter GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Planter();
            }
            return _instance;
        }
        public void Work(IFactory fabryka, string ciag)
        {
            try
            {
                var dd = fabryka.PlantOne();
                dd.Nazwa(ciag);
            } catch (NullReferenceException e)
            {
                //Console.WriteLine("Nie mamy takiego wariantu roślinki :C");
            }
        }
    }
    class AbstractFactory
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var p = Planter.GetInstance();
            var d = Drzewa.GetInstance();
            var k = Kwiaty.GetInstance();
            var r = Krzewy.GetInstance();
            p.Work(d, "Klon");
            p.Work(r, "Głóg");
            p.Work(k, "Hiacynt");
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

    }
}
