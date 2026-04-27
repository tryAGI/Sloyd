#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Sloyd.JsonConverters
{
    /// <inheritdoc />
    public class EditObjectRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Sloyd.EditObjectRequest>
    {
        /// <inheritdoc />
        public override global::Sloyd.EditObjectRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();
            var __jsonProps = new global::System.Collections.Generic.HashSet<string>();
            if (__jsonDocument.RootElement.ValueKind == global::System.Text.Json.JsonValueKind.Object)
            {
                foreach (var __jsonProp in __jsonDocument.RootElement.EnumerateObject())
                {
                    __jsonProps.Add(__jsonProp.Name);

                }
            }

            var __score0 = 0;
            if (__jsonProps.Contains("AiPromptModifiers")) __score0++;
            if (__jsonProps.Contains("ClientId")) __score0++;
            if (__jsonProps.Contains("ClientSecret")) __score0++;
            if (__jsonProps.Contains("LOD")) __score0++;
            if (__jsonProps.Contains("ModelOutputType")) __score0++;
            if (__jsonProps.Contains("Prompt")) __score0++;
            if (__jsonProps.Contains("ResponseEncoding")) __score0++;
            if (__jsonProps.Contains("ThumbnailPreviewExportType")) __score0++;
            if (__jsonProps.Contains("ThumbnailPreviewSizeX")) __score0++;
            if (__jsonProps.Contains("ThumbnailPreviewSizeY")) __score0++;
            var __score1 = 0;
            if (__jsonProps.Contains("InteractionId")) __score1++;
            var __bestScore = 0;
            var __bestIndex = -1;
            if (__score0 > __bestScore) { __bestScore = __score0; __bestIndex = 0; }
            if (__score1 > __bestScore) { __bestScore = __score1; __bestIndex = 1; }

            global::Sloyd.CreateObjectRequest? create = default;
            global::Sloyd.EditObjectRequestVariant2? editObjectRequestVariant2 = default;
            if (__bestIndex >= 0)
            {
                if (__bestIndex == 0)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Sloyd.CreateObjectRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Sloyd.CreateObjectRequest> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Sloyd.CreateObjectRequest).Name}");
                        create = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
                else if (__bestIndex == 1)
                {
                    try
                    {
                        var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Sloyd.EditObjectRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Sloyd.EditObjectRequestVariant2> ??
                                       throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Sloyd.EditObjectRequestVariant2).Name}");
                        editObjectRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                    }
                    catch (global::System.Text.Json.JsonException)
                    {
                    }
                    catch (global::System.InvalidOperationException)
                    {
                    }
                }
            }

            if (create == null && editObjectRequestVariant2 == null)
            {
                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Sloyd.CreateObjectRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Sloyd.CreateObjectRequest> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Sloyd.CreateObjectRequest).Name}");
                    create = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }

                try
                {
                    var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Sloyd.EditObjectRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Sloyd.EditObjectRequestVariant2> ??
                                   throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Sloyd.EditObjectRequestVariant2).Name}");
                    editObjectRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
                }
                catch (global::System.Text.Json.JsonException)
                {
                }
                catch (global::System.InvalidOperationException)
                {
                }
            }

            var __value = new global::Sloyd.EditObjectRequest(
                create,

                editObjectRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Sloyd.EditObjectRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            if (value.IsCreate)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Sloyd.CreateObjectRequest), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Sloyd.CreateObjectRequest?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Sloyd.CreateObjectRequest).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.Create!, typeInfo);
            }
            else if (value.IsEditObjectRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Sloyd.EditObjectRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Sloyd.EditObjectRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Sloyd.EditObjectRequestVariant2).Name}");
                global::System.Text.Json.JsonSerializer.Serialize(writer, value.EditObjectRequestVariant2!, typeInfo);
            }
        }
    }
}