namespace InterviewQuestion.BLL.ResponseViewModel;

public class AnalyzeResponseViewModel
{
    public int CharCount { get; set; }
    public int WordCount { get; set; }
    public int SentenceCount { get; set; }
    public MostFrequentWord MostFrequentWord { get; set; }
    public LongestWord LongestWord { get; set; }
}

public class MostFrequentWord
{
    public string Word { get; set; }
    public int Frequency { get; set; }
}

public class LongestWord
{
    public string Word { get; set; }
    public int length { get; set; }
}