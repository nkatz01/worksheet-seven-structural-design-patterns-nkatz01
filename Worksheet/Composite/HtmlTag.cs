using System.Collections.Generic;

namespace Composite
{
    public abstract class HtmlTag
    {
        public string StartTag { get; set; }
        public string EndTag { get; set; }
        public string TagBody { get; set; }

        private List<HtmlTag> children;

        public void AddChildTag(HtmlTag htmlTag)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveChildTag(HtmlTag htmlTag)
        {
            throw new System.NotImplementedException();
        }

        public void GenerateHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}