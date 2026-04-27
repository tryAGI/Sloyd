
#nullable enable

namespace Sloyd
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditObjectResponse
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
        [global::System.Text.Json.Serialization.JsonPropertyName("ResponseType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Sloyd.JsonConverters.EditObjectResponseResponseTypeJsonConverter))]
        public global::Sloyd.EditObjectResponseResponseType? ResponseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ResponseMessage")]
        public string? ResponseMessage { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ModelData")]
        public string? ModelData { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditObjectResponse" /> class.
        /// </summary>
        /// <param name="interactionId"></param>
        /// <param name="name"></param>
        /// <param name="responseType"></param>
        /// <param name="responseMessage"></param>
        /// <param name="responseEncoding"></param>
        /// <param name="modelOutputType"></param>
        /// <param name="modelData"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditObjectResponse(
            string? interactionId,
            string? name,
            global::Sloyd.EditObjectResponseResponseType? responseType,
            string? responseMessage,
            string? responseEncoding,
            string? modelOutputType,
            string? modelData)
        {
            this.InteractionId = interactionId;
            this.Name = name;
            this.ResponseType = responseType;
            this.ResponseMessage = responseMessage;
            this.ResponseEncoding = responseEncoding;
            this.ModelOutputType = modelOutputType;
            this.ModelData = modelData;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditObjectResponse" /> class.
        /// </summary>
        public EditObjectResponse()
        {
        }
    }
}