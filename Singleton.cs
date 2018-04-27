//单例:保证一个类仅有一个实例，并提供一个访问它的全局访问点
//单线程单例
using System;
class Singleton
{
	private static Singleton instance;
	private Singleton() { }
	public static Singleton GetInstance()
	{
		if (instance == null) instance = new Singleton();
		return instance;
	}
}
class Program
{
	static void Main()
	{
		Singleton s1 = Singleton.GetInstance();
		Singleton s2 = Singleton.GetInstance();
		Console.ReadKey();
	}
}
//多线程-双重锁定
using System;
public sealed class Singleton
{
	private static Singleton instance;
	private static readonly object syncRoot = new object();
	private Singleton() { }
	public static Singleton GetInstance()
	{
		if (instance == null)
		{
			lock (syncRoot)
			{
				if (instance == null)
				{
					instance = new Singleton();
				}
			}
		}
		return instance;
	}
}
class Program
{
	static void Main()
	{
		Singleton s1 = Singleton.GetInstance();
		Singleton s2 = Singleton.GetInstance();
		Console.ReadKey();
	}
}
//静态初始化
using System;
public sealed class Singleton
{
	private static readonly Singleton instance = new Singleton();
	private Singleton() { }
	public static Singleton GetInstance()
	{
		return instance;
	}
}
class Program
{
	static void Main()
	{
		Singleton s1 = Singleton.GetInstance();
		Singleton s2 = Singleton.GetInstance();
		Console.ReadKey();
	}
}