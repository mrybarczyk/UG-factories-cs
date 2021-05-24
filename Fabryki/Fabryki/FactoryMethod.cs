using System;
using System.Diagnostics;
namespace Fabryki
{
    public interface IRoslina
    {
        string Nazwa { get; }
    }
    abstract class FM
    {
        public abstract IRoslina FactoryMethod(string type);
        public string Create(string type)
        {
            try
            {
                var p = FactoryMethod(type);
                return p.Nazwa;
            } catch (NullReferenceException e)
            {
                return "Nie mamy takiego typu wybranej rośliny";
            }
        }

    }
    class FMDrzewa : FM
    {
        private FMDrzewa() { }
        private static FMDrzewa _instance;
        public static FMDrzewa GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FMDrzewa();
            }
            return _instance;
        }
        public override IRoslina FactoryMethod(string type)
        {
            switch (type)
            {
                case "Buk":
                    return new Drzewo("Buk");
                case "Brzoza":
                    return new Drzewo("Brzoza");
                case "Lipa":
                    return new Drzewo("Lipa");
                case "Sosna":
                    return new Drzewo("Sosna");
                case "Klon":
                    return new Drzewo("Klon");
                default:
                    return null;
            }
        }
    }
    class FMKrzewy : FM
    {
        private FMKrzewy() { }
        private static FMKrzewy _instance;
        public static FMKrzewy GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FMKrzewy();
            }
            return _instance;
        }
        public override IRoslina FactoryMethod(string type)
        {
            switch (type)
            {
                case "Głóg":
                    return new Krzew("Głóg");
                case "Róża":
                    return new Krzew("Róża");
                case "Jałowiec":
                    return new Krzew("Jałowiec");
                case "Cis":
                    return new Krzew("Cis");
                case "Jarząb":
                    return new Krzew("Jarząb");
                default:
                    return null;
            }
        }
    }
    class FMKwiaty : FM
    {
        private FMKwiaty() { }
        private static FMKwiaty _instance;
        public static FMKwiaty GetInstance()
        {
            if (_instance == null)
            {
                _instance = new FMKwiaty();
            }
            return _instance;
        }
        public override IRoslina FactoryMethod(string type)
        {
            switch (type)
            {
                case "Tulipan":
                    return new Kwiat("Tulipan");
                case "Hiacynt":
                    return new Kwiat("Hiacynt");
                case "Azalia":
                    return new Kwiat("Azalia");
                case "Fiołek":
                    return new Kwiat("Fiołek");
                case "Goździk":
                    return new Kwiat("Goździk");
                default:
                    return null;
            }
        }
    }
    class Drzewo : IRoslina
    {
        public string Nazwa { get; }
        public Drzewo(string type)
        {
            Nazwa = type;
        }
    }
    class Kwiat : IRoslina
    {
        public string Nazwa { get; }
        public Kwiat(string type)
        {
            Nazwa = type;
        }
    }
    class Krzew : IRoslina
    {
        public string Nazwa { get; }
        public Krzew(string type)
        {
            Nazwa = type;
        }
    }

    class FactoryMethod
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            var f = FMDrzewa.GetInstance();
            var c = FMKwiaty.GetInstance();
            var d = FMKrzewy.GetInstance();
            Operator(f, "Klon");
            Operator(d, "Głóg");
            Operator(c, "Hiacynt");
            sw.Stop();
            Console.WriteLine(sw.Elapsed);
        }

        static void Operator(FM o, string type)
        {
           o.Create(type);
        }
    }
}
