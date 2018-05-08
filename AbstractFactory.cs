//抽象工厂模式:提供一个创建一系列相关或相互依赖对象的接口,而无需指定它们具体的类
using System;
interface IFactory
{
    IProductA CreateProductA();
    IProductB CreateProductB();
}
class ConcreteFactory1 : IFactory
{
    public IProductA CreateProductA()
    {
        return new ProductA1();
    }
    public IProductB CreateProductB()
    {
        return new ProcuctB1();
    }
}
class ConcreteFactory2 : IFactory
{
    public IProductA CreateProductA()
    {
        return new ProductA2();
    }
    public IProductB CreateProductB()
    {
        return new ProcuctB2();
    }
}
interface IProductA
{
    void ShowA();
}
class ProductA1 : IProductA
{
    public void ShowA()
    {
        Console.WriteLine("ProductA1");
    }
}
class ProductA2 : IProductA
{
    public void ShowA()
    {
        Console.WriteLine("ProductA2");
    }
}
interface IProductB
{
    void ShowB();
}
class ProcuctB1 : IProductB
{
    public void ShowB()
    {
        Console.WriteLine("ProductB1");
    }
}
class ProcuctB2 : IProductB
{
    public void ShowB()
    {
        Console.WriteLine("ProductB2");
    }
}

class Program
{
    static void Main()
    {
        IFactory factory = new ConcreteFactory1();
        IProductA productA = factory.CreateProductA();
        productA.ShowA();
        IProductB productB = factory.CreateProductB();
        productB.ShowB();
        Console.ReadKey();
    }
}