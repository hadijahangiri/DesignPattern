using System;
using System.Text;

namespace StepHtmlBuilder
{
    public class HtmlBuilder: IHtmlBuilder, IOpenBodyBuilder, ICloseBodyBuilder, IOpenHeaderBuilder, ITitleBuilder, ICloseHeaderBuilder
    {
        private readonly StringBuilder _html;

        private HtmlBuilder()
        {
            _html = new StringBuilder();
            _html.Append("<html>");
        }

        public static IOpenHeaderBuilder Create()
        {
            return new HtmlBuilder();
        }
        public IHtmlBuilder WithH1(string text)
        {
            _html.Append($"<h1>{text}</h1>");
            return this;
        }

        public IHtmlBuilder WithH2(string text)
        {
            _html.Append($"<h2>{text}</h2>");
            return this;
        }

        public IHtmlBuilder WithP(string text)
        {
            _html.Append($"<p>{text}</p>");
            return this;
        }

        public ICloseHeaderBuilder WithTitle(string title)
        {
            _html.Append($"<title>{title}</title>");
            return this;
        }

        public string Build()
        {
            _html.Append("</html>");
            return _html.ToString();
        }

        public IHtmlBuilder OpenBody()
        {
            _html.Append("<body>");
            return this;
        }

        public ICloseBodyBuilder CloseBody()
        {
            _html.Append("</body>");
            return this;
        }

        public ITitleBuilder OpenHeader()
        {
            _html.Append($"<head>");
            return this;
        }

        public IOpenBodyBuilder CloseHeader()
        {
            _html.Append($"</head>");
            return this;
        }
    }
}
