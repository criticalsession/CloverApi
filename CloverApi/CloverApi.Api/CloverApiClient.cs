using System.Text.Json;
using CloverApi.Api.Models;

namespace CloverApi.Api;

public class CloverApiClient : ICloverApiClient
{
    private readonly HttpClient _httpClient;

    private readonly JsonSerializerOptions _jsonOptions = new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
    };

    public CloverApiClient(HttpClient httpClient)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
    }

    // TODO: GetAsync
    public Task<List<Board>> GetBoardsAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
}