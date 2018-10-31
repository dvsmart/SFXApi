namespace SFX.Dtos.CustomEntity
{
    public class CreateCustomTemplateTabRequest
    {
        public int Id { get; set; }

        public string Caption { get; set; }

        public int CustomTemplateId { get; set; }

        public bool IsVisible { get; set; }
    }
}
