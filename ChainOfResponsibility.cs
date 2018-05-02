//责任链模式:使多个对象都有机会处理请求,从而避免请求的发送者和接受者之间的耦合关系,将这些对象连成一条链,并沿着这条链传递该请求,直到有对象能够处理它
using System;
abstract class Handler
{
	protected Handler successor;
	public void SetSuccessor(Handler successor)
	{
		this.successor = successor;
	}
	public abstract void HandleRequest(int request);
}
class ConcreteHandler1 : Handler
{
	public override void HandleRequest(int request)
	{
		if (request < 0)
		{
			Console.WriteLine("{0}: Handle {1}", this.GetType().Name, request);
		}
		else if (successor != null)
		{
			successor.HandleRequest(request);
		}
	}
}
class ConcreteHandler2 : Handler
{
	public override void HandleRequest(int request)
	{
		if (request >= 0)
		{
			Console.WriteLine("{0}: Handle {1}", this.GetType().Name, request);
		}
		else if (successor != null)
		{
			successor.HandleRequest(request);
		}
	}
}
class Program
{
	static void Main()
	{
		Handler h1 = new ConcreteHandler1();
		Handler h2 = new ConcreteHandler2();
		h1.SetSuccessor(h2);
		h1.HandleRequest(-1);
		h1.HandleRequest(1);
	}
}