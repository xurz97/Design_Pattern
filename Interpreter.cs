//解释器模式:给定一个语言,定义它的文法表示,并定义一个解释器,这个解释器使用该标识来解释语言中的句子
using System;
abstract class AbstractExpression
{
	public abstract void Interpret(Context context);
}
class Expression1 : AbstractExpression
{
	public override void Interpret(Context context)
	{
		Console.WriteLine("Expression1:" + context.Str);
	}
}
class Expression2 : AbstractExpression
{
	public override void Interpret(Context context)
	{
		Console.WriteLine("Expression2:" + context.Str);
	}
}
class Context
{
	private string str;
	public Context(string str) { this.str = str; }
	public string Str
	{
		get { return str; }
		set { str = value; }
	}
}
class Program
{
	static void Main()
	{
		Context context = new Context("Context");
		AbstractExpression exp = null;
		exp = new Expression1();
		exp.Interpret(context);
		exp = new Expression2();
		exp.Interpret(context);
		Console.ReadKey();
	}
}