using System;
namespace Composite
{
    public class HtmlElement: HtmlTag
    {
        public HtmlElement(string s)  
        {
              
        }

        public override void GenerateHtml()
        {
            Console.WriteLine(  StartTag +  TagBody +  EndTag);
        }

         

    }
}