#nullable enable

namespace Sloyd
{
    public partial interface ISloydClient
    {
        /// <summary>
        /// Create a new 3D object<br/>
        /// Creates a 3D object from a text prompt.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sloyd.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sloyd.CreateObjectResponse> CreateObjectAsync(

            global::Sloyd.CreateObjectRequest request,
            global::Sloyd.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a new 3D object<br/>
        /// Creates a 3D object from a text prompt.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sloyd.CreateObjectResponse> CreateObjectAsync(
            string prompt,
            string clientId,
            string clientSecret,
            double? lod = default,
            string? aiPromptModifiers = default,
            global::Sloyd.ModelOutputType? modelOutputType = default,
            global::Sloyd.ResponseEncoding? responseEncoding = default,
            global::Sloyd.CreateObjectRequestThumbnailPreviewExportType? thumbnailPreviewExportType = default,
            int? thumbnailPreviewSizeX = default,
            int? thumbnailPreviewSizeY = default,
            global::Sloyd.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}