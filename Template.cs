//ģ�巽��ģʽ:��һ�������ж���һ���㷨�Ŀ��,Ȼ�󽫸÷����е�һЩ�����ӳٵ�������,ʹ���ٲ��ı��㷨��ǰ����,���¶����Լ����㷨
using System;
abstract class AbstractClass
{
	public abstract void PrimitiveOperation1();
	public abstract void PrimitiveOperation2();
	public void TemplateMethod()
	{
		PrimitiveOperation1();
		PrimitiveOperation2();
	}
}
class ConcreteClassA : AbstractClass
{
	public override void PrimitiveOperation1()
	{
		Console.WriteLine("A 1");
	}
	public override void PrimitiveOperation2()
	{
		Console.WriteLine("A 2");
	}
}
class ConcreteClassB : AbstractClass
{
	public override void PrimitiveOperation1()
	{
		Console.WriteLine("B 1");
	}
	public override void PrimitiveOperation2()
	{
		Console.WriteLine("B 2");
	}
}
class Program
{
	static void Main()
	{
		AbstractClass c;
		c = new ConcreteClassA();
		c.TemplateMethod();
		c = new ConcreteClassB();
		c.TemplateMethod();
		Console.ReadKey();
	}
}