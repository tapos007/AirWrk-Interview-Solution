using InterviewQuestion.BLL.RequestModel;
using InterviewQuestion.BLL.Services;
using Microsoft.AspNetCore.Mvc;

namespace InterviewQuestion.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StringProcessingController : ControllerBase
{
    private readonly IStringProcessingService _stringProcessingService;

    public StringProcessingController(IStringProcessingService stringProcessingService)
    {
        _stringProcessingService = stringProcessingService;
    }

    [HttpPost("analyze")]
    public async Task<IActionResult> Analyze(AnalyzeRequestViewModel requestViewModel)
    {
        return Ok(await _stringProcessingService.AnalysisReport(requestViewModel));
    }
    
    [HttpPost("similarities")]
    public async Task<IActionResult> Similarities(SimilaritiesRequestViewModel requestViewModel)
    {
        return Ok(await _stringProcessingService.SimilarityReport(requestViewModel));
    }
}