using System.Collections.Generic;

namespace Composite
{
    public abstract class HtmlTag
    {
        public string StartTag { get; set; }
        public string EndTag { get; set; }
        public string TagBody { get; set; }

       

        public virtual void AddChildTag(HtmlTag htmlTag)
        {
            throw new System.NotImplementedException();
        }

        public virtual void RemoveChildTag(HtmlTag htmlTag)
        {
            throw new System.NotImplementedException();
        }

        public void GenerateHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}