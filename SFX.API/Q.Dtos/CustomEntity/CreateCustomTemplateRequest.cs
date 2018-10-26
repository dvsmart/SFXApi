namespace SFX.Dtos.CustomEntity
{
    public class CreateCustomTemplateRequest
    {
        public int Id { get; set; }

        public int? CategoryId { get; set; }

        public string TemplateName { get; set; }

        public string PluralName { get; set; }

        public bool IsVisible { get; set; }
    }
}
