using InterviewQuestion.BLL.RequestModel;
using InterviewQuestion.BLL.ResponseViewModel;

namespace InterviewQuestion.BLL.Services;

public interface IStringProcessingService
{
    Task<AnalyzeResponseViewModel> AnalysisReport(AnalyzeRequestViewModel requestViewModel);
    Task<SimilarityResponseViewModel> SimilarityReport(SimilaritiesRequestViewModel requestViewModel);
}

public class StringProcessingService : IStringProcessingService
{
    public Task<AnalyzeResponseViewModel> AnalysisReport(AnalyzeRequestViewModel requestViewModel)
    {
        throw new NotImplementedException();
    }

    public Task<SimilarityResponseViewModel> SimilarityReport(SimilaritiesRequestViewModel requestViewModel)
    {
        throw new NotImplementedException();
    }
}