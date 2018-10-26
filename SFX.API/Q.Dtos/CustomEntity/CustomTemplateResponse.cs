namespace SFX.Dtos.CustomEntity
{
    public class CustomTemplateResponse
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PluralName => $"{Name}s";

        public string CategoryName { get; set; }

        public int? CategoryId { get; set; }

        public bool IsVisible { get; set; } = true;

    }
}
