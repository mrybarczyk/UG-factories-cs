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
        public IRoslina plant(string type1, string type2)
        {
            IRoslina r = null;
            switch (type1)
            {
                case "Drzewo":
                    switch (type2)
                    {
                        case "Buk":
                            r = new DrzewoBuk();
                            return r;
                        case "Lipa":
                            r = new DrzewoLipa();
                            return r;
                        case "Brzoza":
                            r = new DrzewoBrzoza();
                            return r;
                        case "Sosna":
                            r = new DrzewoSosna();
                            return r;
                        case "Klon":
                            r = new DrzewoKlon();
                            return r;
                        default:
                            Console.WriteLine("Nie mamy takiego drzewka :C");
                            return r;
                    }
                case "Krzew":
                    switch (type2)
                    {
                        case "Jałowiec":
                            r = new KrzewJalowiec();
                            return r;
                        case "Cis":
                            r = new KrzewCis();
                            return r;
                        case "Głóg":
                            r = new KrzewGlog();
                            return r;
                        case "Jarząb":
                            r = new KrzewJarzab();
                            return r;
                        case "Róża":
                            r = new KrzewRoza();
                            return r;
                        default:
                            Console.WriteLine("Nie mamy takiego krzewu :C");
                            return r;
                    }
                case "Kwiat":
                    switch (type2)
                    {
                        case "Tulipan":
                            r = new KwiatTulipan();
                            return r;
                        case "Goździk":
                            r = new KwiatGozdzik();
                            return r;
                        case "Hiacynt":
                            r = new KwiatHiacynt();
                            return r;
                        case "Fiołek":
                            r = new KwiatFiolek();
                            return r;
                        case "Azalia":
                            r = new KwiatAzalia();
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