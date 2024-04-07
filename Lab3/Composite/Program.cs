namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode div = new LightElementNode("div", true, false);
        div.AddClass("container");
        div.AddChild(new LightTextNode("Hello, World!"));

        LightElementNode span = new LightElementNode("span", false, false);
        span.AddChild(new LightTextNode("This is a span."));
        div.AddChild(span);

        Console.WriteLine(div.OuterHtml);
    }
}