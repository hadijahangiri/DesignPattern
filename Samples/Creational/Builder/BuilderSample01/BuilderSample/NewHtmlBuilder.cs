using System;
using System.Text;

namespace BuilderSample
{
    public class HtmlBuilder
    {
        private readonly StringBuilder _html;

        public HtmlBuilder()
        {
            _html = new StringBuilder();
            _html.Append("<html>");
        }

        public HtmlBuilder WithTitle(string title)
        {
            _html.Append($"<title>{title}</title>");
            return this;
        }

        public HtmlBuilder OpenBody()
        {
            _html.Append("<body>");
            return this;
        }

        public HtmlBuilder CloseBody()
        {
            _html.Append("</body>");
            return this;
        }
        public HtmlBuilder WithH1(string text)
        {
            _html.Append($"<h1>{text}</h1>");
            return this;
        }

        public HtmlBuilder WithH2(string text)
        {
            _html.Append($"<h2>{text}</h2>");
            return this;
        }

        public HtmlBuilder WithP(string text)
        {
            _html.Append($"<p>{text}</p>");
            return this;
        }

        public string Build()
        {
            _html.Append("</html>");
            return _html.ToString();
        }
    }
}
