using FluentValidation;
using InterviewQuestion.BLL.RequestModel;
using InterviewQuestion.BLL.Services;
using InterviewQuestion.BLL.ValidatorObj;
using Microsoft.Extensions.DependencyInjection;

namespace InterviewQuestion.BLL;

public static class BllDependency
{
    public static void InjectBllDependency(IServiceCollection services)
    {
        services.AddScoped<IValidator<AnalyzeRequestViewModel>, AnalyzeRequestViewModelValidator>();
        services.AddTransient<IStringProcessingService, StringProcessingService>();

    }
    
}