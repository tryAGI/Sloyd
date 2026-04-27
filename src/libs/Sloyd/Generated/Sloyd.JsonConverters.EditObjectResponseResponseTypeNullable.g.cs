#nullable enable

namespace Sloyd.JsonConverters
{
    /// <inheritdoc />
    public sealed class EditObjectResponseResponseTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Sloyd.EditObjectResponseResponseType?>
    {
        /// <inheritdoc />
        public override global::Sloyd.EditObjectResponseResponseType? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Sloyd.EditObjectResponseResponseTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Sloyd.EditObjectResponseResponseType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Sloyd.EditObjectResponseResponseType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Sloyd.EditObjectResponseResponseType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Sloyd.EditObjectResponseResponseTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
