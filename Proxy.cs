//代理模式:为其他对象提供一种代理以便控制对这个对象的访问
using System;
interface Interface
{
	void Request();
}
class RealSubject : Interface
{
	public void Request()
	{
		Console.WriteLine("Real Request");
	}
}
class Proxy : Interface
{
	RealSubject realSubject;
	public Proxy()
	{
		if (realSubject == null)
		{
			realSubject = new RealSubject();
		}
	}
	public void Request()
	{
		realSubject.Request();
	}
}
class Program
{
	static void Main()
	{
		Proxy proxy = new Proxy();
		proxy.Request();
		Console.ReadKey();
	}
}