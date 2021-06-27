using System;
using Xunit;

namespace StepHtmlBuilder.Tests
{
    public class StepHtmlBuilderTests
    {
        [Fact]
        public void Test1()
        {
            var title = "Step builder";
            var h1 = "Welcome";
            var paragraph = "This is test";
            var expectHtml =
                $"<html><head><title>{title}</title></head><body><h1>{h1}</h1><p>{paragraph}</p></body></html>";
            
            var html = HtmlBuilder
                .Create()
                .OpenHeader()
                .WithTitle(title)
                .CloseHeader()
                .OpenBody()
                .WithH1(h1)
                .WithP(paragraph)
                .CloseBody()
                .Build();

            Assert.Equal(expectHtml, html);
        }
    }
}
