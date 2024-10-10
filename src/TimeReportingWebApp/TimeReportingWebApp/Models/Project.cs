namespace TimeReportingWebApp.Models
{
    public class Project
    {
        public string Name { get; set; }
        public string Client { get; set; }
        public List<string> Categories { get; set; }

        public static List<Project> GetSampleProjects()
        {
            return new List<Project>
            {
                new Project { Name = "Project Alpha", Client = "Client A", Categories = new List<string> { "Development", "Testing", "Deployment" } },
                new Project { Name = "Project Beta", Client = "Client B", Categories = new List<string> { "Requirements Gathering", "UI Design" } },
                new Project { Name = "Project Gamma", Client = "Client C", Categories = new List<string> { "Development", "Support" } },
                // Add more projects as needed
            };
        }
    }

}
