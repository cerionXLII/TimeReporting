namespace TimeReportingWebApp.Models
{

    public class TimeEntry
    {
        public string ConsultantName { get; set; }
        public string ProjectName { get; set; }
        public string Activity { get; set; }
        public int Hours { get; set; }
        public string Date { get; set; }
    }

}
