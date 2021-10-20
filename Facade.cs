using System;

namespace Facade
{
    class Authorize
    {
        public void CheckUser()
        {
            Console.WriteLine("User checked!");
        }
    }
    class Logging
    {
        public void Log()
        {
            Console.WriteLine("Logging...");
        }
    }
    class Caching
    {
        public void Cache()
        {
            Console.WriteLine("Cache saved");
        }
    }
    class Validation
    {
        public void Validate()
        {
            Console.WriteLine("Validating!");
        }
    }


    class CrossCuttingConcerns
    {
        public Authorize Authorize { get; set; }
        public Caching Caching { get; set; }
        public Logging Logging { get; set; }
        public Validation Validation { get; set; }
        public void DoSomething()
        {
            Console.WriteLine("Hi guys!");
        }
        public CrossCuttingConcerns(Authorize _authorize, Caching _caching, Logging _logging, Validation _validation)
        {
            Authorize = _authorize;
            Caching = _caching;
            Logging = _logging;
            Validation = _validation;
        }

        public void UseAll()
        {
            Authorize.CheckUser();
            Logging.Log();
            Validation.Validate();
            Caching.Cache();
            DoSomething();
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            CrossCuttingConcerns crossCutting = new CrossCuttingConcerns(new Authorize(), new Caching(), new Logging(), new Validation());

            crossCutting.UseAll();
        }
    }
}
