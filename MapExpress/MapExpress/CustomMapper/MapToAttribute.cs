
namespace MapExpress.CustomMapper
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class MapToAttribute : Attribute
    {
        public Type TargetType { get; }
        public MapToAttribute(Type targetType) => TargetType = targetType;
    }
}
