using AuthoringTagHelpers.Models;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AuthoringTagHelpers.TagHelpers
{
    [HtmlTargetElement("text")]
    public class SomeTextTagHelper : TagHelper
    {
        public WebsiteContext SomeText { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("bold");
            output.TagName = "text";
            output.Content.SetHtmlContent(
                $@"<p bold>This markup will be generated using taghelpers :)</p>");
            output.TagMode = TagMode.StartTagAndEndTag;
        }
    }
}
