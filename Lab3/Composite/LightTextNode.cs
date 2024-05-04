namespace Composite;

public class LightTextNode : LightNode
{
    private string _text;

    public LightTextNode(string text)
    {
        this._text = text;
    }

    public override string OuterHtml => _text;
    public override string InnerHtml => _text;
    
    protected override void OnCreated()
    {
        Console.WriteLine("Text node has been created.");
    }

    protected override void OnRendered()
    {
        Console.WriteLine("Text node has been rendered.");
    }
}