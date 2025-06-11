using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebAPIKeyAuth.MessageAPIHandler
{
    /// <summary>
    /// Represents a custom message handler for authenticating API requests using an API key.
    /// This handler intercepts incoming HTTP requests, extracts the 'X-ApiKey' header,
    /// and validates it against a pre-configured API key. If the key is valid, the request
    /// proceeds to the next handler in the pipeline; otherwise, a 403 Forbidden response
    /// is returned.
    /// </summary>
    public class AuthorizationHandler : DelegatingHandler
    {
        public const string APIKeyConfigured = "admin";


        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            IEnumerable<string> headerAPIkeyValues = null;
            if (request.Headers.TryGetValues("X-ApiKey", out headerAPIkeyValues))
            {
                var secretKey = headerAPIkeyValues.First();

                if (!string.IsNullOrEmpty(secretKey) && APIKeyConfigured.Equals(secretKey))
                {
                    return await base.SendAsync(request, cancellationToken);
                }
            }
            return request.CreateResponse(System.Net.HttpStatusCode.Forbidden, "API key is invalid.");
        }
    }
}
