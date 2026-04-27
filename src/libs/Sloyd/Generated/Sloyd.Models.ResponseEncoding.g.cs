
#nullable enable

namespace Sloyd
{
    /// <summary>
    /// Response serialization format.<br/>
    /// Default Value: json
    /// </summary>
    public enum ResponseEncoding
    {
        /// <summary>
        /// 
        /// </summary>
        MessagePack,
        /// <summary>
        /// 
        /// </summary>
        Only3dModelFormatWithoutMetaData,
        /// <summary>
        /// 
        /// </summary>
        Json,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseEncodingExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseEncoding value)
        {
            return value switch
            {
                ResponseEncoding.MessagePack => "MessagePack",
                ResponseEncoding.Only3dModelFormatWithoutMetaData => "Only3dModelFormatWithoutMetaData",
                ResponseEncoding.Json => "json",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseEncoding? ToEnum(string value)
        {
            return value switch
            {
                "MessagePack" => ResponseEncoding.MessagePack,
                "Only3dModelFormatWithoutMetaData" => ResponseEncoding.Only3dModelFormatWithoutMetaData,
                "json" => ResponseEncoding.Json,
                _ => null,
            };
        }
    }
}