
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Sloyd
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Sloyd.JsonConverters.CreateObjectRequestThumbnailPreviewExportTypeJsonConverter),

            typeof(global::Sloyd.JsonConverters.CreateObjectRequestThumbnailPreviewExportTypeNullableJsonConverter),

            typeof(global::Sloyd.JsonConverters.ModelOutputTypeJsonConverter),

            typeof(global::Sloyd.JsonConverters.ModelOutputTypeNullableJsonConverter),

            typeof(global::Sloyd.JsonConverters.ResponseEncodingJsonConverter),

            typeof(global::Sloyd.JsonConverters.ResponseEncodingNullableJsonConverter),

            typeof(global::Sloyd.JsonConverters.EditObjectResponseResponseTypeJsonConverter),

            typeof(global::Sloyd.JsonConverters.EditObjectResponseResponseTypeNullableJsonConverter),

            typeof(global::Sloyd.JsonConverters.EditObjectRequestJsonConverter),

            typeof(global::Sloyd.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.CreateObjectRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.ModelOutputType), TypeInfoPropertyName = "ModelOutputType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.ResponseEncoding), TypeInfoPropertyName = "ResponseEncoding2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.CreateObjectRequestThumbnailPreviewExportType), TypeInfoPropertyName = "CreateObjectRequestThumbnailPreviewExportType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.EditObjectRequest), TypeInfoPropertyName = "EditObjectRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.EditObjectRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.CreateObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.EditObjectResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Sloyd.EditObjectResponseResponseType), TypeInfoPropertyName = "EditObjectResponseResponseType2")]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}