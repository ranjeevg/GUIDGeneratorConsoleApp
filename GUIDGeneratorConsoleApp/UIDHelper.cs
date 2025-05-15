namespace GUIDGeneratorConsoleApp
{
    public enum UIDHelperType
    {
        GUID = 1,
        UUID = 2,
        ULID = 3
    }

    public sealed class UIDHelper (UIDHelperType uidType)
    {        
        public UIDHelperType UIDType { get; init; } = uidType;
    }
}
