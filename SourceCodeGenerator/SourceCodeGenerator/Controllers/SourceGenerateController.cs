using Microsoft.AspNetCore.Mvc;
using SourceCodeGenerator.WorkerService;

namespace SourceCodeGenerator.Controllers
{
    [ApiController]
    [Route("source-generate")]
    public class SourceGenerateController : ControllerBase
    {
        /// <summary>
        /// ロガー
        /// </summary>
        private readonly ILogger<SourceGenerateController> _logger;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="logger"></param>
        public SourceGenerateController(ILogger<SourceGenerateController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// サンプルコード取得
        /// </summary>
        /// <returns></returns>
        [Route("sample")]
        [HttpGet()]
        public IActionResult GetSampleCode()
        {
            _logger.LogInformation("GetSampleCode execute.");
            SourceGenerateWorkerService workerService = new SourceGenerateWorkerService();
            return new OkObjectResult(workerService.GenerateSourceCode());
        }
    }
}