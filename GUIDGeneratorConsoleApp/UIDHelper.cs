using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

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
        private UIDHelperType UIDType { get; init; } = uidType;
    }
}
