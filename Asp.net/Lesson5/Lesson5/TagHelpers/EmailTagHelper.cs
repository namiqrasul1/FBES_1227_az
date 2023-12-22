using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Lesson5.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        public string Mail { get; set; } = string.Empty;
        public string Content { get; set; } = string.Empty;

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.Attributes.Add("href", $"mailto:{Mail}");
            output.Content.Append(Content);
        }
    }
}
