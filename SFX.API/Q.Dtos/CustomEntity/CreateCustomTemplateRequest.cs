namespace SFX.Dtos.CustomEntity
{
    public class CreateCustomTemplateRequest
    {
        public int Id { get; set; }

        public int CustomGroupId { get; set; }

        public string TemplateName { get; set; }
    }
}
