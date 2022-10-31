namespace MVCuppgift.Models
{
    public class ProjectModel
    {
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectLink { get; set; }

        public ProjectModel(string projectName, string projectDescription, string projectLink)
        {
            ProjectName = projectName;
            ProjectDescription = projectDescription;
            ProjectLink = projectLink;
        }
    }
}
