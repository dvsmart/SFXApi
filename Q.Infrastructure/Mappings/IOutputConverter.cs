namespace SFX.Infrastructure.Mappings
{
    public interface IOutputConverter
    {
        T Map<T>(object source);

    }
}