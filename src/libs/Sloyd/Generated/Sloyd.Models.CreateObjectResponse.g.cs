
#nullable enable

namespace Sloyd
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateObjectResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("InteractionId")]
        public string? InteractionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ConfidenceScore")]
        public double? ConfidenceScore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ResponseEncoding")]
        public string? ResponseEncoding { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ModelOutputType")]
        public string? ModelOutputType { get; set; }

        /// <summary>
        /// Generated 3D file data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ModelData")]
        public string? ModelData { get; set; }

        /// <summary>
        /// Preview image format, if returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ThumbnailPreviewExportType")]
        public string? ThumbnailPreviewExportType { get; set; }

        /// <summary>
        /// Preview image data, if returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ThumbnailPreview")]
        public string? ThumbnailPreview { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObjectResponse" /> class.
        /// </summary>
        /// <param name="interactionId"></param>
        /// <param name="name"></param>
        /// <param name="confidenceScore"></param>
        /// <param name="responseEncoding"></param>
        /// <param name="modelOutputType"></param>
        /// <param name="modelData">
        /// Generated 3D file data.
        /// </param>
        /// <param name="thumbnailPreviewExportType">
        /// Preview image format, if returned.
        /// </param>
        /// <param name="thumbnailPreview">
        /// Preview image data, if returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateObjectResponse(
            string? interactionId,
            string? name,
            double? confidenceScore,
            string? responseEncoding,
            string? modelOutputType,
            string? modelData,
            string? thumbnailPreviewExportType,
            string? thumbnailPreview)
        {
            this.InteractionId = interactionId;
            this.Name = name;
            this.ConfidenceScore = confidenceScore;
            this.ResponseEncoding = responseEncoding;
            this.ModelOutputType = modelOutputType;
            this.ModelData = modelData;
            this.ThumbnailPreviewExportType = thumbnailPreviewExportType;
            this.ThumbnailPreview = thumbnailPreview;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObjectResponse" /> class.
        /// </summary>
        public CreateObjectResponse()
        {
        }
    }
}