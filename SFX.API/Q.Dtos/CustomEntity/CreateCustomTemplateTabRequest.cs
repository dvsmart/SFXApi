namespace SFX.Dtos.CustomEntity
{
    public class CreateCustomTemplateTabRequest
    {
        public int Id { get; set; }

        public string TabName { get; set; }

        public int CustomTemplateId { get; set; }

        public bool IsVisible { get; set; }
    }
}
