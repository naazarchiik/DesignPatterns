namespace Composite;

class Program
{
    static void Main(string[] args)
    {
        LightElementNode div = new LightElementNode("div", true, false);
        div.AddClass("container");
        div.AddChild(new LightTextNode("Hello, World!"));

        LightElementNode span1 = new LightElementNode("span", false, false);
        span1.AddChild(new LightTextNode("This is a span."));
        div.AddChild(span1);
        
        LightElementNode span2 = new LightElementNode("span", false, false);
        span2.AddChild(new LightTextNode("This is a second span."));
        div.AddChild(span2);

        //div.Render();
        
        var iterator = div.GetIterator();
        int elementNodeCount = 0;
        int textNodeCount = 0;
        while (iterator.MoveNext())
        {
            var node = iterator.GetCurrent();
            Console.WriteLine(node.OuterHtml);

            elementNodeCount = iterator.CountElementsOfType<LightElementNode>();
            textNodeCount = iterator.CountElementsOfType<LightTextNode>();
            
        }
        Console.WriteLine($"Number of LightElementNodes: {elementNodeCount}");
        Console.WriteLine($"Number of LightTextNodes: {textNodeCount}");
    }
}