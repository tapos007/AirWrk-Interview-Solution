using System.Text.RegularExpressions;
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
    public async Task<AnalyzeResponseViewModel> AnalysisReport(AnalyzeRequestViewModel requestViewModel)
    {
        var str = requestViewModel.Text.Replace(" ", "");
        var returnObj = new AnalyzeResponseViewModel()
        {
            CharCount = str.Length,
            WordCount = GetNumberOfWordsInText(requestViewModel.Text),
            SentenceCount = GetNumberOfSentenceInText(requestViewModel.Text),
            LongestWord = GetLongestWord(requestViewModel.Text),
            MostFrequentWord = GetMostFrequestWord(requestViewModel.Text)
        };

        return returnObj;
    }

    private  MostFrequentWord GetMostFrequestWord(string text)
    {
        Regex rgx = new Regex("[^a-zA-Z -]");
        var  str = rgx.Replace(text, "");
        var words = str.Split(new[] { " " }, StringSplitOptions.None);
        var result = words
            .GroupBy(s => s)
            .Where(g=>g.Count()>1)
            .OrderByDescending(g => g.Count())
            .Select(g => g.Key).FirstOrDefault();

        return new MostFrequentWord()
        {
            Word = result,
            Frequency = words.Where(s=>s.Equals(result)).Count()
        };
    }
    private LongestWord GetLongestWord(string text)
    {
        Regex rgx = new Regex("[^a-zA-Z -]");
       var  str = rgx.Replace(text, "");
        var words = str.Split(new[] { " " }, StringSplitOptions.None);
        if (words.Length == 0)
        {
            return null;
        }

        int longestWordCount = words[0].Length;
        int count = 0;
        string longestText = null;
        foreach (var input in words)
        {
            if (count == 0)
            {
                count++;
                continue;
            }

            if (input.Length > longestWordCount)
            {
                longestWordCount = input.Length;
                longestText = input;
            }
        }

        return new LongestWord()
        {
            length = longestWordCount,
            Word = longestText
        };

    }

    private int GetNumberOfSentenceInText(string text)
    {
        var txt = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
        return txt.Length;
    }

    private int GetNumberOfWordsInText(string text)
    {
        var str = text.Split(" ");
        return str.Length;
    }

    public Task<SimilarityResponseViewModel> SimilarityReport(SimilaritiesRequestViewModel requestViewModel)
    {
        throw new NotImplementedException();
    }
}