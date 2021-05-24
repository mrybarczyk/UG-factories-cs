using System;
using System.Diagnostics;
namespace Fabryki
{
    public interface IRoslina
    {
        string Nazwa { get; }
    }
    public class KwiatTulipan : IRoslina
    {
        public string Nazwa { get; }
        public KwiatTulipan()
        {
            Nazwa = "Bardzo ładne tulipany";
        }
    }
    public class KwiatGozdzik : IRoslina
    {
        public string Nazwa { get; }
        public KwiatGozdzik()
        {
            Nazwa = "Przepiękne goździki";
        }
    }
    public class KwiatHiacynt : IRoslina
    {
        public string Nazwa { get; }
        public KwiatHiacynt()
        {
            Nazwa = "Hiacynt - niedługo zakwitnie!";
        }
    }
    public class KwiatAzalia : IRoslina
    {
        public string Nazwa { get; }
        public KwiatAzalia()
        {
            Nazwa = "Azalie";
        }
    }
    public class KwiatFiolek : IRoslina
    {
        public string Nazwa { get; }
        public KwiatFiolek()
        {
            Nazwa = "Fiołki";
        }
    }
    public class KrzewCis : IRoslina
    {
        public string Nazwa { get; }
        public KrzewCis()
        {
            Nazwa = "Sadzonka cisa";
        }
    }
    public class KrzewGlog : IRoslina
    {
        public string Nazwa { get; }
        public KrzewGlog()
        {
            Nazwa = "Sadzonka głógu";
        }
    }
    public class KrzewRoza : IRoslina
    {
        public string Nazwa { get; }
        public KrzewRoza()
        {
            Nazwa = "Sadzonka dzikiej róży";
        }
    }
    public class KrzewJalowiec : IRoslina
    {
        public string Nazwa { get; }
        public KrzewJalowiec()
        {
            Nazwa = "Sadzonka jałowca";
        }
    }
    public class KrzewJarzab : IRoslina
    {
        public string Nazwa { get; }
        public KrzewJarzab()
        {
            Nazwa = "Sadzonka jarzębu";
        }
    }
    public class DrzewoBuk : IRoslina
    {
        public string Nazwa { get; }
        public DrzewoBuk()
        {
            Nazwa = "Sadzonka buku";
        }
    }
    public class DrzewoLipa : IRoslina
    {
        public string Nazwa { get; }
        public DrzewoLipa()
        {
            Nazwa = "Sadzonka lipy";
        }
    }
    public class DrzewoSosna : IRoslina
    {
        public string Nazwa { get; }
        public DrzewoSosna()
        {
            Nazwa = "Sadzonka sosny";
        }
    }
    public class DrzewoKlon : IRoslina
    {
        public string Nazwa { get; }
        public DrzewoKlon()
        {
            Nazwa = "Sadzonka klonu";
        }
    }
    public class DrzewoBrzoza : IRoslina
    {
        public string Nazwa { get; }
        public DrzewoBrzoza()
        {
            Nazwa = "Sadzonka brzozy";
        }
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
            }
            catch (NullReferenceException e)
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
                    return new DrzewoBuk();
                case "Brzoza":
                    return new DrzewoBrzoza();
                case "Lipa":
                    return new DrzewoLipa();
                case "Sosna":
                    return new DrzewoSosna();
                case "Klon":
                    return new DrzewoKlon();
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
                    return new KrzewGlog();
                case "Róża":
                    return new KrzewRoza();
                case "Jałowiec":
                    return new KrzewJalowiec();
                case "Cis":
                    return new KrzewCis();
                case "Jarząb":
                    return new KrzewJarzab();
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
                    return new KwiatTulipan();
                case "Hiacynt":
                    return new KwiatHiacynt();
                case "Azalia":
                    return new KwiatAzalia();
                case "Fiołek":
                    return new KwiatFiolek();
                case "Goździk":
                    return new KwiatGozdzik();
                default:
                    return null;
            }
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
