using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadonlyModifierPOC
{
    class InitBlockPOC
    {
        readonly int Field1;
        int Field2;
        int Prop1 { get; init; } //init-only setters is not available in C# 7.3. It is available from C# 9.0 onwards.
        int Prop2
        {
            get => 42;
            init
            { //init-only setters is not available in C# 7.3. It is available from C# 9.0 onwards.
                Field1 = 13; 
                Field2 = 13;
                Prop1 = 13; 
            }
        }
    }
}

