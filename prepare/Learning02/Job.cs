public class Job
{
    
    public string _jobTitle;
    public string _company;
    public string _startYear;
    public string _endYear;
    // public Job(string jobTitle, string company, string startYear, string endYear)
    // {
    //     _jobTitle = jobTitle;
    //     _company = company;
    //     _startYear = startYear;
    //     _endYear = endYear;
    // }
    public void JobInfo()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear} {_endYear}");
    } 
    
}