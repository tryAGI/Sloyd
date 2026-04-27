
#nullable enable

namespace Sloyd
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EditObjectRequestVariant2
    {
        /// <summary>
        /// Reference returned by createObject for AI editing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("InteractionId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InteractionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EditObjectRequestVariant2" /> class.
        /// </summary>
        /// <param name="interactionId">
        /// Reference returned by createObject for AI editing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EditObjectRequestVariant2(
            string interactionId)
        {
            this.InteractionId = interactionId ?? throw new global::System.ArgumentNullException(nameof(interactionId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditObjectRequestVariant2" /> class.
        /// </summary>
        public EditObjectRequestVariant2()
        {
        }
    }
}