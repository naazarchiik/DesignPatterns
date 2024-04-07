﻿namespace Composite;

public class LightElementNode : LightNode
{
    private string _tagName;
    private bool _isBlock;
    private bool _isSelfClosing;
    private List<string> _cssClasses;
    private List<LightNode> _children;

    public LightElementNode(string tagName, bool isBlock, bool isSelfClosing)
    {
        this._tagName = tagName;
        this._isBlock = isBlock;
        this._isSelfClosing = isSelfClosing;
        this._cssClasses = new List<string>();
        this._children = new List<LightNode>();
    }

    public void AddClass(string cssClass)
    {
        _cssClasses.Add(cssClass);
    }

    public void AddChild(LightNode child)
    {
        _children.Add(child);
    }

    public override string OuterHtml
    {
        get
        {
            string classes = _cssClasses.Any() ? $" class=\"{string.Join(" ", _cssClasses)}\"" : "";
            string startTag = $"<{_tagName}{classes}>";
            string endTag = _isSelfClosing ? "" : $"</{_tagName}>";
            return startTag + InnerHtml + endTag;
        }
    }

    public override string InnerHtml
    {
        get
        {
            return string.Join(_isBlock ? "\n" : "", _children.Select(child => child.OuterHtml));
        }
    }
}