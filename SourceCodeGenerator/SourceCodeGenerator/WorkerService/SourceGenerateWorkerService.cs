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
            var template = Template.Parse("Hello {{name}}!");
            var result = template.Render(new { Name = "World" });
            return result;
        }
    }
}
