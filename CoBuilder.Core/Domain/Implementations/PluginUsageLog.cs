using CoBuilder.Core.Enums;

namespace CoBuilder.Core.Domain
{
    public class PluginUsageLog
    {
        public PluginApp Id { get; set; }
        public string ProgramVersion { get; set; }
        public string Username { get; set; }
        public string ProjectId { get; set; }
        public string ObjectId { get; set; }
        public string ElementRoomBounding { get; set; }
        public string ElementArea { get; set; }
        public string ElementLevel { get; set; }
        public string SiteCoordinates { get; set; }
        public string ProjectAddress { get; set; }
        public string BuildingName { get; set; }
        public string ProjectName { get; set; }
        public string ProjectLocation { get; set; }
        public string ClientId { get; set; }
        public string ProductId { get; set; }
        public string WorkplaceId { get; set; }
    }
}