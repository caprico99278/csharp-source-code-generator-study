using Microsoft.AspNetCore.Mvc;
using SourceCodeGenerator.WorkerService;

namespace SourceCodeGenerator.Controllers
{
    [ApiController]
    [Route("source-generate")]
    public class SourceGenerateController : ControllerBase
    {
        /// <summary>
        /// ���K�[
        /// </summary>
        private readonly ILogger<SourceGenerateController> _logger;

        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        /// <param name="logger"></param>
        public SourceGenerateController(ILogger<SourceGenerateController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// �T���v���R�[�h�擾
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