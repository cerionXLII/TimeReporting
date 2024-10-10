using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.Json;
using TimeReportingWebApp.Models;

namespace TimeReportingWebApp.Controllers
{
    public class TimeEntryController : Controller
    {
        private static string DataFilePath = "data.json";

        [HttpGet("api/projects")] // Endpoint to get list of projects
        public IActionResult GetProjects()
        {
            var projects = Project.GetSampleProjects();
            if (projects == null || projects.Count == 0)
            {
                return NotFound("No projects available.");
            }
            return Ok(projects);
        }

        [HttpPost("api/timeentry")] // Endpoint to save time entry
        public IActionResult SaveTimeEntry([FromBody] TimeEntry timeEntry)
        {
            var timeEntries = LoadTimeEntries();
            timeEntries.Add(timeEntry);
            SaveTimeEntries(timeEntries);
            return Ok();
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        private List<TimeEntry> LoadTimeEntries()
        {
            if (!System.IO.File.Exists(DataFilePath))
                return new List<TimeEntry>();

            var json = System.IO.File.ReadAllText(DataFilePath);
            return JsonSerializer.Deserialize<List<TimeEntry>>(json);
        }

        private void SaveTimeEntries(List<TimeEntry> timeEntries)
        {
            var json = JsonSerializer.Serialize(timeEntries);
            System.IO.File.WriteAllText(DataFilePath, json);
        }
    }
}

