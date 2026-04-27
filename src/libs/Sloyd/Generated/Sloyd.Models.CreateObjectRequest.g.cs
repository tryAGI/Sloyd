
#nullable enable

namespace Sloyd
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateObjectRequest
    {
        /// <summary>
        /// Description of the requested 3D model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("Prompt")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prompt { get; set; }

        /// <summary>
        /// Sloyd API client identifier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ClientId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientId { get; set; }

        /// <summary>
        /// Sloyd API client secret.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ClientSecret")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ClientSecret { get; set; }

        /// <summary>
        /// Level of detail. Higher values generate more triangles.<br/>
        /// Default Value: 0.5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("LOD")]
        public double? Lod { get; set; }

        /// <summary>
        /// Prompt modifier such as recoloring or texturing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("AiPromptModifiers")]
        public string? AiPromptModifiers { get; set; }

        /// <summary>
        /// Requested 3D file format.<br/>
        /// Default Value: gltf
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ModelOutputType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sloyd.JsonConverters.ModelOutputTypeJsonConverter))]
        public global::Sloyd.ModelOutputType? ModelOutputType { get; set; }

        /// <summary>
        /// Response serialization format.<br/>
        /// Default Value: json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ResponseEncoding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sloyd.JsonConverters.ResponseEncodingJsonConverter))]
        public global::Sloyd.ResponseEncoding? ResponseEncoding { get; set; }

        /// <summary>
        /// Optional preview image format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ThumbnailPreviewExportType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sloyd.JsonConverters.CreateObjectRequestThumbnailPreviewExportTypeJsonConverter))]
        public global::Sloyd.CreateObjectRequestThumbnailPreviewExportType? ThumbnailPreviewExportType { get; set; }

        /// <summary>
        /// Preview image width in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ThumbnailPreviewSizeX")]
        public int? ThumbnailPreviewSizeX { get; set; }

        /// <summary>
        /// Preview image height in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ThumbnailPreviewSizeY")]
        public int? ThumbnailPreviewSizeY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObjectRequest" /> class.
        /// </summary>
        /// <param name="prompt">
        /// Description of the requested 3D model.
        /// </param>
        /// <param name="clientId">
        /// Sloyd API client identifier.
        /// </param>
        /// <param name="clientSecret">
        /// Sloyd API client secret.
        /// </param>
        /// <param name="lod">
        /// Level of detail. Higher values generate more triangles.<br/>
        /// Default Value: 0.5
        /// </param>
        /// <param name="aiPromptModifiers">
        /// Prompt modifier such as recoloring or texturing.
        /// </param>
        /// <param name="modelOutputType">
        /// Requested 3D file format.<br/>
        /// Default Value: gltf
        /// </param>
        /// <param name="responseEncoding">
        /// Response serialization format.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="thumbnailPreviewExportType">
        /// Optional preview image format.
        /// </param>
        /// <param name="thumbnailPreviewSizeX">
        /// Preview image width in pixels.
        /// </param>
        /// <param name="thumbnailPreviewSizeY">
        /// Preview image height in pixels.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateObjectRequest(
            string prompt,
            string clientId,
            string clientSecret,
            double? lod,
            string? aiPromptModifiers,
            global::Sloyd.ModelOutputType? modelOutputType,
            global::Sloyd.ResponseEncoding? responseEncoding,
            global::Sloyd.CreateObjectRequestThumbnailPreviewExportType? thumbnailPreviewExportType,
            int? thumbnailPreviewSizeX,
            int? thumbnailPreviewSizeY)
        {
            this.Prompt = prompt ?? throw new global::System.ArgumentNullException(nameof(prompt));
            this.ClientId = clientId ?? throw new global::System.ArgumentNullException(nameof(clientId));
            this.ClientSecret = clientSecret ?? throw new global::System.ArgumentNullException(nameof(clientSecret));
            this.Lod = lod;
            this.AiPromptModifiers = aiPromptModifiers;
            this.ModelOutputType = modelOutputType;
            this.ResponseEncoding = responseEncoding;
            this.ThumbnailPreviewExportType = thumbnailPreviewExportType;
            this.ThumbnailPreviewSizeX = thumbnailPreviewSizeX;
            this.ThumbnailPreviewSizeY = thumbnailPreviewSizeY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateObjectRequest" /> class.
        /// </summary>
        public CreateObjectRequest()
        {
        }
    }
}