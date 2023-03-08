namespace AOMT.Core.Models
{
    public class ActorModel // properties are 
    {
        public ActorModel(string id, string name, string aonUrl, string family, 
            int level, string alignment, string type, string size, string source, 
            string sourceType, string rarity, string[] traits, string description)
        {
            Id = id;
            this.Name = name;
            this.AonUrl = aonUrl;
            this.Family = family;
            this.Level = level;
            this.Alignment = alignment;
            this.Type = type;
            this.Size = size;
            this.Source = source;
            this.SourceType = sourceType;
            this.Rarity = rarity;
            this.Traits = traits;
            this.Description = description;
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string AonUrl { get; set; }
        public string Family { get; set; }
        public int Level { get; set; }
        public string Alignment { get; set; }
        public string Type { get; set; }
        public string Size { get; set; }
        public string Source { get; set; }
        public string SourceType { get; set; }
        public string Rarity { get; set; }
        public string[] Traits { get; set; }
        public string Description { get; set; }


    }
}