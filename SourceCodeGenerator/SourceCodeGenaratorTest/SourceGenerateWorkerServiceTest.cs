using SourceCodeGenerator.WorkerService;

namespace �\�[�X�R�[�h�����@�\�e�X�g
{
    /// <summary>
    /// �\�[�X�R�[�h�������[�J�[�T�[�r�X�e�X�g�N���X
    /// </summary>
    public class �\�[�X�R�[�h�������[�J�[�T�[�r�X�e�X�g
    {
        /// <summary>
        /// �R���X�g���N�^
        /// </summary>
        public �\�[�X�R�[�h�������[�J�[�T�[�r�X�e�X�g()
        {
            // TODO�F��ꏈ���ł����������Ƃ��o������AFixture�N���X���쐬�B
        }

        /// <summary>
        /// �\�[�X�R�[�h�����e�X�g
        /// </summary>
        [Fact]
        public void �\�[�X�R�[�h�����e�X�g()
        {
            SourceGenerateWorkerService workerService = new SourceGenerateWorkerService();
            var result = workerService.GenerateSourceCode();
            Assert.NotNull(result); // ���ʂ�Null�łȂ����Ƃ��m�F�B
        }
    }
}