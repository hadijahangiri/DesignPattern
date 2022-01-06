namespace TemplateMethod_Parser
{
    internal abstract class BaseParser
    {
       public void Pars(string filePath)
        {
            var content = ReadFileContent(filePath);
            var parsedContent = ParseContent(content);
            PrintInConsole(parsedContent);
        }

        private void PrintInConsole(List<string> parsedContent)
        {
            Console.WriteLine();
        }

        protected abstract List<string> ParseContent(string content);

        private string ReadFileContent(string filePath)
        {
            if (!File.Exists(filePath)) throw new FileNotFoundException();
            return File.ReadAllText(filePath);
        }
    }
}