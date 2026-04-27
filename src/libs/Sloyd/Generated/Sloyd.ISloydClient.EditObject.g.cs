#nullable enable

namespace Sloyd
{
    public partial interface ISloydClient
    {
        /// <summary>
        /// Edit an existing 3D object<br/>
        /// Edits a previously generated object using its InteractionId.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Sloyd.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Sloyd.EditObjectResponse> EditObjectAsync(

            global::Sloyd.EditObjectRequest request,
            global::Sloyd.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Edit an existing 3D object<br/>
        /// Edits a previously generated object using its InteractionId.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Sloyd.EditObjectResponse> EditObjectAsync(
            global::Sloyd.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}