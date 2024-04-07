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
}