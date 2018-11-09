namespace SFX.Dtos.CustomEntity
{
    public class TabFieldDto
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public short SortOrder { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }
        public bool IsVisible { get; set; }
        public bool IsRequired { get; set; }
    }
    
}
