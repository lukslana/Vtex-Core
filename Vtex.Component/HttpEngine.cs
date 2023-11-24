using Vtex.Component.Entities;
using Vtex.Component.Entities.Common.Enums;
using Vtex.Component.Entities.Interfaces;
using Vtex.Component.Exceptions;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Text.Json;
using Vtex.Component.Entities.Common.Converters;


namespace Vtex.Component
{

    /// <summary>
    /// Http Engine.
    /// </summary>
    public class HttpEngine
    {
        /// <summary>
        /// Json Serializer Options.
        /// </summary>
        internal static readonly JsonSerializerOptions jsonSerializerOptions = new()
        {
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Converters =
            {
                new EnumJsonConverterFactory(JsonNamingPolicy.CamelCase, true)
            },
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
    }

    /// <summary>
    /// Http Engine.
    /// Manages the http connections, and is responsible for invoking request and handling responses.
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public class HttpEngine<TRequest, TResponse> : HttpEngine
        where TRequest : IRequest, new()
        where TResponse : IResponse, new()
    {
        private readonly HttpClient httpClient;

        /// <summary>
        /// Constructor.
        /// </summary>
        protected HttpEngine()
            : this(HttpClientFactory.CreateDefaultHttpClient())
        {

        }

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="httpClient">The <see cref="httpClient"/>.</param>
        protected HttpEngine(HttpClient httpClient)
        {
            this.httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        }

        /// <summary>
        /// Query Async.
        /// </summary>
        /// <param name="request">The request that will be sent.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{T}"/>.</returns>
        public async Task<TResponse> QueryAsync(TRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            return await this.QueryAsync(request, new HttpEngineOptions(), cancellationToken);
        }

        /// <summary>
        /// Query Async.
        /// </summary>
        /// <param name="request">The request that will be sent.</param>
        /// <param name="httpEngineOptions">The <see cref="HttpEngineOptions"/></param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/>.</param>
        /// <returns>The <see cref="Task{T}"/>.</returns>
        public async Task<TResponse> QueryAsync(TRequest request, HttpEngineOptions httpEngineOptions, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            httpEngineOptions ??= new HttpEngineOptions();

            try
            {
                using var httpResponseMessage = await this.ProcessRequestAsync(request, cancellationToken)
                    .ConfigureAwait(false);

                var response = await this.ProcessResponseAsync(httpResponseMessage)
                    .ConfigureAwait(false);

                switch (response.Status)
                {
                    case Status.Ok:
                    case Status.NotFound:
                    case Status.ZeroResults:
                    case Status.ResourceExhausted:
                        return response;

                    case Status.InvalidRequest:
                    case Status.InvalidArgument:
                        if (!httpEngineOptions.ThrowOnInvalidRequest)
                        {
                            return response;
                        }

                        throw new VtexApiException($"{response.Status}: {response.ErrorMessage ?? "No message"}")
                        {
                            Status = response.Status
                        };

                    default:
                        throw new VtexApiException($"{response.Status}: {response.ErrorMessage ?? "No message"}")
                        {
                            Status = response.Status
                        };
                }
            }
            catch (Exception ex)
            {
                if (ex is VtexApiException)
                {
                    throw;
                }

                var baseException = ex
                    .GetBaseException();

                throw new VtexApiException(baseException.Message, baseException);
            }
        }

        private async Task<HttpResponseMessage> ProcessRequestAsync(TRequest request, CancellationToken cancellationToken = default)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            var uri = request
                .GetUri();

            using var httpRequestMessage = new HttpRequestMessage(request.HttpMethod, uri);

            httpRequestMessage.Headers
                .Add(VtexHttpHeaders.API_AppKey, request.AppKey);

            httpRequestMessage.Headers
                .Add(VtexHttpHeaders.API_AppToken, request.AppToken);

            switch (request)
            {
                case IRequestQueryString:
                    {
                        return await this.httpClient
                            .SendAsync(httpRequestMessage, cancellationToken);
                    }

                case IRequestJson:
                    {
                        var serializeObject = System.Text.Json.JsonSerializer.Serialize(request, HttpEngine.jsonSerializerOptions);
                        httpRequestMessage.Content = new StringContent(serializeObject, Encoding.UTF8);

                        return await this.httpClient
                            .SendAsync(httpRequestMessage, cancellationToken)
                            .ConfigureAwait(false);
                    }
            }

            throw new NotSupportedException();
        }
        private async Task<TResponse> ProcessResponseAsync(HttpResponseMessage httpResponse)
        {
            if (httpResponse == null)
                throw new ArgumentNullException(nameof(httpResponse));

            var response = new TResponse
            {
                RawQueryString = httpResponse.RequestMessage?.RequestUri?.PathAndQuery
            };

            if (httpResponse.StatusCode == HttpStatusCode.Forbidden)
            {
                response.Status = Status.PermissionDenied;
                response.ErrorMessage = httpResponse.ReasonPhrase;

                return response;
            }

            switch (response)
            {
                case BaseResponseStream streamResponse:
                    {

                        streamResponse.Buffer = await httpResponse.Content
                            .ReadAsByteArrayAsync()
                            .ConfigureAwait(false);

                        response = (TResponse)(IResponse)streamResponse;

                        break;
                    }

                default:
                    {
                        var rawJson = await httpResponse.Content
                            .ReadAsStringAsync()
                            .ConfigureAwait(false);

                        response = System.Text.Json.JsonSerializer.Deserialize<TResponse>(rawJson, HttpEngine.jsonSerializerOptions) ?? new TResponse();
                        response.RawJson = rawJson;

                        break;
                    }
            }

            return response;
        }
    }
}

