using Scriban;

namespace SourceCodeGenerator.WorkerService
{
    /// <summary>
    /// ソースコード生成ワーカーサービス
    /// </summary>
    public class SourceGenerateWorkerService
    {
        /// <summary>
        /// ソースコード生成
        /// </summary>
        /// <returns></returns>
        public string GenerateSourceCode()
        {
            // TODO:仮実装
            string filePathTxt = @"TemplateFiles\ControllerTemplate.txt";
            var readToEnd = File.ReadAllText(filePathTxt);
            if (readToEnd != null)
            {
                var template = Template.Parse(readToEnd);
                var result = template.Render(new { Name = "World！おはよう世界！" });
                Console.WriteLine(result);
                return result;
            }

            return string.Empty;
        }
    }
}
