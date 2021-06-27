namespace StepHtmlBuilder
{
    public interface IHtmlBuilder
    {
        IHtmlBuilder WithH1(string text);
        IHtmlBuilder WithH2(string text);
        IHtmlBuilder WithP(string text);
        ICloseBodyBuilder CloseBody();
    }
}