using System;

namespace Fleka.DotnetVcmp.Interop {
    [AttributeUsage(AttributeTargets.Method, AllowMultiple=false)]
    public class EntryPointAttribute: Attribute {};
}
