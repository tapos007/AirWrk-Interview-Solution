using FluentValidation;
using InterviewQuestion.BLL.RequestModel;

namespace InterviewQuestion.BLL.ValidatorObj;

public class AnalyzeRequestViewModelValidator :  AbstractValidator<AnalyzeRequestViewModel> 
{
    public AnalyzeRequestViewModelValidator()
    {
        RuleFor(x => x.Text).NotNull().NotEmpty();
    }
}