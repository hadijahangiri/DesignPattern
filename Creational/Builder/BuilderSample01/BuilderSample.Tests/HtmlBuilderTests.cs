using System;
using Xunit;

namespace BuilderSample.Tests
{
    public class HtmlBuilderTests
    {
        [Fact]
        public void Builder_probably_work_correctly()
        {
            var title = "hadi web site";
            var header = "Domain driven design";
            var paragraph =
                "Domain-Driven Design is an approach to software development that centers the development on programming a domain model that has a rich understanding of the processes and rules of a domain";
            var expectedHtml = $@"<html><title>{title}</title><body><h1>{header}</h1><p>{paragraph}</p></body></html>";

            var htmlBuilder = new HtmlBuilder();

            var result = htmlBuilder
                .WithTitle(title)
                .OpenBody()
                .WithH1(header)
                .WithP(paragraph)
                .CloseBody()
                .Build();

            Assert.Equal(result, expectedHtml);
        }
    }
}
