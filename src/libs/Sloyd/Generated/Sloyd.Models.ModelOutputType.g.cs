
#nullable enable

namespace Sloyd
{
    /// <summary>
    /// Requested 3D file format.<br/>
    /// Default Value: gltf
    /// </summary>
    public enum ModelOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        Glb,
        /// <summary>
        /// 
        /// </summary>
        Gltf,
        /// <summary>
        /// 
        /// </summary>
        Obj,
        /// <summary>
        /// 
        /// </summary>
        Stl,
        /// <summary>
        /// 
        /// </summary>
        Usd,
        /// <summary>
        /// 
        /// </summary>
        Usdz,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelOutputType value)
        {
            return value switch
            {
                ModelOutputType.Glb => "glb",
                ModelOutputType.Gltf => "gltf",
                ModelOutputType.Obj => "obj",
                ModelOutputType.Stl => "stl",
                ModelOutputType.Usd => "usd",
                ModelOutputType.Usdz => "usdz",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelOutputType? ToEnum(string value)
        {
            return value switch
            {
                "glb" => ModelOutputType.Glb,
                "gltf" => ModelOutputType.Gltf,
                "obj" => ModelOutputType.Obj,
                "stl" => ModelOutputType.Stl,
                "usd" => ModelOutputType.Usd,
                "usdz" => ModelOutputType.Usdz,
                _ => null,
            };
        }
    }
}