
#nullable enable

namespace Sloyd
{
    /// <summary>
    /// Optional preview image format.
    /// </summary>
    public enum CreateObjectRequestThumbnailPreviewExportType
    {
        /// <summary>
        /// 
        /// </summary>
        Jpg,
        /// <summary>
        /// 
        /// </summary>
        Png,
        /// <summary>
        /// 
        /// </summary>
        Webp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateObjectRequestThumbnailPreviewExportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateObjectRequestThumbnailPreviewExportType value)
        {
            return value switch
            {
                CreateObjectRequestThumbnailPreviewExportType.Jpg => "jpg",
                CreateObjectRequestThumbnailPreviewExportType.Png => "png",
                CreateObjectRequestThumbnailPreviewExportType.Webp => "webp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateObjectRequestThumbnailPreviewExportType? ToEnum(string value)
        {
            return value switch
            {
                "jpg" => CreateObjectRequestThumbnailPreviewExportType.Jpg,
                "png" => CreateObjectRequestThumbnailPreviewExportType.Png,
                "webp" => CreateObjectRequestThumbnailPreviewExportType.Webp,
                _ => null,
            };
        }
    }
}