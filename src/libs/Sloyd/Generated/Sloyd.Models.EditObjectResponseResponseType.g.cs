
#nullable enable

namespace Sloyd
{
    /// <summary>
    /// 
    /// </summary>
    public enum EditObjectResponseResponseType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        Info,
        /// <summary>
        /// 
        /// </summary>
        Warning,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EditObjectResponseResponseTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EditObjectResponseResponseType value)
        {
            return value switch
            {
                EditObjectResponseResponseType.Error => "ERROR",
                EditObjectResponseResponseType.Info => "INFO",
                EditObjectResponseResponseType.Warning => "WARNING",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EditObjectResponseResponseType? ToEnum(string value)
        {
            return value switch
            {
                "ERROR" => EditObjectResponseResponseType.Error,
                "INFO" => EditObjectResponseResponseType.Info,
                "WARNING" => EditObjectResponseResponseType.Warning,
                _ => null,
            };
        }
    }
}