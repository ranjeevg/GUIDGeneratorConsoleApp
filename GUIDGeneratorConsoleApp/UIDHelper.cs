namespace GUIDGeneratorConsoleApp
{
    public enum UIDHelperType
    {
        GUID = 0,
        UUID = 1,
        ULID = 2
    }

    public sealed class UIDHelper (UIDHelperType uidType)
    {        
        public UIDHelperType UIDType { get; init; } = uidType;
    }
}
