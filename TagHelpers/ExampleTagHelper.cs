using Microsoft.AspNetCore.Razor.TagHelpers;
using System;

namespace StatiqRazorMarkdownTagHelperTest.TagHelpers
{
	[HtmlTargetElement("h1")]
	//[HtmlTargetElement("h1", Attributes = "abc")]
	public class ExampleTagHelper : TagHelper
	{
		public const int TestConst = 1;

		public override void Process(TagHelperContext context, TagHelperOutput output)
		{
			output.PostElement.SetContent($"This is from a Tag Helper (PID: {Environment.ProcessId}, Const: {TestConst})");
		}
	}
}
