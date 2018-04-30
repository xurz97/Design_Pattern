//工厂方法模式:定义一个创建产品对象的工厂接口,将实际创建工作推迟到子类当中
using System;
public class ClassBase { }
class ClassA : ClassBase { }
class ClassB : ClassBase { }
interface IFactory
{
	ClassBase CreateClass();
}
class ClassAFactory : IFactory
{
	public ClassBase CreateClass()
	{
		return new ClassA();
	}
}
class ClassBFactory : IFactory
{
	public ClassBase CreateClass()
	{
		return new ClassB();
	}
}
class Program
{
	static void Main()
	{
		IFactory classAFactory = new ClassAFactory();
		ClassBase classA = classAFactory.CreateClass();
		IFactory classBFactory = new ClassBFactory();
		ClassBase classB = classBFactory.CreateClass();
	}
}