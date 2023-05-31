using FluentValidation;
using InterviewQuestion.BLL.RequestModel;

namespace InterviewQuestion.BLL.ValidatorObj;

public class SimilaritiesRequestViewModelValidator :  AbstractValidator<SimilaritiesRequestViewModel> 
{
    public SimilaritiesRequestViewModelValidator()
    {
        RuleFor(x => x.Text1).NotNull().NotEmpty();
        RuleFor(x => x.Text2).NotNull().NotEmpty();
    }
}