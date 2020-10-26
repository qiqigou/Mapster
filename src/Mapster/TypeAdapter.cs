using System;
using System.Reflection;

namespace Mapster
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Minor Code Smell", "S1104:Fields should not have public accessibility", Justification = "<Pending>")]
    public static class TypeAdapter<TSource, TDestination>
    {
        public static Func<TSource, TDestination> Map = TypeAdapterConfig.GlobalSettings.GetMapFunction<TSource, TDestination>();
    }
}
