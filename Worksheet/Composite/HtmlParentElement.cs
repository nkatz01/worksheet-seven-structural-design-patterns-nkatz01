using System.Collections.Generic;

namespace Composite
{
    public class HtmlParentElement: HtmlTag
    {
        private List<HtmlTag> children;
        public HtmlParentElement(string body)
        {
            throw new System.NotImplementedException();
        }


        public override void AddChildTag(HtmlTag htmlTag)
        {
         //   foreach(HtmlTag tag in children)
            children.Add(htmlTag);
        }

        public override void RemoveChildTag(HtmlTag htmlTag)
        {   
            children.Remove(htmlTag);
        }

        public void GenerateHtml()
        {
            throw new System.NotImplementedException();
        }
    }
}