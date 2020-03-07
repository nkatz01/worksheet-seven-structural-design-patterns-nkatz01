using System.Collections.Generic;
using System.Linq;
using System;
namespace Composite
{
    public class HtmlParentElement: HtmlTag
    {
        protected List<HtmlTag> _children  = new List<HtmlTag>();


        public HtmlParentElement(string body) 
        {
            
        }


        public override void AddChildTag(HtmlTag htmlTag)
        {
         
            _children.Add(htmlTag);
        }

        public override void RemoveChildTag(HtmlTag htmlTag)
        {   
            _children.Remove(htmlTag);
        }

        public override void GenerateHtml()
        {   
            Console.WriteLine(this.StartTag);
            

            int i = 0;
            foreach (HtmlTag tag in _children)
            {

                tag.GenerateHtml();
                i++;
            }

            Console.WriteLine(this.EndTag);


        }
    }
}