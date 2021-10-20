using System;

namespace RefactoringGuru.DesignPatterns.AbstractFactory.Conceptual
{

    public interface IAbstractFactory
    {
        IAbstractProductA CreateCameraA();

        IAbstractProductB CreateCameraB();
    }

    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractProductA CreateCameraA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateCameraB()
        {
            return new ConcreteProductB1();
        }
    }

    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractProductA CreateCameraA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateCameraB()
        {
            return new ConcreteProductB2();
        }
    }

    public interface IAbstractProductA
    {
        string Photo();
    }


    class ConcreteProductA1 : IAbstractProductA
    {
        public string Photo()
        {
            return "Full HD";
        }
    }

    class ConcreteProductA2 : IAbstractProductA
    {
        public string Photo()
        {
            return "Photo captured";
        }
    }
    public interface IAbstractProductB
    {

        string UsefulFunctionB();
        string StartLiveVideo();
    }

    class ConcreteProductB1 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "Photo captured Canon";
        }
        public string StartLiveVideo()
        {
            return $"Live video started";
        }
    }

    class ConcreteProductB2 : IAbstractProductB
    {
        public string UsefulFunctionB()
        {
            return "The result of the product B2.";
        }
        public string StartLiveVideo()
        {
            return $"360 Sony live video started";
        }
    }
    class Client
    {
        public void Main()
        {
            ClientMethod(new ConcreteFactory1());
            Console.WriteLine();
            ClientMethod(new ConcreteFactory2());
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateCameraA();
            var productB = factory.CreateCameraB();

            Console.WriteLine(productB.UsefulFunctionB());
            Console.WriteLine(productB.StartLiveVideo());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();
        }
    }
}
