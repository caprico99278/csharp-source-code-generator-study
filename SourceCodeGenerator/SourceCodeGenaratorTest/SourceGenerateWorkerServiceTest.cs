using SourceCodeGenerator.WorkerService;

namespace ソースコード生成機能テスト
{
    /// <summary>
    /// ソースコード生成ワーカーサービステストクラス
    /// </summary>
    public class ソースコード生成ワーカーサービステスト
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ソースコード生成ワーカーサービステスト()
        {
            // TODO：基底処理でさせたいことが出来たら、Fixtureクラスを作成。
        }

        /// <summary>
        /// ソースコード生成テスト
        /// </summary>
        [Fact]
        public void ソースコード生成テスト()
        {
            SourceGenerateWorkerService workerService = new SourceGenerateWorkerService();
            var result = workerService.GenerateSourceCode();
            Assert.NotNull(result); // 結果がNullでないことを確認。
        }
    }
}