using NLog;
using NLog.Web;
using System.Text;

var logger = LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Debug("Application Initialize");

try
{
    // �G���R�[�h�ݒ�
    Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

    // �r���_�[����уT�[�r�X�R���e�i�ݒ�
    var builder = WebApplication.CreateBuilder(args);

    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    var app = builder.Build();
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();
}
catch (Exception exception)
{
    logger.Error(exception, "Stopped Application Initialize by Error");
    throw;
}
finally
{
    LogManager.Shutdown();
}
